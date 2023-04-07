using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using KiemTra7_3.Models;
using KiemTra7_3.Models.ProductModels;

namespace KiemTra7_3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsAPIController : ControllerBase
    {
        QlbongDaContext db = new QlbongDaContext();
        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            var products = (from a in db.Caulacbos
                            join b in db.Cauthus on a.CauLacBoId equals b.CauLacBoId
                            select new Product
                            {
                                IdCauThu = b.CauThuId,
                                IdSanVanDong = a.SanVanDongId,
                                TenCauThu = b.HoVaTen,
                                AnhCauThu = b.Anh,
                                QuocGia = b.QuocTich,
                            }).ToList();
            return products;
        }

        [HttpGet("{SanVanDongId}")]
        public IEnumerable<Product> GetProductsByCategory(string SanVanDongId)
        {
            var products = (from a in db.Caulacbos
                            join b in db.Cauthus on a.CauLacBoId equals b.CauLacBoId
                            where a.SanVanDongId == SanVanDongId
                            select new Product
                            {
                                IdCauThu = b.CauThuId,
                                IdSanVanDong = a.SanVanDongId,
                                TenCauThu = b.HoVaTen,
                                AnhCauThu = b.Anh,
                                QuocGia = b.QuocTich,
                            }).ToList();
            return products;
        }
    }
}
