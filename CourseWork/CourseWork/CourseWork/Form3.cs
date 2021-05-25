using System;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class PictureForm : Form
    {
        public PictureForm()
        {
            InitializeComponent();

            Timer disappear = new Timer();
            disappear.Interval = 2000;
            disappear.Start();
            disappear.Tick += new EventHandler(disappear_Tick);
        }

        //закрытие формы
        private void disappear_Tick(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

 
    }
}
