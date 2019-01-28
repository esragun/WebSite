using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web.Helpers;
using System.Web.Mvc;
using TrafficKurye.Models;
using TrafficKurye.Skallia;

namespace TrafficKurye
{
    public class FormExtension
    {   
        
        public static bool MailGonder(FormCollection model, string formAdi)
        {
            try
            {
                var _smtpClient = new SmtpClient("mail.traffickurye.com", 587);
                var _networkCredentials = new NetworkCredential("test@traffickurye.com", "ek124578!!");
                var _acc = new System.Net.Mail.MailAddress("report@traffickurye.com", "TrafficReport");

                var _tMail = new SMail(_smtpClient, _networkCredentials, _acc);
                _tMail.AddReciever("e.gun@traffickurye.com");

               

                //var _body = "Test";                

                _tMail.Body(FormVeriAl(model, formAdi).ToString());

                //_tMail.Body(_body);

                _tMail.Send();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public static StringBuilder FormVeriAl(FormCollection model,string formAdi)
        {
            var _sb = new StringBuilder();
            _sb.Append("<h1>" + formAdi + " Bilgileri" + "</h1>");
            //_sb.Append("<h1>" + model.GetType().Name+" Bilgileri" + "</h1>");
            _sb.Append("<table border=1 bordercolor=darkgreen>");

            int i = 0;
            foreach (var item in model.AllKeys)
            {
                if (i == 0)
                {
                    _sb.Append("<tr>");
                    _sb.Append("<td>");
                    _sb.Append("<h2>" + item + "</h2>");
                    _sb.Append("</td>");
                    _sb.Append("<td>");
                    var deger = model[item];
                    _sb.Append("<h2>" + deger + "</h2>");
                    _sb.Append("</td>");
                    _sb.Append("</tr>");
                    i = 1;
                }
                else
                {
                    _sb.Append("<tr"+ " bgcolor="+ "LightGrey" + ">");
                    _sb.Append("<td>");
                    _sb.Append("<h2>" + item + "</h2>");
                    _sb.Append("</td>");
                    _sb.Append("<td>");
                    var deger = model[item];
                    _sb.Append("<h2>" + deger + "</h2>");
                    _sb.Append("</td>");
                    _sb.Append("</tr>");
                    i = 0;
                }
                
                

            }

            _sb.Append("</table>");

            return _sb;
        }
        

        //foreach (var item in model.GetType().GetProperties())
        //{
        //    _sb.Append("<tr>");
        //    _sb.Append("<td>");
        //    _sb.Append("<h2>" + item.Name + "</h2>");
        //    _sb.Append("</td>");
        //    _sb.Append("<td>");
        //    _sb.Append("<h2>" + model.GetType().GetProperty(item.Name).GetValue(model) + "</h2>");
        //    _sb.Append("</td>");
        //    _sb.Append("</tr>");
        //}

    }
}
