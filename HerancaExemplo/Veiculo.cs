using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaExemplo
{
    internal class Veiculo
    {//atributos
        private uint numeroRodas;
        private uint numeroPortas;
        private uint velocidade;
        private bool estaLigado;

        

        //propriedade para alterar os atributos
        public uint NumeroRodas {
            get { return numeroRodas;}

        }

        public uint NumeroPortas
        {
            get { return numeroPortas;}
        }

        public uint Velocidade { get { return velocidade;}

            set


            { velocidade = value; } 
        }
        public bool EstaLigado { 
            get { return estaLigado; }
        
        }

        //metodo vazio
        public void Ligar()
        {

            Console.WriteLine("Veiculo Ligado!!");
            estaLigado = true;
        }
        public void Desligar()
        {

            Console.WriteLine("Veiculo Desligado!!");
            estaLigado = false;
        }

        //construtor da classe

        public Veiculo(uint numeroRodas, uint numeroPortas/*uint velocidade, bool estaLigado*/)
        {
            this.numeroRodas = numeroRodas;
            this.numeroPortas = numeroPortas;
            //this.velocidade = velocidade;
            //this.estaLigado = estaLigado;
            velocidade = 0;
            estaLigado = false;
        }

    }
}
