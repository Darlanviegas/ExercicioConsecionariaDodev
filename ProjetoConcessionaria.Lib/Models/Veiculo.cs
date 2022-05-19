using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concessionaria.Lib.MyExeptions;

namespace Concessionaria.Lib.Models
{
    public class Veiculo
    {
        private string Marca { get; set; }
        private string Modelo { get; set; }
        private DateTime Ano { get; set; }
        private int Kilometragem { get; set; }
        private string Cor { get; set; }
        private double Valor { get; set; }

        public Veiculo(string marca, string modelo, DateTime ano, int kilometragem, string cor, double valor)
        {
            SetMarca(marca);
            SetModelo(modelo);
            SetAno(ano);
            SetKilometragem(kilometragem);
            SetCor(cor);
            SetValor(valor);
        }
        public virtual double CalcularValor(double valor)
        {
            return valor;
        }

        //Get e Set Marca
        public string GetMarca()
        {
            return Marca;
        }
        public void SetMarca(string marca)
        {
            Marca = marca;
        }

        //Get e Set Modelo
        public string GetModelo()
        {
            return Modelo;
        }
        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }

        //Get e Set Ano
        public DateTime GetAno()
        {
            return Ano;
        }
        public void SetAno(DateTime ano)
        {
            ValidarAno(ano);
            Ano = ano;
        }
        public bool ValidarAno(DateTime ano)

        {

            if (ano.Year >= 2004 && ano.Year <= DateTime.Today.Year)

            {

                return true;

            }

            throw new ValidarInput("Ano inválido!");

        }

        //Get e Set Kilometragem
        public int GetKilometragem()
        {
            return Kilometragem;
        }
        public void SetKilometragem(int kilometragem)
        {
            Kilometragem = kilometragem;
        }

        //Get e Set Cor
        public string GetCor()
        {
            return Cor;
        }
        public void SetCor(string cor)
        {
            Cor = cor;
        }

        //Get e Set Valor
        public double GetValor()
        {
            return Valor;
        }
        public void SetValor(double valor)
        {
            ValidarValor(valor);
            Valor = valor;
        }
        public virtual bool ValidarValor(double valor)

        {
            if (valor >= 0)

            {

                return true;

            }
            throw new ValidarInput("valor inválido!");
        }
    }
}
