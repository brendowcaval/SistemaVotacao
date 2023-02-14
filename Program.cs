using SistemaVotacao.Models;




// Desenvolvedor : Brendow Cavalcante
// Projeto : Sistema de voto para uma eleição
// votação para presidência em 2022 e alguns governos de estado(São Paulo/Minas Gerais/ Rio de Janeiro)
Presidencia eleicaoBR = new Presidencia();
eleicaoBR.votoUm = 0;
eleicaoBR.votoDois = 0;
eleicaoBR.votoTres = 0;
eleicaoBR.votoQuatro = 0;

SaoPaulo eleicaoSP = new SaoPaulo();
eleicaoSP.votoUm = 0;
eleicaoSP.votoDois = 0;

Minas eleicaoMG = new Minas();
eleicaoMG.votoUm = 0;
eleicaoMG.votoDois = 0;

RioJaneiro eleicaoRJ = new RioJaneiro();
eleicaoRJ.votoUm = 0;
eleicaoRJ.votoDois = 0;


bool sistemaVotacao = true;


while(sistemaVotacao == true)
{
    Console.Clear();
    Console.WriteLine("            ELEIÇÕES 2022  \n");
    Console.WriteLine("1. Vote");
    Console.WriteLine("2. Acompanhar Apuração");
    Console.WriteLine("3. Encerrar Votação e ver os Eleitos ");
    Console.WriteLine("4. Sair \n ");

    int decisaoSistema = Convert.ToInt32(Console.ReadLine());

    if(decisaoSistema == 1)
    {
        Console.Clear();
        Console.WriteLine("Digite seu nome: ");
        string eleitorNome = Console.ReadLine();
        Console.WriteLine("Digite seu CPF: ");
        string eleitorCPF = Console.ReadLine();
        Console.WriteLine("Qual o estado que você irá votar? (São Paulo/Minas Gerais/Rio de Janeiro)");
        string eleitorEstado = Console.ReadLine();
        
        if(eleitorEstado == "São Paulo")
        {
            Console.Clear();
            eleicaoSP.ApresentarCandidatos();
            int votandoGovernador = Convert.ToInt32(Console.ReadLine());

            switch(votandoGovernador)
            {
              case 10:
                    eleicaoSP.votoUm += 1;
                    break;
              case 13:
                    eleicaoSP.votoDois += 1;
                    break;
            }

            Console.Clear();
            eleicaoBR.ApresentarCandidatos();
            int votandoPresidente = Convert.ToInt32(Console.ReadLine());

            switch(votandoPresidente)
            {
              case 22:
                 eleicaoBR.votoUm += 1;
                 break;
              case 13:
                 eleicaoBR.votoDois += 1;
                 break;
              case 12:
                 eleicaoBR.votoTres += 1;
                 break;
              case 15:
                 eleicaoBR.votoQuatro += 1;
                 break;
            }


        }
        else if(eleitorEstado == "Minas Gerais")
        {
            Console.Clear();
            eleicaoMG.ApresentarCandidatos();

            int votandoGovernador = Convert.ToInt32(Console.ReadLine());

            switch(votandoGovernador)
            {
              case 30:
                    eleicaoMG.votoUm += 1;
                    break;
              case 55:
                    eleicaoMG.votoDois += 1;
                    break;
            }

            Console.Clear();
            eleicaoBR.ApresentarCandidatos();
            int votandoPresidente = Convert.ToInt32(Console.ReadLine());

            switch(votandoPresidente)
            {
              case 22:
                 eleicaoBR.votoUm += 1;
                 break;
              case 13:
                 eleicaoBR.votoDois += 1;
                 break;
              case 12:
                 eleicaoBR.votoTres += 1;
                 break;
              case 15:
                 eleicaoBR.votoQuatro += 1;
                 break;
            }


        }
        else if(eleitorEstado == "Rio de Janeiro")
        {
            Console.Clear();
            eleicaoRJ.ApresentarCandidatos();
            int votandoGovernador = Convert.ToInt32(Console.ReadLine());

            switch(votandoGovernador)
            {
              case 22:
                    eleicaoRJ.votoUm += 1;
                    break;
              case 40:
                    eleicaoRJ.votoDois += 1;
                    break;
            }

            Console.Clear();
            eleicaoBR.ApresentarCandidatos();
            int votandoPresidente = Convert.ToInt32(Console.ReadLine());

            switch(votandoPresidente)
            {
              case 22:
                 eleicaoBR.votoUm += 1;
                 break;
              case 13:
                 eleicaoBR.votoDois += 1;
                 break;
              case 12:
                 eleicaoBR.votoTres += 1;
                 break;
              case 15:
                 eleicaoBR.votoQuatro += 1;
                 break;
            }

        }
    }
    else if(decisaoSistema == 2)
    {
        Console.Clear();
        eleicaoSP.acompanharAPuracao();
        Console.WriteLine("------------------------------");
        eleicaoMG.acompanharAPuracao();
        Console.WriteLine("------------------------------");
        eleicaoRJ.acompanharAPuracao();
        Console.WriteLine("------------------------------");
        eleicaoBR.acompanharAPuracao();

        Console.ReadLine();

    }
    else if(decisaoSistema == 3)
    {
        Console.Clear();
        eleicaoSP.verificarCandidatosEleitos();
        Console.WriteLine("------------------------------");
        eleicaoMG.verificarCandidatosEleitos();
        Console.WriteLine("------------------------------");
        eleicaoRJ.verificarCandidatosEleitos();
        Console.WriteLine("------------------------------");
        eleicaoBR.verificarCandidatosEleitos();

        Console.ReadLine();
        // aqui ele zera os votos dos candidatos, pois a votação foi encerrada
        eleicaoBR.votoUm = 0;
        eleicaoBR.votoDois = 0;
        eleicaoBR.votoTres = 0;
        eleicaoBR.votoQuatro = 0;
        eleicaoSP.votoUm = 0;
        eleicaoSP.votoDois = 0;
        eleicaoMG.votoUm = 0;
        eleicaoMG.votoDois = 0;
        eleicaoRJ.votoUm = 0;
        eleicaoRJ.votoDois = 0;

    }
    else if(decisaoSistema == 4)
    {
        sistemaVotacao = false;
    }

}