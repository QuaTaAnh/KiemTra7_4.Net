using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using KiemTra7_3.Models;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace KiemTra7_3.Controllers
{
	public class AdminController : Controller
	{
        QlbongDaContext db = new QlbongDaContext();
        [Route("/admin")]
        public IActionResult Index()
		{
			return View();
		}

        public IActionResult DanhMucCauThu(int? page)
        {
            //Phân trang
            int pageSize = 12;
            int pageNumber = page == null || page <= 0 ? 1 : page.Value;
            var lstSanPham = db.Cauthus.AsNoTracking().OrderBy(x => x.CauThuId);

            PagedList<Cauthu> lst = new PagedList<Cauthu>(lstSanPham, pageNumber, pageSize);
            return View(lst);
        }
        //Sửa sản phẩm
        [Route("SuaSanPham")]
        [HttpGet]
        public IActionResult SuaSanPham(string maSanPham)
        {
            ViewBag.CauLacBoId = new SelectList(db.Caulacbos.ToList(),
                "CauLacBoId", "TenClb");
            var sanpham = db.Cauthus.Find(maSanPham);
            return View(sanpham);
        }

        [Route("SuaSanPham")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SuaSanPham(Cauthu sanpham)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sanpham).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sanpham);
        }

        //Thêm mới sản phẩm
        [Route("ThemSanPham")]
        [HttpGet]
        public IActionResult ThemSanPham()
        {
            ViewBag.CauLacBoId = new SelectList(db.Caulacbos.ToList(),
                "CauLacBoId", "TenClb");
            return View();
        }

        [Route("ThemSanPham")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult themSanPham(Cauthu sanpham)
        {
            if (ModelState.IsValid)
            {
                db.Cauthus.Add(sanpham);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sanpham);
        }
	}
}
