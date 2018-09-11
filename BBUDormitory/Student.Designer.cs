namespace BBUDormitory
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于我们ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.版本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label_sname = new System.Windows.Forms.Label();
            this.label_ssex = new System.Windows.Forms.Label();
            this.label_sdor = new System.Windows.Forms.Label();
            this.button_alter = new System.Windows.Forms.Button();
            this.textBox_news = new System.Windows.Forms.TextBox();
            this.button_updatenews = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.菜单ToolStripMenuItem.Text = "编辑（E）";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于我们ToolStripMenuItem,
            this.版本ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.帮助ToolStripMenuItem.Text = "帮助（H）";
            // 
            // 关于我们ToolStripMenuItem
            // 
            this.关于我们ToolStripMenuItem.Name = "关于我们ToolStripMenuItem";
            this.关于我们ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.关于我们ToolStripMenuItem.Text = "关于我们";
            // 
            // 版本ToolStripMenuItem
            // 
            this.版本ToolStripMenuItem.Name = "版本ToolStripMenuItem";
            this.版本ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.版本ToolStripMenuItem.Text = "版本";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(639, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "电费状态：正常";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(59, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 140);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "0.jpg");
            this.imageList1.Images.SetKeyName(1, "1.jpg");
            // 
            // label_sname
            // 
            this.label_sname.AutoSize = true;
            this.label_sname.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_sname.Location = new System.Drawing.Point(215, 78);
            this.label_sname.Name = "label_sname";
            this.label_sname.Size = new System.Drawing.Size(48, 16);
            this.label_sname.TabIndex = 3;
            this.label_sname.Text = "姓名:";
            // 
            // label_ssex
            // 
            this.label_ssex.AutoSize = true;
            this.label_ssex.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ssex.Location = new System.Drawing.Point(215, 127);
            this.label_ssex.Name = "label_ssex";
            this.label_ssex.Size = new System.Drawing.Size(48, 16);
            this.label_ssex.TabIndex = 4;
            this.label_ssex.Text = "性别:";
            // 
            // label_sdor
            // 
            this.label_sdor.AutoSize = true;
            this.label_sdor.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_sdor.Location = new System.Drawing.Point(215, 176);
            this.label_sdor.Name = "label_sdor";
            this.label_sdor.Size = new System.Drawing.Size(48, 16);
            this.label_sdor.TabIndex = 5;
            this.label_sdor.Text = "宿舍:";
            // 
            // button_alter
            // 
            this.button_alter.Location = new System.Drawing.Point(78, 347);
            this.button_alter.Name = "button_alter";
            this.button_alter.Size = new System.Drawing.Size(139, 47);
            this.button_alter.TabIndex = 0;
            this.button_alter.Text = "修改资料";
            this.button_alter.UseVisualStyleBackColor = true;
            this.button_alter.Click += new System.EventHandler(this.button_alter_Click);
            // 
            // textBox_news
            // 
            this.textBox_news.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_news.Location = new System.Drawing.Point(456, 81);
            this.textBox_news.Multiline = true;
            this.textBox_news.Name = "textBox_news";
            this.textBox_news.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_news.Size = new System.Drawing.Size(252, 127);
            this.textBox_news.TabIndex = 6;
            this.textBox_news.Text = "暂无公告";
            // 
            // button_updatenews
            // 
            this.button_updatenews.Location = new System.Drawing.Point(303, 347);
            this.button_updatenews.Name = "button_updatenews";
            this.button_updatenews.Size = new System.Drawing.Size(139, 47);
            this.button_updatenews.TabIndex = 7;
            this.button_updatenews.Text = "刷新公告";
            this.button_updatenews.UseVisualStyleBackColor = true;
            this.button_updatenews.Click += new System.EventHandler(this.button_updatenews_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(533, 347);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(139, 47);
            this.button_exit.TabIndex = 8;
            this.button_exit.Text = "退出登录";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(793, 471);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_updatenews);
            this.Controls.Add(this.textBox_news);
            this.Controls.Add(this.button_alter);
            this.Controls.Add(this.label_sdor);
            this.Controls.Add(this.label_ssex);
            this.Controls.Add(this.label_sname);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于我们ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 版本ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label_sname;
        private System.Windows.Forms.Label label_ssex;
        private System.Windows.Forms.Label label_sdor;
        private System.Windows.Forms.Button button_alter;
        private System.Windows.Forms.TextBox textBox_news;
        private System.Windows.Forms.Button button_updatenews;
        private System.Windows.Forms.Button button_exit;

        static public string temp1;
        static public string temp_name;
        static public string temp_sex;
        static public string temp_tel;
        static public string temp_dor;
    }
}