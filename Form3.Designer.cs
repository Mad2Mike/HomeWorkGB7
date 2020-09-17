namespace LessonGB7
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumEnt = new System.Windows.Forms.TextBox();
            this.lblNumEnt = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumEnt
            // 
            this.txtNumEnt.Location = new System.Drawing.Point(173, 134);
            this.txtNumEnt.Name = "txtNumEnt";
            this.txtNumEnt.Size = new System.Drawing.Size(107, 22);
            this.txtNumEnt.TabIndex = 0;
            this.txtNumEnt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNumEnt
            // 
            this.lblNumEnt.AutoSize = true;
            this.lblNumEnt.Location = new System.Drawing.Point(220, 105);
            this.lblNumEnt.Name = "lblNumEnt";
            this.lblNumEnt.Size = new System.Drawing.Size(110, 17);
            this.lblNumEnt.TabIndex = 1;
            this.lblNumEnt.Text = "Введите число:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(180, 38);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(191, 17);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "Угадайте число от 1 до 100";
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Location = new System.Drawing.Point(233, 180);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(76, 17);
            this.lblHelp.TabIndex = 3;
            this.lblHelp.Text = "Результат";
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Пробуем!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(223, 243);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 37);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Меню";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 328);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblNumEnt);
            this.Controls.Add(this.txtNumEnt);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumEnt;
        private System.Windows.Forms.Label lblNumEnt;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExit;
    }
}