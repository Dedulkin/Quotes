namespace Цитатник
{
    partial class addquo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addquo));
            this.name_lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.auth_cB = new System.Windows.Forms.ComboBox();
            this.auth_tB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Location = new System.Drawing.Point(-2, 0);
            this.name_lb.Name = "name_lb";
            this.name_lb.Size = new System.Drawing.Size(35, 13);
            this.name_lb.TabIndex = 0;
            this.name_lb.Text = "label1";
            this.name_lb.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Текст цитаты:";
            // 
            // txt_tB
            // 
            this.txt_tB.Location = new System.Drawing.Point(16, 36);
            this.txt_tB.Multiline = true;
            this.txt_tB.Name = "txt_tB";
            this.txt_tB.Size = new System.Drawing.Size(344, 176);
            this.txt_tB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(382, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Автор цитаты:";
            // 
            // auth_cB
            // 
            this.auth_cB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.auth_cB.FormattingEnabled = true;
            this.auth_cB.Location = new System.Drawing.Point(386, 37);
            this.auth_cB.Name = "auth_cB";
            this.auth_cB.Size = new System.Drawing.Size(182, 21);
            this.auth_cB.TabIndex = 4;
            this.auth_cB.SelectedIndexChanged += new System.EventHandler(this.auth_cB_SelectedIndexChanged);
            // 
            // auth_tB
            // 
            this.auth_tB.Location = new System.Drawing.Point(386, 95);
            this.auth_tB.Name = "auth_tB";
            this.auth_tB.Size = new System.Drawing.Size(229, 20);
            this.auth_tB.TabIndex = 5;
            this.auth_tB.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(386, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "А именно:";
            this.label3.Visible = false;
            // 
            // add_btn
            // 
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_btn.Location = new System.Drawing.Point(389, 180);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(155, 23);
            this.add_btn.TabIndex = 7;
            this.add_btn.Text = "Добавить цитату";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Visible = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // addquo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 230);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.auth_tB);
            this.Controls.Add(this.auth_cB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_lb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addquo";
            this.Text = "Ща такое забахаем";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox auth_cB;
        private System.Windows.Forms.TextBox auth_tB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button add_btn;
    }
}