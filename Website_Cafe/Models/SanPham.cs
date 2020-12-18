namespace Website_Cafe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [Key]
        public int MaSP { get; set; }

        [StringLength(50)]
        [DisplayName("Tên sản phẩm")]
        public string TenSP { get; set; }
        [DisplayName("Mô tả")]
        public string MoTa { get; set; }
        [DisplayName("Số lượng")]
        public int? SoLuong { get; set; }
        [DisplayName("Đơn giá")]
        public int? DonGia { get; set; }
        [DisplayName("Mã loại")]
        [Required]
        [StringLength(10)]
        public string MaLoai { get; set; }

        [StringLength(50)]
        [DisplayName("Ảnh")]
        public string Anh { get; set; }
    }
}
