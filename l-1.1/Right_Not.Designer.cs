namespace l_1._1
{
    partial class Right_Not
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Right_Not));
            this.Answer_Number = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Yes = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.Button();
            this.label_ans = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Answer_Number
            // 
            this.Answer_Number.AutoSize = true;
            this.Answer_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answer_Number.Location = new System.Drawing.Point(122, 21);
            this.Answer_Number.Name = "Answer_Number";
            this.Answer_Number.Size = new System.Drawing.Size(0, 17);
            this.Answer_Number.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Is it right answer?";
            // 
            // Yes
            // 
            this.Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Yes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Yes.Image = ((System.Drawing.Image)(resources.GetObject("Yes.Image")));
            this.Yes.Location = new System.Drawing.Point(12, 69);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(75, 31);
            this.Yes.TabIndex = 3;
            this.Yes.Text = "Yes";
            this.Yes.UseVisualStyleBackColor = true;
            this.Yes.Click += new System.EventHandler(this.Yes_Click);
            // 
            // No
            // 
            this.No.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.No.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.No.Image = ((System.Drawing.Image)(resources.GetObject("No.Image")));
            this.No.Location = new System.Drawing.Point(112, 69);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(75, 31);
            this.No.TabIndex = 4;
            this.No.Text = "No";
            this.No.UseVisualStyleBackColor = true;
            this.No.Click += new System.EventHandler(this.No_Click);
            // 
            // label_ans
            // 
            this.label_ans.AutoSize = true;
            this.label_ans.Location = new System.Drawing.Point(142, 25);
            this.label_ans.Name = "label_ans";
            this.label_ans.Size = new System.Drawing.Size(35, 13);
            this.label_ans.TabIndex = 5;
            this.label_ans.Text = "label1";
            // 
            // Right_Not
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 120);
            this.Controls.Add(this.label_ans);
            this.Controls.Add(this.No);
            this.Controls.Add(this.Yes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Answer_Number);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Right_Not";
            this.Text = "Right_Not";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Answer_Number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Yes;
        private System.Windows.Forms.Button No;
        public System.Windows.Forms.Label label_ans;
    }
}