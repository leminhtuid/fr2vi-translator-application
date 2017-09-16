namespace Fr2ViTranslator
{
    partial class Translator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Translator));
            this.txtFrench = new System.Windows.Forms.TextBox();
            this.txtVietnamese = new System.Windows.Forms.TextBox();
            this.lblFrench = new System.Windows.Forms.Label();
            this.lblVietnamese = new System.Windows.Forms.Label();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFrench
            // 
            this.txtFrench.Location = new System.Drawing.Point(120, 32);
            this.txtFrench.Name = "txtFrench";
            this.txtFrench.Size = new System.Drawing.Size(150, 20);
            this.txtFrench.TabIndex = 0;
            // 
            // txtVietnamese
            // 
            this.txtVietnamese.Location = new System.Drawing.Point(120, 82);
            this.txtVietnamese.Name = "txtVietnamese";
            this.txtVietnamese.ReadOnly = true;
            this.txtVietnamese.Size = new System.Drawing.Size(150, 20);
            this.txtVietnamese.TabIndex = 2;
            this.txtVietnamese.TabStop = false;
            // 
            // lblFrench
            // 
            this.lblFrench.AutoSize = true;
            this.lblFrench.Location = new System.Drawing.Point(35, 35);
            this.lblFrench.Name = "lblFrench";
            this.lblFrench.Size = new System.Drawing.Size(40, 13);
            this.lblFrench.TabIndex = 3;
            this.lblFrench.Text = "French";
            // 
            // lblVietnamese
            // 
            this.lblVietnamese.AutoSize = true;
            this.lblVietnamese.Location = new System.Drawing.Point(35, 85);
            this.lblVietnamese.Name = "lblVietnamese";
            this.lblVietnamese.Size = new System.Drawing.Size(62, 13);
            this.lblVietnamese.TabIndex = 4;
            this.lblVietnamese.Text = "Vietnamese";
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(195, 132);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(75, 23);
            this.btnTranslate.TabIndex = 1;
            this.btnTranslate.Text = "T&ranslate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            // 
            // Translator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 195);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.lblVietnamese);
            this.Controls.Add(this.lblFrench);
            this.Controls.Add(this.txtVietnamese);
            this.Controls.Add(this.txtFrench);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Translator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fr2Vi Translator";
            this.Load += new System.EventHandler(this.Translator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFrench;
        private System.Windows.Forms.TextBox txtVietnamese;
        private System.Windows.Forms.Label lblFrench;
        private System.Windows.Forms.Label lblVietnamese;
        private System.Windows.Forms.Button btnTranslate;
    }
}

