using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class ExamenData
    {
        public List<Sins>? SelectedSins { get; set; } 
        public bool AddPrayer { get; set; }
        public bool AddGuide { get; set; }
        public string? SelectedPrayer { get; set; }
        public string? Confession { get; set; }
        public bool Quit { get; set; }
        public bool Reset { get; set; }
    }
}
