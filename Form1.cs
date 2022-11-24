using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chatbot
{
    public partial class Form1 : Form
    {
        //Preset messages
        string Msg1 = "hello";
        string Ressponse1 = "Well hello there!";
        string Msg2 = "whats your name";
        string Ressponse2 = "My name is Computer!";
        string Msg3 = "2+2";
        string Ressponse3 = "2 + 2 = 4!";
        string Msg4 = "goodbye";
        string Ressponse4 = "Goodbye sir!";
        string Msg5 = "help";
        string Ressponse5 = "Ok, I am opening the help menu for this chatbot!";
        string Msg6 = "im sad";
        string Ressponse6 = "Why are you sad?! Remember: alwase be happy!";
        string Msg7 = "tell me a joke";
        string Ressponse7 = "What is sticky and brown? A stick!";
        string Msg8 = "who made you";
        string Ressponse8 = "I was made by C#";
        string Msg9 = "calculator";
        string Ressponse9 = "Ok, opening calculator...";
        string Msg10 = "what time is it";
        string Ressponse10 = "Your curent time is: ";
        string Msg11 = "What day is it today";
        string Ressponse11 = "Today is ";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_click(object sender, EventArgs e)
        {
            //Visibility in first msg
            if (label3.Visible != true)
            {
                label3.Visible = true;
                label4.Visible = true;
            }

            //Other inputs in the textbox
            if (textBox1.Text == "")
            {
                label4.Text = "Enter a message, for example: hello";
                label3.Text = "Your message will go here after you send it!";
            }

            //normal msgs and ressponses
            else if (textBox1.Text.Contains(Msg1) == true)
            {
                label4.Text = Ressponse1;
                label3.Text = Msg1;
            }

            else if (textBox1.Text.Contains(Msg2) == true)
            {
                label4.Text = Ressponse2;
                label3.Text = Msg2;
            }

            else if (textBox1.Text.Contains(Msg3) == true)
            {
                label4.Text = Ressponse3;
                label3.Text = Msg3;
            }

            else if (textBox1.Text.Contains(Msg4) == true)
            {
                label4.Text = Ressponse4;
                label3.Text = Msg4;
            }

            else if (textBox1.Text.Contains(Msg5) == true)
            {
                label4.Text = Ressponse5;
                label3.Text = Msg5;
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }

            else if (textBox1.Text.Contains(Msg6) == true)
            {
                label4.Text = Ressponse6;
                label3.Text = Msg6;
            }

            else if (textBox1.Text.Contains(Msg7) == true)
            {
                label4.Text = Ressponse7;
                label3.Text = Msg7;
            }

            else if (textBox1.Text.Contains(Msg8) == true)
            {
                label4.Text = Ressponse8;
                label3.Text = Msg8;  
            }

            else if (textBox1.Text.Contains(Msg9) == true)
            {
                label4.Text = Ressponse9;
                label3.Text = Msg9;
                Process.Start("Calc.exe");
            }

            else if (textBox1.Text.Contains(Msg10) == true)
            {
                label4.Text = Ressponse10 + DateTime.Now.ToString("hh:mm:ss");
                label3.Text = Msg10;
            }

            else if (textBox1.Text.Contains(Msg11) == true)
            {
                label4.Text = Ressponse11 + DateTime.Now.DayOfWeek;
                label3.Text = Msg11;
            }

            else
            {
                label4.Text = "May you write your message again? I couldn't read it :(";
                label3.Text = textBox1.Text;
            }

            textBox1.Clear();
        }

        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                btnSend_click(sender, e);
            }
        }
    }
}
