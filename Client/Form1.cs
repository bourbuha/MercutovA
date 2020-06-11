using System;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonNet3;

namespace Client
{
    public partial class Form1 : Form
    {
        private String serverHost;
        private Socket cSocket;
        private int port = 8034;
        private NetMessaging net;

        Thread t1;
        Thread t2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Choice_Click(object sender, EventArgs e)
        {
            var sHost = "DESKTOP-6GCQ6FP";
            String usHost;
            usHost = AddressTB.Text;
            if (usHost.Length > 0) sHost = usHost;
            try
            {
                serverHost = sHost;
                AddressTB.Enabled = false;
                Choice.Enabled = false;
                AddressTB.Text = "Подключение к " + sHost;
                cSocket = new Socket(SocketType.Stream, ProtocolType.Tcp);
                cSocket.Connect(this.serverHost, port);
                net = new NetMessaging(cSocket);
                net.MessageCmdReceived += OnMessage;
                net.EventNeedInverse += GetAnswer;
                
                GoMessaging();
                ThreadStart th = new ThreadStart(Communicate);
                t1 = new Thread(th);
                t1.Start();

            }
            catch (Exception)
            {

                OnComment("Что-то пошло не так... :(");
            }
        }
        void Communicate()
        {
            try
            {
                net.Communicate();
            }
            catch (Exception)
            {

                OnComment("Не удалось получить данные. Завершение соединения...");
                //OnNameError(0);
            }
        }

        private void OnComment(String value)
        {
            if (!Comment.InvokeRequired)
            {
                Comment.Text += value + "\r\n";
            }
            else
            {
                Invoke(new NetMessaging.Comment(OnComment), value);
            }
        }

        private void OnMessage(string command, string data)
        {
            if (!AnswerTB.InvokeRequired) AnswerTB.Text =data;
            else
            {
                object[] value = { command, data };
                Invoke(new NetMessaging.Receiving(OnMessage), value);
            }
        }

        private void GoMessaging()
        {
            ThreadStart th = new ThreadStart(Message);
            t2 = new Thread(th);
            t2.Start();
        }
        void Message()
        {
            while (true)
            {
                String userData = "";
                userData = send;
                if (send != "")
                {
                    send = "";
                    net.SendData("MESSAGE",userData);
                }
            }
        }

      

        String send = "";
        private void Send_Click(object sender, EventArgs e)
        {
            Comment.Text = "";
            send = AnumUpDown.Value.ToString() + " " + BnumUpDown.Value.ToString() + " " + NnumUpDown.Value.ToString();
        }
        double a; double b; int n;
        int parts = 4;

        private void GetAnswer(string data)
        {
            if (!AnswerTB.InvokeRequired && !Comment.InvokeRequired)
            {  
                Comment.Text = data;
                a = (double)AnumUpDown.Value;
                b = (double)BnumUpDown.Value;
                n = (int)NnumUpDown.Value;
                res = new Sum();
                Result = -func(b);
                var data1 = Integrate();
                AnswerTB.Text = data1.ToString();
                net.SendData("MESSAGE1", AnumUpDown.Value.ToString() + " " + BnumUpDown.Value.ToString() + " " + NnumUpDown.Value.ToString() + " " + data1);
            }
            else
            {
                Invoke(new NetMessaging.NeedInverse(GetAnswer), data);
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t1 != null)
            {

                t1.Abort();
            }
            if (t2 != null)
            {

                t2.Abort();
            }

        }

        private class Sum
        {
            public double value;
        }
        private Sum res;
        public double Result
        {
            get { return res.value; }
            private set { res.value = value; }
        }
        public double Integrate()
        {
            Parallel.For(
                0,
                parts,
                new Action<int>(_Integrate)
            );
            return Result;
        }
        private void _Integrate(int part)
        {
            int partsSize = (int)(n / 2) / (parts);
            int ost = (n / 2) - partsSize * parts;
            int st = part * partsSize + ((part < ost) ? part : ost);
            int fn = (part + 1) * partsSize + ((part + 1 < ost) ? part : (ost - 1));
            double width = (b - a) / n;
            double trapezoidal_integral = 0;
            for (int i = st; i <= fn; i++)
            {
                double x1 = a + i * width;
                double x2 = a + (i + 1) * width;

                trapezoidal_integral += 0.5 * (x2 - x1) * (func(x1) + func(x2));
            }
            Monitor.Enter(res);
            try
            {
                Result += trapezoidal_integral;
            }
            finally
            {
                Monitor.Exit(res);
            }
        }
        double func(double x)
        {
            var res = (x - 5 * Math.Pow(Math.Sin(x), 2));
            return (double)res;
        }
    }
}
