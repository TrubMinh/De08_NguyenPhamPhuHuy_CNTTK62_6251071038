﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace De08_NguyenPhamPhuHuy_CNTTK62_6251071038
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            this.SPtheoMaus = new HashSet<SPtheoMau>();
        }
        [DisplayName("Mã sản phẩm")]
        public string MaSanPham { get; set; }

        [DisplayName("Tên sản phẩm")]
        [RegularExpression(@"^[a-zA-Zà-ỹÀ-Ỹ].*",ErrorMessage ="Chỉ nhập kí tự đầu tiên là chữ cái")]
        public string TenSanPham { get; set; }
        [DisplayName("Mã phân loại")]
        public string MaPhanLoai { get; set; }
        [DisplayName("Giá nhập")]
        [RegularExpression(@"^\d[0-9]+$", ErrorMessage = "Chỉ nhập số")]
        public Nullable<long> GiaNhap { get; set; }
        [DisplayName("Đơn giá bán nhỏ nhất")]
        [RegularExpression(@"^\d[0-9]+$", ErrorMessage = "Chỉ nhập số")]
        public Nullable<long> DonGiaBanNhoNhat { get; set; }
        [DisplayName("Đơn giá bán lớn nhất")]
        [RegularExpression(@"^\d[0-9]+$", ErrorMessage = "Chỉ nhập số")]
        public Nullable<long> DonGiaBanLonNhat { get; set; }
        [DisplayName("Trạng thái")]
        public Nullable<bool> TrangThai { get; set; }
        [DisplayName("Mô tả ngắn")]
        [RegularExpression(@"^[a-zA-Zà-ỹÀ-Ỹ].*", ErrorMessage = "Chỉ nhập kí tự đầu tiên là chữ cái")]
        public string MoTaNgan { get; set; }
        [DisplayName("Ảnh đại diện")]
        public string AnhDaiDien { get; set; }
        [DisplayName("Nổi bật")]
        public Nullable<bool> NoiBat { get; set; }
        [DisplayName("Mã phân loại phụ")]
        public string MaPhanLoaiPhu { get; set; }
        [DisplayName("Phân loại")]
        public virtual PhanLoai PhanLoai { get; set; }
        [DisplayName("Phân loại phụ")]
        public virtual PhanLoaiPhu PhanLoaiPhu { get; set; }
        [DisplayName("Sản phẩm theo mẫu")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SPtheoMau> SPtheoMaus { get; set; }
    }
}