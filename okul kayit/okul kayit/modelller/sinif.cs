using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace okul_kayit.modelller
{
    public class sinif
    {
        public int Id { get; set; }

        public string? sube { get; set; }
        public int seviye { get; set; }

        public virtual ObservableCollectionListSource<ogrenciler>? ogenci { get; set; }
    }
}
