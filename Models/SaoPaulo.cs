using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVotacao.Models
{
    public class SaoPaulo : Eleicao
    {






        public override void ApresentarCandidatos()
        {
            Console.WriteLine("          Candidatos para o Governo de São Paulo \n");
            Console.WriteLine("Tarcisio - 10");
            Console.WriteLine("Fernando Haddad - 13");
            Console.WriteLine("Digite o número do seu candidato: ");
        }

        public override void acompanharAPuracao()
        {
            Console.WriteLine("    Corrida ao Governo de São Paulo ");
            Console.WriteLine($" Tarcisio | Votos : {votoUm}");
            Console.WriteLine($" Fernando Haddad | Votos : {votoDois}");
        }

        public override void verificarCandidatosEleitos()
        {
            Console.WriteLine("    Corrida ao Governo de São Paulo ");
            Console.WriteLine($" Tarcisio | Votos : {votoUm}");
            Console.WriteLine($" Fernando Haddad | Votos : {votoDois}");

            if(votoUm > votoDois)
            {
                Console.WriteLine($" o Tarcisio foi eleito com {votoUm} dos votos");
            }
            else if(votoDois > votoUm)
            {
                Console.WriteLine($" o Fernando Haddad foi eleito com {votoDois} dos votos");
            }
            else
            {
                Console.WriteLine(" Houve empate, é necessário realização de outro turno! ");
            }
        }
    }
}