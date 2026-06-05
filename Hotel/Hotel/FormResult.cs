using System;
using System.Windows.Forms;

namespace Hotel
{
    public partial class FormResult : Form
    {
        string direction;
        string hotel;
        string category;
        int price;
        string phone;

        public FormResult(string direction, string hotel, string category, int price, string phone)
        {
            InitializeComponent();
            this.direction = direction;
            this.hotel = hotel;
            this.category = category;
            this.price = price;
            this.phone = phone;
        }

        private void FormResult_Load(object sender, EventArgs e)
        {
            textBoxSummary.Text =
                "Ваша бронь оформлена!" + Environment.NewLine + Environment.NewLine +
                "Направление: " + direction + Environment.NewLine +
                "Гостиница: " + hotel + Environment.NewLine +
                "Категория номера: " + category + Environment.NewLine +
                "Стоимость за сутки: " + price + " руб." + Environment.NewLine +
                "Контактный телефон: " + phone + Environment.NewLine + Environment.NewLine +
                "Мы свяжемся с вами для подтверждения.";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
