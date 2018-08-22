using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public partial class Options : Form
    {
        private int[] baudRate = new int[] { 2400, 4800, 9600, 28800, 56000 };
        private int[] dateBits = new int[] { 5, 6, 7, 8 };
        private string[] portName = SerialPort.GetPortNames();
        private string[] encoding = new string[] { "windows-1251", "UTF-8" };
        private MainForm form;

        public Options(MainForm _form)
        {
            InitializeComponent();
            LoadAttribute();

            form = _form;
        }

        private void LoadAttribute()
        {
            for (int i = 0; i < baudRate.Length; ++i)
                CbxBaudRate.Items.Add(baudRate[i]);
            for (int i = 0; i < dateBits.Length; ++i)
                CbxDataBits.Items.Add(dateBits[i]);
            for (int i = 0; i < portName.Length; ++i)
                CbxPortName.Items.Add(portName[i]);
            for (int i = 0; i < encoding.Length; ++i)
                CbxEncoding.Items.Add(encoding[i]);
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                PortInfo.BaudRate = Convert.ToInt32(CbxBaudRate.Text);
                PortInfo.DataBits = Convert.ToInt32(CbxDataBits.Text);
                PortInfo.TimeRead = Convert.ToInt32(TbxReadTime.Text);
                PortInfo.TimeWrite = Convert.ToInt32(TbxWriteTime.Text);
                PortInfo.Encoding = Encoding.GetEncoding(CbxEncoding.Text);
                PortInfo.PortName = CbxPortName.Text;

                form.PortOpen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            this.Hide();
        }
    }
}
