using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVotacao.Models
{
    public class RioJaneiro : Eleicao
    {
        



        public override void ApresentarCandidatos()
        {
            Console.WriteLine("          Candidatos para o Governo do Rio de Janeiro \n");
            Console.WriteLine("Cláudio Castro - 22");
            Console.WriteLine("Marcelo Freixo - 40");
            Console.WriteLine("Digite o número do seu candidato: ");
        }

        public override void acompanharAPuracao()
        {
            Console.WriteLine("    Corrida ao Governo do Rio de Janeiro ");
            Console.WriteLine($" Cláudio Castro | Votos : {votoUm}");
            Console.WriteLine($" Marcelo Freixo | Votos : {votoDois}");
        }

        public override void verificarCandidatosEleitos()
        {
            Console.WriteLine("    Corrida ao Governo do Rio de Janeiro ");
            Console.WriteLine($" Cláudio Castro | Votos : {votoUm}");
            Console.WriteLine($" Marcelo Freixo | Votos : {votoDois}");

            if(votoUm > votoDois)
            {
                Console.WriteLine($" o Cláudio Castro foi eleito com {votoUm} dos votos");
            }
            else if(votoDois > votoUm)
            {
                Console.WriteLine($" o Marcelo Freixo foi eleito com {votoDois} dos votos");
            }
            else
            {
                Console.WriteLine(" Houve empate, é necessário realização de outro turno! ");
            }
        }
    }
}