//using namespaces;

namespace namespaces
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        public double saldo;

        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            // this é usando para refrerencia que é desse objeto
            {
                return false;
                // retorna o valor da função
            }
            else
            {
                this.saldo -= 100;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }
    }
}

