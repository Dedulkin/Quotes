namespace Цитатник
{
    partial class tables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tables));
            this.quo_DGV = new System.Windows.Forms.DataGridView();
            this.name_lb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.search_tB = new System.Windows.Forms.TextBox();
            this.updt_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quo_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // quo_DGV
            // 
            this.quo_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.quo_DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.quo_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quo_DGV.Location = new System.Drawing.Point(12, 61);
            this.quo_DGV.Name = "quo_DGV";
            this.quo_DGV.Size = new System.Drawing.Size(766, 357);
            this.quo_DGV.TabIndex = 0;
            this.quo_DGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.quo_DGV_CellValueChanged);
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Location = new System.Drawing.Point(0, 0);
            this.name_lb.Name = "name_lb";
            this.name_lb.Size = new System.Drawing.Size(35, 13);
            this.name_lb.TabIndex = 1;
            this.name_lb.Text = "label1";
            this.name_lb.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Поиск*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "*Пока только по автору";
            // 
            // search_tB
            // 
            this.search_tB.Location = new System.Drawing.Point(83, 29);
            this.search_tB.Name = "search_tB";
            this.search_tB.Size = new System.Drawing.Size(250, 20);
            this.search_tB.TabIndex = 4;
            this.search_tB.TextChanged += new System.EventHandler(this.search_tB_TextChanged);
            // 
            // updt_btn
            // 
            this.updt_btn.Location = new System.Drawing.Point(420, 27);
            this.updt_btn.Name = "updt_btn";
            this.updt_btn.Size = new System.Drawing.Size(123, 23);
            this.updt_btn.TabIndex = 5;
            this.updt_btn.Text = "Обновить табличку";
            this.updt_btn.UseVisualStyleBackColor = true;
            this.updt_btn.Click += new System.EventHandler(this.updt_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(339, 27);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 6;
            this.search_btn.Text = "Найти";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(549, 27);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(128, 23);
            this.add_btn.TabIndex = 7;
            this.add_btn.Text = "Хочу новые добавить";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(692, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.updt_btn);
            this.Controls.Add(this.search_tB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_lb);
            this.Controls.Add(this.quo_DGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вообще все цитаточки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.tables_FormClosing);
            this.Load += new System.EventHandler(this.tables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quo_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView quo_DGV;
        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search_tB;
        private System.Windows.Forms.Button updt_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button button1;
    }
}