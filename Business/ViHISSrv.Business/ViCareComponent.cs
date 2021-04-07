
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
        public DataTable Get_DangKyLichHen_Id_by_MaBenhNhan(string MaBenhNhan)
        {
            try
            {
                ViCareDAC tkdac = new ViCareDAC();
                return tkdac.Get_DangKyLichHen_Id_by_MaBenhNhan(MaBenhNhan);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        #endregion

        #region DangKyHenKB
        //Insert
        public int Insert(DangKyHenKBModel obj)
        {
            try
            {
                ViCareDAC tkdac = new ViCareDAC();
                return tkdac.Insert(obj);
            }
            catch (Exception ex)
            {
                return -2;
            }
        }
        //Update
        public int Update(DangKyHenKBModel obj)
        {
            try
            {
                ViCareDAC tkdac = new ViCareDAC();
                return tkdac.Update(obj);
            }
            catch (Exception ex)
            {
                return -2;
            }
        }
        //GetByKey
        public DataTable GetByKey(int DangKyLichHen_Id)
        {
            try
            {
                ViCareDAC tkdac = new ViCareDAC();
                return tkdac.GetByKey(DangKyLichHen_Id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //DangKyHenKB_UpdateRandomMaLichHen
        public int UpdateRandomMaLichHen(int DangKyLichHen_Id)
        {
            try
            {
                ViCareDAC tkdac = new ViCareDAC();
                return tkdac.UpdateRandomMaLichHen(DangKyLichHen_Id);
            }
            catch (Exception ex)
            {
                return -2;
            }
        }
        //GetByKey
        public DataTable LichHen_Notification()
        {
            try
            {
                ViCareDAC tkdac = new ViCareDAC();
                return tkdac.LichHen_Notification();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //GetByKey
        public DataTable TraCuuLichHen()
        {
            try
            {
                ViCareDAC tkdac = new ViCareDAC();
                return tkdac.TraCuuLichHen();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //
        //HuyLichHen
        public int HuyLichHen(int DangKyLichHen_Id, int NguoiHuy_Id)
        {
            try
            {
                ViCareDAC tkdac = new ViCareDAC();
                return tkdac.HuyLichHen(DangKyLichHen_Id, NguoiHuy_Id);
            }
            catch (Exception ex)
            {
                return -2;
            }
        }
        #endregion

        #region QMS
        //GetByKey
        public DataTable QMS_GetByCondition(string Type, int PhongBanID, int IntPara_0)
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
        public DataTable QMS_Notification(int BenhNhan_Id, string Type, int PhongBanID, int IntPara_0, int IntPara_1)
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
        public DataTable Mas_BenhNhan_GetAll()
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