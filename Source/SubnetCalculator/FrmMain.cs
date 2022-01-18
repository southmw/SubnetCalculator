using System;
using System.Windows.Forms;

namespace SubnetCalculator
{
    public partial class FrmMain : Form
    {
        private string[] SubnetTable = {"8" , "9", "10", "11", "12", "13", "14" , "15", "16" , "17", "18" , "19", "20",
                                        "21", "22", "23", "24" , "25", "26" , "27", "28" , "29", "30", "31", "32"};

        private byte ClassA = 8;
        private byte ClassB = 16;
        private byte ClassC = 24;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            txbResult.Clear();

            cmbSourceSubnet.BeginUpdate();
            cmbSourceSubnet.Items.AddRange(SubnetTable);
            cmbSourceSubnet.EndUpdate();
            cmbSourceSubnet.SelectedItem = ClassC.ToString();

            iacSourceIP.Text = "10.1.1.0";
        }

        private string SetSubnetCIDRToNetMask(int CIDR)
        {
            UInt32 ip = 0xFFFFFFFF;
            ip <<= (32 - CIDR);

            byte[] bytearray = UintToByteArray(ip);

            return $"{bytearray[0]}.{bytearray[1]}.{bytearray[2]}.{bytearray[3]}";
        }

        private byte[] UintToByteArray(UInt32 source)
        {
            byte[] byteArray = new byte[4];

            byteArray[0] = (byte)((source & 0xFF000000) >> ClassC);
            byteArray[1] = (byte)((source & 0x00FF0000) >> ClassB);
            byteArray[2] = (byte)((source & 0x0000FF00) >> ClassA);
            byteArray[3] = (byte)((source & 0x000000FF));

            return byteArray;
        }

        private UInt32 IPStringToUint32(string ip)
        {
            UInt32 result = 0x00000000;
            string[] iparray = ip.Split('.');

            result = (result | byte.Parse(iparray[0])) << ClassA;
            result = (result | byte.Parse(iparray[1])) << ClassA;
            result = (result | byte.Parse(iparray[2])) << ClassA;
            result = (result | byte.Parse(iparray[3]));

            return result;
        }

        private string Uint32ToIpString(UInt32 ip)
        {
            string result = $"{(ip & 0xFF000000) >> 24}.{(ip & 0x00FF0000) >> 16}.{(ip & 0x0000FF00) >> 8}.{(ip & 0x000000FF)}";
            return result;
        }

        private void cmbSourceSubnet_SelectedIndexChanged(object sender, EventArgs e)
        {
            iacSourceSubnet.Text = SetSubnetCIDRToNetMask(int.Parse(cmbSourceSubnet.SelectedItem.ToString()));
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            UInt32 StartIp = IPStringToUint32(iacSourceIP.Text);
            int NetMask = 32 - int.Parse(cmbSourceSubnet.SelectedItem.ToString());

            int EndRange = (int)Math.Pow( 2, NetMask); 

            txbResult.Clear();
            txbResult.AppendText($"Current IP: {iacSourceIP.Text}\r\n");
            txbResult.AppendText($"Current Subnet[{cmbSourceSubnet.Text}]: {iacSourceSubnet.Text}\r\n");
            txbResult.AppendText($"IP Range[{EndRange}]: {Uint32ToIpString(StartIp)} ~ {Uint32ToIpString(StartIp + (UInt32)EndRange -1)}");
        }

        private void btnClassA_Click(object sender, EventArgs e)
        {
            cmbSourceSubnet.SelectedItem = ClassA.ToString();
        }

        private void btnClassB_Click(object sender, EventArgs e)
        {
            cmbSourceSubnet.SelectedItem = ClassB.ToString();
        }

        private void btnClassC_Click(object sender, EventArgs e)
        {
            cmbSourceSubnet.SelectedItem = ClassC.ToString();
        }
    }
}