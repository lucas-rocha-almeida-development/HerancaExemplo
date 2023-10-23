using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HerancaExemplo
{
    internal class Carro : Veiculo
    {
        public void Acelerar(uint pVelocidade)
        {
            if (EstaLigado == true)
            {
                Console.WriteLine("Carro acelerando!!!");
                Velocidade =pVelocidade;
                Console.WriteLine("Velocidade do Carro:" + Velocidade);
            }
            else
            {
                Console.WriteLine("Carro esta Desligado:");
            }
            
            
        }
        //Metodo para break Carro
        public void Brecar()
        {
            Console.WriteLine("Carro brekando!!");
            Velocidade = 0;
            Console.WriteLine("Velocidade do Carro:" + Velocidade);
        }
        //Construtor do Nosso Carro
        public Carro(uint numeroRodas, uint numeroPortas) : base(numeroRodas, numeroPortas)
        {
            
        }
    }
}
