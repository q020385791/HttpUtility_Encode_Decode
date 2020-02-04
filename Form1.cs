using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web;
using System.Net;

namespace Changeunicode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
         
            string myString = txtinput.Text;
            string Conv = HttpUtility.HtmlDecode(myString);
            result.Text = Conv;
        }

        private void Btnencode_Click(object sender, EventArgs e)
        {
           string myEncodedString = HttpUtility.HtmlEncode(txtenocde.Text);
            result.Text = myEncodedString;

            string input = txtenocde.Text;
            StringBuilder output = new StringBuilder();
            foreach (char ch in input)
            {
                if (ch > 0x7F)
                    output.AppendFormat("&#{0};", (int)ch);
                else
                    output.Append(ch);
            }
            result.Text = output.ToString();
        }
    }
}
