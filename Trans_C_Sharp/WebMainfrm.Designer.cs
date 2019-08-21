namespace Trans_C_Sharp
{
    partial class WebMainfrm
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
            this.webBr1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBr1
            // 
            this.webBr1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBr1.Location = new System.Drawing.Point(0, 0);
            this.webBr1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBr1.Name = "webBr1";
            this.webBr1.Size = new System.Drawing.Size(1139, 613);
            this.webBr1.TabIndex = 0;
            // 
            // WebMainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 613);
            this.Controls.Add(this.webBr1);
            this.Name = "WebMainfrm";
            this.Text = "WebMainfrm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBr1;
    }
}