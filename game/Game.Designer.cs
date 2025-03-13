namespace game
{
    partial class Game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNorth = new Button();
            btnSouth = new Button();
            btnWest = new Button();
            btnEast = new Button();
            btnback = new Button();
            lvl = new Label();
            exp = new Label();
            hlth = new Label();
            lvltext = new Label();
            exptext = new Label();
            hlthtext = new Label();
            cboWeapons = new ComboBox();
            cboItems = new ComboBox();
            gold = new Label();
            goldtxt = new Label();
            Pic = new PictureBox();
            btnWeapon = new Button();
            btnItem = new Button();
            btnTrade = new Button();
            amr = new Label();
            amrtxt = new Label();
            acttxt = new RichTextBox();
            btnChange = new Button();
            cboChange = new ComboBox();
            btnQuest = new Button();
            spctxt = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)Pic).BeginInit();
            SuspendLayout();
            // 
            // btnNorth
            // 
            btnNorth.Location = new Point(175, 345);
            btnNorth.Name = "btnNorth";
            btnNorth.Size = new Size(154, 44);
            btnNorth.TabIndex = 0;
            btnNorth.Text = "North";
            btnNorth.UseVisualStyleBackColor = true;
            btnNorth.Click += btnNorth_Click;
            // 
            // btnSouth
            // 
            btnSouth.Location = new Point(175, 445);
            btnSouth.Name = "btnSouth";
            btnSouth.Size = new Size(154, 44);
            btnSouth.TabIndex = 1;
            btnSouth.Text = "South";
            btnSouth.UseVisualStyleBackColor = true;
            btnSouth.Click += btnSouth_Click;
            // 
            // btnWest
            // 
            btnWest.Location = new Point(15, 395);
            btnWest.Name = "btnWest";
            btnWest.Size = new Size(154, 44);
            btnWest.TabIndex = 2;
            btnWest.Text = "West";
            btnWest.UseVisualStyleBackColor = true;
            btnWest.Click += btnWest_Click;
            // 
            // btnEast
            // 
            btnEast.Location = new Point(335, 395);
            btnEast.Name = "btnEast";
            btnEast.Size = new Size(154, 44);
            btnEast.TabIndex = 3;
            btnEast.Text = "East";
            btnEast.UseVisualStyleBackColor = true;
            btnEast.Click += btnEast_Click;
            // 
            // btnback
            // 
            btnback.Location = new Point(175, 395);
            btnback.Name = "btnback";
            btnback.Size = new Size(154, 44);
            btnback.TabIndex = 6;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // lvl
            // 
            lvl.AutoSize = true;
            lvl.Location = new Point(930, 412);
            lvl.Name = "lvl";
            lvl.Size = new Size(0, 20);
            lvl.TabIndex = 7;
            // 
            // exp
            // 
            exp.AutoSize = true;
            exp.Location = new Point(930, 386);
            exp.Name = "exp";
            exp.Size = new Size(0, 20);
            exp.TabIndex = 8;
            // 
            // hlth
            // 
            hlth.AutoSize = true;
            hlth.Location = new Point(930, 362);
            hlth.Name = "hlth";
            hlth.Size = new Size(0, 20);
            hlth.TabIndex = 9;
            // 
            // lvltext
            // 
            lvltext.AutoSize = true;
            lvltext.Location = new Point(862, 412);
            lvltext.Name = "lvltext";
            lvltext.Size = new Size(46, 20);
            lvltext.TabIndex = 10;
            lvltext.Text = "Level:";
            // 
            // exptext
            // 
            exptext.AutoSize = true;
            exptext.Location = new Point(862, 386);
            exptext.Name = "exptext";
            exptext.Size = new Size(36, 20);
            exptext.TabIndex = 11;
            exptext.Text = "Exp:";
            // 
            // hlthtext
            // 
            hlthtext.AutoSize = true;
            hlthtext.Location = new Point(862, 362);
            hlthtext.Name = "hlthtext";
            hlthtext.Size = new Size(56, 20);
            hlthtext.TabIndex = 12;
            hlthtext.Text = "Health:";
            // 
            // cboWeapons
            // 
            cboWeapons.DropDownStyle = ComboBoxStyle.DropDownList;
            cboWeapons.FormattingEnabled = true;
            cboWeapons.Location = new Point(677, 404);
            cboWeapons.Name = "cboWeapons";
            cboWeapons.Size = new Size(168, 28);
            cboWeapons.TabIndex = 13;
            // 
            // cboItems
            // 
            cboItems.DropDownStyle = ComboBoxStyle.DropDownList;
            cboItems.FormattingEnabled = true;
            cboItems.Location = new Point(677, 354);
            cboItems.Name = "cboItems";
            cboItems.Size = new Size(168, 28);
            cboItems.TabIndex = 14;
            // 
            // gold
            // 
            gold.AutoSize = true;
            gold.Location = new Point(930, 436);
            gold.Name = "gold";
            gold.Size = new Size(0, 20);
            gold.TabIndex = 15;
            // 
            // goldtxt
            // 
            goldtxt.AutoSize = true;
            goldtxt.Location = new Point(862, 436);
            goldtxt.Name = "goldtxt";
            goldtxt.Size = new Size(44, 20);
            goldtxt.TabIndex = 16;
            goldtxt.Text = "Gold:";
            // 
            // Pic
            // 
            Pic.BorderStyle = BorderStyle.Fixed3D;
            Pic.Location = new Point(30, 12);
            Pic.Name = "Pic";
            Pic.Size = new Size(300, 300);
            Pic.TabIndex = 17;
            Pic.TabStop = false;
            // 
            // btnWeapon
            // 
            btnWeapon.Location = new Point(517, 395);
            btnWeapon.Name = "btnWeapon";
            btnWeapon.Size = new Size(154, 44);
            btnWeapon.TabIndex = 18;
            btnWeapon.Text = "Use Weapon";
            btnWeapon.UseVisualStyleBackColor = true;
            btnWeapon.Click += btnWeapon_Click;
            // 
            // btnItem
            // 
            btnItem.Location = new Point(517, 345);
            btnItem.Name = "btnItem";
            btnItem.Size = new Size(154, 44);
            btnItem.TabIndex = 19;
            btnItem.Text = "Use Item";
            btnItem.UseVisualStyleBackColor = true;
            btnItem.Click += btnItem_Click;
            // 
            // btnTrade
            // 
            btnTrade.Location = new Point(335, 345);
            btnTrade.Name = "btnTrade";
            btnTrade.Size = new Size(154, 44);
            btnTrade.TabIndex = 20;
            btnTrade.Text = "Trade";
            btnTrade.UseVisualStyleBackColor = true;
            btnTrade.Click += btnTrade_Click;
            // 
            // amr
            // 
            amr.AutoSize = true;
            amr.Location = new Point(930, 457);
            amr.Name = "amr";
            amr.Size = new Size(0, 20);
            amr.TabIndex = 23;
            // 
            // amrtxt
            // 
            amrtxt.AutoSize = true;
            amrtxt.Location = new Point(862, 457);
            amrtxt.Name = "amrtxt";
            amrtxt.Size = new Size(54, 20);
            amrtxt.TabIndex = 24;
            amrtxt.Text = "Armor:";
            // 
            // acttxt
            // 
            acttxt.BorderStyle = BorderStyle.FixedSingle;
            acttxt.Location = new Point(720, 12);
            acttxt.Name = "acttxt";
            acttxt.ReadOnly = true;
            acttxt.Size = new Size(300, 300);
            acttxt.TabIndex = 25;
            acttxt.Text = "";
            // 
            // btnChange
            // 
            btnChange.Location = new Point(517, 445);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(154, 44);
            btnChange.TabIndex = 26;
            btnChange.Text = "Change Armor";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += change_Click;
            // 
            // cboChange
            // 
            cboChange.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChange.FormattingEnabled = true;
            cboChange.Location = new Point(677, 454);
            cboChange.Name = "cboChange";
            cboChange.Size = new Size(168, 28);
            cboChange.TabIndex = 27;
            // 
            // btnQuest
            // 
            btnQuest.Location = new Point(335, 445);
            btnQuest.Name = "btnQuest";
            btnQuest.Size = new Size(154, 44);
            btnQuest.TabIndex = 28;
            btnQuest.Text = "Quest";
            btnQuest.UseVisualStyleBackColor = true;
            btnQuest.Click += btnQuest_Click;
            // 
            // spctxt
            // 
            spctxt.BorderStyle = BorderStyle.FixedSingle;
            spctxt.Location = new Point(380, 12);
            spctxt.Name = "spctxt";
            spctxt.ReadOnly = true;
            spctxt.Size = new Size(300, 300);
            spctxt.TabIndex = 29;
            spctxt.Text = "";
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 511);
            Controls.Add(spctxt);
            Controls.Add(btnQuest);
            Controls.Add(cboChange);
            Controls.Add(btnChange);
            Controls.Add(acttxt);
            Controls.Add(amrtxt);
            Controls.Add(amr);
            Controls.Add(btnTrade);
            Controls.Add(btnItem);
            Controls.Add(btnWeapon);
            Controls.Add(Pic);
            Controls.Add(goldtxt);
            Controls.Add(gold);
            Controls.Add(cboItems);
            Controls.Add(cboWeapons);
            Controls.Add(hlthtext);
            Controls.Add(exptext);
            Controls.Add(lvltext);
            Controls.Add(hlth);
            Controls.Add(exp);
            Controls.Add(lvl);
            Controls.Add(btnback);
            Controls.Add(btnEast);
            Controls.Add(btnWest);
            Controls.Add(btnSouth);
            Controls.Add(btnNorth);
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game";
            ((System.ComponentModel.ISupportInitialize)Pic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNorth;
        private Button btnSouth;
        private Button btnWest;
        private Button btnEast;
        private Button btnback;
        private Label lvl;
        private Label exp;
        private Label hlth;
        private Label lvltext;
        private Label exptext;
        private Label hlthtext;
        private ComboBox cboWeapons;
        private ComboBox cboItems;
        private Label gold;
        private Label goldtxt;
        private PictureBox Pic;
        private Button btnWeapon;
        private Button btnItem;
        private Button btnTrade;
        private Label amr;
        private Label amrtxt;
        private RichTextBox acttxt;
        private Button btnChange;
        private ComboBox cboChange;
        private Button btnQuest;
        private RichTextBox spctxt;
    }
}
