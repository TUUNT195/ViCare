
using ViHISSrv.Data;
using ViHISSrv.Entities;
using log4net;
using System;
using System.Data;

namespace ViHISSrv.Business
{
    public class ViCareComponent
    {
        #region DangKyHenKB
        //Insert
        public int DangKyHenKB_Insert(DangKyHenKBModel obj)
        {
            try
            {
                ViCareDAC tkdac = new ViCareDAC();
                return tkdac.DangKyHenKB_Insert(obj);
            }
            catch (Exception ex)
            {
                return -2;
            }
        }
        //Update
        public int DangKyHenKB_Update(DangKyHenKBModel obj)
        {
            try
            {
                ViCareDAC tkdac = new ViCareDAC();
                return tkdac.DangKyHenKB_Update(obj);
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
        public int DangKyHenKB_UpdateRandomMaLichHen(int DangKyLichHen_Id)
        {
            try
            {
                ViCareDAC tkdac = new ViCareDAC();
                return tkdac.DangKyHenKB_UpdateRandomMaLichHen(DangKyLichHen_Id);
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
