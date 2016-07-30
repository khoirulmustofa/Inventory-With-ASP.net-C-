using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TugasRPL.Entity;

namespace TugasRPL.CRUD
{
    public class CustomerCRUD : BaseCRUD
    {
        public void Insert(CUSTOMER customer)
        {
            db.Insert("CUSTOMER", "KODE_CUSTOMER", false, customer);
        }

        public void Update(CUSTOMER customer)
        {
            db.Update("CUSTOMER", "KODE_CUSTOMER", customer);
        }
        public void Delete(string Id)
        {
            string sql = "delete from customer where kode_customer=@0";
            db.Execute(sql, Id);
        }

        public CUSTOMER GetDataById(string Id)
        {
            string sql = "SELECT * FROM CUSTOMER WHERE KODE_CUSTOMER= @0";
            return db.SingleOrDefault<CUSTOMER>(sql, Id);
        }
        public DataTable GetDisplayAllDataAsTable()
        {
            string sql = "SELECT * FROM CUSTOMER";
            return db.ExecuteReader(sql, null);
        }

        public DataTable GetDisplayVCustomer()
        {
            string sql = "select * from vcustomer";
            return db.ExecuteReader(sql, null);
        }


        public DataTable GetDisplayAllDataAsTable(string criteria)
        {
            DataTable result = null;
            try
            {
                string sql = @"SELECT * FROM CUSTOMER WHERE KODE_CUSTOMER LIKE @0 OR NAMA_CUSTOMER LIKE @0 OR 
                                ALAMAT_CUSTOMER LIKE @0 OR TELEPON_CUSTOMER LIKE @0";
                result = db.ExecuteReader(sql, "%" + criteria + "%");
            }
            catch (Exception e)
            {

            }
            return result;
        }
    }
}