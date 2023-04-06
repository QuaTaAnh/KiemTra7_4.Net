using KiemTra7_3.Models;

namespace KiemTra7_3.Repository
{
    public class CTranDau : ITranDau
    {
        private readonly QlbongDaContext _context;
        public CTranDau(QlbongDaContext context)
        {
            _context = context;
        }
        public TrandauCauthu Add(TrandauCauthu tranDau)
        {
            _context.TrandauCauthus.Add(tranDau);
            _context.SaveChanges();
            return tranDau;
        }

        public TrandauCauthu Delete(string idTranDau)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Trandau> GetAllTranDau()
        {
            return _context.Trandaus.Take(7);
        }

        public TrandauCauthu GetTranDau(string idTranDau)
        {
            return _context.TrandauCauthus.Find(idTranDau);
        }

        public TrandauCauthu Update(TrandauCauthu tranDau)
        {
            _context.Update(tranDau);
            _context.SaveChanges();
            return tranDau;
        }
    }
}
