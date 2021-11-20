using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            webBrowser1.DocumentText = Properties.Resources.Intro;
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (listView1.Items[0].Selected)
            {
                webBrowser1.DocumentText = Properties.Resources.Template_1_HTML;
            } else if (listView1.Items[1].Selected)
            {
                webBrowser1.DocumentText = Properties.Resources.Template_2_HTML;
            } else if (listView1.Items[2].Selected)
            {
                webBrowser1.DocumentText = Properties.Resources.Template_3_HTML;
            } else if (listView1.Items[3].Selected)
            {
                webBrowser1.DocumentText = Properties.Resources.Template_4_HTML;
            } else if (listView1.Items[4].Selected)
            {
                webBrowser1.DocumentText = Properties.Resources.Template_5_HTML;
            } else if (listView1.Items[5].Selected)
            {
                webBrowser1.DocumentText = Properties.Resources.Template_6_HTML;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Clipboard.SetDataObject(webBrowser1.Document.Body.InnerHtml);

        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void about_Click(object sender, EventArgs e)
        {
           
            webBrowser1.DocumentText = Properties.Resources.Intro;
        }
    }

    public static class MyGlobals
    {
        public static string webpageText;
    }


}
