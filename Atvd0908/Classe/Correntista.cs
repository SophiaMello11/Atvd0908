using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atvd0908.Classe;

namespace Atvd0908.Classe
{
    public class Correntista
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Renda { get; set; }
        public decimal Saldo { get; set; }

        public Correntista(int Id, string nome, int Cpf, DateTime dataNascimento, decimal renda, decimal saldo)
        {
            if (Id <= 0)
            {
                throw new ArgumentException("O ID deve ser maior que 0.");
            }


            this.Id = Id;
            Nome = nome;
            this.Cpf = Cpf;
            DataNascimento = dataNascimento;
            Renda = renda;
            Saldo = Saldo;

        }

        public bool VerificarSeCorrentistaMaior()
        {
            DateTime dataNascimento = DateTime.Now;
            int idade = dataNascimento.Year - DataNascimento.Year;

            if (dataNascimento.Month < DataNascimento.Month || (dataNascimento.Month == DataNascimento.Month && dataNascimento.Day < DataNascimento.Day))
            {
                idade--;
            }

            return idade >= 18;
        }
        public string RetornarPerfilCliente()
        {
            decimal Renda = Saldo / 12;

            if (Renda <= 3000)
            {
                return "Silver";


            }
            else if (Renda <= 5000)
            {
                return "Gold";
            }
            else if (Renda <= 10000)
            {
                return "Diamond";
            }
            else
            {
                return "Black";
            }
        }
        public string MontarMensagemBoasVindas()
        {
            string perfil = RetornarPerfilCliente();
            return $"Olá, {Nome}!\nSeja bem vindo ao Sifrão\nCliente {perfil}";
        }
    } 
}
