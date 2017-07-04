using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using Twilio.Clients;
using System.Net;
using System.Net.Mail;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace MyGolfSocietyApp.Forms
{
    public partial class SMS : Form
    {
        public SMS()
        {
            InitializeComponent();
        }


        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            //SendMessageUsingTwilio();
            SendMessageUsingtextlocal();
            //sendSMSClass sms = new sendSMSClass();
            //string cost = sms.send();

            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Message sent,do you want to send another message", "SMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                this.Close();
            }
        }

        private void SendMessageUsingtextlocal()//not working as did not sign up
        {
            string to, from, mess, pass;
            MailMessage message = new MailMessage();
            to = NumberTextBox.Text.ToString();
            to += "@txtlocal.co.uk";
            from = "paulwalshdbs@gmail.com";
            pass = "Mandolin1!";
            mess = MessageBodyTextBox.Text.ToString();

            message.To.Add(to);//add @txtlocal.co.uk to end of number
            message.From = new MailAddress(from);
            message.Body = mess;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        #region SMS functions



        private void SendMessageUsingTwilio()
        {
            string accountSID = "ACa8ed7ee74d1a5c998e110eb7f17e501a";
            string authToken = "6abd18d2494ca1164486a4431d948fbf";
            TwilioClient.Init(accountSID, authToken);

            try
            {
                var to = new PhoneNumber(NumberTextBox.Text);
                var message = MessageResource.Create(to, from: new PhoneNumber("353861801348"),
                    body: MessageBodyTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        #endregion

        class sendSMSClass
        {
            public string send()
            {
                using (var wb = new WebClient())
                {
                    byte[] response = wb.UploadValues("https://api.txtlocal.com/send/", new NameValueCollection()
                {
                    {"apikey" , "dE9isCUxc9Q-CNi5WYaIjVJg20GXrdwau2gzv5eEEk"},
                    {"numbers" , "00353877727879"},
                    {"message" , "This is your message"},
                    {"sender" , "GolfApp"},
                    {"test" , "1"}
                });
                    string result = System.Text.Encoding.UTF8.GetString(response);

                    dynamic resultArray = JsonConvert.DeserializeObject(result);
                    return resultArray.cost;
                }
            }
        }
    }
}
