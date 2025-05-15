//using namespaces;

using Gerenciador_de_solucoes;

namespace Gerenciador_de_solucoes
{
    public class ContaCorrente
    {
        //private Cliente _titular;

        //public Cliente Titular
        //{
        //    get 
        //    {
        //        return _titular; 
        //    }
        //    set
        //    {
        //        _titular = value;
        //    }
        //}

        public Cliente Titular{get;set;}

        private int _agencia;
        public int Agencia 
        {
            get
            {
                return _agencia;

            }
            set
            {
                if(value <= 0)
                {
                    return;
                }

            }
        }
        public int Numero { get;set;}


        private double _saldo;

        public double Saldo
        {
            get
            {
                return _saldo;

            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    _saldo = value;
                }
            }
        }

        public ContaCorrente(int agencia , int numero)
        {
            Agencia = agencia;
            Numero = numero;
        }

        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            // this é usando para refrerencia que é desse objeto
            {
                return false;
                // retorna o valor da função
            }
            else
            {
                this._saldo -= 100;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }
    }
}

