using KiemTra7_3.Models;

namespace KiemTra7_3.Repository
{
    public class CSanVanDong : ISanVanDong
    {
        private readonly QlbongDaContext _context;
        public CSanVanDong(QlbongDaContext context)
        {
            _context = context;
        }
        public Sanvandong Add(Sanvandong tenSan)
        {
            _context.Sanvandongs.Add(tenSan);
            _context.SaveChanges();
            return tenSan;
        }

        public Sanvandong Delete(string idSanVanDong)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sanvandong> GetAllSanVanDong()
        {
            return _context.Sanvandongs.Take(7);
        }

        public Sanvandong GetSanVanDong(string idSanVanDong)
        {
            return _context.Sanvandongs.Find(idSanVanDong);
        }

        public Sanvandong Update(Sanvandong tenSan)
        {
            _context.Update(tenSan);
            _context.SaveChanges();
            return tenSan;
        }
    }
}
