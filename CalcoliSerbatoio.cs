using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimensionamento_Serbatoi
{
    public class CalcoliSerbatoio
    {
        // Determina la modalità di calcolo per guscio cilindrico ASME
        public string DetermineAsmeShellMode(double rInt, double tVerify, double p, double s, double e)
        {
            if (rInt <= 0 || tVerify <= 0 || p <= 0 || s <= 0 || e <= 0)
                throw new ArgumentException("I parametri per la verifica ASME devono essere maggiori di zero.");

            double se = s * e;
            return (tVerify >= 0.5 * rInt || p >= 0.385 * se) ? "Parete Spessa" : "Parete Sottile";
        }

        // Determina la modalità di calcolo per guscio cilindrico PED
        public string DeterminePedShellMode(double dInt, double tVerify, double p, double f, double z)
        {
            if (dInt <= 0 || tVerify <= 0 || p <= 0 || f <= 0 || z <= 0)
                throw new ArgumentException("I parametri per la verifica PED devono essere maggiori di zero.");

            return (tVerify / dInt > 0.1) ? "Parete Spessa" : "Parete Sottile";
        }

        // Calcola lo spessore finale
        public void CalcolaSpessore()
        {
            double spessoreGuscioBase = 0;
            double spessoreFondoBase = 0;
            double P = DatiCalcolo.PressioneProgetto;
            double c = DatiCalcolo.SovraspessoreCorrosione;

            if (DatiCalcolo.Normativa == "ASME")
            {
                double R = DatiCalcolo.DiametroInterno / 2.0;
                double S = DatiCalcolo.SforzoAmmissibile_S_o_f;
                double E = DatiCalcolo.CoefficienteGiunzione;

                // Calcolo Guscio Cilindrico
                if (DatiCalcolo.TipoSerbatoio == "Cilindrico")
                {
                    if (DatiCalcolo.ModalitaCalcoloGuscio == "Parete Sottile")
                    {
                        spessoreGuscioBase = (P * R) / (S * E - 0.6 * P);
                    }
                    else // Parete Spessa
                    {
                        spessoreGuscioBase = R * (Math.Exp(P / (S * E)) - 1);
                    }
                }
                // Aggiungi qui le altre formule per i fondi ASME...
            }
            else if (DatiCalcolo.Normativa == "PED")
            {
                double Di = DatiCalcolo.DiametroInterno;
                double f = DatiCalcolo.SforzoAmmissibile_S_o_f;
                double z = DatiCalcolo.CoefficienteGiunzione;

                // Calcolo Guscio Cilindrico
                if (DatiCalcolo.TipoSerbatoio == "Cilindrico")
                {
                    if (DatiCalcolo.ModalitaCalcoloGuscio == "Parete Sottile")
                    {
                        spessoreGuscioBase = (P * Di) / (2 * f * z - P);
                    }
                    else // Parete Spessa
                    {
                        spessoreGuscioBase = (Di / 2.0) * (Math.Exp(P / (f * z)) - 1);
                    }
                }
                // Aggiungi qui le altre formule per i fondi PED...
            }

            DatiCalcolo.SpessoreCalcolatoGuscio = spessoreGuscioBase + c;
            DatiCalcolo.SpessoreCalcolatoFondo = spessoreFondoBase + c; // Da calcolare
        }
    }
}
