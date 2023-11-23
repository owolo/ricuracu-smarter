namespace Ricu_Racu
{
    partial class Form3
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
            this.uzvara = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.toStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uzvara
            // 
            this.uzvara.AutoSize = true;
            this.uzvara.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uzvara.Location = new System.Drawing.Point(187, 72);
            this.uzvara.Name = "uzvara";
            this.uzvara.Size = new System.Drawing.Size(395, 69);
            this.uzvara.TabIndex = 0;
            this.uzvara.Text = "APSVEICU!!!";
            this.uzvara.Click += new System.EventHandler(this.label1_Click);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text.Location = new System.Drawing.Point(145, 201);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(491, 72);
            this.text.TabIndex = 1;
            this.text.Text = "Zaļais spēlētājs uzvarēja šo! \r\nTagad gan skaidrs kurš ir gudrāks :)";
            // 
            // toStart
            // 
            this.toStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toStart.Location = new System.Drawing.Point(244, 336);
            this.toStart.Name = "toStart";
            this.toStart.Size = new System.Drawing.Size(272, 67);
            this.toStart.TabIndex = 2;
            this.toStart.Text = "Uz sākuma ekrānu";
            this.toStart.UseVisualStyleBackColor = true;
            this.toStart.Click += new System.EventHandler(this.toStart_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toStart);
            this.Controls.Add(this.text);
            this.Controls.Add(this.uzvara);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.Text = "Beigas: \"Kurš ir gudrāks?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uzvara;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Button toStart;
    }
}