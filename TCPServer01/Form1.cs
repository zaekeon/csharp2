using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace TCPServer01
{
    public partial class Form1 : Form
    {
        TcpListener mTCPListener;
        TcpClient mTCPClient;
        byte[] mRX;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            IPAddress ipAddr;
            int nPort;

            if (int.TryParse(tbPort.Text, out nPort))
            {
                nPort = 23000;
            }
            if (IPAddress.TryParse(tbIPAddress.Text,out ipAddr))
            {
                
            }

            mTCPListener = new TcpListener(ipAddr, nPort);

            mTCPListener.Start();
            mTCPListener.BeginAcceptTcpClient(onCompleteAcceptTCPClient, mTCPListener);

            mTCPClient.GetStream().BeginRead(mRX, 0, mRX.Length, onCompleteReadFromTCPCLientStream, mTCPClient);

        }

        void onCompleteAcceptTCPClient(IAsyncResult iar)
        {
            TcpListener tcpl = (TcpListener)iar.AsyncState;
            try {
                mTCPClient = tcpl.EndAcceptTcpClient(iar);
                mRX = new byte[512];

                mTCPClient.GetStream().BeginRead(mRX, 0, mRX.Length, onCompleteReadFromTCPCLientStream, mTCPClient);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error accepting connection");
            }

            
        }

        void onCompleteReadFromTCPCLientStream(IAsyncResult iar)
        {
            TcpClient tcpc;
            int nCountReadBytes = 0;
            string strRecv;
            try
            {
                tcpc = (TcpClient)iar.AsyncState;
                nCountReadBytes = tcpc.GetStream().EndRead(iar);

                if (nCountReadBytes == 0)
                {
                    MessageBox.Show("Client disconnected");
                    return;
                }

                strRecv = Encoding.ASCII.GetString(mRX, 0, nCountReadBytes);

                printLine(strRecv);

                mRX = new byte[512];

                tcpc.GetStream().BeginRead(mRX, 0, mRX.Length, onCompleteReadFromTCPCLientStream, tcpc);


            }
            catch (Exception)
            {
                
                MessageBox.Show("Erorr with client");
            }

        }

        public void printLine(string _strPrint)
        {
            tbConsoleOutput.Invoke(new Action<string>(doInvoke), _strPrint);
        }

        public void doInvoke(string _strPrint)
        {
            tbConsoleOutput.Text = _strPrint + Environment.NewLine + tbConsoleOutput.Text;
        }

    }
}
