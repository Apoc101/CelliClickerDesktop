using System;
namespace CelliClickerMainView
{
    public partial class Form1 : Form
    {
        public int playerpoints = 0;
        public int ppc = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            playerpoints += ppc; //dictates how many cellis a click supplies
            label4.Text = playerpoints.ToString(); //updates value for label
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
                double newlabel8 = label8i * 1.3; //creates new value for celli click
                label8.Text = Math.Floor(newlabel8).ToString(); //updates celli click label + rounds
            }
            else
            {
                //fai cagare
            }
        }
    }
}