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
        public DataTable GetByKey(int DangKyLichHen_Id)
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
        public DataTable LichHen_Notification()
        {
            ViCareComponent objc = new ViCareComponent();
            return objc.LichHen_Notification();
        }
        //TraCuuLichKham
        public DataTable TraCuuLichKham()
        {
            ViCareComponent objc = new ViCareComponent();
            return objc.TraCuuLichKham();
        }
        //HuyLichHen
        public int HuyLichHen(int DangKyLichHen_Id)
        {
            ViCareComponent objc = new ViCareComponent();
            return objc.HuyLichHen(DangKyLichHen_Id);
        }
        #endregion

        #region QMS
        //QMS_GetByCondition
        public DataTable QMS_GetByCondition(string Type, int PhongBanID, int IntPara_0)
        {
            ViCareComponent objc = new ViCareComponent();
            return objc.QMS_GetByCondition(Type, PhongBanID, IntPara_0);
        }
        //QMS_Notification
        public DataTable QMS_Notification(int BenhNhan_Id, string Type, int PhongBanID, int IntPara_0)
        {   
            ViCareComponent objc = new ViCareComponent();
            return objc.QMS_Notification(BenhNhan_Id, Type, PhongBanID, IntPara_0);  
        }
        #endregion

        #region Others
        public DataTable Mas_BenhNhan_GetAll()
        {
            ViCareComponent objc = new ViCareComponent();
            return objc.Mas_BenhNhan_GetAll();
        }
        #endregion

    }
}
