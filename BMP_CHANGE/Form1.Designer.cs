
namespace BMP_CHANGE
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_f = new System.Windows.Forms.Button();
            this.btn_e = new System.Windows.Forms.Button();
            this.btn_r = new System.Windows.Forms.Button();
            this.pictureBox_r = new System.Windows.Forms.PictureBox();
            this.pictureBox_f = new System.Windows.Forms.PictureBox();
            this.pictureBox_e = new System.Windows.Forms.PictureBox();
            this.textBox_c = new System.Windows.Forms.TextBox();
            this.button_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_f)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_e)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_f
            // 
            this.btn_f.Location = new System.Drawing.Point(12, 335);
            this.btn_f.Name = "btn_f";
            this.btn_f.Size = new System.Drawing.Size(150, 50);
            this.btn_f.TabIndex = 0;
            this.btn_f.Text = "起始幀";
            this.btn_f.UseVisualStyleBackColor = true;
            this.btn_f.Click += new System.EventHandler(this.btn_f_Click);
            // 
            // btn_e
            // 
            this.btn_e.Location = new System.Drawing.Point(322, 335);
            this.btn_e.Name = "btn_e";
            this.btn_e.Size = new System.Drawing.Size(150, 50);
            this.btn_e.TabIndex = 1;
            this.btn_e.Text = "截止幀";
            this.btn_e.UseVisualStyleBackColor = true;
            this.btn_e.Click += new System.EventHandler(this.btn_e_Click);
            // 
            // btn_r
            // 
            this.btn_r.Location = new System.Drawing.Point(168, 335);
            this.btn_r.Name = "btn_r";
            this.btn_r.Size = new System.Drawing.Size(150, 50);
            this.btn_r.TabIndex = 2;
            this.btn_r.Text = "運行";
            this.btn_r.UseVisualStyleBackColor = true;
            this.btn_r.Click += new System.EventHandler(this.btn_r_Click);
            // 
            // pictureBox_r
            // 
            this.pictureBox_r.Location = new System.Drawing.Point(168, 179);
            this.pictureBox_r.Name = "pictureBox_r";
            this.pictureBox_r.Size = new System.Drawing.Size(150, 150);
            this.pictureBox_r.TabIndex = 3;
            this.pictureBox_r.TabStop = false;
            // 
            // pictureBox_f
            // 
            this.pictureBox_f.Location = new System.Drawing.Point(12, 179);
            this.pictureBox_f.Name = "pictureBox_f";
            this.pictureBox_f.Size = new System.Drawing.Size(150, 150);
            this.pictureBox_f.TabIndex = 4;
            this.pictureBox_f.TabStop = false;
            // 
            // pictureBox_e
            // 
            this.pictureBox_e.Location = new System.Drawing.Point(322, 179);
            this.pictureBox_e.Name = "pictureBox_e";
            this.pictureBox_e.Size = new System.Drawing.Size(150, 150);
            this.pictureBox_e.TabIndex = 5;
            this.pictureBox_e.TabStop = false;
            // 
            // textBox_c
            // 
            this.textBox_c.Location = new System.Drawing.Point(12, 12);
            this.textBox_c.Multiline = true;
            this.textBox_c.Name = "textBox_c";
            this.textBox_c.ReadOnly = true;
            this.textBox_c.Size = new System.Drawing.Size(460, 150);
            this.textBox_c.TabIndex = 6;
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.Firebrick;
            this.button_exit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_exit.Location = new System.Drawing.Point(204, 410);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 53);
            this.button_exit.TabIndex = 7;
            this.button_exit.Text = "退出";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 475);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.textBox_c);
            this.Controls.Add(this.pictureBox_e);
            this.Controls.Add(this.pictureBox_f);
            this.Controls.Add(this.pictureBox_r);
            this.Controls.Add(this.btn_r);
            this.Controls.Add(this.btn_e);
            this.Controls.Add(this.btn_f);
            this.Name = "Form1";
            this.Text = "BMPCHANGE";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_f)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_e)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_f;
        private System.Windows.Forms.Button btn_e;
        private System.Windows.Forms.Button btn_r;
        private System.Windows.Forms.PictureBox pictureBox_r;
        private System.Windows.Forms.PictureBox pictureBox_f;
        private System.Windows.Forms.PictureBox pictureBox_e;
        private System.Windows.Forms.TextBox textBox_c;
        private System.Windows.Forms.Button button_exit;
    }
}

