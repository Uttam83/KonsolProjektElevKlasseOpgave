using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolProjekt.Codes
{
    interface ISynsInfo
    {
        // Opret en ny Interface klasse: ISynsInfo.cs.Med følgende property; SidstSynet(DateTime?).
        //SynsInfo.cs skal også implementer en metode: public DateTime NæsteSynDato(). 
        // Bil.cs klasse skal implementer SynsInfo interface.

        public DateTime? SidstSynet 
        { get; set; }


        public DateTime? NæsteSynDato();
        


    }
}
