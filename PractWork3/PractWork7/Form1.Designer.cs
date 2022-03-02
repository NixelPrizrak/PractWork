namespace PractWork6
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
            this.sourceButton = new System.Windows.Forms.Button();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.codeButton = new System.Windows.Forms.Button();
            this.encodeButton = new System.Windows.Forms.Button();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.codeFolderButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.encodeTextBox = new System.Windows.Forms.TextBox();
            this.encodeFolderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sourceButton
            // 
            this.sourceButton.Location = new System.Drawing.Point(393, 24);
            this.sourceButton.Name = "sourceButton";
            this.sourceButton.Size = new System.Drawing.Size(27, 23);
            this.sourceButton.TabIndex = 0;
            this.sourceButton.Text = "...";
            this.sourceButton.UseVisualStyleBackColor = true;
            this.sourceButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Location = new System.Drawing.Point(158, 26);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.ReadOnly = true;
            this.sourceTextBox.Size = new System.Drawing.Size(229, 20);
            this.sourceTextBox.TabIndex = 1;
            // 
            // codeButton
            // 
            this.codeButton.Location = new System.Drawing.Point(99, 118);
            this.codeButton.Name = "codeButton";
            this.codeButton.Size = new System.Drawing.Size(229, 23);
            this.codeButton.TabIndex = 2;
            this.codeButton.Text = "Зашифровать";
            this.codeButton.UseVisualStyleBackColor = true;
            this.codeButton.Click += new System.EventHandler(this.codeButton_Click);
            // 
            // encodeButton
            // 
            this.encodeButton.Location = new System.Drawing.Point(99, 147);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Size = new System.Drawing.Size(229, 23);
            this.encodeButton.TabIndex = 3;
            this.encodeButton.Text = "Дешифровать";
            this.encodeButton.UseVisualStyleBackColor = true;
            this.encodeButton.Click += new System.EventHandler(this.encodeButton_Click);
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(158, 52);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ReadOnly = true;
            this.codeTextBox.Size = new System.Drawing.Size(229, 20);
            this.codeTextBox.TabIndex = 5;
            // 
            // codeFolderButton
            // 
            this.codeFolderButton.Location = new System.Drawing.Point(393, 50);
            this.codeFolderButton.Name = "codeFolderButton";
            this.codeFolderButton.Size = new System.Drawing.Size(27, 23);
            this.codeFolderButton.TabIndex = 4;
            this.codeFolderButton.Text = "...";
            this.codeFolderButton.UseVisualStyleBackColor = true;
            this.codeFolderButton.Click += new System.EventHandler(this.targetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Папка с файлами:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Папка зашифровывания:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Папка дешифровывания:";
            // 
            // encodeTextBox
            // 
            this.encodeTextBox.Location = new System.Drawing.Point(158, 79);
            this.encodeTextBox.Name = "encodeTextBox";
            this.encodeTextBox.ReadOnly = true;
            this.encodeTextBox.Size = new System.Drawing.Size(229, 20);
            this.encodeTextBox.TabIndex = 9;
            // 
            // encodeFolderButton
            // 
            this.encodeFolderButton.Location = new System.Drawing.Point(393, 77);
            this.encodeFolderButton.Name = "encodeFolderButton";
            this.encodeFolderButton.Size = new System.Drawing.Size(27, 23);
            this.encodeFolderButton.TabIndex = 8;
            this.encodeFolderButton.Text = "...";
            this.encodeFolderButton.UseVisualStyleBackColor = true;
            this.encodeFolderButton.Click += new System.EventHandler(this.encodeFolderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 191);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.encodeTextBox);
            this.Controls.Add(this.encodeFolderButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.codeFolderButton);
            this.Controls.Add(this.encodeButton);
            this.Controls.Add(this.codeButton);
            this.Controls.Add(this.sourceTextBox);
            this.Controls.Add(this.sourceButton);
            this.Name = "Form1";
            this.Text = "фрование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sourceButton;
        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.Button codeButton;
        private System.Windows.Forms.Button encodeButton;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Button codeFolderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox encodeTextBox;
        private System.Windows.Forms.Button encodeFolderButton;
    }
}

