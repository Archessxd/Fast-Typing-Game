using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace _archsx99
{
    public partial class Form1 : Form
    {
        ArrayList Words = new ArrayList();
        int index;
        int trueWord;
        string selWord;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            true_word_LBL.Text = trueWord.ToString();
            Start();
            addWord();
            WordReset();
            /*Random r  = new Random();
            index = r.Next(Words.Count);
            selWord = Words[index].ToString();
            word_LBL.Text = selWord;*/
        }
        private void addWord()
        {
            // if you want , u can add more words, for coding step there are enough
            Words.Add("school");
            Words.Add("bag");
            Words.Add("pencil");
            Words.Add("kid");
            Words.Add("woman");
            Words.Add("man");
            Words.Add("lamb");
        }
        private void Start()
        {
            button1.Enabled= true;
            groupBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            groupBox1.Visible= true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if (text == selWord) 
            {
                WordReset();
                trueWord++;
                true_word_LBL.Text = trueWord.ToString();
            }
        }
        private void WordReset() 
        {
            Random r = new Random();
            index = r.Next(Words.Count);
            selWord = Words[index].ToString();
            word_LBL.Text = selWord;
            textBox1.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            Start();
            addWord();
            WordReset();
        }
    }
}
