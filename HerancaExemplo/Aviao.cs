using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaExemplo
{
    internal class Aviao : Veiculo
    {
        private uint altitude;

        //propriedade para alterar altitude
        public uint Altitude
        {
            get { return altitude; }

        }
        //METODOS ESPECIFICOS DA CLASSE AVIÃO
        public void Decolar(uint pVelocidade, uint pAltitude)
        {
            if (EstaLigado == true)
            {

                Console.WriteLine("Avião Decolando!!");
                altitude = pAltitude;
                Velocidade = pVelocidade;
                Console.WriteLine("Velocidade do Avião:" + Velocidade);
                Console.WriteLine("Altitude do Avião:" + Altitude);
            }
            else
            {
                Console.WriteLine("Avião DESLIGADO!");
            }

        }
        //METODO
        public void Pousar()
        {
            Console.WriteLine("Avião Pousando!!");
            altitude = 0;
            Velocidade = 0;
            Console.WriteLine("Velocidade do Avião:" + Velocidade);
            Console.WriteLine("Altitude do Avião:" + Altitude);

        }
    //construtor
    public Aviao(uint numeroRodas, uint numeroPortas) :base(numeroRodas,numeroPortas)
        {
            altitude = 0;
        }


    }
}
