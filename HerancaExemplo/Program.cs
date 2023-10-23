using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaExemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //criando 1ª objeto
            Carro meuCarro = new Carro(4,4);
            Aviao meuAviao = new Aviao(3, 3);
            meuCarro.Ligar();
            meuAviao.Ligar();
            meuCarro.Acelerar(120);
            //podemos observar metodos distintos ( cada qual em sua class especifica para determinado obj)
            meuAviao.Decolar(200, 3000);

            //utilizando metodo brecar

            meuCarro.Brecar();
            meuAviao.Pousar();

            //agora vamos utilizar o metodo que contem para ambos (herdados da class Veiculo)
            meuCarro.Desligar();
            meuAviao.Desligar();

            Console.ReadKey();

        }
    }
}
