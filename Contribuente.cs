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
        public int RedditoAnnuale { get; set; }

        //metodo che va ad eseguire calcoli in base ai scaglioni
        public string CalcoloImposta()
        {
            if (this.RedditoAnnuale > 0 && this.RedditoAnnuale <= 15000)
            {
                var imposta = this.RedditoAnnuale * 0.23;             
                    return $"{imposta} euro";
            }
            else if (this.RedditoAnnuale > 15000 && this.RedditoAnnuale <= 28000)
            {
                var parteEccedente = this.RedditoAnnuale - 15000;
                var imposta = parteEccedente * 0.27 + 3450;
                return $"{imposta} euro";
            }
            else if (this.RedditoAnnuale > 28000 && this.RedditoAnnuale <= 55000)
            {
                var parteEccedente = this.RedditoAnnuale - 28000;
                var imposta = parteEccedente * 0.38 + 6960;
                return $"{imposta} euro";
            }
            else if (this.RedditoAnnuale > 55000 && this.RedditoAnnuale <= 75000)
            {
                var parteEccedente = this.RedditoAnnuale - 55000;
                var imposta = parteEccedente * 0.41 + 17220;
                return $"{imposta} euro";
            }
            else if (this.RedditoAnnuale > 75000 )
            {
                var parteEccedente = this.RedditoAnnuale - 75000;
                var imposta = parteEccedente * 0.43 + 25420;
                return $"{imposta} euro";
            }
            else
            {
                return "Errore, controllare i dati e riprovare";            }
           
                   
            
           
        }




    }
}
