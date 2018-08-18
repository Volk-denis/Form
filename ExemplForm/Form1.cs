using System;
using System.IO;
using System.Windows.Forms;
using System.Text;

namespace ExemplForm
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
            
            foreach(var iten in this.Controls)
            {
                Console.WriteLine(iten);
                Button b = iten as Button;
                {
                    if (b != null)
                        b.Click += (a, c) => MessageBox.Show(b.Text);
                                               
                        
                }
                    
            }

            

            



        }

        private void GroupBox_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(String.Format(sender.GetType().ToString()));
            Button b = null;
            if(sender is Button)
                b = (Button)sender;

            
            if (b != null)
            {
                MessageBox.Show($"Была нажата{b.Name}");
            }
            
        }

        private void ButClic3(object sender, EventArgs e)
        {
            
            try
            {
                               

                
                
            }
            catch (Exception d)
            {
                Console.WriteLine(d.Message);
            }
        }

        private void ButClic2(object sender, EventArgs e)
        {
            

           
            

        }

        private void tex_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
