using System;
namespace jogomatematica

{
    public class Program
    {
        static void Main(string[] args)
        {
            // variaveis para armazenar a quantidade de questoes que o usuario quer responder.
            int quantidadeQuestoes;

            // armazena a quantidade de resposta que o usuario acertou
            int respostasCorretas = 0;

            QuestoesMatematica questoes = new QuestoesMatematica();
            Console.WriteLine("Jogo de Matematica \n");
            Console.WriteLine("Digite a quantidade de questoes : ");
            quantidadeQuestoes = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < quantidadeQuestoes; i++)
            {
                bool acertou = questoes.GerarQuestaoAdicao();
                if(acertou)
                {
                    respostasCorretas++;
                }

                Console.WriteLine("\nvocê acertou a resposta de " +respostasCorretas + " de " + quantidadeQuestoes);
                Console.WriteLine("********************************");
                
            }
            Console.ReadLine();


        }
    }
}
