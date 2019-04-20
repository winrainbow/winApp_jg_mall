using JgMall.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JgMall
{
    public partial class JgMall : Form
    {
        public JgMall()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {

            /* DES 加解密
            string enStr = "{\"keyCol\":\"store_id,serial,paytype\",\"tableName\":\"PaytypeDetail\",\"columnNames\":[\"location_id\",\"store_id\",\"b_date\",\"serial\",\"start_time\",\"end_time\",\"paytype\",\"paytype_income\",\"time\",\"refresh_time\"],\"records\":[[\"25801\",\"25801001\",\"2018-01-0100:00:00\",\"JS0010-180101-0001\",\"2018-01-0100:00:00\",\"2018-01-0100:02:00\",\"人民币\",\"25.50\",\"2018-01-0101:02:00\",\"2018-01-0101:02:00\"],[\"25801\",\"25801001\",\"2018-01-0100:00:00\",\"JS0010-180101-0001\",\"2018-01-0100:00:00\",\"2018-01-0100:02:00\",\"微信\",\"38.50\",\"2018-01-0101:02:00\",\"2018-01-0101:02:00\"]]}";
            this.textBox1.Text = enStr.Length + "\r\n";


            string decstr = "gi14pRjG7Um6Y0mHKfuop5ekrOow2WFKiK0f/zm2rYzCIRxpOjz7o35Oq3CEAvyFV6xU+SwC6dxeiV39+Cu81VZIOyTndog+RP3K2q9JMBldXWh6Ps2rK947bRD7sSo7bLy2Iu81CyMwNSdJ5JRmfWNIGPpA+Ue5bhptSzdrnKuXpKzqMNlhSrdMuBnihYiX+jSyeToukH36+fgqFEIzrWQSjdaqHkw3OcEvNbFMQRBuGm1LN2ucq8AsTnZy1FQ9MXOlv6E+frKAr+lXeUso6yO+3UbhgPcJYVdL4RtXeITSdlqgd+a7WGv+a3/XNPs4LNN3jP31Hsu/0KEH4PqogvXTXJWJQ20LDmhUfLh2w5e6Af7h714S3i7Tn4COMlF601mnbx5CmOQedEDnws+SwTGKXh3WZsgJCUEzXnH0H//IEgUqhb+JjeereNjiENOcbLy2Iu81CyO5wyepPiSDQrdMuBnihYiXbhptSzdrnKt9i5SLBo74SrdMuBnihYiXbhptSzdrnKsK4M+MDlk7vAO766iDGmGOekFR95eO7A1svLYi7zULI6NEc7S2cyTJRYO+235qB6ZZBlfEV2NfAWy8tiLvNQsjU7A08XDIhBZu2oyPvKIeWJek4dZrDhoCt0y4GeKFiJduGm1LN2ucqwrgz4wOWTu85tToaHlKpsF6QVH3l47sDWy8tiLvNQsj18vb/DXwFbA86p9pBQKmf2y8tiLvNQsjZyerRjxGjcytBtjdL6D5y2y8tiLvNQsjB1uATkQzqMQDll+TWPE6b6AEL4jZdb+5bLy2Iu81CyMwhvIUuCO+enyBGgdrohlO5i2v0tIaO5dhV0vhG1d4hDGKXh3WZsgJ56t42OIQ05xsvLYi7zULI7nDJ6k+JINCt0y4GeKFiJduGm1LN2ucq32LlIsGjvhKt0y4GeKFiJduGm1LN2ucqwrgz4wOWTu8A7vrqIMaYY56QVH3l47sDWy8tiLvNQsjo0RztLZzJMlFg77bfmoHplkGV8RXY18BbLy2Iu81CyNTsDTxcMiEFm7ajI+8oh5Yl6Th1msOGgK3TLgZ4oWIl24abUs3a5yrCuDPjA5ZO7zm1OhoeUqmwXpBUfeXjuwNbLy2Iu81CyNOSCNlqiQvtODUVngD0JBrbLy2Iu81CyPGrHQrKryvL2FXS+EbV3iEceYOH8kBvVnsZlBikilonk66UrQmbH0UrQbY3S+g+ctsvLYi7zULIwdbgE5EM6jEA5Zfk1jxOm9YaPE+Xyvtfgtx8tRrsa77LAFxvEeBZQM=";

            string decStr = DesUtil.DecryptString(decstr);
            this.textBox1.Text = decStr + "\r\n";

            */

            string desStr = "000124";
            string result = RsaUtil.EncryptCSharp(desStr);
            this.textBox1.Text += result;
            this.textBox1.Text += "\r\n";

        }
    }
}
