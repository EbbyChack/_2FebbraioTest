using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2FebbraioTest
{
    public class Contribuente
    {
        public string Nome {  get; set; }
        public string Cognome { get; set; }
        public string DataNascita { get; set; }
        public string CodiceFiscale { get; set; }
        public string Sesso { get; set; }
        public string ComuneResidenza { get; set; }
        public decimal RedditoAnnuale { get; set; }

        //metodo che va ad eseguire calcoli in base ai scaglioni
        public string CalcoloImposta()
        {
            if (this.RedditoAnnuale > 0 && this.RedditoAnnuale <= 15000)
            {
                //calcolo per trovare l'aliquota
                decimal imposta = this.RedditoAnnuale * 0.23m;             
                    return $"{imposta:c} ";
            }
            else if (this.RedditoAnnuale > 15000 && this.RedditoAnnuale <= 28000)
            {
                //la variabile chiamata parteEccedente va a sottrarre il valore prestabilito dal reddito annuale
                decimal parteEccedente = this.RedditoAnnuale - 15000;
                //qui calcoliamo l'aliquota e dopo lo sommiamo con l'imposta fissa per ottenere l'imposta totale
                decimal imposta = parteEccedente * 0.27m + 3450;
                return $"{imposta:c} ";
            }
            else if (this.RedditoAnnuale > 28000 && this.RedditoAnnuale <= 55000)
            {
                decimal parteEccedente = this.RedditoAnnuale - 28000;
                decimal imposta = parteEccedente * 0.38m + 6960;
                return $"{imposta:c} ";
            }
            else if (this.RedditoAnnuale > 55000 && this.RedditoAnnuale <= 75000)
            {
                decimal parteEccedente = this.RedditoAnnuale - 55000;
                decimal imposta = parteEccedente * 0.41m + 17220;
                return $"{imposta:c} ";
            }
            else if (this.RedditoAnnuale > 75000 )
            {
                decimal parteEccedente = this.RedditoAnnuale - 75000;
                decimal imposta = parteEccedente * 0.43m + 25420;
                return $"{imposta:c} ";
            }
            else
            {
                return "Errore, controllare i dati e riprovare";            
            }
        }
    }
}
