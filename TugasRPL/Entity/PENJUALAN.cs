using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TugasRPL.Entity
{
    [PetaPoco.TableName("PENJUALAN")]
    [PetaPoco.PrimaryKey("ID_PENJUALAN")]
    [PetaPoco.ExplicitColumns]
    [Serializable]

    public class PENJUALAN
    {
        [PetaPoco.Column]
        public int ID_PENJUALAN { get; set; }

        [PetaPoco.Column]
        public string KODE_PENJUALAN { get; set; }

        [PetaPoco.Column]
        public string KODE_CUSTOMER { get; set; }

        [PetaPoco.Column]
        public string KODE_BARANG { get; set; }

        [PetaPoco.Column]
        public string JUMLAH_JUAL { get; set; }

        [PetaPoco.Column]
        public string TGL_PENJUALAN { get; set; }
    }
}
