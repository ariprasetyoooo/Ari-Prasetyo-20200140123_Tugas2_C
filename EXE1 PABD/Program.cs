using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace EXE1_PABD
{
    class Program
    {
        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-2M5MKTU9;database=Toko_Bakeryy;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand(
                    "insert into Customer (id_customer,nama,no_hp,email) values ('1234','Susanto','085745845002','Susanto@gmail.com')"
                    + "insert into Customer(id_customer,nama,no_hp,email) values ('1236','Pardi','085745845123','Pardi@gmail.com')"
                    + "insert into Customer(id_customer,nama,no_hp,email) values ('1232','Atta','085745846534','Atta@gmail.com')"
                    + "insert into Customer(id_customer,nama,no_hp,email) values ('1239','Reza','085745845142','Reza@gmail.com')"
                    + "insert into Customer (Id_customer,nama,no_hp,email) values ('1244','Paini','085745845874','Paini@gmail.com')"

                    + "insert into Penjual (id_user,nama,passwordd) values ('0001','Supardi','123456')"
                    + "insert into Penjual (id_user,nama,passwordd) values ('0011','Supardi','123456')"
                    + "insert into Penjual (id_user,nama,passwordd) values ('0111','Supardi','123456')"
                    + "insert into Penjual (id_user,nama,passwordd) values ('1111','Supardi','123456')"
                    + "insert into Penjual (id_user,nama,passwordd) values ('1112','Supardi','123456')"

                    + "insert into kue (id_kue,nama_kue,jenis_kue,harga) values ('0001','Bolu','Basah','5000')"
                    + "insert into kue (id_kue,nama_kue,jenis_kue,harga) values ('0002','Nastar','Basah','6000')"
                    + "insert into kue (id_kue,nama_kue, jenis_kue, harga) values ('0003','Pukis','Basah','4000')"
                    + "insert into kue (id_kue,nama_kue,jenis_kue,harga) values ('0004','Nagasari','Basah','3000')"
                    + "insert into kue (id_kue, nama_kue, jenis_kue, harga) values ('0005','Cornflakes','Basah','7000')"

                    + "insert into pemesanan (id_pemesanan, id_customer, id_user,id_kue) values ('1224','1234','0001','0001')"
                    + "insert into pemesanan (id_pemesanan, id_customer, id_user,id_kue) values ('1226','1236','0011','0002')"
                    + "insert into pemesanan (id_pemesanan, id_customer, id_user,id_kue) values ('1232','1239','0111','0003')"
                    + "insert into pemesanan (id_pemesanan, id_customer, id_user,id_kue) values ('1239','1239','1111','0004')"
                    + "insert into pemesanan (id_pemesanan, id_customer, id_user,id_kue) values ('1224','1244','1112','0005')", con);
                cm.ExecuteNonQuery();


                Console.WriteLine("Sukses menambahkan data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Datamu masih ada yang salah :(" + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            new Program().InsertData();
        }
    }

}