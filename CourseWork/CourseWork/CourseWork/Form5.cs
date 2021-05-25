using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        //переход на форму регистрации
        private void Registr_Click(object sender, EventArgs e)
        {
            Registration frm4 = new Registration();
            frm4.Show();
            Hide();
        }

        //открыть пароль
        private void openpassword1_Click(object sender, EventArgs e)
        {
            passwordtextBox1.UseSystemPasswordChar = false;
        }

        //подтверждение данных
        private void Confirm_Click(object sender, EventArgs e)
        {
            Check();
        }

        //проверка полей
        private void Check()
        {
            string[] readtext = File.ReadAllText(@"D:\\My papers\\CourseWork\\users.txt").Split(' ');
            
            if (!(readtext.Contains(nametextBox1.Text)))
            {
                MessageBox.Show("Пользователя с таким именем нет...\nВам нужно зарегистрироваться! ;)", "Что-то не так...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (!(readtext.Contains(passwordtextBox1.Text)))
            {
                MessageBox.Show("Такого пароля нет...", "Что-то не так...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (nametextBox1.TextLength == 0 && passwordtextBox1.TextLength == 0)
            {
                MessageBox.Show("Поля не должны быть пустыми!", "Проверьте введённые данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           

            //чтение из файла
            for (int i = 0; i < readtext.Count() - 1; i += 2)
            {
                if (nametextBox1.Text == readtext[i] && passwordtextBox1.Text == readtext[i + 1])
                {
                    MessageBox.Show("Данные подтверждены", "Вы есть в наших списках!", MessageBoxButtons.OK);
                    Game frm2 = new Game();
                    frm2.Show();
                    Hide();
                }
                if (!(nametextBox1.Text == readtext[i]) && (passwordtextBox1.Text == readtext[i + 1]))
                {
                    MessageBox.Show("Имя пользователя и пароль не совпадают", "Хммм...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //удаляем пробелы
        private void nametextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
            {
                e.KeyChar = '\0';
            }
        }

        private void passwordtextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
            {
                e.KeyChar = '\0';
            }
        }
    }
}