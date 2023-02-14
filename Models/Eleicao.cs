using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVotacao.Models
{
    public class Eleicao
    {
        public int votoUm { get; set; }
        public int votoDois { get; set; }


        public virtual void ApresentarCandidatos()
        {
            Console.WriteLine("    Candidatos ao Governo/Presidencia ");
            Console.WriteLine(" XX ");
            Console.WriteLine(" XY ");

        }

        public virtual void acompanharAPuracao()
        {
            Console.WriteLine("    Corrida ao Governo/Presidencia ");
            Console.WriteLine($" XX | Votos : {votoUm}");
            Console.WriteLine($" XY | Votos : {votoDois}");
        }

        public virtual void verificarCandidatosEleitos()
        {
            Console.WriteLine("    Corrida ao Governo/Presidencia ");
            Console.WriteLine($" XX | Votos : {votoUm}");
            Console.WriteLine($" XY | Votos : {votoDois}");

            if(votoUm > votoDois)
            {
                Console.WriteLine($" o XX foi eleito com {votoUm} dos votos");
            }
            else if(votoDois > votoUm)
            { 
                Console.WriteLine($" o XY foi eleito com {votoDois} dos votos");
            }
            else
            {
                Console.WriteLine($" Houve empate, é necessário outro turno!");
            }
        }


    }
}