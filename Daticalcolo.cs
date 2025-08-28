using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimensionamento_Serbatoi
{
    public static class DatiCalcolo
    {
        // Dati di input principali
        public static string? Normativa { get; set; }
        public static string? TipoSerbatoio { get; set; }
        public static string? TipoFondo { get; set; }
        public static string? MaterialeSelezionato { get; set; }
        public static double PressioneProgetto { get; set; }
        public static double DiametroInterno { get; set; }
        public static double DiametroEsterno { get; set; }
        public static double SpessoreNominaleVerifica { get; set; }
        public static double CoefficienteGiunzione { get; set; }
        public static double SovraspessoreCorrosione { get; set; }

        // Parametri specifici per i fondi
        public static double Parametro_C_ASME { get; set; }
        public static double Parametro_K1_ASME { get; set; }
        public static double Parametro_C_PED { get; set; }
        public static double Parametro_Beta_PED { get; set; }
        public static double Parametro_Alpha { get; set; }

        // Proprietà del materiale (popolate automaticamente)
        public static double SforzoAmmissibile_S_o_f { get; set; }
        public static double ModuloElastico { get; set; }
        public static string? ModalitaCalcoloGuscio { get; set; }

        // Risultati del calcolo finale
        public static double SpessoreCalcolatoGuscio { get; set; }
        public static double SpessoreCalcolatoFondo { get; set; }
        public static double SpessoreCalcolatoGuscioInterno { get; set; }

        public static void Reset()
        {
            Normativa = string.Empty;
            TipoSerbatoio = string.Empty;
        }
    }
}
