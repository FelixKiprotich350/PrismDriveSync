using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrismDriveSync
{
    public partial class Browse : Form
    {
        public Browse()
        {
            InitializeComponent();
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            var myUri = new Uri("https://app.prismdrive.com/api/v1/entries");
            var myWebRequest = WebRequest.Create(myUri);
            var myHttpWebRequest = (HttpWebRequest)myWebRequest;
            myHttpWebRequest.PreAuthenticate = true;
            myHttpWebRequest.Headers.Add("Authorization", "Bearer 2379|luhCTxAKhvC1JZNeKWrIZ4Xhbu9WPoC1HP2F40yz");
            myHttpWebRequest.Accept = "application/json";

            var myWebResponse = myWebRequest.GetResponse();
            var responseStream = myWebResponse.GetResponseStream();
            if (responseStream == null) return;

            var myStreamReader = new StreamReader(responseStream, Encoding.Default);
            var json = myStreamReader.ReadToEnd();

            responseStream.Close();
            myWebResponse.Close();

            var result = JsonConvert.DeserializeObject(json);
            Console.WriteLine(result); 
        }
    }
}
