using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_de_GFT.Desafio1.Models
{
    public class IngressoDoCinema
    {
        public IngressoDoCinema(int ingresso,  int quantidadeIngressoDisponivel)
        {
            Ingresso = ingresso;
            QuantidadeIngressoDisponivel = quantidadeIngressoDisponivel;

        }
        public int Ingresso { get; set; }
        public int QuantidadeIngressoDisponivel { get; set; }
        public void CompraDeIngresso()
        {
            bool negativo = true;

            while (negativo)
            {
                if (Ingresso > 0 &&  Ingresso < QuantidadeIngressoDisponivel)
                {
                    Console.WriteLine($"Compra feita!! Preço: {33 * Ingresso}");
                    
                    negativo = false;
                }

                else
                {
                    Console.WriteLine("A quantidade de ingresso é menor ou igual a 0, escreva novamente a quantidade ");
                }
            }
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Filme:Aventura Épica, Preço: 33 um ingresso, Quantidade: {QuantidadeIngressoDisponivel}");

        }



        
    }
}