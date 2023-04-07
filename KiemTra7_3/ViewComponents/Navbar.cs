using Microsoft.AspNetCore.Mvc;
using KiemTra7_3.Repository;
using KiemTra7_3.Models;

namespace KiemTra7_3.ViewComponents
{
    public class Navbar:ViewComponent
    {
        QlbongDaContext db = new QlbongDaContext();
        private readonly ISanVanDong _navbar;
        public Navbar(ISanVanDong navSpRepository)
        {
            _navbar = navSpRepository;
        }
        public IViewComponentResult Invoke()
        {
            var navbar = _navbar.GetAllSanVanDong().OrderBy(x => x.TenSan);
            return View(navbar);
        }
    }
}
