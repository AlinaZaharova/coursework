using System;
using System.IO;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        //посмотреть пароль
        private void openpassword_Click(object sender, EventArgs e)
        {
            passwordtextBox.UseSystemPasswordChar = false;
        }

        //вернуться на главный экран
        private void button2_Click(object sender, EventArgs e)
        {
            Welcome frm1 = new Welcome();
            frm1.Show();
            Hide();
        }

        //сохранение
        private void button1_Click(object sender, EventArgs e)
        {
            Check();
        }

        //проверка полей
        private void Check()
        {
            if (nametextBox.TextLength == 0 && passwordtextBox.TextLength == 0 && repeatpasswordtextBox.TextLength == 0)
            {
                MessageBox.Show("Поля не должны быть пустыми!", "Проверьте введённые данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (passwordtextBox.TextLength < 5)
            {
                MessageBox.Show("Пароль должен содержать не менее 5 символов", "Проверьте введённые данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (passwordtextBox.Text != repeatpasswordtextBox.Text)
            {
                MessageBox.Show("Пароли не совпадают!", "Проверьте введённые данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                repeatpasswordtextBox.Clear();
            }

            string readtext = File.ReadAllText(@"D:\\My papers\\CourseWork\\users.txt");

            if (readtext.Contains(nametextBox.Text))
            {
                MessageBox.Show("Такое имя уже есть :(", "Проверьте введённые данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (readtext.Contains(passwordtextBox.Text))
            {
                MessageBox.Show("Такой пароль уже есть :(", "Проверьте введённые данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if ((nametextBox.TextLength != 0 && passwordtextBox.TextLength != 0 && repeatpasswordtextBox.TextLength != 0) && (passwordtextBox.TextLength > 5) 
                && (passwordtextBox.Text == repeatpasswordtextBox.Text) && (!(readtext.Contains(nametextBox.Text)) && (!(readtext.Contains(passwordtextBox.Text)))))
            {
                WriteToFile();
                MessageBox.Show("Ваши данные записаны", "Наши поздравления", MessageBoxButtons.OK);
                Authorization frm5 = new Authorization();
                frm5.Show();
                Hide();
            }
        }

        //запись в файл
        private void WriteToFile()
        {
            string writerfileusers = @"D:\\My papers\\CourseWork\\users.txt";
            using (StreamWriter writer = new StreamWriter(writerfileusers, true))
            {
                writer.Write(nametextBox.Text + " ");
                writer.Write(passwordtextBox.Text + " ");
                writer.Close();
            }
        }

        //убираем пробелы
        private void nametextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
            {
                e.KeyChar = '\0';
            }
        }

        private void passwordtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
            {
                e.KeyChar = '\0';
            }
        }
    }
}