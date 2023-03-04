namespace Цитатник
{
    partial class quotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quotes));
            this.quo_lb = new System.Windows.Forms.Label();
            this.num_lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.authr_lb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chng_btn = new System.Windows.Forms.Button();
            this.table_btn = new System.Windows.Forms.Button();
            this.greet_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // quo_lb
            // 
            this.quo_lb.AutoSize = true;
            this.quo_lb.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quo_lb.Location = new System.Drawing.Point(91, 84);
            this.quo_lb.MaximumSize = new System.Drawing.Size(500, 0);
            this.quo_lb.Name = "quo_lb";
            this.quo_lb.Size = new System.Drawing.Size(493, 50);
            this.quo_lb.TabIndex = 0;
            this.quo_lb.Text = "тексткккккккккккккккккккккккккккккккккккккккккккккккккккккккккккккккккккккккккккк" +
    "кккк";
            // 
            // num_lb
            // 
            this.num_lb.AutoSize = true;
            this.num_lb.Location = new System.Drawing.Point(13, 13);
            this.num_lb.Name = "num_lb";
            this.num_lb.Size = new System.Drawing.Size(0, 13);
            this.num_lb.TabIndex = 1;
            this.num_lb.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(613, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Автор:";
            // 
            // authr_lb
            // 
            this.authr_lb.AutoSize = true;
            this.authr_lb.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.authr_lb.Location = new System.Drawing.Point(613, 112);
            this.authr_lb.Name = "authr_lb";
            this.authr_lb.Size = new System.Drawing.Size(0, 25);
            this.authr_lb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ваша сегодняшняя цитата это:";
            // 
            // chng_btn
            // 
            this.chng_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chng_btn.Location = new System.Drawing.Point(618, 170);
            this.chng_btn.Name = "chng_btn";
            this.chng_btn.Size = new System.Drawing.Size(150, 51);
            this.chng_btn.TabIndex = 5;
            this.chng_btn.Text = "Мне не нравится! Хочу другую цитату!";
            this.chng_btn.UseVisualStyleBackColor = true;
            this.chng_btn.Click += new System.EventHandler(this.chng_btn_Click);
            // 
            // table_btn
            // 
            this.table_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.table_btn.Location = new System.Drawing.Point(618, 237);
            this.table_btn.Name = "table_btn";
            this.table_btn.Size = new System.Drawing.Size(150, 51);
            this.table_btn.TabIndex = 6;
            this.table_btn.Text = "Покажи мне всё что у тебя есть...";
            this.table_btn.UseVisualStyleBackColor = true;
            this.table_btn.Click += new System.EventHandler(this.table_btn_Click);
            // 
            // greet_lb
            // 
            this.greet_lb.AutoSize = true;
            this.greet_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greet_lb.Location = new System.Drawing.Point(21, 13);
            this.greet_lb.Name = "greet_lb";
            this.greet_lb.Size = new System.Drawing.Size(0, 24);
            this.greet_lb.TabIndex = 7;
            // 
            // quotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 352);
            this.Controls.Add(this.greet_lb);
            this.Controls.Add(this.table_btn);
            this.Controls.Add(this.chng_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.authr_lb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_lb);
            this.Controls.Add(this.quo_lb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "quotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Цитаточки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.quotes_FormClosing);
            this.Load += new System.EventHandler(this.quotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label quo_lb;
        private System.Windows.Forms.Label num_lb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label authr_lb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button chng_btn;
        private System.Windows.Forms.Button table_btn;
        private System.Windows.Forms.Label greet_lb;
    }
}