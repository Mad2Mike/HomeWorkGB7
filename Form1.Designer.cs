namespace LessonGB7
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
            this.btnUdvoitel = new System.Windows.Forms.Button();
            this.btnUgadayCh = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUdvoitel
            // 
            this.btnUdvoitel.AutoSize = true;
            this.btnUdvoitel.Location = new System.Drawing.Point(193, 41);
            this.btnUdvoitel.Name = "btnUdvoitel";
            this.btnUdvoitel.Size = new System.Drawing.Size(75, 27);
            this.btnUdvoitel.TabIndex = 0;
            this.btnUdvoitel.Text = "button1";
            this.btnUdvoitel.UseVisualStyleBackColor = true;
            this.btnUdvoitel.Click += new System.EventHandler(this.btnUdvoitel_Click);
            // 
            // btnUgadayCh
            // 
            this.btnUgadayCh.AutoSize = true;
            this.btnUgadayCh.Location = new System.Drawing.Point(193, 98);
            this.btnUgadayCh.Name = "btnUgadayCh";
            this.btnUgadayCh.Size = new System.Drawing.Size(75, 27);
            this.btnUgadayCh.TabIndex = 1;
            this.btnUgadayCh.Text = "button2";
            this.btnUgadayCh.UseVisualStyleBackColor = true;
            this.btnUgadayCh.Click += new System.EventHandler(this.btnUgadayCh_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(193, 190);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "button1";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 266);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUgadayCh);
            this.Controls.Add(this.btnUdvoitel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUdvoitel;
        private System.Windows.Forms.Button btnUgadayCh;
        private System.Windows.Forms.Button btnExit;
    }
}

