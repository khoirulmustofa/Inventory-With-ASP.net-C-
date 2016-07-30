using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TugasRPL.Entity
{
    [PetaPoco.TableName("BARANG")]
    [PetaPoco.PrimaryKey("KODE_BARANG")]
    [PetaPoco.ExplicitColumns]
    [Serializable]

    public class BARANG
    {
        [PetaPoco.Column]
        public string KODE_BARANG { get; set; }

        [PetaPoco.Column]
        public string NAMA_BARANG { get; set; }

        [PetaPoco.Column]
        public int STOK { get; set; }

        [PetaPoco.Column]
        public int HARGA { get; set; }

        [PetaPoco.Column]
        public string KODE_SUPPLIER { get; set; }

    }
}