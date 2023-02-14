using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVotacao.Models
{
    public class Presidencia : Eleicao 
    {

        public int votoTres { get; set; }
        public int votoQuatro { get; set; }


        public override void ApresentarCandidatos()
        {
            Console.WriteLine("          Candidatos para a Presidência do Brasil \n");
            Console.WriteLine("Jair Bolsonaro - 22");
            Console.WriteLine("Lula - 13");
            Console.WriteLine("Ciro Gomes - 12");
            Console.WriteLine("Simone Tebet - 15");
            Console.WriteLine("Digite o número do seu candidato : ");
        }

        public override void acompanharAPuracao()
        {
            Console.WriteLine("    Corrida a Presidência do Brasil  ");
            Console.WriteLine($" Jair Bolsonaro | Votos : {votoUm}");
            Console.WriteLine($" Lula | Votos : {votoDois}");
            Console.WriteLine($" Ciro Gomes | Votos : {votoTres}");
            Console.WriteLine($" Simone Tebet | Votos : {votoQuatro}");
        }

        public override void verificarCandidatosEleitos()
        {
            Console.WriteLine("    Corrida a Presidência do Brasil  ");
            Console.WriteLine($" Jair Bolsonaro | Votos : {votoUm}");
            Console.WriteLine($" Lula | Votos : {votoDois}");
            Console.WriteLine($" Ciro Gomes | Votos : {votoTres}");
            Console.WriteLine($" Simone Tebet | Votos : {votoQuatro}");

            if(votoUm > votoDois && votoUm > votoTres && votoUm > votoQuatro)
            {
                Console.WriteLine($" o Jair Bolsonaro foi eleito com {votoUm} dos votos");
            }
            else if(votoDois > votoUm && votoDois > votoTres && votoDois > votoQuatro)
            {
                Console.WriteLine($" o Lula foi eleito com {votoDois} dos votos");
            }
            else if(votoTres > votoUm && votoTres > votoDois && votoTres > votoQuatro)
            {
                Console.WriteLine($" o Ciro Gomes foi eleito com {votoTres} dos votos");
            }
            else if(votoQuatro > votoUm && votoQuatro > votoDois && votoQuatro > votoTres)
            {  
                Console.WriteLine($" A Simone Tebet foi eleita com {votoQuatro} dos votos");
            }
            else
            {
                Console.WriteLine(" Houve empate, é necessário realização de outro turno! ");
            }
        }
        
    }
}