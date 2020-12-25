namespace BeatGame
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.buttonUpgrade = new System.Windows.Forms.Button();
            this.buttonShop = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.labelLife = new System.Windows.Forms.Label();
            this.labelHit = new System.Windows.Forms.Label();
            this.labelMana = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.labelBoss = new System.Windows.Forms.Label();
            this.timerHitMonster = new System.Windows.Forms.Timer(this.components);
            this.buttonUpHit = new System.Windows.Forms.Button();
            this.buttonFreez = new System.Windows.Forms.Button();
            this.buttonUpLife = new System.Windows.Forms.Button();
            this.buttonHil = new System.Windows.Forms.Button();
            this.buttonCancelUp = new System.Windows.Forms.Button();
            this.buttonCancelShop = new System.Windows.Forms.Button();
            this.timerFreez = new System.Windows.Forms.Timer(this.components);
            this.labelFreez = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonBeat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Monster");
            this.imageList.Images.SetKeyName(1, "Viking");
            this.imageList.Images.SetKeyName(2, "Arabian");
            this.imageList.Images.SetKeyName(3, "Character");
            this.imageList.Images.SetKeyName(4, "Zombie");
            this.imageList.Images.SetKeyName(5, "Guard");
            this.imageList.Images.SetKeyName(6, "Profess");
            this.imageList.Images.SetKeyName(7, "Knigth");
            // 
            // buttonUpgrade
            // 
            this.buttonUpgrade.Location = new System.Drawing.Point(13, 428);
            this.buttonUpgrade.Name = "buttonUpgrade";
            this.buttonUpgrade.Size = new System.Drawing.Size(107, 43);
            this.buttonUpgrade.TabIndex = 1;
            this.buttonUpgrade.Text = "Улучшения";
            this.buttonUpgrade.UseVisualStyleBackColor = true;
            this.buttonUpgrade.Click += new System.EventHandler(this.buttonUpgrade_Click);
            // 
            // buttonShop
            // 
            this.buttonShop.Location = new System.Drawing.Point(170, 428);
            this.buttonShop.Name = "buttonShop";
            this.buttonShop.Size = new System.Drawing.Size(107, 43);
            this.buttonShop.TabIndex = 2;
            this.buttonShop.Text = "Магазин";
            this.buttonShop.UseVisualStyleBackColor = true;
            this.buttonShop.Click += new System.EventHandler(this.buttonShop_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(98, 91);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(83, 20);
            this.labelInfo.TabIndex = 3;
            this.labelInfo.Text = "[lvl1] 35/35";
            // 
            // time
            // 
            this.time.Interval = 1000;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // labelLife
            // 
            this.labelLife.AutoSize = true;
            this.labelLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLife.ForeColor = System.Drawing.Color.Red;
            this.labelLife.Location = new System.Drawing.Point(30, 2);
            this.labelLife.Name = "labelLife";
            this.labelLife.Size = new System.Drawing.Size(49, 20);
            this.labelLife.TabIndex = 4;
            this.labelLife.Text = "50/50";
            // 
            // labelHit
            // 
            this.labelHit.AutoSize = true;
            this.labelHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelHit.Location = new System.Drawing.Point(30, 33);
            this.labelHit.Name = "labelHit";
            this.labelHit.Size = new System.Drawing.Size(18, 20);
            this.labelHit.TabIndex = 5;
            this.labelHit.Text = "5";
            // 
            // labelMana
            // 
            this.labelMana.AutoSize = true;
            this.labelMana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMana.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelMana.Location = new System.Drawing.Point(244, 3);
            this.labelMana.Name = "labelMana";
            this.labelMana.Size = new System.Drawing.Size(18, 20);
            this.labelMana.TabIndex = 6;
            this.labelMana.Text = "0";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMoney.ForeColor = System.Drawing.Color.Gold;
            this.labelMoney.Location = new System.Drawing.Point(244, 28);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(18, 20);
            this.labelMoney.TabIndex = 7;
            this.labelMoney.Text = "0";
            // 
            // labelBoss
            // 
            this.labelBoss.AutoSize = true;
            this.labelBoss.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBoss.Location = new System.Drawing.Point(115, 71);
            this.labelBoss.Name = "labelBoss";
            this.labelBoss.Size = new System.Drawing.Size(53, 20);
            this.labelBoss.TabIndex = 8;
            this.labelBoss.Text = "Босс!";
            this.labelBoss.Visible = false;
            // 
            // timerHitMonster
            // 
            this.timerHitMonster.Interval = 1000;
            this.timerHitMonster.Tick += new System.EventHandler(this.timerHitMonster_Tick);
            // 
            // buttonUpHit
            // 
            this.buttonUpHit.Location = new System.Drawing.Point(13, 357);
            this.buttonUpHit.Name = "buttonUpHit";
            this.buttonUpHit.Size = new System.Drawing.Size(107, 43);
            this.buttonUpHit.TabIndex = 9;
            this.buttonUpHit.Text = "Атака (10)";
            this.buttonUpHit.UseVisualStyleBackColor = true;
            this.buttonUpHit.Visible = false;
            this.buttonUpHit.Click += new System.EventHandler(this.buttonUpHit_Click);
            // 
            // buttonFreez
            // 
            this.buttonFreez.Location = new System.Drawing.Point(170, 357);
            this.buttonFreez.Name = "buttonFreez";
            this.buttonFreez.Size = new System.Drawing.Size(107, 43);
            this.buttonFreez.TabIndex = 10;
            this.buttonFreez.Text = "Заморозка (40)";
            this.buttonFreez.UseVisualStyleBackColor = true;
            this.buttonFreez.Visible = false;
            this.buttonFreez.Click += new System.EventHandler(this.buttonFreez_Click);
            // 
            // buttonUpLife
            // 
            this.buttonUpLife.Location = new System.Drawing.Point(12, 308);
            this.buttonUpLife.Name = "buttonUpLife";
            this.buttonUpLife.Size = new System.Drawing.Size(107, 43);
            this.buttonUpLife.TabIndex = 11;
            this.buttonUpLife.Text = "Здоровье (10)";
            this.buttonUpLife.UseVisualStyleBackColor = true;
            this.buttonUpLife.Visible = false;
            this.buttonUpLife.Click += new System.EventHandler(this.buttonUpLife_Click);
            // 
            // buttonHil
            // 
            this.buttonHil.Location = new System.Drawing.Point(170, 308);
            this.buttonHil.Name = "buttonHil";
            this.buttonHil.Size = new System.Drawing.Size(107, 43);
            this.buttonHil.TabIndex = 12;
            this.buttonHil.Text = "Хилка (30)";
            this.buttonHil.UseVisualStyleBackColor = true;
            this.buttonHil.Visible = false;
            this.buttonHil.Click += new System.EventHandler(this.buttonHil_Click);
            // 
            // buttonCancelUp
            // 
            this.buttonCancelUp.Location = new System.Drawing.Point(13, 428);
            this.buttonCancelUp.Name = "buttonCancelUp";
            this.buttonCancelUp.Size = new System.Drawing.Size(107, 43);
            this.buttonCancelUp.TabIndex = 13;
            this.buttonCancelUp.Text = "Отмена";
            this.buttonCancelUp.UseVisualStyleBackColor = true;
            this.buttonCancelUp.Visible = false;
            this.buttonCancelUp.Click += new System.EventHandler(this.buttonCancelUp_Click);
            // 
            // buttonCancelShop
            // 
            this.buttonCancelShop.Location = new System.Drawing.Point(170, 428);
            this.buttonCancelShop.Name = "buttonCancelShop";
            this.buttonCancelShop.Size = new System.Drawing.Size(107, 43);
            this.buttonCancelShop.TabIndex = 14;
            this.buttonCancelShop.Text = "Отмена";
            this.buttonCancelShop.UseVisualStyleBackColor = true;
            this.buttonCancelShop.Visible = false;
            this.buttonCancelShop.Click += new System.EventHandler(this.buttonCancelShop_Click);
            // 
            // timerFreez
            // 
            this.timerFreez.Interval = 1000;
            this.timerFreez.Tick += new System.EventHandler(this.timerFreez_Tick);
            // 
            // labelFreez
            // 
            this.labelFreez.AutoSize = true;
            this.labelFreez.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFreez.Location = new System.Drawing.Point(136, 58);
            this.labelFreez.Name = "labelFreez";
            this.labelFreez.Size = new System.Drawing.Size(14, 15);
            this.labelFreez.TabIndex = 15;
            this.labelFreez.Text = "0";
            this.labelFreez.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::BeatGame.Properties.Resources._2;
            this.pictureBox4.Location = new System.Drawing.Point(217, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(21, 21);
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BeatGame.Properties.Resources._41;
            this.pictureBox3.Location = new System.Drawing.Point(3, 33);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 21);
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BeatGame.Properties.Resources._3;
            this.pictureBox2.Location = new System.Drawing.Point(217, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 21);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BeatGame.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 21);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // buttonBeat
            // 
            this.buttonBeat.BackColor = System.Drawing.Color.White;
            this.buttonBeat.FlatAppearance.BorderSize = 0;
            this.buttonBeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBeat.ImageIndex = 1;
            this.buttonBeat.ImageList = this.imageList;
            this.buttonBeat.Location = new System.Drawing.Point(87, 123);
            this.buttonBeat.Name = "buttonBeat";
            this.buttonBeat.Size = new System.Drawing.Size(109, 155);
            this.buttonBeat.TabIndex = 0;
            this.buttonBeat.UseVisualStyleBackColor = false;
            this.buttonBeat.Click += new System.EventHandler(this.buttonBeat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(289, 483);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelFreez);
            this.Controls.Add(this.buttonCancelShop);
            this.Controls.Add(this.buttonCancelUp);
            this.Controls.Add(this.buttonHil);
            this.Controls.Add(this.buttonUpLife);
            this.Controls.Add(this.buttonFreez);
            this.Controls.Add(this.buttonUpHit);
            this.Controls.Add(this.labelBoss);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.labelMana);
            this.Controls.Add(this.labelHit);
            this.Controls.Add(this.labelLife);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonShop);
            this.Controls.Add(this.buttonUpgrade);
            this.Controls.Add(this.buttonBeat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "beat!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBeat;
        private System.Windows.Forms.Button buttonUpgrade;
        private System.Windows.Forms.Button buttonShop;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Label labelLife;
        private System.Windows.Forms.Label labelHit;
        private System.Windows.Forms.Label labelMana;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label labelBoss;
        private System.Windows.Forms.Timer timerHitMonster;
        private System.Windows.Forms.Button buttonUpHit;
        private System.Windows.Forms.Button buttonFreez;
        private System.Windows.Forms.Button buttonUpLife;
        private System.Windows.Forms.Button buttonHil;
        private System.Windows.Forms.Button buttonCancelUp;
        private System.Windows.Forms.Button buttonCancelShop;
        private System.Windows.Forms.Timer timerFreez;
        private System.Windows.Forms.Label labelFreez;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

