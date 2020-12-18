namespace Website_Cafe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiSP")]
    public partial class LoaiSP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaLoai { get; set; }

        [StringLength(50)]
        [DisplayName("Tên loại")]
        public string TenLoai { get; set; }

        [StringLength(50)]
        [DisplayName("Ghi chú")]
        public string GhiChu { get; set; }
    }
}
