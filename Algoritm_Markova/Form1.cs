using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritm_Markova
{
    public partial class Form1 : Form
    {
        private string[] alphavit;
        private string[] words;
        private bool successAlphavit = true;
        private bool successWord = true;

        private void Answer()
        {
            InputAccept();
           // InputWordAccept();
        }


        private void InputAccept()
        {
            var text = textBox2.Text.Replace(" ", "");  // 4, 5   ,8
            alphavit = text.Split(','); // {4,5,8}
            foreach(var symbol in alphavit)
            {
                if (symbol.Length > 1)
                {
                    successAlphavit = false;
                    MessageBox.Show("Некорректный ввод алфавита");
                    textBox2.Text = "";
                }
            }
        }

        private void InputWordAccept()
        {
            var text = textBox1.Text.Replace(" ", "");
            words = text.Split(',');
            foreach (var word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (!alphavit.Contains(word[i].ToString())) ;
                    {
                        successWord = false;
                        MessageBox.Show("Некорректный ввод слова");
                        textBox1.Text = "";
                    }
                }
            }
        }

        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Answer();
            if (!successAlphavit) return;
            Random random = new Random();
            var lenght = random.Next(1, 8);
            var lengt_alphavit = alphavit.Length;
            string word = "";
            for (int i = 0; i < lenght; i++)
            {
                if (lengt_alphavit > 0) word += alphavit[random.Next(0, lengt_alphavit)];
            }
            textBox1.Text = word;
        }
    }
}
