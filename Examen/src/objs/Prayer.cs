using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.src.objs
{
    internal class Prayer
    {
        public Prayer(int ID, string prayer) 
        { 
            PrayerID = ID;
            PrayerContents = prayer;
        }

        public int PrayerID { get; set; }
        public string PrayerContents { get; set; }
    }
}
