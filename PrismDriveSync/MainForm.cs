using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrismDriveSync
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Btn_Select_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("selecting...");
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog()==DialogResult.OK)
            {
                textBox1.Text = f.FileName;
                richTextBox1.AppendText("selected...");
            }
            else
            {
                textBox1.Text = "";
                richTextBox1.AppendText("failed...");
            }

        }

        private void Btn_Upload_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.AppendText("uploading...");
                if (!File.Exists(textBox1.Text))
                {
                    MessageBox.Show("Message Box","Selecty file");

                    return;
                }
                richTextBox1.AppendText("file exists...");
                string requestURL = "https://app.prismdrive.com/api/v1/uploads";
                string fileName = textBox1.Text;
                WebClient wc = new WebClient();
                byte[] bytes = wc.DownloadData(fileName); // You need to do this download if your file is on any other server otherwise you can convert that file directly to bytes
                Dictionary<string, object> postParameters = new Dictionary<string, object>();
                // Add your parameters here
                //postParameters.Add("fileToUpload", new FormUpload.FileParameter(bytes, Path.GetFileName(fileName), "image/png"));
                postParameters.Add("file", new FormUpload.FileParameter(bytes, Path.GetFileName(fileName)));
               // postParameters.Add("parentId", "3173133");
                // postParameters.Add("relativePath", "3173133");
                string userAgent = "Someone";
                HttpWebResponse webResponse = FormUpload.MultipartFormPost(requestURL, userAgent, postParameters);
                // Process response
                StreamReader responseReader = new StreamReader(webResponse.GetResponseStream());
                var ResponseText = responseReader.ReadToEnd();
                webResponse.Close();
                MessageBox.Show("done");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
