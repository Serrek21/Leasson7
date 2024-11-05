namespace Leasson7
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
            this.EB = new System.Windows.Forms.Button();
            this.rbEscape = new System.Windows.Forms.RadioButton();
            this.rbFollow = new System.Windows.Forms.RadioButton();
            this.rbDrag = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // EB
            // 
            this.EB.Location = new System.Drawing.Point(289, 153);
            this.EB.Name = "EB";
            this.EB.Size = new System.Drawing.Size(75, 34);
            this.EB.TabIndex = 0;
            this.EB.Text = "Catch me!";
            this.EB.UseVisualStyleBackColor = true;
            this.EB.Click += new System.EventHandler(this.escapeButton_Click);
            // 
            // rbEscape
            // 
            this.rbEscape.AutoSize = true;
            this.rbEscape.Location = new System.Drawing.Point(58, 46);
            this.rbEscape.Name = "rbEscape";
            this.rbEscape.Size = new System.Drawing.Size(61, 17);
            this.rbEscape.TabIndex = 1;
            this.rbEscape.TabStop = true;
            this.rbEscape.Text = "Escape";
            this.rbEscape.UseVisualStyleBackColor = true;
            this.rbEscape.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbFollow
            // 
            this.rbFollow.AutoSize = true;
            this.rbFollow.Location = new System.Drawing.Point(166, 46);
            this.rbFollow.Name = "rbFollow";
            this.rbFollow.Size = new System.Drawing.Size(55, 17);
            this.rbFollow.TabIndex = 2;
            this.rbFollow.TabStop = true;
            this.rbFollow.Text = "Follow";
            this.rbFollow.UseVisualStyleBackColor = true;
            // 
            // rbDrag
            // 
            this.rbDrag.AutoSize = true;
            this.rbDrag.Location = new System.Drawing.Point(260, 46);
            this.rbDrag.Name = "rbDrag";
            this.rbDrag.Size = new System.Drawing.Size(48, 17);
            this.rbDrag.TabIndex = 3;
            this.rbDrag.TabStop = true;
            this.rbDrag.Text = "Drag";
            this.rbDrag.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbDrag);
            this.Controls.Add(this.rbFollow);
            this.Controls.Add(this.rbEscape);
            this.Controls.Add(this.EB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EB;
        private System.Windows.Forms.RadioButton rbEscape;
        private System.Windows.Forms.RadioButton rbFollow;
        private System.Windows.Forms.RadioButton rbDrag;
    }
}

