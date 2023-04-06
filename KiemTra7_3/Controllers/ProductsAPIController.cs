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
            var products = (from a in db.TrandauCauthus
                            join b in db.Cauthus on a.CauThuId equals b.CauThuId
                            select new Product
                            {
                                IdCauThu = a.CauThuId,
                                IdTranDau = a.TranDauId,
                                TenCauThu = b.HoVaTen,
                                AnhCauThu = b.Anh,
                                QuocGia = b.QuocTich,
                            }).ToList();
            return products;
        }

        [HttpGet("{TranDauId}")]
        public IEnumerable<Product> GetProductsByCategory(string TranDauId)
        {
            var products = (from a in db.TrandauCauthus
                            join b in db.Cauthus on a.CauThuId equals b.CauThuId
							where a.TranDauId == TranDauId
							select new Product
                            {
                                IdCauThu = a.CauThuId,
                                IdTranDau = a.TranDauId,
                                TenCauThu = b.HoVaTen,
                                AnhCauThu = b.Anh,
                                QuocGia = b.QuocTich,
                            }).ToList();
            return products;
        }
    }
}
