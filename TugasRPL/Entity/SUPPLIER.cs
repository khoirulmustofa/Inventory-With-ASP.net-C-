using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TugasRPL.Entity
{
    [PetaPoco.TableName("SUPPLIER")]
    [PetaPoco.PrimaryKey("KODE_SUPPLIER")]
    [PetaPoco.ExplicitColumns]
    [Serializable]

    public class SUPPLIER
    {
        [PetaPoco.Column]
        public string KODE_SUPPLIER { get; set; }

        [PetaPoco.Column]
        public string NAMA_SUPPLIER { get; set; }

        [PetaPoco.Column]
        public string ALAMAT_SUPPLIER { get; set; }

        [PetaPoco.Column]
        public string TELEPON_SUPPLIER { get; set; }
    }
}