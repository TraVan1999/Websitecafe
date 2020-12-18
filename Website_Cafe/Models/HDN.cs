namespace Website_Cafe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HDN")]
    public partial class HDN
    {
        [Key]
        public int maHDN { get; set; }

        [StringLength(50)]
        [DisplayName("Tên nhân viên")]
        public string tenNV { get; set; }
        [DisplayName("Ngày nhập")]
        public DateTime? ngayNhap { get; set; }
        [DisplayName("Tổng tiền")]
        public double? tongtien { get; set; }
    }
}
