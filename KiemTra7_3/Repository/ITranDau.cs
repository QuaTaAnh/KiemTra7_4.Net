using KiemTra7_3.Models;

namespace KiemTra7_3.Repository
{
    public interface ITranDau
    {
        TrandauCauthu Add(TrandauCauthu tranDau);
        TrandauCauthu Update(TrandauCauthu tranDau);
        TrandauCauthu Delete(String idTranDau);
        TrandauCauthu GetTranDau(String idTranDau);

        IEnumerable<Trandau> GetAllTranDau();
    }
}
