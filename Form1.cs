using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WAZAAARRRRR
{
    public partial class Form1 : Form
    {   
        public string SaveBat = Category.SaveBat;
        bool Chek = Category.Chek;       
        Random rnd = new Random();
        static int N = Category.N;
        string[][] liter = new string[N][];
        public int[] Count = new int[N];
        string CorrectAnswer;
        int Balls = 0;
        int CountQuestion = 0;
        int[][] Repeat = new int[4][];
        int i = 60;

        public Form1()
        {
            InitializeComponent();
           if (Chek==true)
            {
               
                label1.Visible = true;
                label1.Text = Convert.ToString(i);
                timer1.Enabled = true;
            }
        }
        public void RandQues()
        {
            Repeat[0] =new int[4] {1,2,3,4 };
            Repeat[1] = new int[4] { 2, 3, 4, 1 };
            Repeat[2] = new int[4] { 3, 4, 1, 2 };
            Repeat[3] = new int[4] { 4, 1, 2, 3 };
            int value = rnd.Next(0, N);
            if (value==Count[value])
                value = rnd.Next(0, N);
            Count[value] = value;
            lblQuestion.Text = liter[value][0];
            CorrectAnswer = liter[value][1];
            int c = rnd.Next(0, 4);
            
            button1.Text = liter[value][Repeat[c][0]];
            button2.Text = liter[value][Repeat[c][1]];
            button3.Text = liter[value][Repeat[c][2]];
            button4.Text = liter[value][Repeat[c][3]];

           
            CountQuestion++;
            if(Chek==false)
                if (CountQuestion == 11)
                {
                    string temp = Convert.ToString(Balls);
                    MessageBox.Show(temp);
                }    
            if(Chek==true)
                if(i<=0)
                {
                    timer1.Enabled = false;
                    string temp = Convert.ToString(Balls);
                    MessageBox.Show(temp);
                }
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            
                
            int k = 0;
            int v = 1;
            string path="";
            if (SaveBat == "Литература")
                path = "Liter.txt";
            if (SaveBat == "История")
                path = "History.txt";
            if (SaveBat == "Флора и фауна")
                path = "Flor.txt";
            if (SaveBat == "Спорт")
                path = "Sport.txt";
            if (SaveBat == "Наука")
                path = "Science.txt";
            if (SaveBat == "География")
                path = "Geo.txt";
            if (SaveBat == "Кинематограф")
                path = "Film.txt";
            if (SaveBat == "Всё и сразу")
                path = "Base.txt";
            var arrLiter = File.ReadAllLines(path);
           
            for (int i = 0; i < N; i++)
            {
                liter[i] = new string[5];
            }
            for (int i = 0; i < N; i++)
            {

                liter[i][0] = arrLiter[k];
                k += 5;
                liter[i][1] = arrLiter[v];
                v++;
                liter[i][2] = arrLiter[v];
                v++;
                liter[i][3] = arrLiter[v];
                v++;
                liter[i][4] = arrLiter[v];
                v += 2;
            }

            int value = rnd.Next(0, N);
            Count[value] = value;
            lblQuestion.Text = liter[value][0];
            button1.Text = liter[value][1];
            button2.Text = liter[value][2];
            button3.Text = liter[value][3];
            button4.Text = liter[value][4];
            CorrectAnswer= liter[value][1];
            CountQuestion++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text==CorrectAnswer)
            {
                Balls++;
                RandQues();
            }
            else RandQues();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == CorrectAnswer)
            {
                Balls++;
                RandQues();
            }
            else RandQues();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == CorrectAnswer)
            {
                Balls++;
                RandQues();
            }
            else RandQues();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == CorrectAnswer)
            {
                Balls++;
                RandQues();
            }
            else RandQues();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i--;
            label1.Text = Convert.ToString(i);
            if(i<=0)
            {
                timer1.Stop();
                string temp = Convert.ToString(Balls);
                MessageBox.Show(temp);
            }    
        }
    }
}
