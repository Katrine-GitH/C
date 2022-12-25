using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ExampleSQLAdd
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();


        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Green;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }
        Point lastPoint;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }
        
        private void Generate_Click(object sender, EventArgs e)
        {
            // Получаем количество слов и букв за слово.
            int num_letters = 10;
            int num_words = 10;
            //WordBox.Items.Add($"string");
            // Создаем массив букв, которые мы будем использовать.
            char[] letters = "AB!CDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            //char[] letters = "ABCDEFGHIJKL!MNOPQRSTUVWXYZ".ToCharArray();
            Create_words(10,10, letters);
            //Console.WriteLine($"new_letters, new_words");
        }
        int answer=0;
        //char [] v = "!".ToCharArray();
        // Делаем слова.
        public void Create_words(int num_letters,int num_words,char[] letters)
        {
            // Создаем генератор случайных чисел.
            Random rand = new Random();
            for (int i = 1; i < num_words; i++)
            {
                // Сделайте слово.
                string word = "";
                for (int j = 1; j < num_letters; j++)
                {
                    // Выбор случайного числа от 0 до 25
                    // для выбора буквы из массива букв.
                    int letter_num = rand.Next(0, letters.Length - 1); 

                    // Добавить письмо.
                    word += letters[letter_num];
                }
                // Добавьте слово в список.
                WordBox.Items.Add( word);
                //bool Contains(char value, StringComparison comparisonType);
                string s2 = "!";
                bool b = word.Contains(s2);
                if(b)
                {
                    answer += 1;
                }
                //Answer.Items.Add(answer);
            }
            Answer.Items.Add(answer);
            Console.WriteLine();
        }
        
        
        private void WordBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        private void Answer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Answer.Items.Add($"ansver");
        }
    }
}
