using Banco;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    internal class Cliente
    {
        public string nome;
        public double saldo;



        public void Creditar(double valor)
        {
            if(valor <= 0)
            {
                throw new Exception("Por favor insira um valor valido: ");
            }

            Conexao conexao = new Conexao();

            string query = "INSERT INTO MOVIMENTACAO (operacao, valor) VALUES (@valor1, @valor2)";

            MySqlParameter[] param = new MySqlParameter[]
            {
                new MySqlParameter("@valor1", "credito"),
                new MySqlParameter("@valor2", valor)
            };

            conexao.ExecuteQueryWithParameters(query, param);

            this.saldo += valor;
        }
        
        public void Debitar(double valor)
        {
            if (valor <= 0 || saldo <= valor)
            {
                throw new Exception("Por favor insira um valor valido: ");
                
            }

            this.saldo -= valor;
        }


    }
}
