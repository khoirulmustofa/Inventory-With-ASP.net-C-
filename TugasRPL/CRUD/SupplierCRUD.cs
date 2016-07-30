using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TugasRPL.Entity;

namespace TugasRPL.CRUD
{
    public class SupplierCRUD : BaseCRUD
    {
        public void Insert(SUPPLIER supplier)
        {
            db.Insert("SUPPLIER","KODE_SUPPLIER",false,supplier);
        }

        public void Update(SUPPLIER supplier)
        {
            db.Update("SUPPLIER", "KODE_SUPPLIER", supplier);
        }

        //public void Delete(SUPPLIER supplier)
        //{
        //    db.Delete<SUPPLIER>("WHERE KODE_SUPPLIER=@0", supplier);

        //}

        public void Delete(string id)
        {
            string sql = "delete from supplier where kode_supplier=@0";
            db.Execute(sql, id);
        }

        public DataTable GetAllDataSupplierAsTable()
        {
            string sql = "select * from supplier";
            return db.ExecuteReader(sql, null);
        }

        public SUPPLIER GetSupplierById(string id)//---------UNTUK READ BY ID NOT DATA TABLE------------
        {
            string sql = "SELECT * FROM SUPPLIER WHERE KODE_SUPPLIER = @0";
            return db.SingleOrDefault<SUPPLIER>(sql, id);
        }

        internal DataTable GetVLaporanSupplierAsTable()
        {
            return db.ExecuteReader("select * from vlaporansupplier", null);
        }
    }
}