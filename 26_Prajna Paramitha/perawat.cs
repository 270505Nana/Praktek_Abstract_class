using System;
using System.Collections.Generic;
using System.Text;

namespace _26_Prajna_Paramitha
{
    class perawat : Pegawai
    {
        public override string Absendatang()
        {
            return Absendatang();
        }

        public override string Absenpulang()
        {
            return Absenpulang();
        }

        public override int GetBonus()
        {
            jml_pasien = (int)(5000 * jml_pasien);
            return jml_pasien;
        }

        public override string IDpegawai()
        {
            return IDpegawai();
        }

        public override int jmlpasien()
        {
            return jmlpasien();
        }

        public override string namapegawai()
        {
            return namapegawai();
        }
    }
}
