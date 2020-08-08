using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnStart_ClickAsync(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            CallReadFunction();
        }
        ReadAndDisplayFile readObj;
        private async void CallReadFunction()
        {
            readObj = new ReadAndDisplayFile();
            var count = await readObj.ReadFileOrCancelOperation();
            textBox1.Text = $" Lines read {count.Item1}";
            textBox2.Text = $" Lines \n { count.Item2}";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            readObj?.Cancel();
        }

        class ReadAndDisplayFile
        {
            CancellationTokenSource source = new CancellationTokenSource();
            public async Task<Tuple<int,string>> ReadFileOrCancelOperation()
            {
                int count = 0;
                StringBuilder message = new StringBuilder();
                message.AppendLine("Begining reading File");
                using (FileStream fs = new FileStream(@"Repo\HelloWorldRepo.txt", FileMode.Open))
                {
                    StreamReader sr = new StreamReader(fs);
                    while (!sr.EndOfStream)
                    {
                        if (source.IsCancellationRequested)
                        {
                            message.AppendLine($"Task Cancelled. Count of words {count}");
                            break;
                        }
                        string strLine = sr.ReadLine();
                        count += strLine.Length;
                        await Task.Delay(200);
                        message.AppendLine($"Count of words {count}");
                        if (source.IsCancellationRequested)
                        {
                            message.AppendLine($" Task Cancelled. Count of words {count}");
                            break;
                        }
                    }
                    sr.Close();
                    sr.Dispose();
                }
                if (!source.IsCancellationRequested) 
                    message.AppendLine($" Task Finished. Count of words {count}");
                return new Tuple<int,string>(count, message.ToString());
            }

            public bool Cancel()
            {
                bool result = false;
                if (source != null)
                {
                    source.Cancel();
                    result = true;
                }
                return result;
            }
        }
    }
}
