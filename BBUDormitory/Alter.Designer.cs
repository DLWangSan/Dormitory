namespace BBUDormitory
{
    partial class Alter
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
            this.textBox_alsex = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_alName = new System.Windows.Forms.TextBox();
            this.label_resName = new System.Windows.Forms.Label();
            this.textBox_aldornum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_altel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_alsex
            // 
            this.textBox_alsex.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_alsex.Location = new System.Drawing.Point(96, 104);
            this.textBox_alsex.Name = "textBox_alsex";
            this.textBox_alsex.Size = new System.Drawing.Size(175, 26);
            this.textBox_alsex.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(31, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 14);
            this.label6.TabIndex = 19;
            this.label6.Text = "性别";
            // 
            // textBox_alName
            // 
            this.textBox_alName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_alName.Location = new System.Drawing.Point(96, 43);
            this.textBox_alName.Name = "textBox_alName";
            this.textBox_alName.Size = new System.Drawing.Size(175, 26);
            this.textBox_alName.TabIndex = 18;
            // 
            // label_resName
            // 
            this.label_resName.AutoSize = true;
            this.label_resName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_resName.Location = new System.Drawing.Point(31, 47);
            this.label_resName.Name = "label_resName";
            this.label_resName.Size = new System.Drawing.Size(35, 14);
            this.label_resName.TabIndex = 17;
            this.label_resName.Text = "姓名";
            // 
            // textBox_aldornum
            // 
            this.textBox_aldornum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_aldornum.Location = new System.Drawing.Point(411, 106);
            this.textBox_aldornum.Name = "textBox_aldornum";
            this.textBox_aldornum.Size = new System.Drawing.Size(175, 26);
            this.textBox_aldornum.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(335, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 23;
            this.label4.Text = "宿舍号";
            // 
            // textBox_altel
            // 
            this.textBox_altel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_altel.Location = new System.Drawing.Point(411, 43);
            this.textBox_altel.Name = "textBox_altel";
            this.textBox_altel.Size = new System.Drawing.Size(175, 26);
            this.textBox_altel.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(335, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 21;
            this.label5.Text = "手机号";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 50);
            this.button1.TabIndex = 25;
            this.button1.Text = "保存更改";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Alter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 303);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_aldornum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_altel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_alsex);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_alName);
            this.Controls.Add(this.label_resName);
            this.Name = "Alter";
            this.Text = "Alter";
            this.Load += new System.EventHandler(this.Alter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_alsex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_alName;
        private System.Windows.Forms.Label label_resName;
        private System.Windows.Forms.TextBox textBox_aldornum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_altel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}