namespace Pattern3_Factory_Method
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
            this.comboBoxExtension = new System.Windows.Forms.ComboBox();
            this.textBoxFileText = new System.Windows.Forms.TextBox();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.buttonCreateFile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxExtension
            // 
            this.comboBoxExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExtension.FormattingEnabled = true;
            this.comboBoxExtension.Items.AddRange(new object[] {
            ".txt",
            ".rtf"});
            this.comboBoxExtension.Location = new System.Drawing.Point(289, 14);
            this.comboBoxExtension.Name = "comboBoxExtension";
            this.comboBoxExtension.Size = new System.Drawing.Size(121, 24);
            this.comboBoxExtension.TabIndex = 0;
            // 
            // textBoxFileText
            // 
            this.textBoxFileText.Location = new System.Drawing.Point(12, 42);
            this.textBoxFileText.Multiline = true;
            this.textBoxFileText.Name = "textBoxFileText";
            this.textBoxFileText.Size = new System.Drawing.Size(627, 415);
            this.textBoxFileText.TabIndex = 1;
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(12, 14);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(271, 22);
            this.textBoxFileName.TabIndex = 2;
            // 
            // buttonCreateFile
            // 
            this.buttonCreateFile.Location = new System.Drawing.Point(416, 13);
            this.buttonCreateFile.Name = "buttonCreateFile";
            this.buttonCreateFile.Size = new System.Drawing.Size(117, 23);
            this.buttonCreateFile.TabIndex = 3;
            this.buttonCreateFile.Text = "Создать";
            this.buttonCreateFile.UseVisualStyleBackColor = true;
            this.buttonCreateFile.Click += new System.EventHandler(this.ButtonCreateFile_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Открыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCreateFile);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.textBoxFileText);
            this.Controls.Add(this.comboBoxExtension);
            this.Name = "Form1";
            this.Text = "Лабораторная работа 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxExtension;
        private System.Windows.Forms.TextBox textBoxFileText;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonCreateFile;
        private System.Windows.Forms.Button button1;
    }
}

