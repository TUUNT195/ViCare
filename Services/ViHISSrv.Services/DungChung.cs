using System;
using System.Configuration;
using System.Linq;
using System.Net.Configuration;
using System.IO;
using Newtonsoft.Json.Linq;
using log4net;

namespace ViHISSrv.Services
{
    public class DungChung
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(DungChung));

        public static string GenerateHash(string pwd, string saltAsBase64)
        {
            byte[] p1 = Convert.FromBase64String(saltAsBase64);
            return GenerateHash(pwd, p1);
        }
        public static string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
       
        public static T ConvertStreamToObject<T>(Stream t)
        {
            try
            {
                StreamReader reader = new StreamReader(t);
                string res = reader.ReadToEnd();
                reader.Close();
                reader.Dispose();
                var json = JObject.Parse(res);
                return json.ToObject<T>();
            }
            catch (Exception ex)
            {
                log4net.Config.XmlConfigurator.Configure();
                log.Error(ex.Message);
                return default(T);
            }
          
        }
        public static string GenerateHash(string pwd, byte[] saltAsByteArray)
        {
            System.Security.Cryptography.SHA1 sha = new System.Security.Cryptography.SHA1CryptoServiceProvider();

            byte[] p1 = saltAsByteArray;
            byte[] p2 = System.Text.Encoding.Unicode.GetBytes(pwd);

            byte[] data = new byte[p1.Length + p2.Length];

            p1.CopyTo(data, 0);
            p2.CopyTo(data, p1.Length);

            byte[] result = sha.ComputeHash(data);

            string res = Convert.ToBase64String(result);
            return res;
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
        /// <summary>
        /// ham nay copy tu bai DVC
        /// </summary>
        /// <param name="dulieu"></param>
        /// <returns></returns>
        public static string MaHoaMD5(string dulieu)
        {
            return BitConverter.ToString(MaHoaByte(dulieu)).Replace("-", "").ToLower();
        }
        private static byte[] MaHoaByte(string _DuLieu)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider _MD5Hasher = new

System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] _KetQua;
            System.Text.UTF8Encoding _Encoder = new System.Text.UTF8Encoding();
            _KetQua = _MD5Hasher.ComputeHash(_Encoder.GetBytes(_DuLieu));
            return _KetQua;
        }
        /// <summary>
        /// ham nay copy tu bai DVC
        /// </summary>
        /// <param name="doDai"></param>
        /// <returns></returns>
        public static string RandomNumber(int doDai)
        {
            string result = "";
            Random rand = new Random();

            for (int i = 0; i < doDai; i++)
            {
                result += rand.Next(0, 9).ToString();
            }

            return result;
        }
        
        #region Lấy cấu hình để gửi mail
        public static String FromAddress
        {
            get
            {
                SmtpSection cfg = (SmtpSection)ConfigurationManager.GetSection
                    ("system.net/mailSettings/smtp");
                return cfg.Network.UserName;
            }
        }

        public static String Password
        {
            get
            {
                SmtpSection cfg = (SmtpSection)ConfigurationManager.GetSection
                    ("system.net/mailSettings/smtp");
                return cfg.Network.Password;
            }
        }

        public static String Host
        {
            get
            {
                SmtpSection cfg = (SmtpSection)ConfigurationManager.GetSection
                    ("system.net/mailSettings/smtp");
                return cfg.Network.Host;
            }
        }

        public static int Port
        {
            get
            {
                SmtpSection cfg = (SmtpSection)ConfigurationManager.GetSection
                    ("system.net/mailSettings/smtp");
                return cfg.Network.Port;
            }
        }
        
        #endregion
    }
}