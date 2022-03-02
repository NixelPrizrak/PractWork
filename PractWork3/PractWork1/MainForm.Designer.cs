namespace WindowsFormsApplication1
{
    partial class MainForm
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
            this.newStringLabel = new System.Windows.Forms.Label();
            this.wordTextBox = new System.Windows.Forms.TextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newStringLabel
            // 
            this.newStringLabel.AutoSize = true;
            this.newStringLabel.Location = new System.Drawing.Point(12, 75);
            this.newStringLabel.Name = "newStringLabel";
            this.newStringLabel.Size = new System.Drawing.Size(59, 13);
            this.newStringLabel.TabIndex = 5;
            this.newStringLabel.Text = "Результат";
            // 
            // wordTextBox
            // 
            this.wordTextBox.Location = new System.Drawing.Point(12, 12);
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(260, 20);
            this.wordTextBox.TabIndex = 4;
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(12, 38);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(260, 23);
            this.encryptButton.TabIndex = 3;
            this.encryptButton.Text = "Зашифровать";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.codedButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 102);
            this.Controls.Add(this.newStringLabel);
            this.Controls.Add(this.wordTextBox);
            this.Controls.Add(this.encryptButton);
            this.Name = "Form1";
            this.Text = "Шифрование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label newStringLabel;
        internal System.Windows.Forms.TextBox wordTextBox;
        internal System.Windows.Forms.Button encryptButton;
    }
}

