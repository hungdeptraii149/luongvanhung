namespace LuongVanHung_2121110123
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThanhVien")]
    public partial class ThanhVien
    {
        [Key]
        [StringLength(100)]
        public string TenDangNhap { get; set; }

        [Required]
        [StringLength(100)]
        public string MatKhau { get; set; }
        public static ThanhVien thanhvien = null;
    }

}
