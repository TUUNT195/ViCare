﻿//====================================================================================================
// Base code generated with Momentum: DAC Gen (Build 2.5.5044.27856)
// Layered Architecture Solution Guidance (http://layerguidance.codeplex.com)
//
// Generated by ThienLoi at KHANHND-LAPTOP on 08/28/2014 11:03:35 
//====================================================================================================

using log4net;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Reflection;
using ViHISSrv.Entities;
namespace ViHISSrv.Data
{

    public partial class ViCareDAC : DataAccessComponent
    {

        private string _ProcedureName = "usp_ViCare_DangKyHenKB"; // LH
        private string _ProcedureName_QMS = "usp_ViCare_QMS_Show";// App
        private string _ProcedureName_Vicare = "usp_ViCare"; // App

        #region Get info
        //
        public DataTable VC_Get_by_MaBenhNhan(string MaBenhNhan)
        {
            DataTable dt = new DataTable();
            try
            {
                Database db = DatabaseFactory.CreateDatabase(ConnectionDefine.HIS_APP);
                using (DbCommand cmd = db.GetStoredProcCommand(_ProcedureName_Vicare))
                {
                    db.AddInParameter(cmd, "@Action", DbType.String, "VC_Get_by_MaBenhNhan");
                    db.AddInParameter(cmd, "@MaBenhNhan", DbType.String, MaBenhNhan);
                    DataSet ds = new DataSet();
                    ds = db.ExecuteDataSet(cmd);
                    if (ds != null && ds.Tables.Count > 0)
                    {
                        dt = ds.Tables[0];
                    }   
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return dt;
        }
        #endregion

        #region DangKyHenKB
        //Insert
        public Int32 LH_Insert(DangKyHenKBModel obj)
        {
            Int32 iResult = Int32.MinValue;
            try
            {
                Database db = DatabaseFactory.CreateDatabase(ConnectionDefine.HIS_LICHHEN);
                using (DbCommand cmd = db.GetStoredProcCommand(_ProcedureName))
                {
                    db.AddInParameter(cmd, "@Action", DbType.String, "LH_Insert");
                    db.AddOutParameter(cmd, "@DangKyLichHen_Id", DbType.Int32, obj.DangKyLichHen_Id);
                    db.AddInParameter(cmd, "@TenBenhNhan", DbType.String, obj.TenBenhNhan);
                    db.AddInParameter(cmd, "@NgaySinh", DbType.DateTime, obj.NgaySinh);
                    db.AddInParameter(cmd, "@GioiTinh", DbType.String, obj.GioiTinh);
                    db.AddInParameter(cmd, "@SoDienThoai", DbType.String, obj.SoDienThoai);
                    db.AddInParameter(cmd, "@Email", DbType.String, obj.Email);
                    db.AddInParameter(cmd, "@NgayHen", DbType.Date, obj.NgayHen);
                    db.AddInParameter(cmd, "@ChuyenKhoa_Id", DbType.Int32, obj.ChuyenKhoa_Id);
                    db.AddInParameter(cmd, "@ThoiGianBatDau", DbType.Time, obj.ThoiGianBatDau);
                    db.AddInParameter(cmd, "@ThoiGianKetThuc", DbType.Time, obj.@ThoiGianKetThuc);
                    db.AddInParameter(cmd, "@CreateBy_Id", DbType.Int32, obj.CreateBy_Id);

                    db.ExecuteNonQuery(cmd);
                    iResult = Convert.ToInt32(cmd.Parameters["@DangKyLichHen_Id"].Value);

                    return iResult;
                }
            }
            catch (Exception ex)
            {
                return -2;
            };
        }
        //Update
        public int LH_Update(DangKyHenKBModel mol)
        {
            Int32 iResult = Int32.MinValue;
            try
            {
                Database db = DatabaseFactory.CreateDatabase(ConnectionDefine.HIS_LICHHEN);
                using (DbCommand cm = db.GetStoredProcCommand(_ProcedureName))
                {
                    db.AddInParameter(cm, "@AcTion", DbType.String, "LH_Update");
                    db.AddInParameter(cm, "@DangKyLichHen_Id", DbType.Int32, mol.DangKyLichHen_Id);
                    db.AddInParameter(cm, "@TenBenhNhan", DbType.String, mol.TenBenhNhan);
                    db.AddInParameter(cm, "@NgaySinh", DbType.Date, mol.NgaySinh);
                    db.AddInParameter(cm, "@GioiTinh", DbType.String, mol.GioiTinh);
                    db.AddInParameter(cm, "@SoDienThoai", DbType.String, mol.SoDienThoai);
                    db.AddInParameter(cm, "@Email", DbType.String, mol.Email);
                    db.AddInParameter(cm, "@NgayHen", DbType.Boolean, mol.NgayHen);
                    db.AddInParameter(cm, "@ChuyenKhoa_Id", DbType.Boolean, mol.ChuyenKhoa_Id); 
                    db.AddInParameter(cm, "@ThoiGianBatDau", DbType.Time, mol.ThoiGianBatDau);
                    db.AddInParameter(cm, "@ThoiGianKetThuc", DbType.Time, mol.ThoiGianKetThuc);
                    db.AddInParameter(cm, "@UpdateBy_Id", DbType.Int32, mol.UpdateBy_Id);

                    iResult = db.ExecuteNonQuery(cm);

                    return iResult;
                }
            }
            catch (Exception ex)
            {
                return -2;
            }
        }
        //GetByKey
        public string LH_GetByKey(int DangKyLichHen_Id)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase(ConnectionDefine.HIS_LICHHEN);
                using (DbCommand cmd = db.GetStoredProcCommand(_ProcedureName))
                {
                    db.AddInParameter(cmd, "@Action", DbType.String, "LH_GetByKey");
                    db.AddInParameter(cmd, "@DangKyLichHen_Id", DbType.Int32, DangKyLichHen_Id);
                    var obj = JsonConvert.SerializeObject(db.ExecuteDataSet(cmd).Tables[0]);
                    return obj;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //GetByKey
        public string LH_GetBy_MaLichHen(string MaLichHen)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase(ConnectionDefine.HIS_LICHHEN);
                using (DbCommand cmd = db.GetStoredProcCommand(_ProcedureName))
                {
                    db.AddInParameter(cmd, "@Action", DbType.String, "LH_GetBy_MaLichHen");
                    db.AddInParameter(cmd, "@MaLichHen", DbType.Int32, MaLichHen);
                    var obj = JsonConvert.SerializeObject(db.ExecuteDataSet(cmd).Tables[0]);
                    return obj;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //Update mã lịch hẹn
        public int LH_UpdateRandomMaLichHen(int DangKyLichHen_Id)
        {
            Int32 iResult = Int32.MinValue;
            try
            {
                Database db = DatabaseFactory.CreateDatabase(ConnectionDefine.HIS_LICHHEN);
                using (DbCommand cm = db.GetStoredProcCommand(_ProcedureName))
                {
                    db.AddInParameter(cm, "@AcTion", DbType.String, "LH_UpdateRandomMaLichHen");
                    db.AddInParameter(cm, "@DangKyLichHen_Id", DbType.Int32, DangKyLichHen_Id);

                    iResult = db.ExecuteNonQuery(cm);
                    return iResult;
                }
            }
            catch (Exception ex)
            {
                return -2;
            }
        }
        //LichHen_Notification  
        public string LH_Notification()
        {
            try
            {
                string SoNgayNhacHen = ConfigurationManager.AppSettings["SoNgayNhacHen"];
                if (string.IsNullOrEmpty(SoNgayNhacHen))
                    return null;
                Database db = DatabaseFactory.CreateDatabase(ConnectionDefine.HIS_LICHHEN);
                using (DbCommand cmd = db.GetStoredProcCommand(_ProcedureName))
                {
                    db.AddInParameter(cmd, "@Action", DbType.String, "LH_Notification");
                    db.AddInParameter(cmd, "@CreateBy_Id", DbType.Int32, Convert.ToInt32(SoNgayNhacHen));
                    var obj = JsonConvert.SerializeObject(db.ExecuteDataSet(cmd).Tables[0]);
                    return obj;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //TraCuuLichKham
        public string LH_TraCuu(string SoDienThoai)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase(ConnectionDefine.HIS_LICHHEN);
                using (DbCommand cmd = db.GetStoredProcCommand(_ProcedureName))
                {
                    db.AddInParameter(cmd, "@Action", DbType.String, "LH_TraCuu");
                    db.AddInParameter(cmd, "@SoDienThoai", DbType.String, SoDienThoai);
                    var obj = JsonConvert.SerializeObject(db.ExecuteDataSet(cmd).Tables[0]);
                    return obj;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //HuyLichHen
        public int LH_Huy(int DangKyLichHen_Id, int NguoiHuy_Id)
        {
            Int32 iResult = Int32.MinValue;
            try
            {
                Database db = DatabaseFactory.CreateDatabase(ConnectionDefine.HIS_LICHHEN);
                using (DbCommand cm = db.GetStoredProcCommand(_ProcedureName))
                {
                    db.AddInParameter(cm, "@AcTion", DbType.String, "LH_Huy");
                    db.AddInParameter(cm, "@DangKyLichHen_Id", DbType.Int32, DangKyLichHen_Id);
                    db.AddInParameter(cm, "@UpdateBy_Id", DbType.Int32, NguoiHuy_Id);

                    iResult = db.ExecuteNonQuery(cm);
                    return iResult;
                }
            }
            catch (Exception ex)
            {
                return -2;
            }
        }
        #endregion

        #region ViCare
        //VC_Get_ThongTinSinhHieu
        public string VC_Get_ThongTinSinhHieu(int DangKy_Id)
        {
            Database db = DatabaseFactory.CreateDatabase(ConnectionDefine.HIS_APP);
            try
            {
                using (DbCommand cmd = db.GetStoredProcCommand(_ProcedureName_Vicare))
                {
                    db.AddInParameter(cmd, "@Action", DbType.String, "VC_Get_ThongTinSinhHieu");
                    db.AddInParameter(cmd, "@DangKy_Id", DbType.Int32, DangKy_Id);
                    var obj = JsonConvert.SerializeObject(db.ExecuteDataSet(cmd).Tables[0]);
                    return obj;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //VC_His_KhamBenh
        public DataSet VC_His_KhamBenh(int BenhNhan_Id)
        {
            try
            {
                Database db = DatabaseFactory.CreateDatabase(ConnectionDefine.HIS_APP);
                using (DbCommand cmd = db.GetStoredProcCommand(_ProcedureName_Vicare))
                {
                    db.AddInParameter(cmd, "@Action", DbType.String, "VC_His_KhamBenh");
                    db.AddInParameter(cmd, "@BenhNhan_Id", DbType.Int32, BenhNhan_Id);
                    DataSet ds = new DataSet();
                    ds = db.ExecuteDataSet(cmd);
                    return ds;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //VC_His_CLS
        public string VC_His_CLS(int BenhNhan_Id)
        {
            Database db = DatabaseFactory.CreateDatabase(ConnectionDefine.HIS_APP);
            try
            {
                using (DbCommand cmd = db.GetStoredProcCommand(_ProcedureName_Vicare))
                {
                    db.AddInParameter(cmd, "@Action", DbType.String, "VC_His_CLS");
                    db.AddInParameter(cmd, "@BenhNhan_Id", DbType.Int32, BenhNhan_Id);
                    var obj = JsonConvert.SerializeObject(db.ExecuteDataSet(cmd).Tables[0]);
                    return obj;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //VC_His_CLS
        public string VC_His_PTTT(int BenhNhan_Id)
        {
            Database db = DatabaseFactory.CreateDatabase(ConnectionDefine.HIS_APP);
            try
            {
                using (DbCommand cmd = db.GetStoredProcCommand(_ProcedureName_Vicare))
                {
                    db.AddInParameter(cmd, "@Action", DbType.String, "VC_His_PTTT");
                    db.AddInParameter(cmd, "@BenhNhan_Id", DbType.Int32, BenhNhan_Id);
                    var obj = JsonConvert.SerializeObject(db.ExecuteDataSet(cmd).Tables[0]);
                    return obj;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region QMS
        //QMS_GetByCondition
        public string QMS_GetByCondition(string Type, int PhongBanID, int IntPara_0)
        {
            Database db = DatabaseFactory.CreateDatabase(ConnectionDefine.HIS_APP);
            try
            {
                using (DbCommand cmd = db.GetStoredProcCommand(_ProcedureName_QMS))
                {
                    db.AddInParameter(cmd, "@Action", DbType.String, "QMS_GetByCondition");
                    db.AddInParameter(cmd, "@Type", DbType.String, Type);
                    db.AddInParameter(cmd, "@PhongBanID", DbType.Int32, PhongBanID);
                    db.AddInParameter(cmd, "@IntPara_0", DbType.Int32, IntPara_0);
                    var obj = JsonConvert.SerializeObject(db.ExecuteDataSet(cmd).Tables[0]);
                    return obj;
                }
            }   
            catch (Exception ex)
            {
                return null;
            }
        }
        //            
        public string QMS_Notification(int BenhNhan_Id, string Type, int PhongBanID, int IntPara_0, int IntPara_1)
        {
            Database db = DatabaseFactory.CreateDatabase(ConnectionDefine.HIS_APP);
            try
            {
                using (DbCommand cmd = db.GetStoredProcCommand(_ProcedureName_QMS))
                {
                    db.AddInParameter(cmd, "@Action", DbType.String, "QMS_Notification");
                    db.AddInParameter(cmd, "@BenhNhan_Id", DbType.Int32, BenhNhan_Id);
                    db.AddInParameter(cmd, "@Type", DbType.String, Type);
                    db.AddInParameter(cmd, "@PhongBanID", DbType.Int32, PhongBanID);
                    db.AddInParameter(cmd, "@IntPara_0", DbType.Int32, IntPara_0);
                    db.AddInParameter(cmd, "@IntPara_1", DbType.Int32, IntPara_1);
                    var obj = JsonConvert.SerializeObject(db.ExecuteDataSet(cmd).Tables[0]);
                    return obj;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region Others
        public string Mas_BenhNhan_GetAll()
        {
            Database db = DatabaseFactory.CreateDatabase(ConnectionDefine.HIS_APP);
            try
            {
                using (DbCommand cmd = db.GetStoredProcCommand("usp_Mas_BenhNhan"))
                {
                    db.AddInParameter(cmd, "@Action", DbType.String, "GetAll");
                    var obj = JsonConvert.SerializeObject(db.ExecuteDataSet(cmd).Tables[0]);
                    return obj;
                    //ds = db.ExecuteDataSet(cmd);

                    //if (ds != null && ds.Tables.Count > 0)
                    //{
                    //    dt = ds.Tables[0];
                    //}
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion
    }
}

