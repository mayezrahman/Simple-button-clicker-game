using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buttonclickerfunny1
{
    public partial class ButtonClicker : Form
    {
        int playerScore = 0;
        int seconds = 0;

        public ButtonClicker()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            //Function that resets the application
            seconds = 0;
            playerScore = 0;
            
            //Function that starts the application
            timer1.Start();
            button_click1.Enabled = true;
        }

        private void button_click1_Click(object sender, EventArgs e)
        {
            //Execution of the function on the left button
            playerScore += 1;
            textBox_noOfClicks.Text = playerScore.ToString();
            button_click2.Enabled = true;
            button_click1.Enabled = false;
        }

        private void button_click2_Click(object sender, EventArgs e)
        {
            //Exection of the function on the right button
            playerScore += 1;
            textBox_noOfClicks.Text = playerScore.ToString();
            button_click1.Enabled = true;
            button_click2.Enabled = false;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds += 1;

            if (seconds > 9)
            {
                button_click1.Enabled = false;
                button_click2.Enabled = false;
                timer1.Enabled = false;
            }    
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonClicker_Load(object sender, EventArgs e)
        {

        }
    }
}
