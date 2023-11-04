using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    internal class cliente
    {
        public string nome;
        public double saldo;



        public void Creditar(double valor)
        {
            if(valor <= 0)
            {
                throw new Exception("Por favor insira um valor valido: ");
            }

            this.saldo += valor;
        }
        
        public void Debitar(double valor)
        {
            if (valor <= 0)
            {
                throw new Exception("Por favor insira um valor valido: ");
                
            }

            this.saldo -= valor;
        }


    }
}
