
using System;
using System.Collections.Generic;
using System.Text;

namespace _26_Prajna_Paramitha
{
    //membuat class parent abstract
    public abstract class Pegawai
    {
        //deklarasi atributnya
        public string nama_pegawai,pekerjaan,ID_pegawai;
        public int  jml_pasien;

        //membuat method abstract, ini nanti bisa diubah terus kalo non-void return di child class
        public abstract string namapegawai();
        public abstract string IDpegawai();
        public abstract int jmlpasien();
        public abstract int GetBonus();
        public abstract string Absendatang();
        public abstract string Absenpulang();
        public virtual void GetID() { }
        public virtual void Getnama() { }


        
        
	



    }
}
