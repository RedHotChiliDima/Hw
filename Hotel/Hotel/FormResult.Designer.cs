namespace Hotel
{
    partial class FormResult
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxSummary = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.textBoxSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxSummary.Location = new System.Drawing.Point(25, 25);
            this.textBoxSummary.Multiline = true;
            this.textBoxSummary.Name = "textBoxSummary";
            this.textBoxSummary.ReadOnly = true;
            this.textBoxSummary.Size = new System.Drawing.Size(330, 210);
            this.textBoxSummary.TabIndex = 0;
            this.buttonClose.Location = new System.Drawing.Point(125, 250);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(130, 32);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 301);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxSummary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Итоги бронирования";
            this.Load += new System.EventHandler(this.FormResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxSummary;
        private System.Windows.Forms.Button buttonClose;
    }
}
