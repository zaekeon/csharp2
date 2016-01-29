using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AysncAndAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //label1.Text = BigLongImportantMethod("John");

            // Task.Factory.StartNew(() => BigLongImportantMethod("Sally")).ContinueWith(t=> label1.Text = t.Result, TaskScheduler.FromCurrentSynchronizationContext());

            CallBigImportantMethod();
            label1.Text = "Waiting...";
        }

        private async void CallBigImportantMethod()
        {
            var result = await BigLongImportantMethodAsync("Andrew");
            label1.Text = result;
        }

        private Task<string> BigLongImportantMethodAsync(string name)
        {
            return Task.Factory.StartNew(() => BigLongImportantMethod(name));
        }
        private string BigLongImportantMethod(string name)
        {
            Thread.Sleep(2000);
            return "Hello, " + name;
        }
    }
}
