using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimensionamento_Serbatoi
{
    public class MaterialProperties
    {
        public double ResistenzaSnervamento { get; set; } // ASME S
        public double SforzoNominale { get; set; } // PED f
        public double ModuloElastico { get; set; }
    }

    public static class MaterialiDatabase
    {
        public static readonly Dictionary<string, MaterialProperties> Properties = new Dictionary<string, MaterialProperties>
        {
            ["Acciaio Inox 304 (1.4301)"] = new MaterialProperties { ResistenzaSnervamento = 205.0, SforzoNominale = 138.0, ModuloElastico = 193000.0 },
            ["Acciaio Inox 316L (1.4404)"] = new MaterialProperties { ResistenzaSnervamento = 205.0, SforzoNominale = 143.0, ModuloElastico = 193000.0 },
            ["Acciaio Carbonio SA-516 Gr.70"] = new MaterialProperties { ResistenzaSnervamento = 260.0, SforzoNominale = 180.0, ModuloElastico = 200000.0 },
            ["Acciaio Carbonio P265GH"] = new MaterialProperties { ResistenzaSnervamento = 255.0, SforzoNominale = 177.0, ModuloElastico = 205000.0 },
            ["Alluminio 6061-T6"] = new MaterialProperties { ResistenzaSnervamento = 276.0, SforzoNominale = 185.0, ModuloElastico = 68900.0 },
            ["Titanio Grado 2"] = new MaterialProperties { ResistenzaSnervamento = 275.0, SforzoNominale = 160.0, ModuloElastico = 103000.0 }
        };

        public static List<string> GetMaterialNames()
        {
            return new List<string>(Properties.Keys);
        }

        public static MaterialProperties GetProperties(string materialName)
        {
            return Properties.ContainsKey(materialName) ? Properties[materialName] : null;
        }
    }
}
