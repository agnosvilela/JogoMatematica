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
            Console.WriteLine(numero1 + "+" + numero2 + " = ");
            int resposta = Int32.Parse(Console.ReadLine());

            // calculando a resposta correta
            
            int resultado = numero1 + numero2;
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
