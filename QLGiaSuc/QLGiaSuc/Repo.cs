using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGiaSuc
{
    class Repo // singleton pattern
    {
        public QLGiaSucContext context = null;
        public GenericRepository<LoaiGiaSuc> loaiGiaSucRepo = null;
        public GenericRepository<Dan> danRepo = null;
        public GenericRepository<Benh> benhRepo = null;
        public GenericRepository<ChamSoc> chamSocRepo = null;
        public GenericRepository<Chuong> chuongRepo = null;
        public GenericRepository<XuatChuong> xuatChuongRepo = null;
        public GenericRepository<KhoThuoc> khoThuocRepo = null;
        public GenericRepository<LoaiThuoc> loaiThuocRepo = null;
        public GenericRepository<NhanVien> nhanVienRepo = null;
        public GenericRepository<TheoDoiBenh> theoDoiBenhRepo = null;
        public GenericRepository<TiemChung> tiemChungRepo = null;
        public GenericRepository<CongViec> congViecRepo = null;
        public GenericRepository<KhuVuc> khuVucRepo = null;

        static Repo instance = null;

        private Repo()
        {
            context = new QLGiaSucContext();

            loaiGiaSucRepo = new GenericRepository<LoaiGiaSuc>(context);
            danRepo = new GenericRepository<Dan>(context);
            benhRepo = new GenericRepository<Benh>(context);
            chamSocRepo = new GenericRepository<ChamSoc>(context);
            chuongRepo = new GenericRepository<Chuong>(context);
            xuatChuongRepo = new GenericRepository<XuatChuong>(context);
            khoThuocRepo = new GenericRepository<KhoThuoc>(context);
            loaiThuocRepo = new GenericRepository<LoaiThuoc>(context);
            nhanVienRepo = new GenericRepository<NhanVien>(context);
            theoDoiBenhRepo = new GenericRepository<TheoDoiBenh>(context);
            tiemChungRepo = new GenericRepository<TiemChung>(context);
            congViecRepo = new GenericRepository<CongViec>(context);
            khuVucRepo = new GenericRepository<KhuVuc>(context);
        }

        public static Repo GetInstance()
        {
            if (instance == null)
            {
                instance = new Repo();
            }
            return instance;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
