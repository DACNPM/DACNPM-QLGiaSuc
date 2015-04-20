namespace QLGiaSuc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChamSoc")]
    public partial class ChamSoc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaChamSoc { get; set; }

        public int MaCongViec { get; set; }

        public int MaDan { get; set; }

        public DateTime NgayBatDau { get; set; }

        public DateTime NgayKetThuc { get; set; }

        public int MaNhanVien { get; set; }

        public virtual CongViec CongViec { get; set; }

        public virtual Dan Dan { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
