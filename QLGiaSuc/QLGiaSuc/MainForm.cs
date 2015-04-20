using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGiaSuc
{
    public partial class MainForm : Form
    {
        Repo repo = Repo.GetInstance();
        public MainForm()
        {
            InitializeComponent();
            
            //var s = Repo.GetInstance().danRepo.Get().FirstOrDefault();

            // huong dan su dung!
            // insert

            LoaiGiaSuc loai1 = new LoaiGiaSuc();
            loai1.MaLoaiGiaSuc = 1;
            loai1.TenLoaiGiaSuc = "heo";

            // bat ngoai le trung khoa chinh
            try
            {
                repo.loaiGiaSucRepo.Insert(loai1);
                repo.loaiGiaSucRepo.Save();
            }
            catch (Exception ex)
            {
                repo.loaiGiaSucRepo.Delete(loai1);
            }

            

            // update
            loai1.TenLoaiGiaSuc = "bo";
            try
            {
                repo.loaiGiaSucRepo.Update(loai1);
                repo.loaiGiaSucRepo.Save();
            }
            catch (Exception ex)
            {
            }

            // delete

            repo.loaiGiaSucRepo.Delete(loai1);
            repo.loaiGiaSucRepo.Save();

            //hoac
            // repo.loaiGiaSucRepo.Delete(loai1.MaLoaiGiaSuc);
            // repo.loaiGiaSucRepo.Save();

            // get du lieu tu bang

            var query = repo.loaiGiaSucRepo.Get();

            // truy van

            var query2 = from s in repo.context.LoaiGiaSucs
                         where s.MaLoaiGiaSuc == 1
                         select s;

        }

        
    }
}
