namespace Pattern1_AbstractFactory
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonClient1 = new System.Windows.Forms.Button();
            this.buttonClient2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonMoveC1 = new System.Windows.Forms.Button();
            this.buttonMoveC2 = new System.Windows.Forms.Button();
            this.groupBoxA1 = new System.Windows.Forms.GroupBox();
            this.groupBoxB1 = new System.Windows.Forms.GroupBox();
            this.groupBoxA2 = new System.Windows.Forms.GroupBox();
            this.groupBoxB2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNameA1 = new System.Windows.Forms.TextBox();
            this.numericUpDownMassA1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownVeloA1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAccelerA1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNameB1 = new System.Windows.Forms.TextBox();
            this.numericUpDownMassB1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownVeloB1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpAccelerB1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxNameA2 = new System.Windows.Forms.TextBox();
            this.numericUpDownMassA2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownVeloA2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAccelerA2 = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxNameB2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDownMassB2 = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.numericUpDownVeloB2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAccelerB2 = new System.Windows.Forms.NumericUpDown();
            this.groupBoxA1.SuspendLayout();
            this.groupBoxB1.SuspendLayout();
            this.groupBoxA2.SuspendLayout();
            this.groupBoxB2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMassA1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVeloA1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccelerA1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMassB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVeloB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpAccelerB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMassA2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVeloA2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccelerA2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMassB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVeloB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccelerB2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClient1
            // 
            this.buttonClient1.Location = new System.Drawing.Point(446, 524);
            this.buttonClient1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClient1.Name = "buttonClient1";
            this.buttonClient1.Size = new System.Drawing.Size(270, 28);
            this.buttonClient1.TabIndex = 0;
            this.buttonClient1.Text = "Create Client1";
            this.buttonClient1.UseVisualStyleBackColor = true;
            this.buttonClient1.Click += new System.EventHandler(this.ButtonClient1_Click);
            // 
            // buttonClient2
            // 
            this.buttonClient2.Location = new System.Drawing.Point(446, 560);
            this.buttonClient2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClient2.Name = "buttonClient2";
            this.buttonClient2.Size = new System.Drawing.Size(270, 28);
            this.buttonClient2.TabIndex = 0;
            this.buttonClient2.Text = "Create Client2";
            this.buttonClient2.UseVisualStyleBackColor = true;
            this.buttonClient2.Click += new System.EventHandler(this.ButtonClient2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(16, 15);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(421, 580);
            this.listBox1.TabIndex = 1;
            // 
            // buttonMoveC1
            // 
            this.buttonMoveC1.Enabled = false;
            this.buttonMoveC1.Location = new System.Drawing.Point(905, 524);
            this.buttonMoveC1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMoveC1.Name = "buttonMoveC1";
            this.buttonMoveC1.Size = new System.Drawing.Size(299, 28);
            this.buttonMoveC1.TabIndex = 0;
            this.buttonMoveC1.Text = "Client1:Move";
            this.buttonMoveC1.UseVisualStyleBackColor = true;
            this.buttonMoveC1.Click += new System.EventHandler(this.ButtonMoveC1_Click);
            // 
            // buttonMoveC2
            // 
            this.buttonMoveC2.Enabled = false;
            this.buttonMoveC2.Location = new System.Drawing.Point(905, 560);
            this.buttonMoveC2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMoveC2.Name = "buttonMoveC2";
            this.buttonMoveC2.Size = new System.Drawing.Size(299, 28);
            this.buttonMoveC2.TabIndex = 0;
            this.buttonMoveC2.Text = "Client2:Move";
            this.buttonMoveC2.UseVisualStyleBackColor = true;
            this.buttonMoveC2.Click += new System.EventHandler(this.ButtonMoveC2_Click);
            // 
            // groupBoxA1
            // 
            this.groupBoxA1.Controls.Add(this.numericUpDownAccelerA1);
            this.groupBoxA1.Controls.Add(this.numericUpDownVeloA1);
            this.groupBoxA1.Controls.Add(this.numericUpDownMassA1);
            this.groupBoxA1.Controls.Add(this.textBoxNameA1);
            this.groupBoxA1.Controls.Add(this.label4);
            this.groupBoxA1.Controls.Add(this.label3);
            this.groupBoxA1.Controls.Add(this.label2);
            this.groupBoxA1.Controls.Add(this.label1);
            this.groupBoxA1.Location = new System.Drawing.Point(445, 15);
            this.groupBoxA1.Name = "groupBoxA1";
            this.groupBoxA1.Size = new System.Drawing.Size(344, 241);
            this.groupBoxA1.TabIndex = 2;
            this.groupBoxA1.TabStop = false;
            this.groupBoxA1.Text = "Продукт A1";
            // 
            // groupBoxB1
            // 
            this.groupBoxB1.Controls.Add(this.numericUpAccelerB1);
            this.groupBoxB1.Controls.Add(this.numericUpDownVeloB1);
            this.groupBoxB1.Controls.Add(this.label5);
            this.groupBoxB1.Controls.Add(this.numericUpDownMassB1);
            this.groupBoxB1.Controls.Add(this.label6);
            this.groupBoxB1.Controls.Add(this.textBoxNameB1);
            this.groupBoxB1.Controls.Add(this.label7);
            this.groupBoxB1.Controls.Add(this.label8);
            this.groupBoxB1.Location = new System.Drawing.Point(795, 15);
            this.groupBoxB1.Name = "groupBoxB1";
            this.groupBoxB1.Size = new System.Drawing.Size(410, 241);
            this.groupBoxB1.TabIndex = 2;
            this.groupBoxB1.TabStop = false;
            this.groupBoxB1.Text = "Продукт B1";
            // 
            // groupBoxA2
            // 
            this.groupBoxA2.Controls.Add(this.numericUpDownAccelerA2);
            this.groupBoxA2.Controls.Add(this.numericUpDownVeloA2);
            this.groupBoxA2.Controls.Add(this.label9);
            this.groupBoxA2.Controls.Add(this.numericUpDownMassA2);
            this.groupBoxA2.Controls.Add(this.label10);
            this.groupBoxA2.Controls.Add(this.textBoxNameA2);
            this.groupBoxA2.Controls.Add(this.label11);
            this.groupBoxA2.Controls.Add(this.label12);
            this.groupBoxA2.Location = new System.Drawing.Point(446, 262);
            this.groupBoxA2.Name = "groupBoxA2";
            this.groupBoxA2.Size = new System.Drawing.Size(343, 245);
            this.groupBoxA2.TabIndex = 2;
            this.groupBoxA2.TabStop = false;
            this.groupBoxA2.Text = "Продукт A2";
            // 
            // groupBoxB2
            // 
            this.groupBoxB2.Controls.Add(this.numericUpDownAccelerB2);
            this.groupBoxB2.Controls.Add(this.numericUpDownVeloB2);
            this.groupBoxB2.Controls.Add(this.label13);
            this.groupBoxB2.Controls.Add(this.label16);
            this.groupBoxB2.Controls.Add(this.label14);
            this.groupBoxB2.Controls.Add(this.numericUpDownMassB2);
            this.groupBoxB2.Controls.Add(this.textBoxNameB2);
            this.groupBoxB2.Controls.Add(this.label15);
            this.groupBoxB2.Location = new System.Drawing.Point(795, 262);
            this.groupBoxB2.Name = "groupBoxB2";
            this.groupBoxB2.Size = new System.Drawing.Size(409, 245);
            this.groupBoxB2.TabIndex = 2;
            this.groupBoxB2.TabStop = false;
            this.groupBoxB2.Text = "Продукт B2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Масса";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Скорость";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ускорение";
            // 
            // textBoxNameA1
            // 
            this.textBoxNameA1.Location = new System.Drawing.Point(123, 28);
            this.textBoxNameA1.Name = "textBoxNameA1";
            this.textBoxNameA1.Size = new System.Drawing.Size(191, 22);
            this.textBoxNameA1.TabIndex = 1;
            // 
            // numericUpDownMassA1
            // 
            this.numericUpDownMassA1.Location = new System.Drawing.Point(123, 77);
            this.numericUpDownMassA1.Name = "numericUpDownMassA1";
            this.numericUpDownMassA1.Size = new System.Drawing.Size(191, 22);
            this.numericUpDownMassA1.TabIndex = 2;
            // 
            // numericUpDownVeloA1
            // 
            this.numericUpDownVeloA1.Location = new System.Drawing.Point(123, 111);
            this.numericUpDownVeloA1.Name = "numericUpDownVeloA1";
            this.numericUpDownVeloA1.Size = new System.Drawing.Size(191, 22);
            this.numericUpDownVeloA1.TabIndex = 2;
            // 
            // numericUpDownAccelerA1
            // 
            this.numericUpDownAccelerA1.Location = new System.Drawing.Point(123, 166);
            this.numericUpDownAccelerA1.Name = "numericUpDownAccelerA1";
            this.numericUpDownAccelerA1.Size = new System.Drawing.Size(191, 22);
            this.numericUpDownAccelerA1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Масса";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Скорость";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ускорение";
            // 
            // textBoxNameB1
            // 
            this.textBoxNameB1.Location = new System.Drawing.Point(135, 30);
            this.textBoxNameB1.Name = "textBoxNameB1";
            this.textBoxNameB1.Size = new System.Drawing.Size(259, 22);
            this.textBoxNameB1.TabIndex = 1;
            // 
            // numericUpDownMassB1
            // 
            this.numericUpDownMassB1.Location = new System.Drawing.Point(135, 79);
            this.numericUpDownMassB1.Name = "numericUpDownMassB1";
            this.numericUpDownMassB1.Size = new System.Drawing.Size(259, 22);
            this.numericUpDownMassB1.TabIndex = 2;
            // 
            // numericUpDownVeloB1
            // 
            this.numericUpDownVeloB1.Location = new System.Drawing.Point(135, 113);
            this.numericUpDownVeloB1.Name = "numericUpDownVeloB1";
            this.numericUpDownVeloB1.Size = new System.Drawing.Size(259, 22);
            this.numericUpDownVeloB1.TabIndex = 2;
            // 
            // numericUpAccelerB1
            // 
            this.numericUpAccelerB1.Location = new System.Drawing.Point(135, 168);
            this.numericUpAccelerB1.Name = "numericUpAccelerB1";
            this.numericUpAccelerB1.Size = new System.Drawing.Size(259, 22);
            this.numericUpAccelerB1.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Имя";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Масса";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Скорость";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Ускорение";
            // 
            // textBoxNameA2
            // 
            this.textBoxNameA2.Location = new System.Drawing.Point(122, 33);
            this.textBoxNameA2.Name = "textBoxNameA2";
            this.textBoxNameA2.Size = new System.Drawing.Size(191, 22);
            this.textBoxNameA2.TabIndex = 1;
            // 
            // numericUpDownMassA2
            // 
            this.numericUpDownMassA2.Location = new System.Drawing.Point(122, 82);
            this.numericUpDownMassA2.Name = "numericUpDownMassA2";
            this.numericUpDownMassA2.Size = new System.Drawing.Size(191, 22);
            this.numericUpDownMassA2.TabIndex = 2;
            // 
            // numericUpDownVeloA2
            // 
            this.numericUpDownVeloA2.Location = new System.Drawing.Point(122, 116);
            this.numericUpDownVeloA2.Name = "numericUpDownVeloA2";
            this.numericUpDownVeloA2.Size = new System.Drawing.Size(191, 22);
            this.numericUpDownVeloA2.TabIndex = 2;
            // 
            // numericUpDownAccelerA2
            // 
            this.numericUpDownAccelerA2.Location = new System.Drawing.Point(122, 171);
            this.numericUpDownAccelerA2.Name = "numericUpDownAccelerA2";
            this.numericUpDownAccelerA2.Size = new System.Drawing.Size(191, 22);
            this.numericUpDownAccelerA2.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Ускорение";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 121);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Скорость";
            // 
            // textBoxNameB2
            // 
            this.textBoxNameB2.Location = new System.Drawing.Point(135, 33);
            this.textBoxNameB2.Name = "textBoxNameB2";
            this.textBoxNameB2.Size = new System.Drawing.Size(259, 22);
            this.textBoxNameB2.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Масса";
            // 
            // numericUpDownMassB2
            // 
            this.numericUpDownMassB2.Location = new System.Drawing.Point(135, 82);
            this.numericUpDownMassB2.Name = "numericUpDownMassB2";
            this.numericUpDownMassB2.Size = new System.Drawing.Size(259, 22);
            this.numericUpDownMassB2.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "Имя";
            // 
            // numericUpDownVeloB2
            // 
            this.numericUpDownVeloB2.Location = new System.Drawing.Point(135, 116);
            this.numericUpDownVeloB2.Name = "numericUpDownVeloB2";
            this.numericUpDownVeloB2.Size = new System.Drawing.Size(259, 22);
            this.numericUpDownVeloB2.TabIndex = 2;
            // 
            // numericUpDownAccelerB2
            // 
            this.numericUpDownAccelerB2.Location = new System.Drawing.Point(135, 171);
            this.numericUpDownAccelerB2.Name = "numericUpDownAccelerB2";
            this.numericUpDownAccelerB2.Size = new System.Drawing.Size(259, 22);
            this.numericUpDownAccelerB2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 601);
            this.Controls.Add(this.groupBoxB2);
            this.Controls.Add(this.groupBoxB1);
            this.Controls.Add(this.groupBoxA2);
            this.Controls.Add(this.groupBoxA1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonMoveC2);
            this.Controls.Add(this.buttonMoveC1);
            this.Controls.Add(this.buttonClient2);
            this.Controls.Add(this.buttonClient1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxA1.ResumeLayout(false);
            this.groupBoxA1.PerformLayout();
            this.groupBoxB1.ResumeLayout(false);
            this.groupBoxB1.PerformLayout();
            this.groupBoxA2.ResumeLayout(false);
            this.groupBoxA2.PerformLayout();
            this.groupBoxB2.ResumeLayout(false);
            this.groupBoxB2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMassA1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVeloA1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccelerA1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMassB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVeloB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpAccelerB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMassA2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVeloA2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccelerA2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMassB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVeloB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccelerB2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClient1;
        private System.Windows.Forms.Button buttonClient2;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonMoveC1;
        private System.Windows.Forms.Button buttonMoveC2;
        private System.Windows.Forms.GroupBox groupBoxA1;
        private System.Windows.Forms.NumericUpDown numericUpDownAccelerA1;
        private System.Windows.Forms.NumericUpDown numericUpDownVeloA1;
        private System.Windows.Forms.NumericUpDown numericUpDownMassA1;
        private System.Windows.Forms.TextBox textBoxNameA1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxB1;
        private System.Windows.Forms.GroupBox groupBoxA2;
        private System.Windows.Forms.GroupBox groupBoxB2;
        private System.Windows.Forms.NumericUpDown numericUpAccelerB1;
        private System.Windows.Forms.NumericUpDown numericUpDownVeloB1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownMassB1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNameB1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownAccelerA2;
        private System.Windows.Forms.NumericUpDown numericUpDownVeloA2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownMassA2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxNameA2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDownAccelerB2;
        private System.Windows.Forms.NumericUpDown numericUpDownVeloB2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDownMassB2;
        private System.Windows.Forms.TextBox textBoxNameB2;
        private System.Windows.Forms.Label label15;
    }
}

