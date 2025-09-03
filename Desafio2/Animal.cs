using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_de_GFT.Desafio2
{
    public class Animal
    {
        public Animal(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }

        public  void NomeDoAnimal()
        {
            Console.WriteLine($"O nome do animal é {Nome}");
        }

    
    }
}