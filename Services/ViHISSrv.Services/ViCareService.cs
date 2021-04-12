﻿//====================================================================================================
// Base code generated with Velocity: SL Gen (Build 2.4.5044.27855)
// Layered Architecture Solution Guidance (http://layerguidance.codeplex.com)
//
// Generated by MICAE_VI at BU-VILCH on 09/08/2014 17:33:15 
//====================================================================================================

using ViHISSrv.Business;
using ViHISSrv.Entities;
using ViHISSrv.Services.Contracts;
using log4net;
using System;
using System.Data;
using System.ServiceModel;

namespace ViHISSrv.Services
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]

    public class ViCareService : IViCareService
    {
        #region Get info
        public string GetInfoBy_MabenhNhan(string MaBenhNhan)
        {
            int DangKyLichHen_Id = Int32.MinValue;
            ViCareComponent objc = new ViCareComponent();
            DataTable dt1 = objc.Get_DangKyLichHen_Id_by_MaBenhNhan(MaBenhNhan);
            if (dt1.Rows[0]["Ref_DangKyLichHen_Id"] != null)
                DangKyLichHen_Id = Convert.ToInt32(dt1.Rows[0]["Ref_DangKyLichHen_Id"]);
            var dt2 = objc.GetByKey(DangKyLichHen_Id);
            return dt2;
        }
        #endregion

        #region DangKyHenKB
        //DangKyHenKB_Insert
        public int Insert(DangKyHenKBModel obj)
        {
            ViCareComponent objc = new ViCareComponent();
            return objc.Insert(obj);
        }
        //DangKyHenKB_Update
        public int Update(DangKyHenKBModel obj)
        {
            ViCareComponent objc = new ViCareComponent();
            return objc.Update(obj);
        }
        //GetByKey
        public string GetByKey(int DangKyLichHen_Id)
        {
            ViCareComponent objc = new ViCareComponent();
            return objc.GetByKey(DangKyLichHen_Id);
        }
        //DangKyHenKB_UpdateRandomMaLichHen
        public Int32 UpdateRandomMaLichHen(int DangKyLichHen_Id)
        {
            ViCareComponent objc = new ViCareComponent();
            return objc.UpdateRandomMaLichHen(DangKyLichHen_Id);
        }
        //GetByKey
        public string LichHen_Notification()
        {
            ViCareComponent objc = new ViCareComponent();
            return objc.LichHen_Notification();
        }
        //TraCuuLichKham
        public string TraCuuLichHen(string SoDienThoai)
        {
            ViCareComponent objc = new ViCareComponent();
            return objc.TraCuuLichHen(SoDienThoai);
        }
        //HuyLichHen
        public int HuyLichHen(int DangKyLichHen_Id,int NguoiHuy_Id)
        {
            ViCareComponent objc = new ViCareComponent();
            return objc.HuyLichHen(DangKyLichHen_Id, NguoiHuy_Id);
        }
        #endregion

        #region QMS
        //QMS_GetByCondition
        public string QMS_GetByCondition(string Type, int PhongBanID, int IntPara_0)
        {
            ViCareComponent objc = new ViCareComponent();
            return objc.QMS_GetByCondition(Type, PhongBanID, IntPara_0);
        }
        //QMS_Notification
        public string QMS_Notification(int BenhNhan_Id, string Type, int PhongBanID, int IntPara_0, int IntPara_1)
        {
            ViCareComponent objc = new ViCareComponent();
            return objc.QMS_Notification(BenhNhan_Id, Type, PhongBanID, IntPara_0, IntPara_1);
        }
        #endregion

        #region Others
        public string Mas_BenhNhan_GetAll()
        {
            ViCareComponent objc = new ViCareComponent();
            return objc.Mas_BenhNhan_GetAll();
        }
        #endregion

    }
}
