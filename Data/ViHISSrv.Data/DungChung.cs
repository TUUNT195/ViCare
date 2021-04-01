using log4net;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Reflection;

namespace ViHISSrv.Data
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
            System.Security.Cryptography.MD5CryptoServiceProvider _MD5Hasher = new System.Security.Cryptography.MD5CryptoServiceProvider();
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
        public string ConvertImageStringToBase64String(string path)
        {
            string strResult = "";
            try
            {
                if (string.IsNullOrEmpty(path) || path.Trim().Length == 0)
                    return strResult;

                Bitmap bmp = new Bitmap(path);
                TypeConverter converter = TypeDescriptor.GetConverter(typeof(Bitmap));
                strResult = Convert.ToBase64String((byte[])converter.ConvertTo(bmp, typeof(byte[])));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return strResult;
        }
        public byte[] ConvertImageStringToByte(string path)
        {
            byte[] strResult = null;
            try
            {
                if (string.IsNullOrEmpty(path) || path.Trim().Length == 0)
                    return strResult;

                Bitmap bmp = new Bitmap(path);
                TypeConverter converter = TypeDescriptor.GetConverter(typeof(Bitmap));
                strResult = (byte[])converter.ConvertTo(bmp, typeof(byte[]));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return strResult;
        }
        public byte[] ImageToByteArray(string imagepath)
        {

            FileStream fs;

            fs = new FileStream(imagepath, FileMode.Open, FileAccess.Read);

            //a byte array to read the image

            byte[] picbyte = new byte[fs.Length];

            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));

            fs.Close();

            return picbyte;
        }
        public static Int32 AddImages_ForReport(DataTable dTableReportData)
        {

            string strImageFile = "";
            string strImageFileTemp = "";
            string strColumnName = "";
            string strImgWidthColumnName = "";
            string strImgHeightColumnName = "";
            DataColumn pCol = null;
            string strConstImageName = "Add_Image_Name_";
            string strConstImageName2 = "Add_ImageNames_";
            string strColumnImageName = "";
            Int32 colCount = 0;
            Int32 colIndex = 0;
            Int32 nCount = 0;

            try
            {

                if ((dTableReportData == null) || (dTableReportData.Rows.Count == 0) || (dTableReportData.Columns.Count == 0))
                {
                    return 0;
                }

                colCount = dTableReportData.Columns.Count;
                //string strImageDirectoryInClient = Globals.StartupPath;
                //string strImageDirectoryInServer = Globals.DirectoryFileServer;

                for (colIndex = colCount - 1; colIndex >= 0; colIndex--)
                {

                    pCol = dTableReportData.Columns[colIndex];
                    strColumnImageName = "";


                    if ((pCol.DataType.FullName == "System.String") && (pCol.ColumnName.ToLower().IndexOf(strConstImageName.ToLower()) == 0))
                        strColumnImageName = strConstImageName;
                    else if ((pCol.DataType.FullName == "System.String") && (pCol.ColumnName.ToLower().IndexOf(strConstImageName2.ToLower()) == 0))
                        strColumnImageName = strConstImageName2;


                    if ((pCol.DataType.FullName == "System.String") && (strColumnImageName != ""))
                    {


                        //Get Image File Name
                        strImageFile = dTableReportData.Rows[0][pCol].ToString();
                        strImageFileTemp = strImageFile;

                        if (!(System.IO.File.Exists(strImageFile)))
                        {
                            strImageFile = strImageFileTemp;
                        }

                        //if (!(System.IO.File.Exists(strImageFile)) & strImageFileTemp.ToLower().StartsWith(@"Images\".ToLower()))
                        //{
                        //    strImageFile = strImageDirectoryInServer + @"\" + strImageFileTemp.Substring(@"Images\".Length);
                        //}


                        //Add column để đưa dữ liệu File Image vào DataTable
                        //if (pCol.ColumnName.Length > strConstImageName.Length)
                        if (pCol.ColumnName.Length > strColumnImageName.Length)
                        {
                            if (strColumnImageName == strConstImageName)
                                strColumnName = "Image_" + pCol.ColumnName.Substring(strColumnImageName.Length);
                            else
                                strColumnName = "Images" + pCol.ColumnName.Substring(strColumnImageName.Length);
                        }

                        if (!dTableReportData.Columns.Contains(strColumnName))
                        {
                            dTableReportData.Columns.Add(strColumnName, Type.GetType("System.Byte[]"));
                        }


                        //Add column để đưa dữ liệu về kích thước (Width, Height) của từng File Image
                        //strImgWidthColumnName = "Img_Width_" + pCol.ColumnName.Substring(strConstImageName.Length);
                        strImgWidthColumnName = "Img_Width_" + pCol.ColumnName.Substring(strColumnImageName.Length);
                        if (!(dTableReportData.Columns.Contains(strImgWidthColumnName)))
                        {
                            dTableReportData.Columns.Add(strImgWidthColumnName, Type.GetType("System.Int32"));
                        }

                        //strImgHeightColumnName = "Img_Height_" + pCol.ColumnName.Substring(strConstImageName.Length);
                        strImgHeightColumnName = "Img_Height_" + pCol.ColumnName.Substring(strColumnImageName.Length);
                        if (!dTableReportData.Columns.Contains(strImgHeightColumnName))
                        {
                            dTableReportData.Columns.Add(strImgHeightColumnName, Type.GetType("System.Int32"));
                        }


                        if (!string.IsNullOrEmpty(strImageFile) && System.IO.File.Exists(strImageFile))
                        {
                            System.IO.Stream objImage = null;
                            System.Drawing.Image img = null;
                            System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();

                            objImage = new System.IO.FileStream(strImageFile, System.IO.FileMode.Open, System.IO.FileAccess.Read);


                            byte[] m_buff = new byte[(int)objImage.Length];

                            img = System.Drawing.Image.FromStream(objImage);

                            //If (img.RawFormat.Equals(img.RawFormat.Gif)) Then
                            //if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Gif))
                            //{
                            //    try
                            //    {
                            //        img = ImageHelper.GetThumNailImage(objImage, img.Width, img.Height);

                            //    }
                            //    catch (Exception ex)
                            //    {
                            //        string s = ex.ToString();
                            //    }
                            //}

                            m_buff = (byte[])converter.ConvertTo(img, m_buff.GetType());
                            //objImage.Read(m_buff, 0, m_buff.Length)

                            dTableReportData.Rows[0][strColumnName] = m_buff;
                            dTableReportData.Rows[0][strImgWidthColumnName] = img.Width;
                            dTableReportData.Rows[0][strImgHeightColumnName] = img.Height;

                            if (objImage != null)
                            {
                                objImage.Close();
                                objImage.Dispose();
                                objImage = null;
                            }
                            if (img != null)
                            {
                                img.Dispose();
                                img = null;
                            }

                            nCount += 1;

                        }

                    }

                }
                return nCount;

            }
            catch (Exception ex)
            {
                string s = ex.ToString();
                return -1;
            }

            //return nCount;

        }
        public bool ConvertDataColumnToBase64String(ref DataSet dsSource)
        {
            try
            {
                if (dsSource == null || dsSource.Tables.Count == 0)
                    return true;

                foreach (DataTable dtSource in dsSource.Tables)
                {
                    AddImages_ForReport(dtSource);
                }

                //return true;
                //int icount = 1;
                //string prefix1 = "img_";
                //int prefixlen = prefix1.Length;
                //string clname = "";

                ////foreach (DataTable dtable in dsSource.Tables)
                ////{
                ////    DataTable dt = dtable.Clone();
                ////    dt.TableName = "tbl" + icount;

                ////    for (int i = 0; i < dt.Columns.Count; i++)
                ////    {
                ////        clname = dt.Columns[i].ColumnName.ToLower();
                ////        if (clname.Length >= prefixlen)
                ////        {
                ////            if (clname.Substring(0, prefixlen).Equals(prefix1))
                ////            {
                ////                dt.Columns[i].DataType = 
                ////            }
                ////        }
                ////    }
                ////}

                //dsSource.Tables[0].Columns.Add("TEST", System.Type.GetType("System.Byte[]"));

                //foreach (DataTable dtSource in dsSource.Tables)
                //{
                //    foreach (DataColumn cl in dtSource.Columns)
                //    {
                //        clname = cl.ColumnName.ToLower();
                //        if (clname.Length >= prefixlen)
                //        {
                //            if (clname.Substring(0, prefixlen).Equals(prefix1))
                //            {
                //                //dtSource.Columns[clname].ColumnName = clname + "_TMP";
                //                //dtSource.Columns.Add(clname, System.Type.GetType("System.Byte[]"));
                //                //dtSource.AcceptChanges();

                //                foreach (DataRow dr in dtSource.Rows)
                //                {
                //                    string path = dr[clname].ToString();
                //                    if (path == null || path.ToString().Trim().Equals(""))
                //                        continue;

                //                    Bitmap bmp = new Bitmap(path);
                //                    var imageConverter = new ImageConverter();

                //                    //dr.BeginEdit();
                //                    //byte[] imageByte = null;
                //                    //imageByte = ImageToByteArray(path);
                //                    ////dr[clname] = imageByte;
                //                    ////dr[clname + "_TMP"] = ConvertImageStringToBase64String(path.ToString());
                //                    //dr[clname] = Convert.ToBase64String(imageByte) ;// ConvertImageStringToBase64String(path.ToString());
                //                    dr["TEST"] = imageConverter.ConvertTo(bmp, System.Type.GetType("System.Byte[]")); ;
                //                    //dr.EndEdit();
                //                    dtSource.AcceptChanges();
                //                }
                //            }
                //        }
                //    }

                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
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

        #region Parse data to object
        public static Object ParseDataToObject(Object objClass, DataRow rowSource)
        {
            Object objResult = Convert.ChangeType(objClass, objClass.GetType());
            try
            {
                if (rowSource == null || rowSource.ItemArray.Count() == 0)
                    return objResult;

                foreach (DataColumn column in rowSource.Table.Columns)
                {
                    PropertyInfo property = objClass.GetType().GetProperty(column.ColumnName);
                    if (property != null && rowSource[column] != DBNull.Value)
                    {
                        object result = Convert.ChangeType(rowSource[column], property.PropertyType);
                        property.SetValue(objClass, result, null);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objResult;
        }
      
        #endregion Parse data to object
    }
}