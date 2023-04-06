using Microsoft.AspNetCore.Mvc;
using KiemTra7_3.Repository;
using KiemTra7_3.Models;

namespace KiemTra7_3.ViewComponents
{
    public class Navbar:ViewComponent
    {
        QlbongDaContext db = new QlbongDaContext();
        private readonly ITranDau _navbar;
        public Navbar(ITranDau navSpRepository)
        {
            _navbar = navSpRepository;
        }
        public IViewComponentResult Invoke()
        {
            var navbar = db.Trandaus.Take(7).ToList();
            return View(navbar);
        }
    }
}
