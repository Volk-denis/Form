using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemplForm
{
    class Presenter
    {
        Form1 form;

        public Presenter(Form1 f)
        {
            this.form = f;
            form.start += Form_start;
        }

        //public event Action<SynchronizationContext> start;
        private async void Form_start(object o)
        {
            SynchronizationContext sc = (SynchronizationContext)o;
            await Task.Factory.StartNew(() =>
            {
                string a = null;
                while (true)
                {
                    a = DateTime.Now.ToString();
                    sc.Send(_Send, a);
                    
                    Thread.Sleep(1000);
                }
            });
        }

        public void _Send(object o)
        {
            form.chengeTime((string)o);
        }
    }
}
