using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Quests;
using Engine.Locations;
using Engine.Worlds;
using Engine.Items;
using Engine.Monsters;
using static System.Collections.Specialized.BitVector32;
using System.ComponentModel;
using System.Collections;

namespace Engine
{
    public class GameSession
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Location CurrentLocation { get; set; }
        public Character Player {  get; set; }
        public World ActiveWorld { get; set; }
        public World Town { get; set; }
        public Quest ActiveQuest { get; set; }
        public WorldFactory Factory { get; set; }
        public StateOfWorld State { get; set; }
        public Wolf Wolf { get; set; }
        public Boss Boss { get; set; }

        public void MoveNorth()
        {
            Y -= 1;
            CurrentLocation = ActiveWorld.LocationAt(X, Y);
            ActiveWorld = Factory.UpdateWorld(ActiveWorld, X, Y);
            if (ActiveWorld == Town && X == 0 && Y == 0) State = new StateInn();
            else State = new StateNormal();
            State.Session = this;
            Player.Moves++;
            SpawnMonster();
        }
        public void MoveSouth() 
        {
            State.MoveSouth();
        }
        public void MoveWest()
        {
            X -= 1;
            CurrentLocation = ActiveWorld.LocationAt(X, Y);
            ActiveWorld = Factory.UpdateWorld(ActiveWorld, X, Y);
            if (ActiveWorld == Town && X == 0 && Y == 0) State = new StateInn();
            else State = new StateNormal();
            State.Session = this;
            Player.Moves++;
            SpawnMonster();
        }
        public void MoveEast()
        {
            X += 1;
            CurrentLocation = ActiveWorld.LocationAt(X, Y);
            ActiveWorld = Factory.UpdateWorld(ActiveWorld, X, Y);
            if (ActiveWorld == Town && X == 0 && Y == 0) State = new StateInn();
            else State = new StateNormal();
            State.Session = this;
            Player.Moves++;
            SpawnMonster();
        }

        public void MoveToTown()
        {
            ActiveWorld = Town;
            X = 0; Y = 0;
            CurrentLocation = ActiveWorld.LocationAt(X, Y);
            State = new StateInn();
            State.Session = this;
            Factory = new TownFactory();
            Player.Health = Player.GetMaxHealth();
            Player.Moves = 0;
        }

        public void SpawnMonster()
        {
            if (CurrentLocation.GetType() == typeof(MonstersLair))
            {
                CurrentLocation.SpawnMonster(ActiveQuest, Player);
            }
            else if (CurrentLocation.GetType() == typeof(Castle))
            {
                CurrentLocation.SpawnMonster(ActiveQuest, Player);
            }
        }

        public void ChangeArmor(Item armor)
        {
            Item currentArmor = Player.MyEquipment.GetArmor();
            if (currentArmor != null) { Player.MyEquipment.AddArmament(currentArmor.ID); }
            Player.MyEquipment.SetArmor(armor);
            Player.MyEquipment.RemoveArmament(armor.ID);
        }

        public string Fight(Weapon currentWeapon)
        {
            string acttxt = "";
            acttxt += SpecialQuest(CurrentLocation.ActiveMonster, currentWeapon);
            if (CurrentLocation.ActiveMonster != null && currentWeapon != null)
            {
                CurrentLocation.ActiveMonster.Health = CurrentLocation.ActiveMonster.Health - currentWeapon.GetAttackStrength();
                acttxt += "You attack monster with " + currentWeapon.Name + ". \n";
                if (Wolf != null)
                {
                    CurrentLocation.ActiveMonster.Health = CurrentLocation.ActiveMonster.Health - Wolf.Attack();
                    acttxt += "Wolf attacks monster.\n";
                }
                if (CurrentLocation.ActiveMonster.Health <= 0)
                {
                    acttxt += "You killed " + CurrentLocation.ActiveMonster.Name + ". \n";
                    acttxt += "+ " + CurrentLocation.ActiveMonster.Exp + " Exp, + " + CurrentLocation.ActiveMonster.Gold + " Gold \n\n";
                    Player.Exp += CurrentLocation.ActiveMonster.Exp;
                    Player.Gold += CurrentLocation.ActiveMonster.Gold;
                    QuestCounter(CurrentLocation.ActiveMonster);
                    CurrentLocation.ActiveMonster = null;
                }
                else
                {
                    int a = CurrentLocation.ActiveMonster.Attack();
                    Armor armor = (Armor)Player.MyEquipment.GetArmor();
                    if (armor != null)
                    {
                        a = a - armor.GetDefence();
                        if (a > 0) { Player.Health -= a; }
                        else a = 0;
                    }
                    else Player.Health -= a;
                    acttxt += "Monster attacks: - " + a + " Health \n";
                }
            }
            return acttxt;
        }

