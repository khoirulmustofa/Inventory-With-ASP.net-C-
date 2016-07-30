using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TugasRPL.Entity
{
    [PetaPoco.TableName("CUSTOMER")]
    [PetaPoco.PrimaryKey("KODE_CUSTOMER")]
    [PetaPoco.ExplicitColumns]
    [Serializable]

    public class CUSTOMER
    {
        [PetaPoco.Column]
        public string KODE_CUSTOMER { get; set; }

        [PetaPoco.Column]
        public string NAMA_CUSTOMER { get; set; }

        [PetaPoco.Column]
        public string ALAMAT_CUSTOMER { get; set; }

        [PetaPoco.Column]
        public string TELEPON_CUSTOMER { get; set; }
    }
}