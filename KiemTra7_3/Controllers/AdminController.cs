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
        //Chi Tiet
        public IActionResult ChiTietCauThu(string idCauThu)
        {
            var list = db.Cauthus.SingleOrDefault(x => x.CauThuId == idCauThu);
            return View(list);
        }
    }
}
