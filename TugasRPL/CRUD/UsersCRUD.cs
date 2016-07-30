using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TugasRPL.Entity;

namespace TugasRPL.CRUD
{
    public class UsersCRUD : BaseCRUD
    {
        public USERS GetUserByID(string id)
        {
            string sql = "SELECT * FROM Users WHERE nama_user = @0";
            return db.SingleOrDefault<USERS>(sql, id);
        }     
    }
}