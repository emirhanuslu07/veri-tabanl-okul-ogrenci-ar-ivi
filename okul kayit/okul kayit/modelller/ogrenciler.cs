using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okul_kayit.modelller
{
    public class ogrenciler
    {
        public int Id { get; set; }
        public int okulno { get; set; }
        public string? ad { get; set; }
        public string? soyad { get; set; }

        public virtual sinif? Sınıf { get; set; }
    }
}
