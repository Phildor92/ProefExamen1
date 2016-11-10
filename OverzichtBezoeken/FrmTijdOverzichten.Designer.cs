namespace OverzichtBezoeken
{
    partial class FrmTijdOverzichten
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
            this.tab1en2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtOverzichtMaand = new System.Windows.Forms.TextBox();
            this.txtOverzichtWeekdag = new System.Windows.Forms.TextBox();
            this.tab1en2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1en2
            // 
            this.tab1en2.Controls.Add(this.tabPage1);
            this.tab1en2.Controls.Add(this.tabPage2);
            this.tab1en2.Location = new System.Drawing.Point(12, 12);
            this.tab1en2.Name = "tab1en2";
            this.tab1en2.SelectedIndex = 0;
            this.tab1en2.Size = new System.Drawing.Size(364, 291);
            this.tab1en2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtOverzichtMaand);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(356, 265);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Per maand";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtOverzichtWeekdag);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(356, 265);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Per weekdag";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtOverzichtMaand
            // 
            this.txtOverzichtMaand.Location = new System.Drawing.Point(7, 7);
            this.txtOverzichtMaand.Multiline = true;
            this.txtOverzichtMaand.Name = "txtOverzichtMaand";
            this.txtOverzichtMaand.Size = new System.Drawing.Size(343, 255);
            this.txtOverzichtMaand.TabIndex = 0;
            // 
            // txtOverzichtWeekdag
            // 
            this.txtOverzichtWeekdag.Location = new System.Drawing.Point(7, 7);
            this.txtOverzichtWeekdag.Multiline = true;
            this.txtOverzichtWeekdag.Name = "txtOverzichtWeekdag";
            this.txtOverzichtWeekdag.Size = new System.Drawing.Size(343, 252);
            this.txtOverzichtWeekdag.TabIndex = 0;
            // 
            // FrmTijdOverzichten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 315);
            this.Controls.Add(this.tab1en2);
            this.Name = "FrmTijdOverzichten";
            this.Text = "FrmTijdOverzichten";
            this.tab1en2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab1en2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtOverzichtMaand;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtOverzichtWeekdag;
    }
}