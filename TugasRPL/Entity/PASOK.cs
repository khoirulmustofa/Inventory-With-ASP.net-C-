using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TugasRPL.Entity
{
    [PetaPoco.TableName("PASOK")]
    [PetaPoco.PrimaryKey("KODE_PASOK")]
    [PetaPoco.ExplicitColumns]
    [Serializable]

    public class PASOK
    {
        [PetaPoco.Column]
        public string KODE_PASOK { get; set; }

        [PetaPoco.Column]
        public string KODE_BARANG { get; set; }

        [PetaPoco.Column]
        public DateTime TGL_PASOK { get; set; }

        [PetaPoco.Column]
        public int JUMLAH_BARANG { get; set; }


    }
}