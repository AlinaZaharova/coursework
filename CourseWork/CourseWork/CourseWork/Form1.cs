using System;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        //переход на форму авторизации
        private void button1_Click(object sender, EventArgs e)
        {
            Authorization frm5 = new Authorization();
            frm5.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PictureForm frm3 = new PictureForm();
            frm3.Show();
            Hide();
        }
    }
}
