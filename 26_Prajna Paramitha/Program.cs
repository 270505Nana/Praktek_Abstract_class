using System;

namespace _26_Prajna_Paramitha
{
    class Program
    {
        static void Main(string[] args)
        {
          //membuat objek 
          dokter D01 = new dokter()
          {
              nama_pegawai = "Upin",
              ID_pegawai = "00001234",
              jml_pasien = 10,
              pekerjaan = "Absen Datang, memeriksa pasien, memberi tindakan, Absen Pulang"           
          };
            //dioutput
            Console.WriteLine("=>Dokter<=");
            Console.WriteLine("Nama pegawai = "+ D01.nama_pegawai);
            Console.WriteLine("ID pegawai = " + D01.ID_pegawai);
            Console.WriteLine("pekerjaan yang bisa dilakukan = " + D01.pekerjaan);
            Console.WriteLine("Bonus = " + D01.GetBonus());
            

            Console.WriteLine("=============================================================================================================");

            //membuat objek lagi
            dokter D02 = new dokter()
            {
                nama_pegawai = "Ipin",
                ID_pegawai = "00001235",
                jml_pasien = 10,
                pekerjaan = "Absen Datang, memeriksa pasien, memberikan resep, mencetak_bonus, Absen Pulang"
            };
            //dioutput
            Console.WriteLine("=>Dokter<=");
            Console.WriteLine("Nama pegawai = " + D02.nama_pegawai);
            Console.WriteLine("ID pegawai = " + D02.ID_pegawai);
            Console.WriteLine("pekerjaan yang bisa dilakukan = " + D02.pekerjaan);
            Console.WriteLine("Bonus = " + D02.GetBonus());

            Console.WriteLine("=============================================================================================================");

            //membuat objek lagi
            apoteker P01 = new apoteker()
            {

                nama_pegawai = "Mail",
                ID_pegawai = "00001236",
                jml_pasien = 10,
                pekerjaan = "Absen Datang, meracik resep, merekam resep, mecetak bonus"
            };
            //di output
            //dioutput
            Console.WriteLine("=>Apoteker<=");
            Console.WriteLine("Nama pegawai = " + P01.nama_pegawai);
            Console.WriteLine("ID pegawai = " + P01.ID_pegawai);
            Console.WriteLine("pekerjaan yang bisa dilakukan = " + P01.pekerjaan);
            Console.WriteLine("Bonus = " + P01.GetBonus());

            Console.WriteLine("=============================================================================================================");

            //membuat objek lagi
            apoteker P02 = new apoteker()
            {

                nama_pegawai = "Meymey",
                ID_pegawai = "00001237",
                jml_pasien = 10,
                pekerjaan = "Absen Datang, mencetak bonus"
            };
    
            //dioutput
            Console.WriteLine("=>Apoteker<=");
            Console.WriteLine("Nama pegawai = " + P02.nama_pegawai);
            Console.WriteLine("ID pegawai = " + P02.ID_pegawai);
            Console.WriteLine("pekerjaan yang bisa dilakukan = " + P02.pekerjaan);
            Console.WriteLine("Bonus = " + P02.GetBonus());


            Console.WriteLine("=============================================================================================================");


            //membuat objek lagi
            perawat PW01 = new perawat()
            {

                nama_pegawai = "Rose",
                ID_pegawai = "00001238",
                jml_pasien = 10,
                pekerjaan = "Absen Datang memberikan infus, menyuntik, Absen Pulang"
            };

            //dioutput
            Console.WriteLine("=>Perawat<=");
            Console.WriteLine("Nama pegawai = " + PW01.nama_pegawai);
            Console.WriteLine("ID pegawai = " + PW01.ID_pegawai);
            Console.WriteLine("pekerjaan yang bisa dilakukan = " + PW01.pekerjaan);
            Console.WriteLine("Bonus = " + PW01.GetBonus());

            Console.WriteLine("=============================================================================================================");

            //membuat objek lagi
            perawat PW02 = new perawat()
            {

                nama_pegawai = "Jarjit",
                ID_pegawai = "00001239",
                jml_pasien = 10,
                pekerjaan = "Absen Datang, memberikan infus, mencetak bonus, Absen Pulang"
            };

            //dioutput
            Console.WriteLine("=>Perawat<=");
            Console.WriteLine("=>Masukkan angka<=");
            Console.WriteLine("Nama pegawai = " + PW02.nama_pegawai);
            Console.WriteLine("ID pegawai = " + PW02.ID_pegawai);
            Console.WriteLine("pekerjaan yang bisa dilakukan = " + PW02.pekerjaan);
            Console.WriteLine("Bonus = " + PW02.GetBonus());

            Console.WriteLine("=============================================================================================================");
        }
    }
}
