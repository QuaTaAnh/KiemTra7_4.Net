using KiemTra7_3.Models;

namespace KiemTra7_3.Repository
{
    public interface ISanVanDong
    {
        Sanvandong Add(Sanvandong tenSan);
        Sanvandong Update(Sanvandong tenSan);
        Sanvandong Delete(String idSanVanDong);
        Sanvandong GetSanVanDong(String idSanVanDong);

        IEnumerable<Sanvandong> GetAllSanVanDong();
    }
}
