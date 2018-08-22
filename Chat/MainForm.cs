using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{

    public partial class MainForm : Form
    {
        private SerialPort port;
        private Options optionsForm;

        public MainForm()
        {
            InitializeComponent();

         //   port = new SerialPort();
            optionsForm = new Options(this);
        }

        private void PortConfig()
        {
            port.BaudRate = PortInfo.BaudRate;
            port.DataBits = PortInfo.DataBits;
            port.PortName = PortInfo.PortName;
            port.ReadTimeout = PortInfo.TimeRead;
            port.WriteTimeout = PortInfo.TimeWrite;
            //port.Encoding = Encoding.GetEncoding("windows-1251");
            port.Encoding = PortInfo.Encoding;
            port.DataReceived += SerialPortDataReceived;
        }

        public void PortOpen()
        {
            if (port == null)
                port = new SerialPort();

            if (port.IsOpen)
                port.Close();

          //  port = new SerialPort();

            PortConfig();
            port.Open();
        }

        private void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            if (TbxChatWindow.InvokeRequired)
                TbxChatWindow.Invoke(new Action<string>((s) => TbxChatWindow.Text += s), DateTime.UtcNow.ToString() + " Interlocutor < " + port.ReadExisting() + Environment.NewLine);
            else
                TbxChatWindow.Text += (DateTime.UtcNow.ToString() + " Interlocutor < " + port.ReadExisting() + Environment.NewLine);
        }

        private void OptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            optionsForm.Show();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                TbxChatWindow.Text += (DateTime.UtcNow.ToString() + " You > " + TbxMessage.Text + Environment.NewLine);
                port.Write(TbxMessage.Text);
                TbxMessage.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Порт не открыт", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (port != null && port.IsOpen)
                port.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();

            FBD.ShowNewFolderButton = false;
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter file = new StreamWriter(FBD.SelectedPath + "Message.txt"))
                    {
                        file.WriteLine(TbxChatWindow.Text, FileMode.Create, FileAccess.Write);
                        file.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
