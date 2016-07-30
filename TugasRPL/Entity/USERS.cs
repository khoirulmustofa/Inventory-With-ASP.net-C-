using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TugasRPL.Entity
{
    [PetaPoco.TableName("USERS")]
    [PetaPoco.PrimaryKey("KODE_USERS")]
    [PetaPoco.ExplicitColumns]
    [Serializable]

    public class USERS
    {
        [PetaPoco.Column]
        public int KODE_USERS { get; set; }

        [PetaPoco.Column]
        public string NAMA_USERS { get; set; }

        [PetaPoco.Column]
        public string EMAIL_USERS { get; set; }

        [PetaPoco.Column]
        public string PASSWORDS { get; set; }

        [PetaPoco.Column]
        public string LEVELS { get; set; }
    }
}