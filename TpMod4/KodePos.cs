using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpMod4
{
    class KodePos
    {
        public enum kodePos
        {
            Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer,Samoja
        }
        public static int getKodePos(kodePos kdPos)
        {
            int[] kodePosKelurahan = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
            return kodePosKelurahan[(int)kdPos];
        }
    }
}
