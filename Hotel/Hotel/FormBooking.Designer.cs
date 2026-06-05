namespace Hotel
{
    partial class FormBooking
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
            this.labelDirection = new System.Windows.Forms.Label();
            this.comboBoxDirection = new System.Windows.Forms.ComboBox();
            this.labelHotel = new System.Windows.Forms.Label();
            this.comboBoxHotel = new System.Windows.Forms.ComboBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.pictureBoxHotel = new System.Windows.Forms.PictureBox();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDirection
            // 
            this.labelDirection.AutoSize = true;
            this.labelDirection.Location = new System.Drawing.Point(25, 25);
            this.labelDirection.Name = "labelDirection";
            this.labelDirection.Size = new System.Drawing.Size(116, 13);
            this.labelDirection.TabIndex = 0;
            this.labelDirection.Text = "Куда хотите поехать?";
            // 
            // comboBoxDirection
            // 
            this.comboBoxDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDirection.FormattingEnabled = true;
            this.comboBoxDirection.Location = new System.Drawing.Point(28, 45);
            this.comboBoxDirection.Name = "comboBoxDirection";
            this.comboBoxDirection.Size = new System.Drawing.Size(230, 21);
            this.comboBoxDirection.TabIndex = 1;
            this.comboBoxDirection.SelectedIndexChanged += new System.EventHandler(this.comboBoxDirection_SelectedIndexChanged);
            // 
            // labelHotel
            // 
            this.labelHotel.AutoSize = true;
            this.labelHotel.Location = new System.Drawing.Point(25, 80);
            this.labelHotel.Name = "labelHotel";
            this.labelHotel.Size = new System.Drawing.Size(121, 13);
            this.labelHotel.TabIndex = 2;
            this.labelHotel.Text = "Доступные гостиницы";
            // 
            // comboBoxHotel
            // 
            this.comboBoxHotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHotel.FormattingEnabled = true;
            this.comboBoxHotel.Location = new System.Drawing.Point(28, 100);
            this.comboBoxHotel.Name = "comboBoxHotel";
            this.comboBoxHotel.Size = new System.Drawing.Size(230, 21);
            this.comboBoxHotel.TabIndex = 3;
            this.comboBoxHotel.SelectedIndexChanged += new System.EventHandler(this.comboBoxHotel_SelectedIndexChanged);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(320, 25);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(93, 13);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "Номер телефона";
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(323, 46);
            this.maskedTextBoxPhone.Mask = "+7 (000) 000-00-00";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(230, 20);
            this.maskedTextBoxPhone.TabIndex = 5;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(323, 80);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(101, 13);
            this.labelCategory.TabIndex = 6;
            this.labelCategory.Text = "Категория номера";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(323, 100);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(230, 21);
            this.comboBoxCategory.TabIndex = 7;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // pictureBoxHotel
            // 
            this.pictureBoxHotel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxHotel.Location = new System.Drawing.Point(12, 164);
            this.pictureBoxHotel.Name = "pictureBoxHotel";
            this.pictureBoxHotel.Size = new System.Drawing.Size(360, 240);
            this.pictureBoxHotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHotel.TabIndex = 8;
            this.pictureBoxHotel.TabStop = false;
            this.pictureBoxHotel.Click += new System.EventHandler(this.pictureBoxHotel_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(12, 420);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(100, 30);
            this.buttonPrev.TabIndex = 9;
            this.buttonPrev.Text = "← Назад";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(272, 420);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(100, 30);
            this.buttonNext.TabIndex = 10;
            this.buttonNext.Text = "Вперёд →";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(375, 148);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(57, 13);
            this.labelDescription.TabIndex = 11;
            this.labelDescription.Text = "Описание";
            this.labelDescription.Click += new System.EventHandler(this.labelDescription_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(378, 164);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(239, 240);
            this.textBoxDescription.TabIndex = 12;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.labelPrice.Location = new System.Drawing.Point(25, 260);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(0, 18);
            this.labelPrice.TabIndex = 13;
            // 
            // buttonBook
            // 
            this.buttonBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.buttonBook.Location = new System.Drawing.Point(408, 413);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(230, 45);
            this.buttonBook.TabIndex = 14;
            this.buttonBook.Text = "Забронировать";
            this.buttonBook.UseVisualStyleBackColor = true;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // FormBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 475);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.pictureBoxHotel);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.maskedTextBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.comboBoxHotel);
            this.Controls.Add(this.labelHotel);
            this.Controls.Add(this.comboBoxDirection);
            this.Controls.Add(this.labelDirection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бронирование гостиницы";
            this.Load += new System.EventHandler(this.FormBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelDirection;
        private System.Windows.Forms.ComboBox comboBoxDirection;
        private System.Windows.Forms.Label labelHotel;
        private System.Windows.Forms.ComboBox comboBoxHotel;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.PictureBox pictureBoxHotel;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonBook;
    }
}
