using System;
using System.Collections.Generic;

namespace KiemTra7_3.Models;

public partial class Sanvandong
{
    public string SanVanDongId { get; set; } = null!;

    public string? TenSan { get; set; }

    public string? ThanhPho { get; set; }

    public int? NamBatDau { get; set; }

    public string? Anh { get; set; }

    public virtual ICollection<Caulacbo> Caulacbos { get; } = new List<Caulacbo>();

    public virtual ICollection<Trandau> Trandaus { get; } = new List<Trandau>();
}
