using System.Runtime.InteropServices.Marshalling;

namespace Desafio_de_GFT.Desafio2;

public class Passaro : Animal

{
    public Passaro(string nome, double envergadura) : base(nome)
    {
        Envergadura = envergadura;
    }



    public double Envergadura { get; set; }

    public void Descrição()
    {
        Console.WriteLine($"O Nome do passaro é {Nome}, Sua envergadura é de {Envergadura} m ");
    }
}
        