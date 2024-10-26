using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogomatematica
{
    public class QuestoesMatematica
    {
        // propiedade responsavel por gerar números aleatorios.
        private Random random = new Random();
        public bool GerarQuestaoAdicao()
        {
            bool acertou;
            int numero1 = random.Next(51);
            int numero2 = random.Next(51);

            Console.WriteLine("Escolha a operaçaõ (+, -, * ou /)");
            string operacao = Console.ReadLine();
            double resultado = 0;

         switch(operacao)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    if(numero2 == 0)
                    {
                   resultado = (double)numero1 / numero2;
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                        return false;
                    }
                    break;
                default:
                    Console.WriteLine("Operação inválida.");
                    return false;


            }

            Console.WriteLine($"{numero1} {operacao} {numero2} = ? ");
            int resposta = Int32.Parse(Console.ReadLine());
            

            // calculando a resposta correta
            
         
            if(resultado == resposta)
            {
                acertou = true;
            }
            else
            {
                acertou = false;
            }
            return acertou;
        }
    }
}
