namespace jietu
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxP1 = new System.Windows.Forms.TextBox();
            this.txtBoxQ1 = new System.Windows.Forms.TextBox();
            this.txtBoxR1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxPath = new System.Windows.Forms.TextBox();
            this.txtChildP1 = new System.Windows.Forms.TextBox();
            this.txtChildQ1 = new System.Windows.Forms.TextBox();
            this.txtChildR1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "确认";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "确认";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(165, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "确认";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "P1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Q1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "R1:";
            // 
            // txtBoxP1
            // 
            this.txtBoxP1.Location = new System.Drawing.Point(59, 60);
            this.txtBoxP1.Name = "txtBoxP1";
            this.txtBoxP1.Size = new System.Drawing.Size(54, 21);
            this.txtBoxP1.TabIndex = 6;
            this.txtBoxP1.TextChanged += new System.EventHandler(this.txtBoxP1_TextChanged);
            this.txtBoxP1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxP1_KeyDown);
            // 
            // txtBoxQ1
            // 
            this.txtBoxQ1.Location = new System.Drawing.Point(59, 89);
            this.txtBoxQ1.Name = "txtBoxQ1";
            this.txtBoxQ1.Size = new System.Drawing.Size(54, 21);
            this.txtBoxQ1.TabIndex = 7;
            this.txtBoxQ1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxQ1_KeyDown);
            // 
            // txtBoxR1
            // 
            this.txtBoxR1.Location = new System.Drawing.Point(59, 118);
            this.txtBoxR1.Name = "txtBoxR1";
            this.txtBoxR1.Size = new System.Drawing.Size(54, 21);
            this.txtBoxR1.TabIndex = 8;
            this.txtBoxR1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxR1_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "parent path:";
            // 
            // txtBoxPath
            // 
            this.txtBoxPath.Location = new System.Drawing.Point(12, 24);
            this.txtBoxPath.Name = "txtBoxPath";
            this.txtBoxPath.Size = new System.Drawing.Size(198, 21);
            this.txtBoxPath.TabIndex = 10;
            this.txtBoxPath.Text = "\\\\172.26.12.16\\aoi\\5DX\\5DX不良";
            // 
            // txtChildP1
            // 
            this.txtChildP1.Location = new System.Drawing.Point(124, 60);
            this.txtChildP1.Name = "txtChildP1";
            this.txtChildP1.Size = new System.Drawing.Size(35, 21);
            this.txtChildP1.TabIndex = 11;
            // 
            // txtChildQ1
            // 
            this.txtChildQ1.Location = new System.Drawing.Point(124, 87);
            this.txtChildQ1.Name = "txtChildQ1";
            this.txtChildQ1.Size = new System.Drawing.Size(35, 21);
            this.txtChildQ1.TabIndex = 12;
            // 
            // txtChildR1
            // 
            this.txtChildR1.Location = new System.Drawing.Point(124, 118);
            this.txtChildR1.Name = "txtChildR1";
            this.txtChildR1.Size = new System.Drawing.Size(35, 21);
            this.txtChildR1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "Msg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 170);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtChildR1);
            this.Controls.Add(this.txtChildQ1);
            this.Controls.Add(this.txtChildP1);
            this.Controls.Add(this.txtBoxPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxR1);
            this.Controls.Add(this.txtBoxQ1);
            this.Controls.Add(this.txtBoxP1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "截图3F 20200521";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxP1;
        private System.Windows.Forms.TextBox txtBoxQ1;
        private System.Windows.Forms.TextBox txtBoxR1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxPath;
        private System.Windows.Forms.TextBox txtChildP1;
        private System.Windows.Forms.TextBox txtChildQ1;
        private System.Windows.Forms.TextBox txtChildR1;
        private System.Windows.Forms.Label label5;
    }
}

