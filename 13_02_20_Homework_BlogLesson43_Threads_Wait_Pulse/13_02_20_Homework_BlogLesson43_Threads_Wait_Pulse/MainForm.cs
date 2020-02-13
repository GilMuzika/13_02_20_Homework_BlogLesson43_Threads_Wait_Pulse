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

namespace _13_02_20_Homework_BlogLesson43_Threads_Wait_Pulse
{    
    public partial class MainForm : Form
    {
        private Random _rnd = new Random();
        private int count = 0;
        private AsyncPrinter _currentAsyncPrinter = new AsyncPrinter();
        public MainForm()
        {
            InitializeComponent();
            Initialize();
        }
        private void Initialize()
        {
            lblDisplayMessage.Text = string.Empty;
            lblDisplayMessage.Font = new Font("Helvetica", 8, FontStyle.Bold);
            lblDisplayMessage.Padding = new Padding(10);

            _currentAsyncPrinter.printMessageEvent += (object sender, PrintEventArgs e) =>
            {
                if (lblDisplayMessage.InvokeRequired)
                {
                    lblDisplayMessage.Invoke((Action)delegate
                    {
                        lblDisplayMessage.Text = e.Message;
                        if (e.Reached) lblDisplayMessage.ForeColor = Color.Red;
                        else lblDisplayMessage.ForeColor = Color.Black;
                    });
                }
                else
                {
                    lblDisplayMessage.Text = e.Message;
                    if (e.Reached) lblDisplayMessage.ForeColor = Color.Red;
                    else lblDisplayMessage.ForeColor = Color.Black;
                }
            };

            lblDisplayMessage.drawBorder(1, Color.Black);

            count++;
            txtMessage.Text = $"message_{count}_{Statics.GetUniqueKeyOriginal_BIASED(_rnd.Next(5, 25))}";

            SetThreads();
        }

        private void SetThreads()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(new ParameterizedThreadStart(_currentAsyncPrinter.CheckPrintMessage));
                thread.IsBackground = true;
                thread.Start(i);
            }
        }

        private void btnAddMessage_Click(object sender, EventArgs e)
        {
            count++;
            _currentAsyncPrinter.AddMessage(txtMessage.Text);
            txtMessage.Text = $"message_{count}_{Statics.GetUniqueKeyOriginal_BIASED(_rnd.Next(5, 25))}";
        }

        private void btnOvercomeTheLimit_Click(object sender, EventArgs e)
        {
            SetThreads();
        }
    }
}
