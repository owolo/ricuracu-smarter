﻿namespace Ricu_Racu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gName = new System.Windows.Forms.Label();
            this.onePlay = new System.Windows.Forms.Button();
            this.twoPlay = new System.Windows.Forms.Button();
            this.choose1 = new System.Windows.Forms.Label();
            this.but10 = new System.Windows.Forms.Button();
            this.but20 = new System.Windows.Forms.Button();
            this.but20t = new System.Windows.Forms.Button();
            this.but10t = new System.Windows.Forms.Button();
            this.choose2 = new System.Windows.Forms.Label();
            this.fons = new System.Windows.Forms.Label();
            this.fons2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gName
            // 
            this.gName.AutoSize = true;
            this.gName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.gName.Location = new System.Drawing.Point(142, 41);
            this.gName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gName.Name = "gName";
            this.gName.Size = new System.Drawing.Size(324, 46);
            this.gName.TabIndex = 0;
            this.gName.Text = "Kurš ir gudrāks?";
            this.gName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // onePlay
            // 
            this.onePlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.onePlay.Location = new System.Drawing.Point(73, 254);
            this.onePlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.onePlay.Name = "onePlay";
            this.onePlay.Size = new System.Drawing.Size(147, 57);
            this.onePlay.TabIndex = 3;
            this.onePlay.TabStop = false;
            this.onePlay.Text = "1 spēlētājs";
            this.onePlay.UseVisualStyleBackColor = true;
            this.onePlay.Click += new System.EventHandler(this.onePlay_Click);
            // 
            // twoPlay
            // 
            this.twoPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.twoPlay.Location = new System.Drawing.Point(369, 254);
            this.twoPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.twoPlay.Name = "twoPlay";
            this.twoPlay.Size = new System.Drawing.Size(147, 57);
            this.twoPlay.TabIndex = 4;
            this.twoPlay.TabStop = false;
            this.twoPlay.Text = "2 spēlētāji";
            this.twoPlay.UseVisualStyleBackColor = true;
            this.twoPlay.Click += new System.EventHandler(this.twoPlay_Click);
            // 
            // choose1
            // 
            this.choose1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.choose1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.choose1.Location = new System.Drawing.Point(90, 155);
            this.choose1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.choose1.Name = "choose1";
            this.choose1.Size = new System.Drawing.Size(130, 26);
            this.choose1.TabIndex = 6;
            this.choose1.Text = " Cik lauciņus?";
            this.choose1.Visible = false;
            // 
            // but10
            // 
            this.but10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but10.Location = new System.Drawing.Point(94, 200);
            this.but10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.but10.Name = "but10";
            this.but10.Size = new System.Drawing.Size(33, 34);
            this.but10.TabIndex = 7;
            this.but10.Text = "10";
            this.but10.UseVisualStyleBackColor = true;
            this.but10.Visible = false;
            this.but10.Click += new System.EventHandler(this.but10_Click);
            // 
            // but20
            // 
            this.but20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but20.Location = new System.Drawing.Point(160, 200);
            this.but20.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.but20.Name = "but20";
            this.but20.Size = new System.Drawing.Size(33, 34);
            this.but20.TabIndex = 8;
            this.but20.Text = "20";
            this.but20.UseVisualStyleBackColor = true;
            this.but20.Visible = false;
            this.but20.Click += new System.EventHandler(this.but20_Click);
            // 
            // but20t
            // 
            this.but20t.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but20t.Location = new System.Drawing.Point(394, 200);
            this.but20t.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.but20t.Name = "but20t";
            this.but20t.Size = new System.Drawing.Size(33, 34);
            this.but20t.TabIndex = 16;
            this.but20t.Text = "10";
            this.but20t.UseVisualStyleBackColor = true;
            this.but20t.Visible = false;
            this.but20t.Click += new System.EventHandler(this.but10t_Click);
            // 
            // but10t
            // 
            this.but10t.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but10t.Location = new System.Drawing.Point(462, 200);
            this.but10t.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.but10t.Name = "but10t";
            this.but10t.Size = new System.Drawing.Size(33, 34);
            this.but10t.TabIndex = 15;
            this.but10t.Text = "20";
            this.but10t.UseVisualStyleBackColor = true;
            this.but10t.Visible = false;
            this.but10t.Click += new System.EventHandler(this.but20t_Click);
            // 
            // choose2
            // 
            this.choose2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.choose2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.choose2.Location = new System.Drawing.Point(390, 155);
            this.choose2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.choose2.Name = "choose2";
            this.choose2.Size = new System.Drawing.Size(126, 26);
            this.choose2.TabIndex = 18;
            this.choose2.Text = "Cik lauciņus?";
            this.choose2.Visible = false;
            // 
            // fons
            // 
            this.fons.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fons.Location = new System.Drawing.Point(58, 148);
            this.fons.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fons.Name = "fons";
            this.fons.Size = new System.Drawing.Size(179, 93);
            this.fons.TabIndex = 19;
            this.fons.Visible = false;
            // 
            // fons2
            // 
            this.fons2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fons2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fons2.Location = new System.Drawing.Point(350, 148);
            this.fons2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fons2.Name = "fons2";
            this.fons2.Size = new System.Drawing.Size(180, 93);
            this.fons2.TabIndex = 20;
            this.fons2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.fons2);
            this.Controls.Add(this.fons);
            this.Controls.Add(this.choose2);
            this.Controls.Add(this.but20t);
            this.Controls.Add(this.but10t);
            this.Controls.Add(this.but20);
            this.Controls.Add(this.but10);
            this.Controls.Add(this.choose1);
            this.Controls.Add(this.twoPlay);
            this.Controls.Add(this.onePlay);
            this.Controls.Add(this.gName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sākums: \"Kurš ir gudrāks?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gName;
        private System.Windows.Forms.Button onePlay;
        private System.Windows.Forms.Button twoPlay;
        private System.Windows.Forms.Label choose1;
        private System.Windows.Forms.Button but10;
        private System.Windows.Forms.Button but20;
        private System.Windows.Forms.Button but20t;
        private System.Windows.Forms.Button but10t;
        private System.Windows.Forms.Label choose2;
        private System.Windows.Forms.Label fons;
        private System.Windows.Forms.Label fons2;
    }
}

