using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashMachine
{
    public partial class CashMachine : Form
    {
        public CashMachine()
        {
            InitializeComponent();
        }
        public static string NumberCard;

        public void Exit(RichTextBox richTextBox1)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Введите вашу банковскую карту.";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Первая надпись, означающая просьбу нажать на кнопку "Введите вашу карту"
            richTextBox1.Text = "Введите вашу банковскую карту.";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Money.OutCash();
        }

        private void buttonCard_Click(object sender, EventArgs e)
        {
            //при нажатии на ввод карты, включаются все кнопки банкомата, необходимые для ввода номера карты
            richTextBox1.Clear();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button0.Enabled = true;
            buttonCancel.Enabled = true;
            buttonCorrect.Enabled = true;
            buttonEnter.Enabled = true;
            buttonGrad.Enabled = true;
            buttonStar.Enabled = true;
            buttonTakeCard.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text= richTextBox1.Text+1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + 9;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + 0;
        }

        private void buttonStar_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "*";
        }

        private void buttonGrad_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "#";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void buttonCorrect_Click(object sender, EventArgs e)
        {
            int lenght = richTextBox1.Text.Length - 1;
            string text = richTextBox1.Text;
            richTextBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                richTextBox1.Text = richTextBox1.Text + text[i];
            }
        }

        public void buttonTakeCard_Click(object sender, EventArgs e)
        {
            //Очищаем поле для ввода, возвращаем надпись о вводе карты, отключаем кнопки
            Exit();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button0.Enabled = false;
            buttonCancel.Enabled = false;
            buttonCorrect.Enabled = false;
            buttonEnter.Enabled = false;
            buttonGrad.Enabled = false;
            buttonStar.Enabled = false;
            buttonTakeCard.Enabled = false;
            buttonBalance.Enabled = false;
            buttonOutCash.Enabled = false;
            buttonTransfer.Enabled = false;
            buttonExit.Enabled = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        internal static void Exit()
        {
            throw new NotImplementedException();
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            Money.Transfer();
        }

        private void buttonBalance_Click(object sender, EventArgs e)
        {
            Money.balance();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Exit();
        }
    }
}
