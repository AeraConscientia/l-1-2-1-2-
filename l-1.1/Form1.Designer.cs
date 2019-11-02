namespace l_1._1
{
    partial class Form1
    {
        /*
         * delegate void AccountHandler(string message);
           event AccountHandler Notify; событие Notify

           Notify += обработчик события;

           Обработчики событий - это именно то, что выполняется при вызове событий. 
           Нередко в качестве обработчиков событий применяются методы. 
           Каждый обработчик событий по списку параметров и возвращаемому типу должен соответствовать делегату,
           который представляет событие. Для добавления обработчика события применяется операция +=:
         */
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Length = new System.Windows.Forms.TextBox();
            this.textBox_Wide = new System.Windows.Forms.TextBox();
            this.button_Area = new System.Windows.Forms.Button();
            this.button_Clean = new System.Windows.Forms.Button();
            this.button_About = new System.Windows.Forms.Button();
            this.textBox_Area = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Answer_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wide";
            // 
            // textBox_Length
            // 
            this.textBox_Length.Location = new System.Drawing.Point(19, 39);
            this.textBox_Length.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Length.Name = "textBox_Length";
            this.textBox_Length.Size = new System.Drawing.Size(132, 22);
            this.textBox_Length.TabIndex = 2;
            this.textBox_Length.Text = "1";
            // 
            // textBox_Wide
            // 
            this.textBox_Wide.Location = new System.Drawing.Point(19, 91);
            this.textBox_Wide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Wide.Name = "textBox_Wide";
            this.textBox_Wide.Size = new System.Drawing.Size(132, 22);
            this.textBox_Wide.TabIndex = 3;
            this.textBox_Wide.Text = "5";
            // 
            // button_Area
            // 
            this.button_Area.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Area.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Area.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Area.Image = ((System.Drawing.Image)(resources.GetObject("button_Area.Image")));
            this.button_Area.Location = new System.Drawing.Point(233, 38);
            this.button_Area.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Area.Name = "button_Area";
            this.button_Area.Size = new System.Drawing.Size(176, 49);
            this.button_Area.TabIndex = 4;
            this.button_Area.Text = "Area";
            this.button_Area.UseVisualStyleBackColor = true;
            this.button_Area.Click += new System.EventHandler(this.button_Area_Click);
            // 
            // button_Clean
            // 
            this.button_Clean.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Clean.BackgroundImage")));
            this.button_Clean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Clean.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Clean.Location = new System.Drawing.Point(309, 108);
            this.button_Clean.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Clean.Name = "button_Clean";
            this.button_Clean.Size = new System.Drawing.Size(100, 28);
            this.button_Clean.TabIndex = 5;
            this.button_Clean.Text = "Clear";
            this.button_Clean.UseVisualStyleBackColor = true;
            this.button_Clean.Click += new System.EventHandler(this.button_Clean_Click);
            // 
            // button_About
            // 
            this.button_About.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_About.BackgroundImage")));
            this.button_About.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_About.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_About.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_About.ForeColor = System.Drawing.SystemColors.Control;
            this.button_About.Location = new System.Drawing.Point(309, 233);
            this.button_About.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_About.Name = "button_About";
            this.button_About.Size = new System.Drawing.Size(100, 28);
            this.button_About.TabIndex = 6;
            this.button_About.Text = "About";
            this.button_About.UseVisualStyleBackColor = true;
            this.button_About.Click += new System.EventHandler(this.button_About_Click);
            // 
            // textBox_Area
            // 
            this.textBox_Area.Location = new System.Drawing.Point(19, 164);
            this.textBox_Area.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Area.Name = "textBox_Area";
            this.textBox_Area.Size = new System.Drawing.Size(132, 22);
            this.textBox_Area.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Area";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Is it right?";
            // 
            // Answer_label
            // 
            this.Answer_label.AutoSize = true;
            this.Answer_label.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Answer_label.Location = new System.Drawing.Point(15, 225);
            this.Answer_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Answer_label.Name = "Answer_label";
            this.Answer_label.Size = new System.Drawing.Size(66, 17);
            this.Answer_label.TabIndex = 10;
            this.Answer_label.Text = "Unknown";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(436, 276);
            this.Controls.Add(this.Answer_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Area);
            this.Controls.Add(this.button_About);
            this.Controls.Add(this.button_Clean);
            this.Controls.Add(this.button_Area);
            this.Controls.Add(this.textBox_Wide);
            this.Controls.Add(this.textBox_Length);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Rectangle: Area";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Length;
        private System.Windows.Forms.TextBox textBox_Wide;
        private System.Windows.Forms.Button button_Area;
        private System.Windows.Forms.Button button_Clean;
        private System.Windows.Forms.Button button_About;
        private System.Windows.Forms.TextBox textBox_Area;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Answer_label;
    }
}

