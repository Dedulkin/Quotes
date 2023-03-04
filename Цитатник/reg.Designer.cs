namespace Цитатник
{
    partial class reg
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.user_tB = new System.Windows.Forms.TextBox();
            this.log_tB = new System.Windows.Forms.TextBox();
            this.pswrd_tB = new System.Windows.Forms.TextBox();
            this.reg_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Как вас называть?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // user_tB
            // 
            this.user_tB.Location = new System.Drawing.Point(170, 20);
            this.user_tB.Name = "user_tB";
            this.user_tB.Size = new System.Drawing.Size(212, 20);
            this.user_tB.TabIndex = 3;
            // 
            // log_tB
            // 
            this.log_tB.Location = new System.Drawing.Point(85, 62);
            this.log_tB.Name = "log_tB";
            this.log_tB.Size = new System.Drawing.Size(297, 20);
            this.log_tB.TabIndex = 4;
            // 
            // pswrd_tB
            // 
            this.pswrd_tB.Location = new System.Drawing.Point(85, 103);
            this.pswrd_tB.Name = "pswrd_tB";
            this.pswrd_tB.Size = new System.Drawing.Size(297, 20);
            this.pswrd_tB.TabIndex = 5;
            // 
            // reg_btn
            // 
            this.reg_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reg_btn.Location = new System.Drawing.Point(105, 156);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(174, 23);
            this.reg_btn.TabIndex = 6;
            this.reg_btn.Text = "Зарегистрироваться";
            this.reg_btn.UseVisualStyleBackColor = true;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 216);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.pswrd_tB);
            this.Controls.Add(this.log_tB);
            this.Controls.Add(this.user_tB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "reg";
            this.Text = "reg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user_tB;
        private System.Windows.Forms.TextBox log_tB;
        private System.Windows.Forms.TextBox pswrd_tB;
        private System.Windows.Forms.Button reg_btn;
    }
}