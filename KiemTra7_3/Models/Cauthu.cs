using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KiemTra7_3.Models;

public partial class Cauthu
{
    public string CauThuId { get; set; } = null!;

    public string? HoVaTen { get; set; }

    public string? CauLacBoId { get; set; }

    public DateTime? Ngaysinh { get; set; }

    public string? ViTri { get; set; }

    public string? QuocTich { get; set; }

    [RegularExpression(@"^(?:100|[1-9][0-9]|[1-9])$", ErrorMessage = "Số áo phải nhập bằng số")]
    public string? SoAo { get; set; }

    [RegularExpression("^.*\\.png$", ErrorMessage = "Ảnh phải có đuôi là .png")] //bat buoc anh phai la jpg
    public string? Anh { get; set; }

    public virtual Caulacbo? CauLacBo { get; set; }

    public virtual ICollection<TrandauCauthu> TrandauCauthus { get; } = new List<TrandauCauthu>();

    public virtual ICollection<TrandauGhiban> TrandauGhibans { get; } = new List<TrandauGhiban>();
}
