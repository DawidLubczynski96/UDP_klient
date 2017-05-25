namespace klient_UDP
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
            this.przycisk_wyslij = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.ListBox();
            this.wiadomosc = new System.Windows.Forms.TextBox();
            this.adres = new System.Windows.Forms.TextBox();
            this.my_port = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.my_port)).BeginInit();
            this.SuspendLayout();
            // 
            // przycisk_wyslij
            // 
            this.przycisk_wyslij.Location = new System.Drawing.Point(138, 309);
            this.przycisk_wyslij.Name = "przycisk_wyslij";
            this.przycisk_wyslij.Size = new System.Drawing.Size(111, 59);
            this.przycisk_wyslij.TabIndex = 0;
            this.przycisk_wyslij.Text = "Wyślij wiadomość";
            this.przycisk_wyslij.UseVisualStyleBackColor = true;
            this.przycisk_wyslij.Click += new System.EventHandler(this.przycisk_wyslij_Click);
            // 
            // info
            // 
            this.info.FormattingEnabled = true;
            this.info.Location = new System.Drawing.Point(44, 200);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(299, 82);
            this.info.TabIndex = 1;
            // 
            // wiadomosc
            // 
            this.wiadomosc.Location = new System.Drawing.Point(44, 78);
            this.wiadomosc.Multiline = true;
            this.wiadomosc.Name = "wiadomosc";
            this.wiadomosc.Size = new System.Drawing.Size(299, 101);
            this.wiadomosc.TabIndex = 2;
            this.wiadomosc.Text = "Wpisz wpiadomość";
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(44, 26);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(133, 20);
            this.adres.TabIndex = 2;
            this.adres.Text = "adres";
            // 
            // my_port
            // 
            this.my_port.Location = new System.Drawing.Point(202, 26);
            this.my_port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.my_port.Name = "my_port";
            this.my_port.Size = new System.Drawing.Size(141, 20);
            this.my_port.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 414);
            this.Controls.Add(this.my_port);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.wiadomosc);
            this.Controls.Add(this.info);
            this.Controls.Add(this.przycisk_wyslij);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.my_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button przycisk_wyslij;
        private System.Windows.Forms.ListBox info;
        private System.Windows.Forms.TextBox wiadomosc;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.NumericUpDown my_port;
    }
}

