using System;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ExemplForm
{
    public partial class Form1 : Form
    {
        


        public Form1()
        {
            InitializeComponent();


            Worker.DoWork += Worker_DoWork;
            Worker.ProgressChanged += Worker_ProgressChanged;
            Worker.RunWorkerCompleted += Worker_RunWorkerCompleted;

            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                if(e.Cancelled == false)
                    MessageBox.Show("опперация завершена");
                else
                    MessageBox.Show("опперация прервана");
            }
                
            else
                MessageBox.Show("что-то не так");
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage + 1;
            progressBar1.Value = e.ProgressPercentage;
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int a =0; a<100; a++)
            {
                if (Worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                if (a == 5) throw new Exception();
                Worker.ReportProgress(a);
                Thread.Sleep(100);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Worker.CancelAsync();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            start(SynchronizationContext.Current);
            Worker.RunWorkerAsync();
            
              
        }

        public void chengeTime(string time)
        {
            clock.Text = time;
            //string s = stop(5);
            
        }

        public event Action<object> start;
        //public event Func<int, string> stop;

        
    }
}
