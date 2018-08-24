using System;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExemplForm
{
    public partial class Form1 : Form
    {
        Task task = null;

        public Form1()
        {
            InitializeComponent();

           

            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
        }

        

        private void Button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            start();
           
              
        }

        public void chengeTime(string time)
        {
            Action a = () => clock.Text = time;
            Invoke(a);
        }

        public event Action start;

        
    }
}