        public string BossFight(Weapon currentWeapon)
        {
            string acttxt = "";
            if (CurrentLocation.ActiveMonster != null && currentWeapon != null)
            {
                Boss = (Boss)CurrentLocation.ActiveMonster;
                Boss.Health = Boss.Health - currentWeapon.GetAttackStrength();
                acttxt += "You attack monster with " + currentWeapon.Name + ". \n";
                if (Boss.Health <= 0)
                {
                    CurrentLocation.ActiveMonster = null;
                }
                else
                {
                    Random rnd = new Random();
                    int l = rnd.Next(1, 4);
                    if (Boss.Spec) l = 4;
                    int a = 0;
                    Armor armor = (Armor)Player.MyEquipment.GetArmor();

                    if (l == 1)
                    {
                        a = Boss.Attack();
                        if (armor != null)
                        {
                            a = a - armor.GetDefence();
                            if (a > 0) { Player.Health -= a; }
                            else a = 0;
                        }
                        else Player.Health -= a;
                        acttxt += "Monster attacks: - " + a + " Health \n";
                    }
                    else if (l == 2)
                    {
                        int b = Boss.Slash();
                        int c = Boss.Slash();
                        int d = Boss.Slash();
                        if (armor != null)
                        {
                            b = b - armor.GetDefence();
                            c = c - armor.GetDefence();
                            d = d - armor.GetDefence();
                            if (b > 0) Player.Health -= b;
                            if (c > 0) Player.Health -= c;
                            if (d > 0) Player.Health -= d;
                        }
                        else Player.Health = Player.Health - b - c - d;
                        acttxt += "Monster uses Triple Slash: - " + b + " Health \n - " + c + " Health \n - " + d + " Health \n - ";
                    }
                    else if (l == 3)
                    {
                        a = Boss.Charge();
                        acttxt += "Monster charges a powerful attack...\n";
                    }
                    else
                    {
                        a = Boss.PowerfulAttack();
                        if (armor != null)
                        {
                            a = a - armor.GetDefence();
                            if (a > 0) { Player.Health -= a; }
                            else a = 0;
                        }
                        else Player.Health -= a;
                        acttxt += "Monster uses PowerfulAttack: - " + a + " Health \n";
                    }
                }
            }
            return acttxt;
        }

        public string CheckQuest()
        {
            string acttxt = "";
            if (ActiveQuest == null) 
            { 
                ActiveQuest = CurrentLocation.GiveQuest();
                acttxt += "New quest: " + ActiveQuest.Name + ".\n" + ActiveQuest.Info + "\n";
            }
            else
            {
                ActiveQuest.Completed = (ActiveQuest.Counter >= ActiveQuest.NeededNumber);
                if (ActiveQuest.Completed == false)
                {
                    acttxt += "You still haven't completed previous quest:\n" + ActiveQuest.Info + " " + ActiveQuest.Counter + "/" + ActiveQuest.NeededNumber + "\n";
                }
                else
                {
                    acttxt += "You completed the quest: " + ActiveQuest.Name + "\n+ " + ActiveQuest.Exp + " Exp, + " + ActiveQuest.Gold + " Gold\n";
                    Player.Exp += ActiveQuest.Exp;
                    Player.Gold += ActiveQuest.Gold;
                    ActiveQuest = null;
                }
            }
            return acttxt;
        }

        public string SpecialQuest(Monster monster, Weapon weapon)
        {
            if (ActiveQuest != null && ActiveQuest.GetType() == typeof(KillWolf))
            {
                KillWolf quest = (KillWolf)ActiveQuest;
                if (monster.Name == quest.Monster.Name && weapon.Name == "Bone")
                {
                    Wolf = (Wolf)monster;
                    ActiveQuest.Exp = 0;
                    ActiveQuest.Gold = 0;
                    ActiveQuest.Counter = 1;
                    CurrentLocation.ActiveMonster = null;
                    Player.MyEquipment.RemoveArmament(weapon.ID);
                    return "Wolf happily takes your bone. It seems like from now on, wolf will be by your side.\n\n";
                }
            }
            return "";
        }

        public void QuestCounter(Monster monster)
        {          
            if (ActiveQuest != null)
            {
                if (ActiveQuest.GetType() == typeof(KillMonsters))
                {
                    KillMonsters quest = (KillMonsters)ActiveQuest;
                    
                    if (monster.Name == quest.Monster.Name)
                    {
                        ActiveQuest.Counter++;                      
                    }
                }
                if (ActiveQuest.GetType() == typeof(KillWolf))
                {
                    KillWolf quest = (KillWolf)ActiveQuest;
                    if (monster.Name == quest.Monster.Name)
                    {
                        ActiveQuest.Counter++;
                    }
                }
            }
        }
        public void Start()
        {
            Factory = new TownFactory();
            State = new StateInn();
            State.Session = this;
            ActiveWorld = Factory.CreateWorld();
            Town = ActiveWorld;

            Player = new Character();
            Player.Health = Player.GetMaxHealth();
            Player.Level = 1;
            Player.Exp = 0;
            Player.Gold = 3;
            Player.MyEquipment = new Equipment();

            X = 0; Y = 0;
            CurrentLocation = ActiveWorld.LocationAt(X, Y);
            QuestFactory questFactory = new QuestFactory(Player, CurrentLocation.Monsters);
            CurrentLocation.QuestFactory = questFactory;
        }
    }
}
