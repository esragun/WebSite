using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Web;

namespace TrafficKurye.Skallia
{
    public class SMail
    {
        public virtual NetworkCredential NetworkCredential { get; set; }
        public virtual SmtpClient SmtpClient { get; set; }
        public virtual MailAddress MailAddressSender { get; set; }
        //public virtual List<MailAddress> ListMailAddressRecieverDefault { get; set; } = new List<MailAddress>();
        public List<MailAddress> ListMailAddressReciever = new List<MailAddress>();
        public MailMessage MailMessage = new MailMessage();
        public bool IsBodyHtml = true;
        public bool EnableSsl = false;


        public SMail() { }
        public SMail(SmtpClient smtpClient, NetworkCredential networkCredential)
        {
            Build(smtpClient, networkCredential);
        }
        public SMail(SmtpClient smtpClient, NetworkCredential networkCredential, MailAddress mailAddressSender)
        {
            Build(smtpClient, networkCredential);
            SetSender(mailAddressSender);
        }
        public SMail(SmtpClient smtpClient, NetworkCredential networkCredential, string mailAddressSender)
        {
            Build(smtpClient, networkCredential);
            SetSender(mailAddressSender);
        }
        public SMail(SenderInfo model)
        {
            Build(model.SmtpClient, model.NetworkCredential);
            SetSender(model.MailAddressSender);
            Subject(model.Subject);
        }

        private void Build(SmtpClient smtpClient, NetworkCredential networkCredential)
        {
            this.SmtpClient = smtpClient;
            this.NetworkCredential = networkCredential;
        }
        private void PrepareToSend()
        {
            AddReciever(this.ListMailAddressReciever);
            this.MailMessage.IsBodyHtml = this.IsBodyHtml;

            SmtpClient.EnableSsl = this.EnableSsl;
            SmtpClient.Credentials = this.NetworkCredential;
        }

        public void SetSender(MailAddress mailAddress)
        {
            MailMessage.From = mailAddress;
        }
        public void SetSender(string mailAddress)
        {
            SetSender(new MailAddress(mailAddress));
        }
        public void AddReciever(string mailAddress)
        {
            this.MailMessage.To.Add(mailAddress);
        }
        public void AddReciever(MailAddress mailAddress)
        {
            this.MailMessage.To.Add(mailAddress);
        }
        public void AddReciever(List<string> listMailAddress)
        {
            listMailAddress.ForEach(_mailAddress => { AddReciever(_mailAddress); });
        }
        public void AddReciever(List<MailAddress> listMailAddress)
        {
            listMailAddress.ForEach(_mailAddress => { AddReciever(_mailAddress); });
        }
        public void AddBCC(string mailAddress)
        {
            this.MailMessage.Bcc.Add(mailAddress);
        }
        public void AddBCC(MailAddress mailAddress)
        {
            this.MailMessage.Bcc.Add(mailAddress);
        }
        public void AddBCC(List<string> listMailAddress)
        {
            listMailAddress.ForEach(_mailAddress => { AddBCC(_mailAddress); });
        }
        public void AddBCC(List<MailAddress> listMailAddress)
        {
            listMailAddress.ForEach(_mailAddress => { AddBCC(_mailAddress); });
        }
        public void AddReplyTo(string mailAddress)
        {
            this.MailMessage.ReplyToList.Add(mailAddress);
        }
        public void AddReplyTo(MailAddress mailAddress)
        {
            this.MailMessage.ReplyToList.Add(mailAddress);
        }
        public void AddReplyTo(List<string> listMailAddress)
        {
            listMailAddress.ForEach(_mailAddress => { AddReplyTo(_mailAddress); });
        }
        public void AddReplyTo(List<MailAddress> listMailAddress)
        {
            listMailAddress.ForEach(_mailAddress => { AddReplyTo(_mailAddress); });
        }
        public void AddAttachment(Attachment attachment)
        {
            MailMessage.Attachments.Add(attachment);
        }
        public void AddAttachment(List<Attachment> attachment)
        {
            attachment.ForEach(_attachment => AddAttachment(_attachment));
        }
        public void Content(string subject, string body)
        {
            Subject(subject);
            Body(body);
        }
        public void Subject(string subject)
        {
            this.MailMessage.Subject = subject;
        }
        public void Body(string body)
        {
            this.MailMessage.Body = body;
        }

        public bool Send(string userName = "")
        {
            var _result = false;
            try
            {
                PrepareToSend();
                SmtpClient.Send(this.MailMessage);
                _result = true;
            }
            catch (Exception ex) { _result = false; }
            finally { MailMessage.Dispose(); }

            return _result;
        }



       /// <summary>
       /// //////////////// ******!!!!!!******//////////////////
       /// </summary>
       /// <param name="emailAdsress"></param>
       /// <returns></returns>
        public bool CheckMailAddress(string emailAdsress)
        {


            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(emailAdsress);
            return match.Success;


        }

        public class SenderInfo
        {
            public SenderInfo(SmtpClient smtpClient, NetworkCredential networkCredential, MailAddress mailAddressSender, string subject)
            {
                SmtpClient = smtpClient;
                NetworkCredential = networkCredential;
                MailAddressSender = mailAddressSender;
                Subject = subject;
            }
            public SmtpClient SmtpClient;
            public NetworkCredential NetworkCredential;
            public MailAddress MailAddressSender;
            public string Subject;
        }

    }
}