namespace Test
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
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton8 = new RadioButton();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(56, 249);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(74, 19);
            radioButton5.TabIndex = 29;
            radioButton5.TabStop = true;
            radioButton5.Text = "рабыней";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(56, 211);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(97, 19);
            radioButton6.TabIndex = 28;
            radioButton6.TabStop = true;
            radioButton6.Text = "Священицой";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(56, 174);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(70, 19);
            radioButton7.TabIndex = 27;
            radioButton7.TabStop = true;
            radioButton7.Text = "Жрецой";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(56, 137);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(104, 19);
            radioButton8.TabIndex = 26;
            radioButton8.TabStop = true;
            radioButton8.Text = "Императором";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(45, 79);
            label2.Name = "label2";
            label2.Size = new Size(513, 25);
            label2.TabIndex = 25;
            label2.Text = "1. Как в Дрвенем Египте называли служителей Богов.";
            // 
            // button1
            // 
            button1.Location = new Point(56, 296);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 30;
            button1.Text = "Ответить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 399);
            Controls.Add(button1);
            Controls.Add(radioButton5);
            Controls.Add(radioButton6);
            Controls.Add(radioButton7);
            Controls.Add(radioButton8);
            Controls.Add(label2);
            Name = "Form2";
            Text = "V";
            Load += Form2_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private Label label2;
        private Button button1;
    }
}