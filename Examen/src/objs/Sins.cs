using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Sins
    {
        public Sins(int sinsID, string sin, string confession, int commandment) 
        { 
            SinsID = sinsID;
            Sin = sin;
            Confession = confession;
            Commandment = commandment;
        }

        public int SinsID { get; set; }
        public string Sin { get; set; }
        public string Confession { get; set; }
        public int Commandment { get; set; }
        public bool Mortal { get; set; }
        public DateOnly? Date { get; set; }
        public int NumTimes { get; set; }
    }
}
