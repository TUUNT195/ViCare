using System;
using Afresco.Lib.Uti;
using System.Web.Configuration;
using log4net;
using System.IO;

namespace ViHISSrv.Business
{
    public partial class AlfrescoHelper
    {
        private const string AlfrescoPrefix = "VANTAI_";

        private static readonly string AlfrescoPath = WebConfigurationManager.AppSettings["VanTaiAlfrescoServerPath"];
        private static readonly string AlfrescoHostFtp = WebConfigurationManager.AppSettings["AlfrescoHostFTP"];
        private static readonly int MaxFileSizeMb = int.Parse(WebConfigurationManager.AppSettings["AlfrescoFileSize"]);
        private static readonly string AlfrescoUser = WebConfigurationManager.AppSettings["AlfrescoUsername"];
        private static readonly string AlfrescoPass = WebConfigurationManager.AppSettings["AlfrescoPassword"];

        private static readonly ILog Log = LogManager.GetLogger(typeof(AlfrescoHelper));
        

        public  byte[] DownloadFileFromAlfrescoServer(string fileName)
        {
            try
            {
                AlfrescoFTP alfrescoFTP = new AlfrescoFTP(AlfrescoHostFtp, AlfrescoUser, AlfrescoPass);
                Byte[] bytes = alfrescoFTP.DirectDownload(AlfrescoPath + fileName, fileName);
                return bytes;
            }
            catch (Exception ex)
            {
                log4net.Config.XmlConfigurator.Configure();
                Log.Error(ex.Message);
                return null;
            }
        }
        
    }
}
