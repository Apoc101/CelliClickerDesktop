using System;
namespace CelliClickerMainView
{
    public partial class Form1 : Form
    {
        public int playerpoints = 0;
        public int ppc = 1;
        public int xp = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

           //MessageBox.Show("Welcome to celliclicker: desktop edition!");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //CLICK FOR POINTS
            int label12i = Convert.ToInt32(label12.Text);
            playerpoints += ppc; //dictates how many cellis a click supplies
            label4.Text = playerpoints.ToString(); //updates value for label
            int newxp = new Random().Next(1, 5); //random xp
            progressBar1.Value += newxp; //progress bar value assign 
            if(progressBar1.Value > (progressBar1.Maximum - 5) )
            {
                progressBar1.Value = 0; //resets progress bar
                label12i++; //adds 1 level
                label12.Text = label12i.ToString(); //get int value of level
                bool depend; //see if level is under or over 10
                if(label12i <= 10)
                {
                    depend = true;
                }
                else
                {
                    depend = false;
                }

                if (depend)
                {
                    progressBar1.Maximum += 50; //if under 10, add 50 xp to bar
                }
                else
                {
                    progressBar1.Maximum += 100; //if over 10, add 100 xp to bar 
                }

            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //CELLI CLICK, PPC + 1
            int label8i = Convert.ToInt32(label8.Text); //converts label text to integer
            if(playerpoints > label8i-1)
            {
                ppc += 1; //update points per click
                label5.Text = ppc.ToString(); //updates points per click label
                playerpoints -= label8i; //removes points
                label4.Text = playerpoints.ToString(); //updates points label 
                double newlabel8 = label8i * 1.3; //creates new value for celli click, 1/3 of original cost
                label8.Text = Math.Floor(newlabel8).ToString(); //updates celli click label + rounds
            }
            else
            {
                //fai cagare
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int label9i = Convert.ToInt32(label9.Text); //converts label text to integer
            if(playerpoints > label9i - 1)
            {
                ppc = ppc * 2; //updates points per click
                label5.Text = ppc.ToString(); //updates label
                playerpoints -= label9i; //removes points
                label4.Text = playerpoints.ToString(); //updates label
                double newlabel9 = label9i * 1.6; //creates new value for celli multiply, 2/3 of original cost
                label9.Text = Math.Floor(newlabel9).ToString(); //updates celli click label + rounds
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}