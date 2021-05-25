using System;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Game : Form
    {
        int attempt = 5;    //количество попыток
        int bet = 0;        //начальная ставка
        int balance = 100;  //стартовый баланс  
        int win = 0;        //выигрыш
        int sum = 0;

        public Game()
        {
            InitializeComponent();
            spin.Enabled = false;
            attemptlabel.Text = "Осталось попыток: 5";
        }

        //метод для загрузки картинок
        public string[] GetPicture()
        {
            string[] picture = new string[8];

            picture[0] = "D:\\My papers\\CourseWork\\pictures\\banana.png";
            picture[1] = "D:\\My papers\\CourseWork\\pictures\\cherry.png";
            picture[2] = "D:\\My papers\\CourseWork\\pictures\\clover.png";
            picture[3] = "D:\\My papers\\CourseWork\\pictures\\diamond.png";
            picture[4] = "D:\\My papers\\CourseWork\\pictures\\plum.png";
            picture[5] = "D:\\My papers\\CourseWork\\pictures\\seven.png";
            picture[6] = "D:\\My papers\\CourseWork\\pictures\\watermelon.png";
            picture[7] = "D:\\My papers\\CourseWork\\pictures\\gold.png";

            return picture;
        }

        //генерация рандомных картинок и запуск барабанов при помощи таймеров
        private void engine1_Tick(object sender, EventArgs e)
        {
            string[] allpicture = GetPicture();
            Random rnd = new Random();
            int i = rnd.Next(8);
            pictureBox1.ImageLocation = allpicture[i];
        }

        private void engine2_Tick(object sender, EventArgs e)
        {
            string[] allpicture = GetPicture();
            Random rnd = new Random();
            int i = rnd.Next(8);
            pictureBox2.ImageLocation = allpicture[i];
        }

        private void engine3_Tick(object sender, EventArgs e)
        {
            string[] allpicture = GetPicture();
            Random rnd = new Random();
            int i = rnd.Next(8);
            pictureBox3.ImageLocation = allpicture[i];
        }

        //активация запуска барабанов и стоп-таймеров при нажатии на кнопку "старт"
        private void spin_Click(object sender, EventArgs e)
        {
            attempt--;
            attemptlabel.Text = "Осталось попыток: " + attempt;

            engine1.Enabled = true;
            engine2.Enabled = true;
            engine3.Enabled = true;
            stop1.Enabled = true;
            stop2.Enabled = true;
            stop3.Enabled = true;
            spin.Enabled = false;
            setbet.Enabled = false;
            numericUpDown1.Enabled = false;
        }

        //таймеры для остановки барабанов
        private void stop1_Tick(object sender, EventArgs e)
        {
            engine1.Enabled = false;
            stop1.Enabled = false;
        }

        private void stop2_Tick(object sender, EventArgs e)
        {
            engine2.Enabled = false;
            stop2.Enabled = false;
        }

        private void stop3_Tick(object sender, EventArgs e)
        {
            engine3.Enabled = false;
            stop3.Enabled = false;
            spin.Enabled = true;
            Combinations();
            Attempt();
        }

        //ставка
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Increment = 5;
            numericUpDown1.Maximum = 20;
            numericUpDown1.Minimum = 5;
            numericUpDown1.ReadOnly = true;
        }

        private void Bet(decimal count)
        {
            bet = Convert.ToInt32(count);
            balance -= bet;

            if (balance < 0)
            {
                MessageBox.Show("Игра завершена!", "Турурум... На балансе недостаточно средств", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Welcome frm1 = new Welcome();
                frm1.Show();
                Hide();
            }
            else
            {
                balancelabel.Text = "Баланс: $" + balance;
                attempt = 5;
                attemptlabel.Text = "Осталось попыток: " + attempt;
            }

        }

        private void setbet_Click(object sender, EventArgs e)
        {
            Bet(numericUpDown1.Value);
            setbet.Enabled = false;
            numericUpDown1.Enabled = false;
            spin.Enabled = true;
        }

        //подсчёт количества попыток
        private void Attempt()
        {
            if (attempt != 0)
            {
                spin.Enabled = true;
            }
            else
            {
                attemptlabel.Text = "Осталось попыток: " + attempt;
                MessageBox.Show("Сделайте новую ставку!", "Попытки закончились...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                balance += sum;
                balancelabel.Text = "Баланс: $" + balance;
                sum = 0;
                winlabel.Text = "Выигрыш: $0";

                setbet.Enabled = true;
                numericUpDown1.Enabled = true;
            }
        }

        //рассчёт выигрыша
        private void Win(int n)
        {
            win = (int)(numericUpDown1.Value * n);
            MessageBox.Show("Вы выиграли " + win + "$", "Наши поздравления!", MessageBoxButtons.OK);
            sum += win;
            winlabel.Text = "Выигрыш: $" + sum;
        }

        //получение дополнительной попытки
        private void Chance()
        {
            MessageBox.Show("Вы получили дополнительную попытку!", "Наши поздравления!", MessageBoxButtons.OK);
            attempt += 1;
            attemptlabel.Text = "Осталось попыток: " + attempt;
        }

        //комбинации
        private void Combinations()
        {
            string[] allpicture = GetPicture();

            //один любой клевер
            if ((pictureBox1.ImageLocation == allpicture[2] && pictureBox2.ImageLocation != allpicture[2] && pictureBox3.ImageLocation != allpicture[2]) ||
                (pictureBox2.ImageLocation == allpicture[2] && pictureBox1.ImageLocation != allpicture[2] && pictureBox3.ImageLocation != allpicture[2]) ||
                (pictureBox3.ImageLocation == allpicture[2] && pictureBox1.ImageLocation != allpicture[2] && pictureBox2.ImageLocation != allpicture[2]))
            {
                Chance();
            }
            //два любых банана
            if ((pictureBox1.ImageLocation == allpicture[0] && pictureBox2.ImageLocation == allpicture[0] && pictureBox3.ImageLocation != allpicture[0]) ||
                (pictureBox2.ImageLocation == allpicture[0] && pictureBox3.ImageLocation == allpicture[0] && pictureBox1.ImageLocation != allpicture[0]) ||
                (pictureBox1.ImageLocation == allpicture[0] && pictureBox3.ImageLocation == allpicture[0] && pictureBox2.ImageLocation != allpicture[0]))
            {
                Win(15);
            }
            //две любые вишни
            if ((pictureBox1.ImageLocation == allpicture[1] && pictureBox2.ImageLocation == allpicture[1] && pictureBox3.ImageLocation != allpicture[1]) ||
                (pictureBox2.ImageLocation == allpicture[1] && pictureBox3.ImageLocation == allpicture[1] && pictureBox1.ImageLocation != allpicture[1]) ||
                (pictureBox1.ImageLocation == allpicture[1] && pictureBox3.ImageLocation == allpicture[1] && pictureBox2.ImageLocation != allpicture[1]))
            {
                Win(5);
            }
            //два любых алмаза
            if ((pictureBox1.ImageLocation == allpicture[3] && pictureBox2.ImageLocation == allpicture[3] && pictureBox3.ImageLocation != allpicture[3]) ||
                (pictureBox2.ImageLocation == allpicture[3] && pictureBox3.ImageLocation == allpicture[3] && pictureBox1.ImageLocation != allpicture[3]) ||
                (pictureBox1.ImageLocation == allpicture[3] && pictureBox3.ImageLocation == allpicture[3] && pictureBox2.ImageLocation != allpicture[3]))
            {
                Win(130);
            }
            //две любые сливы
            if ((pictureBox1.ImageLocation == allpicture[4] && pictureBox2.ImageLocation == allpicture[4] && pictureBox3.ImageLocation != allpicture[4]) ||
                (pictureBox2.ImageLocation == allpicture[4] && pictureBox3.ImageLocation == allpicture[4] && pictureBox1.ImageLocation != allpicture[4]) ||
                (pictureBox1.ImageLocation == allpicture[4] && pictureBox3.ImageLocation == allpicture[4] && pictureBox2.ImageLocation != allpicture[4]))
            {
                Win(45);
            }
            //две любые семёрки
            if ((pictureBox1.ImageLocation == allpicture[5] && pictureBox2.ImageLocation == allpicture[5] && pictureBox3.ImageLocation != allpicture[5]) ||
                (pictureBox2.ImageLocation == allpicture[5] && pictureBox3.ImageLocation == allpicture[5] && pictureBox1.ImageLocation != allpicture[5]) ||
                (pictureBox1.ImageLocation == allpicture[5] && pictureBox3.ImageLocation == allpicture[5] && pictureBox2.ImageLocation != allpicture[5]))
            {
                Win(180);
            }
            //два любых арбуза
            if ((pictureBox1.ImageLocation == allpicture[6] && pictureBox2.ImageLocation == allpicture[6] && pictureBox3.ImageLocation != allpicture[6]) ||
                (pictureBox2.ImageLocation == allpicture[6] && pictureBox3.ImageLocation == allpicture[6] && pictureBox1.ImageLocation != allpicture[6]) ||
                (pictureBox1.ImageLocation == allpicture[6] && pictureBox3.ImageLocation == allpicture[6] && pictureBox2.ImageLocation != allpicture[6]))
            {
                Win(25);
            }
            //два любых слитка
            if ((pictureBox1.ImageLocation == allpicture[7] && pictureBox2.ImageLocation == allpicture[7] && pictureBox3.ImageLocation != allpicture[7]) ||
                (pictureBox2.ImageLocation == allpicture[7] && pictureBox3.ImageLocation == allpicture[7] && pictureBox1.ImageLocation != allpicture[7]) ||
                (pictureBox1.ImageLocation == allpicture[7] && pictureBox3.ImageLocation == allpicture[7] && pictureBox2.ImageLocation != allpicture[7]))
            {
                Win(80);
            }
            //три семёрки
            if (pictureBox1.ImageLocation == allpicture[5] && pictureBox2.ImageLocation == allpicture[5] && pictureBox3.ImageLocation == allpicture[5])
            {
                Win(200);
            }
            //три алмаза
            if (pictureBox1.ImageLocation == allpicture[3] && pictureBox2.ImageLocation == allpicture[3] && pictureBox3.ImageLocation == allpicture[3])
            {
                Win(150);
            }
            //три слитка
            if (pictureBox1.ImageLocation == allpicture[7] && pictureBox2.ImageLocation == allpicture[7] && pictureBox3.ImageLocation == allpicture[7])
            {
                Win(100);
            }
            //три сливы
            if (pictureBox1.ImageLocation == allpicture[4] && pictureBox2.ImageLocation == allpicture[4] && pictureBox3.ImageLocation == allpicture[4])
            {
                Win(75);
            }
            //три арбуза
            if (pictureBox1.ImageLocation == allpicture[6] && pictureBox2.ImageLocation == allpicture[6] && pictureBox3.ImageLocation == allpicture[6])
            {
                Win(55);
            }
            //три банана
            if (pictureBox1.ImageLocation == allpicture[0] && pictureBox2.ImageLocation == allpicture[0] && pictureBox3.ImageLocation == allpicture[0])
            {
                Win(35);
            }
            //два слитка и один алмаз
            if (pictureBox1.ImageLocation == allpicture[7] && pictureBox2.ImageLocation == allpicture[7] && pictureBox3.ImageLocation == allpicture[3])
            {
                Win(90);
            }
            //две сливы и один алмаз
            if (pictureBox1.ImageLocation == allpicture[4] && pictureBox2.ImageLocation == allpicture[4] && pictureBox3.ImageLocation == allpicture[3])
            {
                Win(70);
            }
            //два арбуза и один алмаз
            if (pictureBox1.ImageLocation == allpicture[6] && pictureBox2.ImageLocation == allpicture[6] && pictureBox3.ImageLocation == allpicture[3])
            {
                Win(50);
            }
            //два банана и один алмаз
            if (pictureBox1.ImageLocation == allpicture[0] && pictureBox2.ImageLocation == allpicture[0] && pictureBox3.ImageLocation == allpicture[3])
            {
                Win(30);
            }
        }

        //завершение игры
        private void gamestop_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы точно хотите покинуть игру?", "Выход из игры", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                PictureForm frm3 = new PictureForm();
                frm3.Show();
                Hide();
            }
        }

        //вернуться на главный экран
        private void backtomainscreen_Click(object sender, EventArgs e)
        {
            Welcome frm1 = new Welcome();
            frm1.Show();
            Hide();
        }
    }
}


