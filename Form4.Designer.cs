namespace Ricu_Racu
{
    partial class Form4
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // uzvara
            // 
            this.uzvara.AutoSize = true;
            this.uzvara.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uzvara.Location = new System.Drawing.Point(140, 58);
            this.uzvara.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uzvara.Name = "uzvara";
            this.uzvara.Size = new System.Drawing.Size(317, 55);
            this.uzvara.TabIndex = 0;
            this.uzvara.Text = "APSVEICU!!!";
            this.uzvara.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text.Location = new System.Drawing.Point(93, 157);
            this.text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(401, 58);
            this.text.TabIndex = 1;
            this.text.Text = "Zaļais spēlētājs uzvarēja šo! \r\nTagad gan skaidrs, kurš ir gudrāks :)";
            this.text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.text.Click += new System.EventHandler(this.text_Click);
            // 
            // toStart
            // 
            this.toStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toStart.Location = new System.Drawing.Point(183, 273);
            this.toStart.Margin = new System.Windows.Forms.Padding(2);
            this.toStart.Name = "toStart";
            this.toStart.Size = new System.Drawing.Size(204, 54);
            this.toStart.TabIndex = 2;
            this.toStart.Text = "Uz sākuma ekrānu";
            this.toStart.UseVisualStyleBackColor = true;
            this.toStart.Click += new System.EventHandler(this.toStart_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.toStart);
            this.Controls.Add(this.text);
            this.Controls.Add(this.uzvara);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beigas: \"Kurš ir gudrāks?";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uzvara;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Button toStart;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}