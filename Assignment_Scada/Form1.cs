using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Assignment_Scada
{
    public partial class Form1 : Form
    {
    
          //variables for each tank value
          private int tank1Value = 1;
          private int tank2Value = 1;
          private int tank3Value = 1;
          private int tank4Value = 1;
          private int tank5Value = 1;
          private int tank6Value = 1;

          //declaring tank capacities
          private const int Tank1Capacity = 100;
          private const int Tank2Capacity = 120;
          private const int Tank3Capacity = 150;
          private const int Tank4Capacity = 120;
          private const int Tank5Capacity = 140;
          private const int Tank6Capacity = 100;
        SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
        public Form1()
        {
            InitializeComponent();
           
            button1.BackColor = Color.AliceBlue;
            //top pipe connecting to main line
             tank1pipe3.BackColor = Color.Green;
             tank2pipe3.BackColor = Color.Green;
             tank3pipe3.BackColor = Color.Green;
             tank4pipe3.BackColor = Color.Green;
             tank5pipe3.BackColor = Color.Green;
             tank6pipe3.BackColor = Color.Green;

             //setting tank progress bar equall to tank capacity
             pbTank1.Maximum = Tank1Capacity;
             pbTank2.Maximum = Tank2Capacity;
             pbTank3.Maximum = Tank3Capacity;
             pbTank4.Maximum = Tank4Capacity;
             pbTank5.Maximum = Tank5Capacity;
             pbTank6.Maximum = Tank6Capacity;



             mainpipeline.BackColor = Color.Green;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {  
             tank1pressure.Text = tank1Value.ToString("000");
             pbTank1.Value =tank1Value;
             tank1pipe1.BackColor = Color.Green;
             tank1pipe2.BackColor = Color.Green;
             tank1ValveStatus.Text = "Open";
             tank1ValveStatus.BackColor = Color.Green;
             timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            tank1Value = tank1Value + 1;
            if (tank1Value > Tank1Capacity)
            {
                timer1.Enabled = false;
                tank1pipe1.BackColor = Color.White;
                tank1pipe2.BackColor = Color.White;
                tank1ValveStatus.Text = "Closed";
                tank1ValveStatus.BackColor = Color.Red;
                //disabling fill button
                button1.Enabled = false;
            }
            else
            {
                tank1pressure.Text = tank1Value.ToString("000");
                pbTank1.Value = tank1Value;
                //displaying tank warnings
                displayWarning(tank1Warning, tank1Value);
            }
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            tank2pressure.Text = tank2Value.ToString("000");
            pbTank2.Value = tank2Value;
            tank2pipe1.BackColor = Color.Green;
            tank2pipe2.BackColor = Color.Green;
            tank2ValveStatus.Text = "Open";
            tank2ValveStatus.BackColor = Color.Green;
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            tank2Value = tank2Value + 1;
            if (tank2Value > Tank2Capacity)
            {
                timer2.Enabled = false;
                tank2pipe1.BackColor = Color.White;
                tank2pipe2.BackColor = Color.White;
                tank2ValveStatus.Text = "Closed";
                tank2ValveStatus.BackColor = Color.Red;
                //disabling fill button
                button2.Enabled = false;
            }
            else
            {
                tank2pressure.Text = tank2Value.ToString("000");
                pbTank2.Value = tank2Value;
                //displaying tank warnings
                displayWarning(tank2Warning, tank2Value);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tank3pressure.Text = tank3Value.ToString("000");
            pbTank3.Value = tank3Value;
            tank3pipe1.BackColor = Color.Green;
            tank3pipe2.BackColor = Color.Green;
            tank3ValveStatus.Text = "Open";
            tank3ValveStatus.BackColor = Color.Green;
            timer3.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            tank3Value = tank3Value + 1;
            if (tank3Value > Tank3Capacity)
            {
                timer3.Enabled = false;
                tank3pipe1.BackColor = Color.White;
                tank3pipe2.BackColor = Color.White;
                tank3ValveStatus.Text = "Closed";
                tank3ValveStatus.BackColor = Color.Red;
                //disabling fill button
                button3.Enabled = false;
            }
            else
            {
                tank3pressure.Text = tank3Value.ToString("000");
                pbTank3.Value = tank3Value;
                //displaying tank warnings
                displayWarning(tank3Warning, tank3Value);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tank4pressure.Text = tank4Value.ToString("000");
            pbTank4.Value = tank4Value;
            tank4pipe1.BackColor = Color.Green;
            tank4pipe2.BackColor = Color.Green;
            tank4ValveStatus.Text = "Open";
            tank4ValveStatus.BackColor = Color.Green;
            timer4.Enabled = true;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            tank4Value = tank4Value + 1;
            if (tank4Value > Tank4Capacity)
            {
                timer4.Enabled = false;
                tank4pipe1.BackColor = Color.White;
                tank4pipe2.BackColor = Color.White;
                tank4ValveStatus.Text = "Closed";
                tank4ValveStatus.BackColor = Color.Red;
                //disabling fill button
                button4.Enabled = false;

            }
            else
            {
                tank4pressure.Text = tank4Value.ToString("000");
                pbTank4.Value = tank4Value;
                //displaying tank warnings
                displayWarning(tank4Warning, tank4Value);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tank5pressure.Text = tank5Value.ToString("000");
            pbTank5.Value = tank5Value;
            tank5pipe1.BackColor = Color.Green;
            tank5pipe2.BackColor = Color.Green;
            tank5ValveStatus.Text = "Open";
            tank5ValveStatus.BackColor = Color.Green;
            timer5.Enabled = true;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            tank5Value = tank5Value + 1;
            if (tank5Value > Tank5Capacity)
            {
                timer5.Enabled = false;
                tank5pipe1.BackColor = Color.White;
                tank5pipe2.BackColor = Color.White;
                tank5ValveStatus.Text = "Closed";
                tank5ValveStatus.BackColor = Color.Red;
                //disabling fill button
                button5.Enabled = false;

            }
            else
            {
                tank5pressure.Text = tank5Value.ToString("000");
                pbTank5.Value = tank5Value;
                //displaying tank warnings
                displayWarning(tank5Warning, tank5Value);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tank6pressure.Text = tank6Value.ToString("000");
            pbTank6.Value = tank6Value;
            tank6pipe1.BackColor = Color.Green;
            tank6pipe2.BackColor = Color.Green;
            tank6ValveStatus.Text = "Open";
            tank6ValveStatus.BackColor = Color.Green;
            timer6.Enabled = true;
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            tank6Value = tank6Value + 1;
            if (tank6Value > Tank6Capacity)
            {
                timer6.Enabled = false;
                tank6pipe1.BackColor = Color.White;
                tank6pipe2.BackColor = Color.White;
                tank6ValveStatus.Text = "Closed";
                tank6ValveStatus.BackColor = Color.Red;
                //disabling fill button
                button6.Enabled = false;

            }
            else
            {
                tank6pressure.Text = tank6Value.ToString("000");
                pbTank6.Value = tank6Value;
                displayWarning(tank6Warning,tank6Value);
                
            }
        }

        public void displayWarning(Label l,int percentage)
        {
           if (percentage < 30)
            {
                simpleSound.Play();
                //SystemSounds.Asterisk.Play();
                l.Text = "Low";
                l.BackColor = Color.Yellow;
                

            }
            else if (percentage < 90)
            {
                l.Text = "Normal";
                l.BackColor = Color.Green;
                l.ForeColor = Color.White;
            }
            else
            {
                simpleSound.Play();
               // SystemSounds.Beep.Play();
                l.Text = "High";
                l.BackColor = Color.Red;
                l.ForeColor = Color.White;
              
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void tank1Warning_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
