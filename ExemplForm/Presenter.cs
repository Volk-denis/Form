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

        private async void Form_start()
        {
            await Task.Factory.StartNew(() =>
            {
                string a = null;
                while (true)
                {
                    a = DateTime.Now.ToString();
                    form.chengeTime(a);
                    Thread.Sleep(1000);
                }
            });
        }
    }
}
