using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TugasRPL.Entity;

namespace TugasRPL.CRUD
{
    public class PenjualanCRUD : BaseCRUD
    {
        public DataTable GetAllDataPenjualanAsTable()
        {
            string sql = "SELECT * FROM PENJUALAN";
            return db.ExecuteReader(sql, null);
        }

        public PENJUALAN GetPenjualanById(string id)
        {
            string sql = "SELECT * FROM PENJUALAN WHERE ID_PENJUALAN=@0";
            return db.ExecuteScalar<PENJUALAN>(sql, id);
        }

        public void Insert(PENJUALAN penjualan)
        {
            db.Insert("PENJUALAN", "ID_PENJUALAN",true,penjualan); 
        }

        public void Delete(string id)
        {
            string sql = "DELETE FROM PENJUALAN WHERE ID_PENJUALAN =@0";
            db.Execute(sql, id);
        }
        public void Isnew(PENJUALAN penjualan)
        {
            if (db.IsNew(penjualan))
            {
                db.Save("PENJUALAN", "ID_PENJUALAN", penjualan);
            }
            else {
                db.Update("PENJUALAN", "ID_PENJUALAN", penjualan);
            }
        }
    }
}