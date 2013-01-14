namespace ALvector
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
            this.rb_Cross = new System.Windows.Forms.RadioButton();
            this.rb_Line = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rb_Cross
            // 
            this.rb_Cross.AutoSize = true;
            this.rb_Cross.Location = new System.Drawing.Point(13, 326);
            this.rb_Cross.Name = "rb_Cross";
            this.rb_Cross.Size = new System.Drawing.Size(51, 17);
            this.rb_Cross.TabIndex = 0;
            this.rb_Cross.TabStop = true;
            this.rb_Cross.Text = "Cross";
            this.rb_Cross.UseVisualStyleBackColor = true;
            this.rb_Cross.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb_Line
            // 
            this.rb_Line.AutoSize = true;
            this.rb_Line.Location = new System.Drawing.Point(13, 303);
            this.rb_Line.Name = "rb_Line";
            this.rb_Line.Size = new System.Drawing.Size(45, 17);
            this.rb_Line.TabIndex = 1;
            this.rb_Line.TabStop = true;
            this.rb_Line.Text = "Line";
            this.rb_Line.UseVisualStyleBackColor = true;
            this.rb_Line.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 355);
            this.Controls.Add(this.rb_Line);
            this.Controls.Add(this.rb_Cross);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_Cross;
        private System.Windows.Forms.RadioButton rb_Line;
    }
}

