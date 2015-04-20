namespace QLGiaSuc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("XuatChuong")]
    public partial class XuatChuong
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaXuatChuong { get; set; }

        public int MaDan { get; set; }

        public int SoLuong { get; set; }

        public DateTime NgayXuat { get; set; }

        public int GiaXuat { get; set; }

        public double TongCanNang { get; set; }

        public virtual Dan Dan { get; set; }
    }
}
