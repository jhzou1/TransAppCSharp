namespace Trans_C_Sharp
{
    partial class AskFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AskFrm));
            this.btnOk = new System.Windows.Forms.Button();
            this.rdExit = new System.Windows.Forms.RadioButton();
            this.rdMin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ckRemember = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(173, 85);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(70, 26);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // rdExit
            // 
            this.rdExit.AutoSize = true;
            this.rdExit.ForeColor = System.Drawing.Color.White;
            this.rdExit.Location = new System.Drawing.Point(74, 46);
            this.rdExit.Margin = new System.Windows.Forms.Padding(2);
            this.rdExit.Name = "rdExit";
            this.rdExit.Size = new System.Drawing.Size(97, 17);
            this.rdExit.TabIndex = 1;
            this.rdExit.TabStop = true;
            this.rdExit.Text = "我想直接退出";
            this.rdExit.UseVisualStyleBackColor = true;
            // 
            // rdMin
            // 
            this.rdMin.AutoSize = true;
            this.rdMin.ForeColor = System.Drawing.Color.White;
            this.rdMin.Location = new System.Drawing.Point(74, 68);
            this.rdMin.Margin = new System.Windows.Forms.Padding(2);
            this.rdMin.Name = "rdMin";
            this.rdMin.Size = new System.Drawing.Size(97, 17);
            this.rdMin.TabIndex = 1;
            this.rdMin.TabStop = true;
            this.rdMin.Text = "最小化到托盘";
            this.rdMin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "确认退出程序吗?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(19, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 28);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ckRemember
            // 
            this.ckRemember.AutoSize = true;
            this.ckRemember.ForeColor = System.Drawing.Color.White;
            this.ckRemember.Location = new System.Drawing.Point(9, 90);
            this.ckRemember.Margin = new System.Windows.Forms.Padding(2);
            this.ckRemember.Name = "ckRemember";
            this.ckRemember.Size = new System.Drawing.Size(98, 17);
            this.ckRemember.TabIndex = 4;
            this.ckRemember.Text = "记住我的选择";
            this.ckRemember.UseVisualStyleBackColor = true;
            // 
            // AskFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(128)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(252, 121);
            this.Controls.Add(this.ckRemember);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdMin);
            this.Controls.Add(this.rdExit);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AskFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "叔叔的询问";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AskFrm_FormClosing);
            this.Shown += new System.EventHandler(this.AskFrm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.RadioButton rdExit;
        private System.Windows.Forms.RadioButton rdMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox ckRemember;
    }
}