namespace RegexBuddy
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
            this.tb_InputRegularExpression = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.tb_InputText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_InputRegularExpression
            // 
            this.tb_InputRegularExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_InputRegularExpression.Location = new System.Drawing.Point(12, 23);
            this.tb_InputRegularExpression.Multiline = true;
            this.tb_InputRegularExpression.Name = "tb_InputRegularExpression";
            this.tb_InputRegularExpression.Size = new System.Drawing.Size(470, 40);
            this.tb_InputRegularExpression.TabIndex = 2;
            this.tb_InputRegularExpression.TextChanged += new System.EventHandler(this.tb_InputRegularExpression_TextChanged);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(407, 331);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // tb_InputText
            // 
            this.tb_InputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_InputText.Location = new System.Drawing.Point(12, 89);
            this.tb_InputText.Name = "tb_InputText";
            this.tb_InputText.Size = new System.Drawing.Size(470, 236);
            this.tb_InputText.TabIndex = 5;
            this.tb_InputText.Text = "";
            this.tb_InputText.TextChanged += new System.EventHandler(this.tb_InputText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Input rerular expression:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Input text:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_InputText);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.tb_InputRegularExpression);
            this.Name = "Form1";
            this.Text = "Regular epressions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_InputRegularExpression;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.RichTextBox tb_InputText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

