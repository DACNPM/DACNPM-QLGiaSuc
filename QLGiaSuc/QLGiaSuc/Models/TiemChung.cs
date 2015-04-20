namespace QLGiaSuc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TiemChung")]
    public partial class TiemChung
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaTiemChung { get; set; }

        public int MaDan { get; set; }

        public int MaBenh { get; set; }

        [Required]
        [StringLength(10)]
        public string MaThuoc { get; set; }

        public int MuiThu { get; set; }

        public int SoLuongThuoc { get; set; }

        public DateTime Ngay { get; set; }

        public virtual Benh Benh { get; set; }

        public virtual Dan Dan { get; set; }

        public virtual KhoThuoc KhoThuoc { get; set; }
    }
}
