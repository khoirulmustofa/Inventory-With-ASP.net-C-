using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TugasRPL.CRUD
{
    public class BaseCRUD
    {
        public Database db = null;
        public BaseCRUD()
        {
            db = new Database("TUGASRPLCONN");
        }
    }
}