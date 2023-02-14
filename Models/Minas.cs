using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVotacao.Models
{
    public class Minas : Eleicao
    {
        




        public override void ApresentarCandidatos()
        {
            Console.WriteLine("          Candidatos para o Governo de Minas Gerais \n");
            Console.WriteLine("Zema - 30");
            Console.WriteLine("Kalil - 55");
            Console.WriteLine("Digite o número do seu candidato: ");
        }

        public override void acompanharAPuracao()
        {
            Console.WriteLine("    Corrida ao Governo de Minas Gerais ");
            Console.WriteLine($" Zema | Votos : {votoUm}");
            Console.WriteLine($" Kalil | Votos : {votoDois}");
        }

        public override void verificarCandidatosEleitos()
        {
            Console.WriteLine("    Corrida ao Governo de Minas Gerais ");
            Console.WriteLine($" Zema | Votos : {votoUm}");
            Console.WriteLine($" Kalil | Votos : {votoDois}");

            if(votoUm > votoDois)
            {
                Console.WriteLine($" o Zema foi eleito com {votoUm} dos votos");
            }
            else if(votoDois > votoUm)
            {
                Console.WriteLine($" o Kalil foi eleito com {votoDois} dos votos");
            }
            else
            {
                Console.WriteLine(" Houve empate, é necessário realização de outro turno! ");
            }
        }
    }
}