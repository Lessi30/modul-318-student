using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissTransportGui
{
    class Mail
    {
        string receiverAddress;
        string subject;
        string content;
        public Mail(string receiverAddress, string subject, string content)
        {
            this.receiverAddress = receiverAddress;
            this.subject = subject;
            this.content = content;
        }
        public void SendMail()
        {
            Process.Start("mailto:" + receiverAddress + "?subject=" + subject + "&body="+ content);
        }
    }
}
