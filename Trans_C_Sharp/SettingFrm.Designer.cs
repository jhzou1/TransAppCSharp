namespace Trans_C_Sharp
{
    partial class SettingFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingFrm));
            this.tabPageNormal = new System.Windows.Forms.TabPage();
            this.btnResetExitConfig = new System.Windows.Forms.Button();
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabPageNormal.SuspendLayout();
            this.tab1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageNormal
            // 
            this.tabPageNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.tabPageNormal.Controls.Add(this.btnResetExitConfig);
            this.tabPageNormal.Location = new System.Drawing.Point(4, 22);
            this.tabPageNormal.Name = "tabPageNormal";
            this.tabPageNormal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNormal.Size = new System.Drawing.Size(567, 356);
            this.tabPageNormal.TabIndex = 0;
            this.tabPageNormal.Text = "【通用设置】";
            // 
            // btnResetExitConfig
            // 
            this.btnResetExitConfig.Location = new System.Drawing.Point(435, 18);
            this.btnResetExitConfig.Name = "btnResetExitConfig";
            this.btnResetExitConfig.Size = new System.Drawing.Size(124, 31);
            this.btnResetExitConfig.TabIndex = 0;
            this.btnResetExitConfig.Text = "重置退出选项";
            this.btnResetExitConfig.UseVisualStyleBackColor = true;
            this.btnResetExitConfig.Click += new System.EventHandler(this.btnResetExitConfig_Click);
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tabPageNormal);
            this.tab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab1.Location = new System.Drawing.Point(0, 0);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(575, 382);
            this.tab1.TabIndex = 0;
            // 
            // SettingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(128)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(575, 382);
            this.Controls.Add(this.tab1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置";
            this.tabPageNormal.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageNormal;
        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.Button btnResetExitConfig;
    }
}