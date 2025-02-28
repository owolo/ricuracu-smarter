namespace Ricu_Racu
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.atbildeBut1 = new System.Windows.Forms.Button();
            this.atbildeBut2 = new System.Windows.Forms.Button();
            this.atbildeBut3 = new System.Windows.Forms.Button();
            this.jautajums = new System.Windows.Forms.Label();
            this.block1 = new System.Windows.Forms.Label();
            this.block2 = new System.Windows.Forms.Label();
            this.block3 = new System.Windows.Forms.Label();
            this.block4 = new System.Windows.Forms.Label();
            this.block5 = new System.Windows.Forms.Label();
            this.block6 = new System.Windows.Forms.Label();
            this.block7 = new System.Windows.Forms.Label();
            this.block8 = new System.Windows.Forms.Label();
            this.block9 = new System.Windows.Forms.Label();
            this.block10 = new System.Windows.Forms.Label();
            this.spawnRed = new System.Windows.Forms.Label();
            this.imgTimer = new System.Windows.Forms.Timer(this.components);
            this.winBlock = new System.Windows.Forms.Label();
            this.red = new System.Windows.Forms.PictureBox();
            this.dice = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice)).BeginInit();
            this.SuspendLayout();
            // 
            // atbildeBut1
            // 
            this.atbildeBut1.Location = new System.Drawing.Point(65, 289);
            this.atbildeBut1.Margin = new System.Windows.Forms.Padding(2);
            this.atbildeBut1.Name = "atbildeBut1";
            this.atbildeBut1.Size = new System.Drawing.Size(106, 37);
            this.atbildeBut1.TabIndex = 3;
            this.atbildeBut1.TabStop = false;
            this.atbildeBut1.Text = "1";
            this.atbildeBut1.UseVisualStyleBackColor = true;
            this.atbildeBut1.Click += new System.EventHandler(this.atbildeBut1_Click);
            // 
            // atbildeBut2
            // 
            this.atbildeBut2.CausesValidation = false;
            this.atbildeBut2.Location = new System.Drawing.Point(224, 289);
            this.atbildeBut2.Margin = new System.Windows.Forms.Padding(2);
            this.atbildeBut2.Name = "atbildeBut2";
            this.atbildeBut2.Size = new System.Drawing.Size(106, 37);
            this.atbildeBut2.TabIndex = 2;
            this.atbildeBut2.TabStop = false;
            this.atbildeBut2.Text = "2";
            this.atbildeBut2.UseMnemonic = false;
            this.atbildeBut2.UseVisualStyleBackColor = true;
            this.atbildeBut2.Click += new System.EventHandler(this.atbildeBut2_Click);
            // 
            // atbildeBut3
            // 
            this.atbildeBut3.Location = new System.Drawing.Point(146, 353);
            this.atbildeBut3.Margin = new System.Windows.Forms.Padding(2);
            this.atbildeBut3.Name = "atbildeBut3";
            this.atbildeBut3.Size = new System.Drawing.Size(106, 37);
            this.atbildeBut3.TabIndex = 1;
            this.atbildeBut3.TabStop = false;
            this.atbildeBut3.Text = "3";
            this.atbildeBut3.UseVisualStyleBackColor = true;
            this.atbildeBut3.Click += new System.EventHandler(this.atbildeBut3_Click);
            // 
            // jautajums
            // 
            this.jautajums.AutoSize = true;
            this.jautajums.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.jautajums.Location = new System.Drawing.Point(88, 234);
            this.jautajums.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.jautajums.Name = "jautajums";
            this.jautajums.Size = new System.Drawing.Size(222, 20);
            this.jautajums.TabIndex = 4;
            this.jautajums.Text = "Jautājums: Cik būs 2+2*2?";
            this.jautajums.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // block1
            // 
            this.block1.BackColor = System.Drawing.Color.Silver;
            this.block1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.block1.Location = new System.Drawing.Point(63, 76);
            this.block1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.block1.Name = "block1";
            this.block1.Size = new System.Drawing.Size(50, 50);
            this.block1.TabIndex = 12;
            this.block1.Visible = false;
            // 
            // block2
            // 
            this.block2.BackColor = System.Drawing.Color.Silver;
            this.block2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.block2.Location = new System.Drawing.Point(117, 76);
            this.block2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.block2.Name = "block2";
            this.block2.Size = new System.Drawing.Size(50, 50);
            this.block2.TabIndex = 13;
            this.block2.Visible = false;
            // 
            // block3
            // 
            this.block3.BackColor = System.Drawing.Color.Silver;
            this.block3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.block3.Location = new System.Drawing.Point(225, 76);
            this.block3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.block3.Name = "block3";
            this.block3.Size = new System.Drawing.Size(50, 50);
            this.block3.TabIndex = 15;
            this.block3.Visible = false;
            // 
            // block4
            // 
            this.block4.BackColor = System.Drawing.Color.Silver;
            this.block4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.block4.Location = new System.Drawing.Point(171, 76);
            this.block4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.block4.Name = "block4";
            this.block4.Size = new System.Drawing.Size(50, 50);
            this.block4.TabIndex = 14;
            this.block4.Visible = false;
            // 
            // block5
            // 
            this.block5.BackColor = System.Drawing.Color.Silver;
            this.block5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.block5.Location = new System.Drawing.Point(333, 76);
            this.block5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.block5.Name = "block5";
            this.block5.Size = new System.Drawing.Size(50, 50);
            this.block5.TabIndex = 17;
            this.block5.Visible = false;
            // 
            // block6
            // 
            this.block6.BackColor = System.Drawing.Color.Silver;
            this.block6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.block6.Location = new System.Drawing.Point(279, 76);
            this.block6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.block6.Name = "block6";
            this.block6.Size = new System.Drawing.Size(50, 50);
            this.block6.TabIndex = 16;
            this.block6.Visible = false;
            // 
            // block7
            // 
            this.block7.BackColor = System.Drawing.Color.Silver;
            this.block7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.block7.Location = new System.Drawing.Point(441, 76);
            this.block7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.block7.Name = "block7";
            this.block7.Size = new System.Drawing.Size(50, 50);
            this.block7.TabIndex = 19;
            this.block7.Visible = false;
            // 
            // block8
            // 
            this.block8.BackColor = System.Drawing.Color.Silver;
            this.block8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.block8.Location = new System.Drawing.Point(387, 76);
            this.block8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.block8.Name = "block8";
            this.block8.Size = new System.Drawing.Size(50, 50);
            this.block8.TabIndex = 18;
            this.block8.Visible = false;
            // 
            // block9
            // 
            this.block9.BackColor = System.Drawing.Color.Silver;
            this.block9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.block9.Location = new System.Drawing.Point(549, 76);
            this.block9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.block9.Name = "block9";
            this.block9.Size = new System.Drawing.Size(50, 50);
            this.block9.TabIndex = 21;
            this.block9.Visible = false;
            // 
            // block10
            // 
            this.block10.BackColor = System.Drawing.Color.Silver;
            this.block10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.block10.Location = new System.Drawing.Point(495, 76);
            this.block10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.block10.Name = "block10";
            this.block10.Size = new System.Drawing.Size(50, 50);
            this.block10.TabIndex = 20;
            this.block10.Visible = false;
            // 
            // spawnRed
            // 
            this.spawnRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spawnRed.Location = new System.Drawing.Point(9, 76);
            this.spawnRed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.spawnRed.Name = "spawnRed";
            this.spawnRed.Size = new System.Drawing.Size(50, 50);
            this.spawnRed.TabIndex = 32;
            // 
            // imgTimer
            // 
            this.imgTimer.Tick += new System.EventHandler(this.imgTimer_Tick);
            // 
            // winBlock
            // 
            this.winBlock.BackColor = System.Drawing.Color.Chartreuse;
            this.winBlock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.winBlock.Location = new System.Drawing.Point(603, 76);
            this.winBlock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.winBlock.Name = "winBlock";
            this.winBlock.Size = new System.Drawing.Size(50, 50);
            this.winBlock.TabIndex = 39;
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.Silver;
            this.red.Image = global::Ricu_Racu.Properties.Resources.red_ludo;
            this.red.Location = new System.Drawing.Point(9, 76);
            this.red.Margin = new System.Windows.Forms.Padding(2);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(50, 50);
            this.red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.red.TabIndex = 35;
            this.red.TabStop = false;
            // 
            // dice
            // 
            this.dice.Image = global::Ricu_Racu.Properties.Resources.dice1;
            this.dice.Location = new System.Drawing.Point(485, 312);
            this.dice.Margin = new System.Windows.Forms.Padding(2);
            this.dice.Name = "dice";
            this.dice.Size = new System.Drawing.Size(128, 140);
            this.dice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dice.TabIndex = 9;
            this.dice.TabStop = false;
            this.dice.Visible = false;
            this.dice.Click += new System.EventHandler(this.dice_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(694, 500);
            this.Controls.Add(this.winBlock);
            this.Controls.Add(this.red);
            this.Controls.Add(this.spawnRed);
            this.Controls.Add(this.block9);
            this.Controls.Add(this.block10);
            this.Controls.Add(this.block7);
            this.Controls.Add(this.block8);
            this.Controls.Add(this.block5);
            this.Controls.Add(this.block6);
            this.Controls.Add(this.block3);
            this.Controls.Add(this.block4);
            this.Controls.Add(this.block2);
            this.Controls.Add(this.block1);
            this.Controls.Add(this.dice);
            this.Controls.Add(this.jautajums);
            this.Controls.Add(this.atbildeBut3);
            this.Controls.Add(this.atbildeBut2);
            this.Controls.Add(this.atbildeBut1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spēle: \"Kurš ir gudrāks?";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button atbildeBut1;
        private System.Windows.Forms.Button atbildeBut2;
        private System.Windows.Forms.Button atbildeBut3;
        private System.Windows.Forms.Label jautajums;
        private System.Windows.Forms.PictureBox dice;
        private System.Windows.Forms.Label block1;
        private System.Windows.Forms.Label block2;
        private System.Windows.Forms.Label block3;
        private System.Windows.Forms.Label block4;
        private System.Windows.Forms.Label block5;
        private System.Windows.Forms.Label block6;
        private System.Windows.Forms.Label block7;
        private System.Windows.Forms.Label block8;
        private System.Windows.Forms.Label block9;
        private System.Windows.Forms.Label block10;
        private System.Windows.Forms.Label spawnRed;
        private System.Windows.Forms.PictureBox red;
        private System.Windows.Forms.Timer imgTimer;
        private System.Windows.Forms.Label winBlock;
    }
}