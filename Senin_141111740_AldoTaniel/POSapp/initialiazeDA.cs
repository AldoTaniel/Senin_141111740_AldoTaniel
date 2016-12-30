using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace LatihanPos
{
    class initialiazeDA
    {
            public string conn;
            public MySqlConnection connect;
            public MySqlCommand insertBarang;
            public MySqlCommand insertCustomer;
            public MySqlCommand insertSuplier;
            public MySqlCommand insertPenjualan;
            public MySqlCommand insertTransaksi;
            public MySqlCommand insertPembelian;
            public MySqlCommand insertTransaksiPembelian;

            public string penjualanSelectSql;
            public string transaksiPembelianSelectSql;
            public string pembelianSelectSql;

            public string transaksiSelectSql;  
            public string barangSelectSql;
            public string suplierSelectSql;
            public string customerSelectSql;
            public MySqlDataAdapter barangDA = new MySqlDataAdapter();
            public MySqlDataAdapter customerDA = new MySqlDataAdapter();
            public MySqlDataAdapter suplierDA = new MySqlDataAdapter();
            public MySqlDataAdapter penjualanDA = new MySqlDataAdapter();
            public MySqlDataAdapter transaksiDA = new MySqlDataAdapter();
            public MySqlDataAdapter pembelianDA = new MySqlDataAdapter();
            public MySqlDataAdapter transaksiPembelianDA = new MySqlDataAdapter();


        public void db_connection()
            {
                try
                {
                    conn = "Server=localhost;Database=posapp;Uid=root;Pwd=;";
                    connect = new MySqlConnection(conn);
                    connect.Open();
                }
                catch (MySqlException e)
                {
                    throw;
                }
            }
          
        public void TampilBarang() {
                barangSelectSql = string.Concat("select * from tblbarang");
                barangDA.SelectCommand = new MySqlCommand(barangSelectSql, connect);
        }
        public void Barang(string kodeBarang, string idsupplier, string namaBarang, string jlhAwal, string hargaHPP, string hargaJual,int kode) {
            string barangInsertSql = string.Concat("INSERT INTO tblbarang(kodeBarang,kodesuplier,namaBarang,jlhAwal,hrgHPP,hrgJual,created_at,update_at)VALUES(@kodeBarang,@idsupplier,@namaBarang,@jlhAwal,@hargaHPP,@hargaJual,@created_at,@update_at)");
            string barangUpdateSql = string.Concat("update tblbarang set kodesuplier=@idsupplier,namaBarang=@namaBarang,jlhAwal=@jlhAwal,hrgHPP=@hargaHPP,hrgJual=@hargaJual,update_at=@update_at where kodeBarang=@kodeBarang");
            string barangDeleteSql = string.Concat("delete from tblbarang where kodeBarang=@kodeBarang");
            if (kode == 0)
            {
                insertBarang = new MySqlCommand(barangInsertSql, connect);
            }
            else if (kode == 2) {
                insertBarang = new MySqlCommand(barangDeleteSql, connect);
            }
            else
            {
                insertBarang = new MySqlCommand(barangUpdateSql, connect);
            }
            insertBarang.Parameters.AddWithValue("@kodeBarang", kodeBarang);
            insertBarang.Parameters.AddWithValue("@idsupplier",idsupplier);
            insertBarang.Parameters.AddWithValue("@namaBarang", namaBarang);
            insertBarang.Parameters.AddWithValue("@jlhAwal", int.Parse(jlhAwal));
            insertBarang.Parameters.AddWithValue("@hargaHPP", Int32.Parse(hargaHPP));
            insertBarang.Parameters.AddWithValue("@hargaJual", Int32.Parse(hargaJual));
            insertBarang.Parameters.AddWithValue("@created_at", DateTime.Now);
            insertBarang.Parameters.AddWithValue("@update_at", DateTime.Now);
        }
        public void TampilCustomer()
        {
            customerSelectSql = string.Concat("select * from tblcustomer");
            customerDA.SelectCommand = new MySqlCommand(customerSelectSql, connect);
        }
        public void Customer(string idcust, string nama, string alamat, string kodepos, string email,string nohp, int kode)
        {
            string customerInsertSql = string.Concat("INSERT INTO tblcustomer(idcust,nama,alamat,kodepos,email,nohp,created_at,updated_at)VALUES(@idcust,@nama,@alamat,@kodepos,@email,@nohp,@created_at,@update_at)");
            string customerUpdateSql = string.Concat("update tblcustomer set alamat=@alamat, nama=@nama,kodepos=@kodepos,email=@email,nohp=@nohp,updated_at=@update_at where idcust=@idcust");
            string customerDeleteSql = string.Concat("delete from tblcustomer where idcust=@idcust");
            if (kode == 0)
            {
                insertCustomer = new MySqlCommand(customerInsertSql, connect);
            }
            else if (kode == 2)
            {
                insertCustomer = new MySqlCommand(customerDeleteSql, connect);
            }
            else
            {
                insertCustomer = new MySqlCommand(customerUpdateSql, connect);
            }
            insertCustomer.Parameters.AddWithValue("@idcust", idcust);
            insertCustomer.Parameters.AddWithValue("@nama", nama);
            insertCustomer.Parameters.AddWithValue("@alamat",alamat);
            insertCustomer.Parameters.AddWithValue("@kodepos", kodepos);
            insertCustomer.Parameters.AddWithValue("@email", email);
            insertCustomer.Parameters.AddWithValue("@nohp", nohp);
            insertCustomer.Parameters.AddWithValue("@created_at", DateTime.Now);
            insertCustomer.Parameters.AddWithValue("@update_at", DateTime.Now);
        }
        public void TampilPenjualan()
        {
            penjualanSelectSql = string.Concat("select * from tblpenjualan");
            penjualanDA.SelectCommand = new MySqlCommand(penjualanSelectSql, connect);
        }
        public void Penjualan( string idpenj,string nomor, string kodebarang, string nmbarang, string hrgJual, string jumlah,string subtotal, int kode)
        {
            string penjualanInsertSql = string.Concat("INSERT INTO tblpenjualan(idpenj,no,kodeBarang,namaBarang,hrgJual,jumlah,subtotal)VALUES(@idpenj,@nomor,@kodebarang,@nmbarang,@hrgJual,@jumlah,@subtotal)");
            string penjualanUpdateSql = string.Concat("update tblpenjualan set kodeBarang=@kodebarang,jumlah=@jumlah where idpenj=@idpenj");
            string penjualanDeleteSql = string.Concat("delete from tblpenjualan where idpenj=@idpenj");
            if (kode == 0)
            {
                insertPenjualan= new MySqlCommand(penjualanInsertSql, connect);
            }
            else if (kode == 2)
            {
                insertPenjualan = new MySqlCommand(penjualanDeleteSql, connect);
            }
            else
            {
                insertPenjualan= new MySqlCommand(penjualanUpdateSql, connect);
            }
            insertPenjualan.Parameters.AddWithValue("@idpenj", idpenj);
            insertPenjualan.Parameters.AddWithValue("@nomor", nomor);
            insertPenjualan.Parameters.AddWithValue("@kodebarang", kodebarang);
            insertPenjualan.Parameters.AddWithValue("@nmbarang", nmbarang);
            insertPenjualan.Parameters.AddWithValue("@hrgJual", hrgJual);
            insertPenjualan.Parameters.AddWithValue("@jumlah", jumlah);
            insertPenjualan.Parameters.AddWithValue("@subtotal",Int32.Parse(subtotal));
            
        }
        public void TampilPembelian()
        {
            pembelianSelectSql = string.Concat("select * from tblpembelian");
            pembelianDA.SelectCommand = new MySqlCommand(pembelianSelectSql, connect);
        }
        public void Pembelian(string no, string idpemb, string idsuplier,string nmperusahaan, string kodebarang, string nmbarang, string hrghpp, string jumlah, string subtotal, int kode)
        {
            string pembelianInsertSql = string.Concat("INSERT INTO tblpembelian(no,idpembelian,kodesuplier,nm_perusahaan,kodeBarang,namaBarang,hargaHPP,jumlah,subtotal)VALUES(@no,@idpemb,@idsuplier,@nmperusahaan,@kodebarang,@nmbarang,@hrghpp,@jumlah,@subtotal)");
            string pembelianUpdateSql = string.Concat("update tblpembelian set kodeBarang=@kodebarang,jumlah=@jumlah where idpembelian=@idpembelian");
            string pembelianDeleteSql = string.Concat("delete from tblpembelian where idpembelian=@idpemb");
            if (kode == 0)
            {
                insertPembelian = new MySqlCommand(pembelianInsertSql, connect);
            }
            else if (kode == 2)
            {
                insertPembelian = new MySqlCommand(pembelianDeleteSql, connect);
            }
            else
            {
                insertPembelian = new MySqlCommand(pembelianUpdateSql, connect);
            }
            insertPembelian.Parameters.AddWithValue("@no",int.Parse( no));
            insertPembelian.Parameters.AddWithValue("@idpemb",idpemb);
            insertPembelian.Parameters.AddWithValue("@idsuplier", idsuplier);
            insertPembelian.Parameters.AddWithValue("@nmperusahaan", nmperusahaan);
            insertPembelian.Parameters.AddWithValue("@kodebarang", kodebarang);
            insertPembelian.Parameters.AddWithValue("@nmbarang", nmbarang);
            insertPembelian.Parameters.AddWithValue("@hrghpp",int.Parse(hrghpp));
            insertPembelian.Parameters.AddWithValue("@jumlah",int.Parse( jumlah));
            insertPembelian.Parameters.AddWithValue("@subtotal", int.Parse(subtotal));

        }
        public void TampilSuplier()
        {
            suplierSelectSql = string.Concat("select * from tblsuplier");
            suplierDA.SelectCommand = new MySqlCommand(suplierSelectSql, connect);
        }
        public void Suplier(string kodesuplier, string nm_perusahaan, string nm_contact, string alamat, string kodepos, string email, string nohp,int kode)
        {
            string suplierInsertSql = string.Concat("INSERT INTO tblsuplier(kodesuplier,nm_perusahaan,nama_contact,alamat,kodepos,email,nohp,created_at,updated_at)VALUES(@kodesuplier,@nm_perusahaan,@nm_contact,@alamat,@kodepos,@email,@nohp,@created_at,@update_at)");
            string suplierUpdateSql = string.Concat("update tblsuplier set nm_perusahaan=@nm_perusahaan,nama_contact=@nm_contact ,alamat=@alamat,kodepos=@kodepos,email=@email,nohp=@nohp,updated_at=@update_at where kodesuplier=@kodesuplier");
            string suplierDeleteSql = string.Concat("delete from tblsuplier where kodesuplier=@kodesuplier");
            if (kode == 0)
            {
                insertSuplier = new MySqlCommand(suplierInsertSql, connect);
            }
            else if (kode == 2)
            {
                insertSuplier = new MySqlCommand(suplierDeleteSql, connect);
            }
            else
            {
                insertSuplier = new MySqlCommand(suplierUpdateSql, connect);
            }
            insertSuplier.Parameters.AddWithValue("@kodesuplier", kodesuplier);
            insertSuplier.Parameters.AddWithValue("@nm_perusahaan", nm_perusahaan);
            insertSuplier.Parameters.AddWithValue("@nm_contact", nm_contact);
            insertSuplier.Parameters.AddWithValue("@alamat", alamat);
            insertSuplier.Parameters.AddWithValue("@kodepos", kodepos);
            insertSuplier.Parameters.AddWithValue("@email", email);
            insertSuplier.Parameters.AddWithValue("@nohp", nohp);
            insertSuplier.Parameters.AddWithValue("@created_at", DateTime.Now);
            insertSuplier.Parameters.AddWithValue("@update_at", DateTime.Now);
        }
        public void TampilTransaksi()
        {
            transaksiSelectSql = string.Concat("select * from tbltransaksipenjualan");
            transaksiDA.SelectCommand = new MySqlCommand(transaksiSelectSql, connect);
        }
        public void Transaksi(string faktur, string idcust, string nmcust, string kodebrg, string nmbarang,string hrgjual, string jumlah, string total, int kode)
        {
            string transaksiInsertSql = string.Concat("INSERT INTO tbltransaksipenjualan(faktur_penjualan,idcust,nama,kodeBarang,namaBarang,hrgJual,jumlah,total,tglpenjualan,updated_at,status)VALUES(@faktur,@idcust,@nmcust,@kodebrg,@nmbarang,@hrgjual,@jumlah,@total,@created_at,@updated_at,'Belum Bayar')");
            string transaksiUpdateSql = string.Concat("update tbltransaksipenjualan set status='Lunas' where status='Belum Bayar'");
            string transaksiDeleteSql = string.Concat("delete from tbltransaksipenjualan where faktur_penjualan=@faktur");
            if (kode == 0)
            {
                insertTransaksi = new MySqlCommand(transaksiInsertSql, connect);
            }
            else if (kode == 2)
            {
                insertTransaksi = new MySqlCommand(transaksiDeleteSql, connect);
            }
            else
            {
                insertTransaksi = new MySqlCommand(transaksiUpdateSql, connect);
            }
            insertTransaksi.Parameters.AddWithValue("@faktur", faktur);
            insertTransaksi.Parameters.AddWithValue("@idcust",Int32.Parse(idcust));
            insertTransaksi.Parameters.AddWithValue("@nmcust", nmcust);
            insertTransaksi.Parameters.AddWithValue("@kodebrg", kodebrg);
            insertTransaksi.Parameters.AddWithValue("@nmbarang", nmbarang);
            insertTransaksi.Parameters.AddWithValue("@hrgjual",Int32.Parse(hrgjual));
            insertTransaksi.Parameters.AddWithValue("@jumlah",Int32.Parse(jumlah));
            insertTransaksi.Parameters.AddWithValue("@total",Int32.Parse(total));
            insertTransaksi.Parameters.AddWithValue("@created_at", DateTime.Now);
            insertTransaksi.Parameters.AddWithValue("@updated_at", DateTime.Now);
        }
        public void TampilTransaksiPembelian()
        {
            transaksiPembelianSelectSql = string.Concat("select * from tbltransaksipembelian");
            transaksiPembelianDA.SelectCommand = new MySqlCommand(transaksiPembelianSelectSql, connect);
        }
        public void TransaksiPembelian(string faktur, string kodes, string nm_pers, string kodebrg, string nmbarang, string hrghpp, string jumlah, string total, int kode)
        {
            string transaksiPembelianInsertSql = string.Concat("INSERT INTO tbltransaksipembelian(faktur_pembelian,kodesuplier,nm_perusahaan,kodeBarang,namaBarang,hargaHPP,jumlah,total,tglpembelian,updated_at)VALUES(@faktur,@kodes,@nm_pers,@kodebrg,@nmbarang,@hrghpp,@jumlah,@total,@created_at,@updated_at)");
            string transaksiPembelianUpdateSql = string.Concat("update tbltransaksipembelian set status='Lunas' where status='Belum Bayar'");
            string transaksiPembelianDeleteSql = string.Concat("delete from tbltransaksipembelian where faktur_pembelian=@faktur");
            if (kode == 0)
            {
                insertTransaksiPembelian = new MySqlCommand(transaksiPembelianInsertSql, connect);
            }
            else if (kode == 2)
            {
                insertTransaksiPembelian = new MySqlCommand(transaksiPembelianDeleteSql, connect);
            }
            else
            {
                insertTransaksiPembelian = new MySqlCommand(transaksiPembelianUpdateSql, connect);
            }
            insertTransaksiPembelian.Parameters.AddWithValue("@faktur", faktur);
            insertTransaksiPembelian.Parameters.AddWithValue("@kodes", kodes);
            insertTransaksiPembelian.Parameters.AddWithValue("@nm_pers", nm_pers);
            insertTransaksiPembelian.Parameters.AddWithValue("@kodebrg", kodebrg);
            insertTransaksiPembelian.Parameters.AddWithValue("@nmbarang", nmbarang);
            insertTransaksiPembelian.Parameters.AddWithValue("@hrghpp", Int32.Parse(hrghpp));
            insertTransaksiPembelian.Parameters.AddWithValue("@jumlah", Int32.Parse(jumlah));
            insertTransaksiPembelian.Parameters.AddWithValue("@total", Int32.Parse(total));
            insertTransaksiPembelian.Parameters.AddWithValue("@created_at", DateTime.Now);
            insertTransaksiPembelian.Parameters.AddWithValue("@updated_at", DateTime.Now);
        }
    }
}

