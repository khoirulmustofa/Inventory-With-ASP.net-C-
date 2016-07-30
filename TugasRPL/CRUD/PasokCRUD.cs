using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TugasRPL.Entity;

namespace TugasRPL.CRUD
{
    public class PasokCRUD:BaseCRUD
    {
        //public void Insert(PASOK pasok)//---------UNTUK INSERT------------
        //{
        //    string sql = @"insert into barang values(@0,@1,@2,@3,@4)";
        //    db.Execute(sql, pasok.KODE_BARANG,
        //                    pasok.NAMA_BARANG,
        //                    pasok.STOK,
        //                    pasok.HARGA,
        //                    pasok.KODE_SUPPLIER
        //                    );
        //}

        public void Insert(PASOK pasok)
        {
            db.Insert("PASOK", "KODE_BARANG", false, pasok);
        }

        public void Update(PASOK pasok)//---------UNTUK UPDATE------------
        {
            db.Update(pasok);
        }

        public void Delete(string id)//---------UNTUK DELETE------------
        {
            string sql = "DELETE FROM PASOK WHERE KODE_BARANG = @0";
            db.Execute(sql, id);
        }

        public DataTable GetAllBarangAsDataTable()//---------UNTUK READ ALL------------
        {
            string sql = "SELECT * FROM PASOK";
            return db.ExecuteReader(sql, null);
        }

        public DataTable GetLookUpBarangAsTable()
        {
            string sql = "SELECT * FROM VBARANG";
            return db.ExecuteReader(sql, null);
        }

        public DataTable GetVLaporanBarangAsTable()
        {
            string sql = "SELECT * FROM vlaporanbarang";
            return db.ExecuteReader(sql, null);
        }

        public BARANG GetBarangByID(string id)//---------UNTUK READ BY ID NOT DATA TABLE------------
        {
            string sql = "SELECT * FROM BARANG WHERE KODE_BARANG = @0";
            return db.SingleOrDefault<BARANG>(sql, id);
        }

        public DataTable GetListBarangAsDataTableByCriteria(Dictionary<string, object> param)
        {
            DataTable result = null;
            try
            {
                string sql = @"SELECT * FROM BARANG WHERE 1=1 ";
                int seq = 0;
                foreach (string col in param.Keys)
                {
                    sql += "AND " + col + " LIKE @" + seq;
                    seq++;
                }

                result = db.ExecuteReader(sql, param);
            }
            catch (Exception e)
            {

            }
            return result;

        }

        internal DataTable GetAllBarangAsDataTable(string criteria, string value)
        {
            DataTable result = null;
            try
            {
                string sql = string.Format(@"SELECT * FROM BARANG WHERE {0} LIKE @0", criteria);
                result = db.ExecuteReader(sql, "%" + value + "%");
            }
            catch (Exception e)
            {

            }
            return result;
        }

    }
}