namespace OverzichtBezoeken
{
    partial class FrmNotaris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotaris));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imgRand = new System.Windows.Forms.PictureBox();
            this.lstMedewerkers = new System.Windows.Forms.ListBox();
            this.txtResultaat = new System.Windows.Forms.TextBox();
            this.btnToon = new System.Windows.Forms.Button();
            this.btnToonTijdOverzichten = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgRand)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imgRand
            // 
            this.imgRand.Image = ((System.Drawing.Image)(resources.GetObject("imgRand.Image")));
            this.imgRand.Location = new System.Drawing.Point(297, 13);
            this.imgRand.Name = "imgRand";
            this.imgRand.Size = new System.Drawing.Size(100, 89);
            this.imgRand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgRand.TabIndex = 0;
            this.imgRand.TabStop = false;
            // 
            // lstMedewerkers
            // 
            this.lstMedewerkers.FormattingEnabled = true;
            this.lstMedewerkers.Location = new System.Drawing.Point(13, 13);
            this.lstMedewerkers.Name = "lstMedewerkers";
            this.lstMedewerkers.Size = new System.Drawing.Size(148, 82);
            this.lstMedewerkers.TabIndex = 1;
            // 
            // txtResultaat
            // 
            this.txtResultaat.Location = new System.Drawing.Point(13, 102);
            this.txtResultaat.Multiline = true;
            this.txtResultaat.Name = "txtResultaat";
            this.txtResultaat.ReadOnly = true;
            this.txtResultaat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultaat.Size = new System.Drawing.Size(278, 220);
            this.txtResultaat.TabIndex = 2;
            // 
            // btnToon
            // 
            this.btnToon.Location = new System.Drawing.Point(298, 109);
            this.btnToon.Name = "btnToon";
            this.btnToon.Size = new System.Drawing.Size(75, 23);
            this.btnToon.TabIndex = 3;
            this.btnToon.Text = "Toon";
            this.btnToon.UseVisualStyleBackColor = true;
            this.btnToon.Click += new System.EventHandler(this.btnToon_Click);
            // 
            // btnToonTijdOverzichten
            // 
            this.btnToonTijdOverzichten.Location = new System.Drawing.Point(298, 139);
            this.btnToonTijdOverzichten.Name = "btnToonTijdOverzichten";
            this.btnToonTijdOverzichten.Size = new System.Drawing.Size(75, 23);
            this.btnToonTijdOverzichten.TabIndex = 4;
            this.btnToonTijdOverzichten.Text = "Toon Tijd";
            this.btnToonTijdOverzichten.UseVisualStyleBackColor = true;
            this.btnToonTijdOverzichten.Click += new System.EventHandler(this.btnToonTijdOverzichten_Click);
            // 
            // FrmNotaris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 334);
            this.Controls.Add(this.btnToonTijdOverzichten);
            this.Controls.Add(this.btnToon);
            this.Controls.Add(this.txtResultaat);
            this.Controls.Add(this.lstMedewerkers);
            this.Controls.Add(this.imgRand);
            this.Name = "FrmNotaris";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmNotaris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgRand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox imgRand;
        private System.Windows.Forms.ListBox lstMedewerkers;
        private System.Windows.Forms.TextBox txtResultaat;
        private System.Windows.Forms.Button btnToon;
        private System.Windows.Forms.Button btnToonTijdOverzichten;
    }
}

