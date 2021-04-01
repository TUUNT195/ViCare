
using ViHISSrv.Data;
using ViHISSrv.Entities;
using log4net;
using System;
using System.Data;

namespace ViHISSrv.Business
{
    public class LH_DangKyLichHenComponent
    {
        public int DagKyLichHen_Insert(LH_DangKyLichHen obj)
        {
            try
            {
                LH_DangKyLichHenDAC tkdac = new LH_DangKyLichHenDAC();
                return tkdac.DagKyLichHen_Insert(obj);
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        //
        public int DagKyLichHen_Update(LH_DangKyLichHen obj)
        {
            try
            {
                LH_DangKyLichHenDAC tkdac = new LH_DangKyLichHenDAC();
                return tkdac.DagKyLichHen_Update(obj);
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        //
        public Int32 XacNhanLichHen(Int32 DangKyLienHen_Id, Int32 NguoiXacNhan_id)
        {
            try
            {
                LH_DangKyLichHenDAC tkdac = new LH_DangKyLichHenDAC();
                return tkdac.XacNhanLichHen(DangKyLienHen_Id,NguoiXacNhan_id);
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        //
        public Int32 UpdateMaLichHen(Int32 DangKyLienHen_Id, DateTime NgayKham)
        {
            try
            {
                LH_DangKyLichHenDAC tkdac = new LH_DangKyLichHenDAC();
                return tkdac.UpdateMaLichHen(DangKyLienHen_Id, NgayKham);
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        //
        public Int32 HuyHen(Int32 DangKyLienHen_Id, Int32 NguoiHuy_Id)
        {
            try
            {
                LH_DangKyLichHenDAC tkdac = new LH_DangKyLichHenDAC();
                return tkdac.HuyHen(DangKyLienHen_Id, NguoiHuy_Id);
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        //
        public DataTable GetLichHen_By_UserId_TuNgay_DenNgay(string SDT, string Email, DateTime TuNgay, DateTime DenNgay, int PageNum, int PageSize)
        {
            try
            {
                LH_DangKyLichHenDAC tkdac = new LH_DangKyLichHenDAC();
                return tkdac.GetLichHen_By_UserId_TuNgay_DenNgay(SDT,Email, TuNgay,DenNgay, PageNum,PageSize);
            }
            catch (Exception ex)
            {
                //log4net.Config.XmlConfigurator.Configure();
                //log.Error(ex.Message);
                return null;
            }
        }
        //
        public DataTable GetLichHen_By_DangKyLichHen_Id(int DangKyLichHen_Id)
        {
            try
            {
                LH_DangKyLichHenDAC tkdac = new LH_DangKyLichHenDAC();
                return tkdac.GetLichHen_By_DangKyLichHen_Id(DangKyLichHen_Id);
            }
            catch (Exception ex)
            {
                //log4net.Config.XmlConfigurator.Configure();
                //log.Error(ex.Message);
                return null;
            }
        }
        //
        public DataTable GetLichHen_By_UserId_TrangThai_TuNgay_DenNgay_HoTen_SDT(/*Int32 ChuyenKhoa_Id,*/Int32 UserId, DateTime TuNgay, DateTime DenNgay, int TrangThai, string TenBenhNhan, string SDT)
        {
            try
            {
                LH_DangKyLichHenDAC tkdac = new LH_DangKyLichHenDAC();
                return tkdac.GetLichHen_By_UserId_TrangThai_TuNgay_DenNgay_HoTen_SDT(/* ChuyenKhoa_Id,*/UserId, TuNgay, DenNgay, TrangThai, TenBenhNhan, SDT);
            }
            catch (Exception ex)
            {
                //log4net.Config.XmlConfigurator.Configure();
                //log.Error(ex.Message);
                return null;
            }
        }
        public DataTable GetLichHen_By_SDT(string SDT)
        {
            try
            {
                LH_DangKyLichHenDAC tkdac = new LH_DangKyLichHenDAC();
                return tkdac.GetLichHen_By_SDT(SDT);
            }
            catch (Exception ex)
            {
                //log4net.Config.XmlConfigurator.Configure();
                //log.Error(ex.Message);
                return null;
            }
        }

        public DataTable Search_LichHen(DateTime TuNgay, DateTime DenNgay, int TrangThai, string MaLichHen, string HoTen, int ChuyenKhoa_Id, int BacSi_Id, int PageNum, int PageSize)
        {
            try
            {
                LH_DangKyLichHenDAC tkdac = new LH_DangKyLichHenDAC();
                return tkdac.Search_LichHen(TuNgay, DenNgay,TrangThai, MaLichHen, HoTen, ChuyenKhoa_Id, BacSi_Id, PageNum, PageSize);
            }
            catch (Exception ex)
            {
                //log4net.Config.XmlConfigurator.Configure();
                //log.Error(ex.Message);
                return null;
            }
        }
        public DataTable Export_DSBenhNhan(DateTime TuNgay, DateTime DenNgay, int TrangThai, string MaLichHen, string HoTen, int ChuyenKhoa_Id, int BacSi_Id)
        {
            try
            {
                LH_DangKyLichHenDAC tkdac = new LH_DangKyLichHenDAC();
                return tkdac.Export_DSBenhNhan(TuNgay, DenNgay, TrangThai, MaLichHen, HoTen, ChuyenKhoa_Id, BacSi_Id);
            }
            catch (Exception ex)
            {
                //log4net.Config.XmlConfigurator.Configure();
                //log.Error(ex.Message);
                return null;
            }
        }
        //
        public DataTable GetLichHen_By_MaLichHen(string MaLichHen)
        {
            try
            {
                LH_DangKyLichHenDAC tkdac = new LH_DangKyLichHenDAC();
                return tkdac.GetLichHen_By_MaLichHen(MaLichHen);
            }
            catch (Exception ex)
            {
                //log4net.Config.XmlConfigurator.Configure();
                //log.Error(ex.Message);
                return null;
            }
        }
        //
        public DataTable DanhSachBenhNhanHenTrongNgay()
        {
            try
            {
                LH_DangKyLichHenDAC tkdac = new LH_DangKyLichHenDAC();
                return tkdac.DanhSachBenhNhanHenTrongNgay();
            }
            catch (Exception ex)
            {
                //log4net.Config.XmlConfigurator.Configure();
                //log.Error(ex.Message);
                return null;
            }
        }
        //
        public Int32 HIS_DT_KhamBenh_Update_TrangThaiLichHen(Int32 TrangThai_Id, Int32 HIS_KhamBenh_Id)
        {
            try
            {
                LH_DangKyLichHenDAC tkdac = new LH_DangKyLichHenDAC();
                return tkdac.HIS_DT_KhamBenh_Update_TrangThaiLichHen(TrangThai_Id, HIS_KhamBenh_Id);
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        //
        public DataTable CheckDatLich(DateTime TGBD, DateTime TGKT, DateTime NgayHen, int ChuyenKhoa_Id,int DangKyLichHen_Id)
        {
            try
            {
                LH_DangKyLichHenDAC tkdac = new LH_DangKyLichHenDAC();
                return tkdac.CheckDatLich(TGBD, TGKT, NgayHen, ChuyenKhoa_Id, DangKyLichHen_Id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        //
        public int Update_SMSMDaGui(Int32 KhamBenh_Id)
        {
            try
            {
                LH_DangKyLichHenDAC tkdac = new LH_DangKyLichHenDAC();
                return tkdac.Update_SMSMDaGui(KhamBenh_Id);
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        //
        public DataTable Check_DaGuiSMS(string strKhamBenh_Id)
        {
            try
            {
                LH_DangKyLichHenDAC tkdac = new LH_DangKyLichHenDAC();
                return tkdac.Check_DaGuiSMS(strKhamBenh_Id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
         //
        public int Update_LH_SMSMDaGui(Int32 DangKyLichHen_Id)
        {
            try
            {
                LH_DangKyLichHenDAC tkdac = new LH_DangKyLichHenDAC();
                return tkdac.Update_LH_SMSMDaGui(DangKyLichHen_Id);
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        //
        public DataTable Check_LH_DaGuiSMS(Int32 DangKyLichHen_Id)
        {
            try
            {
                LH_DangKyLichHenDAC tkdac = new LH_DangKyLichHenDAC();
                return tkdac.Check_LH_DaGuiSMS(DangKyLichHen_Id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
