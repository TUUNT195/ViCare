using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViHISSrv.Services.Helper
{
    public enum ESmsGateConfig
    {
        SmsNow = 1,
        SmsGateWay = 2,
        SmsBrandName = 3
    }

    public class SmsGateWayAccount
    {
        public string Account { get; set; }
        public string Password { get; set; }
        public string CommandCode { get; set; }
        public string Description { get; set; }
        public string ShortCode { get; set; }

    }
    public class SmsBrandNameAccount
    {
        public string brnusername { get; set; }
        public string brnpassword { get; set; }
        public string brnbrandname { get; set; }
        public string brnloaitin { get; set; }

    }
    public class SmsGateConfig
    {
        public static ESmsGateConfig GetConfig()
        {
            var smsGateConfig = System.Configuration.ConfigurationManager.AppSettings["SmsGateConfig"];
            if (String.IsNullOrEmpty(smsGateConfig)) throw new Exception("The SmsGateConfig is not configurated");

            switch (smsGateConfig.Trim().ToLower())
            {
                case "smsnow": return ESmsGateConfig.SmsNow;
                case "smsgateway": return ESmsGateConfig.SmsGateWay;
                case "smsbrandname": return ESmsGateConfig.SmsBrandName;
                default:
                    {
                        throw new Exception("The SmsGateConfig invalid");
                    }
            }
        }

        public static SmsGateWayAccount GetGateWayAccount()
        {
            string account = System.Configuration.ConfigurationManager.AppSettings["account"];
            string pass = System.Configuration.ConfigurationManager.AppSettings["pass"];
            string shortcode = System.Configuration.ConfigurationManager.AppSettings["shortcode"];
            string commandcode = System.Configuration.ConfigurationManager.AppSettings["commandcode"];
            string description = System.Configuration.ConfigurationManager.AppSettings["description"];

            return new SmsGateWayAccount
            {
                Account = account,
                CommandCode = commandcode,
                Description = description,
                Password = pass,
                ShortCode = shortcode
            };
        }
        public static SmsBrandNameAccount GetBrandNameAccount()
        {
            string username = System.Configuration.ConfigurationManager.AppSettings["brnusername"];
            string password = System.Configuration.ConfigurationManager.AppSettings["brnpassword"];
            string brandname = System.Configuration.ConfigurationManager.AppSettings["brnbrandname"];
            string loaitin = System.Configuration.ConfigurationManager.AppSettings["brnloaitin"];

            return new SmsBrandNameAccount
            {
                brnusername = username,
                brnpassword = password,
                brnbrandname = brandname,
                brnloaitin = loaitin

            };
        }
    }
}
