using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {


        double sayi1;
        double sayi2;
        Double sonuc;
        char islem;
        string islm;
        public Form1()
        {
            InitializeComponent();
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;

         

           
        
      }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
          
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
        }


        private void ekle(object sender,EventArgs e)
        {

            textBox1.Text += (sender as Button).Text; 


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

           

           

            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            sayi1 = Convert.ToDouble(textBox1.Text);
            islem = '+';
           
            textBox1.Clear();
           
            

        }

        private void button20_Click(object sender, EventArgs e)
        {
            Double sayi2;
            sayi2 = Convert.ToDouble(textBox1.Text);
            if(islem =='+')
            {


                sonuc = sayi1 + sayi2;
                textBox1.Text = sonuc.ToString();

            }

            else if(islem =='-')
            {



                sonuc = sayi1 - sayi2;
                textBox1.Text = sonuc.ToString();


            }

            else if (islem =='*')
            {



                sonuc = sayi1 * sayi2;
                textBox1.Text = sonuc.ToString();


            }

            else if (islem == '/')
            {



                sonuc = sayi1 / sayi2;
                textBox1.Text = sonuc.ToString();


            }

            else if(islem =='%')
            {


                sonuc = sayi1 * sayi2 / 100;

                textBox1.Text = sonuc.ToString();


            }
            else if(islm=="mod")
            {


                sonuc = sayi1 % sayi2;

                textBox1.Text = sonuc.ToString();


            }


        }

        private void button14_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            islem = '-';
            textBox1.Clear();
            


               


        }

        private void button21_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sonuc = sayi1 * sayi1;
            textBox1.Text = sonuc.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sonuc = sayi1 * sayi1 * sayi1;
            textBox1.Text = sonuc.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            sonuc = 1 / sayi1;

            textBox1.Text = sonuc.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            islem = '%';
            textBox1.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);

            sonuc = Math.Sqrt(sayi1);

            textBox1.Text = sonuc.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            islm = "mod";
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            islem = '*';
            textBox1.Clear();
          



           
          
           


        }

        private void button16_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(textBox1.Text);
            islem = '/';
            textBox1.Clear();
           
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text; 
        }

        private void button24_Click(object sender, EventArgs e)
        {


            textBox1.Text=textBox1.Text.Substring(0,textBox1.Text.Length-1);
         
           
                
                


           

            



        }

        private void button25_Click(object sender, EventArgs e)
        {

            double say;
            double sonuc;

            say = Convert.ToDouble(textBox1.Text);

            sonuc = Math.Sin(say);


            if(sonuc.ToString().Length>7)
            {

                textBox1.Text = sonuc.ToString().Substring(0, 7);

            }

           

            else
            {

                textBox1.Text = sonuc.ToString();

            }
            
        }
        
        private void button26_Click(object sender, EventArgs e)
        {
            double say;
            double sonuc;

            say = Convert.ToDouble(textBox1.Text);

            sonuc = Math.Cos(say);


            if (sonuc.ToString().Length > 7)
            {

                textBox1.Text = sonuc.ToString().Substring(0, 7);

            }



            else
            {

                textBox1.Text = sonuc.ToString();

            }
            
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double say;
            double sonuc;

            say = Convert.ToDouble(textBox1.Text);

            sonuc = Math.Tan(say);


            if (sonuc.ToString().Length > 7)
            {

                textBox1.Text = sonuc.ToString().Substring(0, 7);

            }



            else
            {

                textBox1.Text = sonuc.ToString();

            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double say;
            double sonuc;

            say = Convert.ToDouble(textBox1.Text);

            sonuc = Math.Log(say);


            if (sonuc.ToString().Length > 7)
            {

                textBox1.Text = sonuc.ToString().Substring(0, 7);

            }



            else
            {

                textBox1.Text = sonuc.ToString();

            }
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();

            this.Close();
        }
    }


}
