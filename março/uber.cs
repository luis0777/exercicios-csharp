using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Uber
{
    private string local;
    private string destino;
    private string valor;
    private float pagamento;

    public Uber()
    {
    }

    public void Viajar()
    {
        float Carteira = 0;
        string nome;
        Console.WriteLine("Bem vindo ao aplicativo da Uber, qual o seu nome? ");
        nome = Console.ReadLine();
        Console.WriteLine($"Olá {nome}, siga o passo a passo para solicitar sua viagem. Tecle ENTER para continuar... ");
        Console.Clear();
        string Local, Destino;
        float Km;
        Console.WriteLine("Qual seu local atual?");
        Local = Console.ReadLine();
        Console.WriteLine("Qual o destino que gostaria de ir?");
        Destino = Console.ReadLine();
        Console.WriteLine("Digite a quantidade de km do seu local até o destino escolhido:");
        Km = Convert.ToInt32(Console.ReadLine());
        float Corrida = Km * 5;
        Console.Clear();
        Console.WriteLine($"Local:{Local}\nDestino:{Destino}\nValor da corrida: R${Corrida}");
        Console.ReadLine();
        string Resposta;
        Console.WriteLine("Gostaria de confirmar a corrida? Digite sim ou não");
        Resposta = Console.ReadLine();

        switch (Resposta.ToLower())
            {
            case "Sim":
                Console.WriteLine("Ira precisar de troco? Digite sim ou não");
                string Troco; 
                Troco = Console.ReadLine(); 
                if(Troco.ToLower() == "sim")
                {
                    float dinheiro;
                    Console.WriteLine("Precisa de troco para quanto?");
                    dinheiro = Convert.ToInt32(Console.ReadLine());
                    float devolver = Corrida - dinheiro;
                    Console.WriteLine($"Seu troco é R${devolver}");
                }
                else
                {

                }

        }
    }

}

namespace LuisFelipe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Uber luis = new Uber();
            luis.Viajar();

           
        }
    }
}
