using System;
using System.Runtime.Serialization;

namespace ViHISSrv.Entities
{
    [DataContract]
    public partial class DangKyHenKBModel
    {
        [DataMember]
        public Int32 DangKyLichHen_Id { get; set; }
        [DataMember]
        public string MaLichHen { get; set; }
        [DataMember]
        public string TenBenhNhan { get; set; }
        [DataMember]
        public DateTime NgaySinh { get; set; }
        [DataMember]
        public string GioiTinh { get; set; }
        //[DataMember]
        //public Int32 NgheNghiep_Id { get; set; }
        //[DataMember]
        //public string NgheNghiep { get; set; }
        [DataMember]
        public string SoDienThoai { get; set; }
        [DataMember]
        public string Email { get; set; }
        //[DataMember]
        //public string SoNha { get; set; }
        //[DataMember]
        //public int TinhThanh_Id { get; set; }
        //[DataMember]
        //public int QuanHuyen_Id { get; set; }
        //[DataMember]
        //public int XaPhuong_Id { get; set; }
        //[DataMember]
        //public string DiaChi { get; set; }
        //[DataMember]
        //public bool IsBHYT { get; set; }
        //[DataMember]
        //public bool IsKhongBHYT { get; set; }
        //[DataMember]
        //public int LoaiDatLichHen { get; set; }
        [DataMember]
        public DateTime NgayHen { get; set; }
        //[DataMember]
        //public int BacSi_Id { get; set; }
        //[DataMember]
        //public string TenBacSi { get; set; }
        [DataMember]
        public int ChuyenKhoa_Id { get; set; }
        [DataMember]
        public string ChuyenKhoa { get; set; }
        //[DataMember]
        //public int PhongKham_Id { get; set; }
        //[DataMember]
        //public int? LichLamViecChiTiet_Id { get; set; }
        [DataMember]
        public DateTime ThoiGianBatDau { get; set; }
        [DataMember]
        public DateTime ThoiGianKetThuc { get; set; }
        //[DataMember]
        //public bool? IsXacNhan { get; set; }
        //[DataMember]
        //public int? NguoiXacNhan_Id { get; set; }
        //[DataMember]
        //public DateTime? ThoiGianXacNhan { get; set; }
        //[DataMember]
        //public bool? IsHuyHen { get; set; }
        //[DataMember]
        //public int? NguoiHuy_Id { get; set; }
        //[DataMember]
        //public DateTime? ThoiGianHuy { get; set; }
        //[DataMember]
        //public Int32 HIS_KhamBenh_Id { get; set; }
        [DataMember]
        public int? CreateBy_Id { get; set; }
        //[DataMember]
        //public DateTime? CreateDate { get; set; }
        [DataMember]
        public int? UpdateBy_Id { get; set; }
        //[DataMember]
        //public DateTime? UpdateDate { get; set; }
    }
}
