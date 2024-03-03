namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.comBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.butOk = new System.Windows.Forms.Button();
            this.butCl = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResult1 = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtResult2a = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtResult2b = new System.Windows.Forms.TextBox();
            this.txtResult1a = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtResult1b = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.txtV = new System.Windows.Forms.TextBox();
            this.butCon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(23, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Уведіть перше число:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(164, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Уведіть друге число:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(26, 86);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(113, 20);
            this.txtA.TabIndex = 2;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(167, 86);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(109, 20);
            this.txtB.TabIndex = 3;
            // 
            // comBox
            // 
            this.comBox.FormattingEnabled = true;
            this.comBox.Location = new System.Drawing.Point(27, 315);
            this.comBox.Name = "comBox";
            this.comBox.Size = new System.Drawing.Size(121, 21);
            this.comBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(45, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Виберіть операцію:";
            // 
            // butOk
            // 
            this.butOk.Location = new System.Drawing.Point(26, 372);
            this.butOk.Name = "butOk";
            this.butOk.Size = new System.Drawing.Size(121, 31);
            this.butOk.TabIndex = 6;
            this.butOk.Text = "OK";
            this.butOk.UseVisualStyleBackColor = true;
            this.butOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // butCl
            // 
            this.butCl.Location = new System.Drawing.Point(172, 372);
            this.butCl.Name = "butCl";
            this.butCl.Size = new System.Drawing.Size(121, 31);
            this.butCl.TabIndex = 7;
            this.butCl.Text = "Clean";
            this.butCl.UseVisualStyleBackColor = true;
            this.butCl.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(28, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Результат:";
            // 
            // txtResult1
            // 
            this.txtResult1.Location = new System.Drawing.Point(31, 436);
            this.txtResult1.Name = "txtResult1";
            this.txtResult1.Size = new System.Drawing.Size(249, 20);
            this.txtResult1.TabIndex = 9;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(166, 131);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(109, 20);
            this.txtD.TabIndex = 13;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(26, 131);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(113, 20);
            this.txtC.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(153, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(11, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "A";
            // 
            // txtResult2a
            // 
            this.txtResult2a.Location = new System.Drawing.Point(167, 196);
            this.txtResult2a.Name = "txtResult2a";
            this.txtResult2a.Size = new System.Drawing.Size(113, 20);
            this.txtResult2a.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(164, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Результат в степені:";
            // 
            // txtResult2b
            // 
            this.txtResult2b.Location = new System.Drawing.Point(167, 215);
            this.txtResult2b.Name = "txtResult2b";
            this.txtResult2b.Size = new System.Drawing.Size(113, 20);
            this.txtResult2b.TabIndex = 16;
            // 
            // txtResult1a
            // 
            this.txtResult1a.Location = new System.Drawing.Point(26, 196);
            this.txtResult1a.Name = "txtResult1a";
            this.txtResult1a.Size = new System.Drawing.Size(113, 20);
            this.txtResult1a.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(23, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Результат в степені:";
            // 
            // txtResult1b
            // 
            this.txtResult1b.Location = new System.Drawing.Point(26, 215);
            this.txtResult1b.Name = "txtResult1b";
            this.txtResult1b.Size = new System.Drawing.Size(113, 20);
            this.txtResult1b.TabIndex = 20;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.checkBox1.Location = new System.Drawing.Point(26, 252);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(154, 17);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Використовувати степінь";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(28, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Ступінь числа А:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(164, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Ступінь числа В:";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.checkBox2.Location = new System.Drawing.Point(448, 294);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(178, 30);
            this.checkBox2.TabIndex = 24;
            this.checkBox2.Text = " з P-ічної системи числення в \r\nдесяткову систему числення";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.checkBox3.Location = new System.Drawing.Point(448, 330);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(192, 30);
            this.checkBox3.TabIndex = 25;
            this.checkBox3.Text = "з Десятковій системи числення \r\nв P-ічну систему числення ";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // txtV
            // 
            this.txtV.Location = new System.Drawing.Point(321, 311);
            this.txtV.Name = "txtV";
            this.txtV.Size = new System.Drawing.Size(100, 20);
            this.txtV.TabIndex = 26;
            // 
            // butCon
            // 
            this.butCon.Location = new System.Drawing.Point(321, 372);
            this.butCon.Name = "butCon";
            this.butCon.Size = new System.Drawing.Size(100, 31);
            this.butCon.TabIndex = 27;
            this.butCon.Text = "Перетворити";
            this.butCon.UseVisualStyleBackColor = true;
            this.butCon.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(644, 557);
            this.Controls.Add(this.butCon);
            this.Controls.Add(this.txtV);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtResult1b);
            this.Controls.Add(this.txtResult1a);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtResult2b);
            this.Controls.Add(this.txtResult2a);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtResult1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butCl);
            this.Controls.Add(this.butOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comBox);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Вариант 20";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.ComboBox comBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butOk;
        private System.Windows.Forms.Button butCl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResult1;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtResult2a;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtResult2b;
        private System.Windows.Forms.TextBox txtResult1a;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtResult1b;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox txtV;
        private System.Windows.Forms.Button butCon;
    }
}

