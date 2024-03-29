﻿
using ViHISSrv.Data;
using ViHISSrv.Entities;
using log4net;
using System;
using System.Data;

namespace ViHISSrv.Business
{
    public class ViCareComponent
    {
        #region Get info
        //GetByKey
        public DataTable VC_Get_by_MaBenhNhan(string MaBenhNhan)
        {
            try
            {
                ViCareDAC tkdac = new ViCareDAC();
                return tkdac.VC_Get_by_MaBenhNhan(MaBenhNhan);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region DangKyHenKB
        //Insert
        public int LH_Insert(DangKyHenKBModel obj)
        {
            try
            {
                ViCareDAC tkdac = new ViCareDAC();
                return tkdac.LH_Insert(obj);
            }
            catch (Exception ex)
            {
                return -2;
            }
        }
        //Update
        public int LH_Update(DangKyHenKBModel obj)
        {
            try
            {
                ViCareDAC tkdac = new ViCareDAC();
                return tkdac.LH_Update(obj);
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
                ViCareDAC tkdac = new ViCareDAC();
                return tkdac.LH_GetByKey(DangKyLichHen_Id);
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
                ViCareDAC tkdac = new ViCareDAC();
                return tkdac.LH_GetBy_MaLichHen(MaLichHen);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //DangKyHenKB_UpdateRandomMaLichHen
        public int LH_UpdateRandomMaLichHen(int DangKyLichHen_Id)
        {
            try
            {
                ViCareDAC tkdac = new ViCareDAC();
                return tkdac.LH_UpdateRandomMaLichHen(DangKyLichHen_Id);
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
                ViCareDAC tkdac = new ViCareDAC();
                return tkdac.LH_Notification();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //TraCuuLichHen
        public string LH_TraCuu(string SoDienThoai)
        {
            try
            {
                ViCareDAC tkdac = new ViCareDAC();
                return tkdac.LH_TraCuu(SoDienThoai);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //
        //HuyLichHen
        public int LH_Huy(int DangKyLichHen_Id, int NguoiHuy_Id)
        {
            try
            {
                ViCareDAC tkdac = new ViCareDAC();
                return tkdac.LH_Huy(DangKyLichHen_Id, NguoiHuy_Id);
            }
            catch (Exception ex)
            {
                return -2;
            }
        }
        #endregion

        #region ViCare
        //TraCuuLichHen
        public string VC_Get_ThongTinSinhHieu(int DangKy_Id)
        {
            try
            {
                ViCareDAC tkdac = new ViCareDAC();
                return tkdac.VC_Get_ThongTinSinhHieu(DangKy_Id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //
        public DataSet VC_His_KhamBenh(int BenhNhan_Id)
        {
            try
            {
                ViCareDAC tkdac = new ViCareDAC();
                return tkdac.VC_His_KhamBenh(BenhNhan_Id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //
        public string VC_His_CLS(int BenhNhan_Id)
        {
            try
            {
                ViCareDAC tkdac = new ViCareDAC();
                return tkdac.VC_His_CLS(BenhNhan_Id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //
        public string VC_His_PTTT(int BenhNhan_Id)
        {
            try
            {
                ViCareDAC tkdac = new ViCareDAC();
                return tkdac.VC_His_PTTT(BenhNhan_Id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region QMS
        //GetByKey
        public string QMS_GetByCondition(string Type, int PhongBanID, int IntPara_0)
        {
            try
            {
                ViCareDAC tkdac = new ViCareDAC();  
                return tkdac.QMS_GetByCondition(Type, PhongBanID, IntPara_0);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //
        public string QMS_Notification(int BenhNhan_Id, string Type, int PhongBanID, int IntPara_0, int IntPara_1)
        {
            try
            {
                ViCareDAC tkdac = new ViCareDAC();
                return tkdac.QMS_Notification(BenhNhan_Id, Type, PhongBanID, IntPara_0, IntPara_1);
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
            try
            {
                ViCareDAC tkdac = new ViCareDAC();
                return tkdac.Mas_BenhNhan_GetAll();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

    }
}