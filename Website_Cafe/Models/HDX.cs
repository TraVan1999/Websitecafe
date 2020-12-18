namespace Website_Cafe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HDX")]
    public partial class HDX
    {
        [Key]
        public int maHDX { get; set; }

        [StringLength(50)]
        [DisplayName("Tên khách hàng")]
        public string tenKH { get; set; }

        [StringLength(50)]
        [DisplayName("Địa chỉ")]
        public string diaChi { get; set; }
        [DisplayName("Số điện thoại")]
        public int? sdt { get; set; }
        [DisplayName("Ngày xuất")]
        public DateTime? ngayXuat { get; set; }
        [DisplayName("Tổng tiền")]
        public double? tongtien { get; set; }
    }
}
