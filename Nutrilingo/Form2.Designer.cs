namespace Nutrilingo
{
    partial class Form2
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
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.carb_Int = new System.Windows.Forms.TextBox();
            this.fat_Int = new System.Windows.Forms.TextBox();
            this.protein_Int = new System.Windows.Forms.TextBox();
            this.alcohol_Int = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.date_Int = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.weeklyStatsBtn = new System.Windows.Forms.Button();
            this.monthlyStatsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carbohydrates (4cal/g)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fats (9cal/g)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Protein (4cal/g)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alcohol (7cal/g)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 325);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit Entry";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // carb_Int
            // 
            this.carb_Int.Location = new System.Drawing.Point(251, 110);
            this.carb_Int.Name = "carb_Int";
            this.carb_Int.Size = new System.Drawing.Size(114, 22);
            this.carb_Int.TabIndex = 5;
            // 
            // fat_Int
            // 
            this.fat_Int.Location = new System.Drawing.Point(251, 165);
            this.fat_Int.Name = "fat_Int";
            this.fat_Int.Size = new System.Drawing.Size(114, 22);
            this.fat_Int.TabIndex = 6;
            // 
            // protein_Int
            // 
            this.protein_Int.Location = new System.Drawing.Point(251, 220);
            this.protein_Int.Name = "protein_Int";
            this.protein_Int.Size = new System.Drawing.Size(114, 22);
            this.protein_Int.TabIndex = 7;
            // 
            // alcohol_Int
            // 
            this.alcohol_Int.Location = new System.Drawing.Point(251, 275);
            this.alcohol_Int.Name = "alcohol_Int";
            this.alcohol_Int.Size = new System.Drawing.Size(114, 22);
            this.alcohol_Int.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 268);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date (mmddyyyy)";
            // 
            // date_Int
            // 
            this.date_Int.Location = new System.Drawing.Point(251, 330);
            this.date_Int.Name = "date_Int";
            this.date_Int.Size = new System.Drawing.Size(114, 22);
            this.date_Int.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Macronutrient Data Entry Form";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(101, 414);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 24);
            this.button3.TabIndex = 13;
            this.button3.Text = "Back to Login";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // weeklyStatsBtn
            // 
            this.weeklyStatsBtn.Location = new System.Drawing.Point(11, 368);
            this.weeklyStatsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.weeklyStatsBtn.Name = "weeklyStatsBtn";
            this.weeklyStatsBtn.Size = new System.Drawing.Size(98, 24);
            this.weeklyStatsBtn.TabIndex = 14;
            this.weeklyStatsBtn.Text = "See Weekly Stats";
            this.weeklyStatsBtn.UseVisualStyleBackColor = true;
            this.weeklyStatsBtn.Click += new System.EventHandler(this.weeklyStatsBtn_Click);
            // 
            // monthlyStatsBtn
            // 
            this.monthlyStatsBtn.Location = new System.Drawing.Point(177, 368);
            this.monthlyStatsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.monthlyStatsBtn.Name = "monthlyStatsBtn";
            this.monthlyStatsBtn.Size = new System.Drawing.Size(98, 24);
            this.monthlyStatsBtn.TabIndex = 15;
            this.monthlyStatsBtn.Text = "See Monthly Stats";
            this.monthlyStatsBtn.UseVisualStyleBackColor = true;
            this.monthlyStatsBtn.Click += new System.EventHandler(this.monthlyStatsBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 449);
            this.Controls.Add(this.monthlyStatsBtn);
            this.Controls.Add(this.weeklyStatsBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.date_Int);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.alcohol_Int);
            this.Controls.Add(this.protein_Int);
            this.Controls.Add(this.fat_Int);
            this.Controls.Add(this.carb_Int);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox carb_Int;
        private System.Windows.Forms.TextBox fat_Int;
        private System.Windows.Forms.TextBox protein_Int;
        private System.Windows.Forms.TextBox alcohol_Int;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox date_Int;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button weeklyStatsBtn;
        private System.Windows.Forms.Button monthlyStatsBtn;
    }
}