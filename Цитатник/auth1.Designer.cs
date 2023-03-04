namespace Цитатник
{
    partial class auth1
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
            this.insert_btn = new System.Windows.Forms.Button();
            this.pswrd_tBox = new System.Windows.Forms.TextBox();
            this.log_tBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // insert_btn
            // 
            this.insert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insert_btn.Location = new System.Drawing.Point(150, 154);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(89, 29);
            this.insert_btn.TabIndex = 11;
            this.insert_btn.Text = "Войти";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // pswrd_tBox
            // 
            this.pswrd_tBox.Location = new System.Drawing.Point(89, 128);
            this.pswrd_tBox.Name = "pswrd_tBox";
            this.pswrd_tBox.PasswordChar = '*';
            this.pswrd_tBox.Size = new System.Drawing.Size(216, 20);
            this.pswrd_tBox.TabIndex = 10;
            // 
            // log_tBox
            // 
            this.log_tBox.Location = new System.Drawing.Point(89, 58);
            this.log_tBox.Name = "log_tBox";
            this.log_tBox.Size = new System.Drawing.Size(216, 20);
            this.log_tBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(163, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(163, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Логин";
            // 
            // auth1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 216);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.pswrd_tBox);
            this.Controls.Add(this.log_tBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "auth1";
            this.Text = "auth1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.TextBox pswrd_tBox;
        private System.Windows.Forms.TextBox log_tBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}