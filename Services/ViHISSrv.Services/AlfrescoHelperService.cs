using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ServiceModel;
using ViHISSrv.Business;
using ViHISSrv.Entities;
using ViHISSrv.Services.Contracts;

namespace ViHISSrv.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class AlfrescoHelperService : IAlfrescoHelperService
    {
        public byte[] DownloadFileFromAlfrescoServer(string fileName)
        {
            AlfrescoHelper bc = new AlfrescoHelper();
            return bc.DownloadFileFromAlfrescoServer(fileName);
        }
    }
}
