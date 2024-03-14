using System;

public class Personal 
{
    private string treino;
    private string nome;
    private int idade;


    public Personal()
    {
        
    }

    public void Treinar()using System;
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

    {
        string Resposta;

        do
        {
            Console.WriteLine("Qual seu objetivo na academia?");
            Console.WriteLine("*Emagrecer\n*Ganhar massa\n*Apenas manter\n");
            Resposta = Console.ReadLine();

            Console.Clear();
            switch (Resposta.ToLower())
            {
                case "emagrecer":
                    Console.WriteLine("\nAqui está um treino ABC com foco no emagrecimento");
                    Console.WriteLine("\nDia A: Parte Superior do Corpo\r\nSupino Inclinado: 3 séries de 10 repetições\r\nRemada com Barra: 3 séries de 10 repetições\r\nDesenvolvimento de Ombros com Halteres: 3 séries de 12 repetições\r\nFlexão de Braços: 3 séries até a falha\r\nRosca Direta com Barra: 3 séries de 12 repetições\r\nPrancha: 3 séries de 30 segundos a 1 minuto");
                    Console.WriteLine("\nDia B: Inferior do Corpo e Cardio\r\nAgachamento: 3 séries de 12 repetições\r\nAvanço com Halteres: 3 séries de 10 repetições para cada perna\r\nLevantamento Terra: 3 séries de 10 repetições\r\nCárdio (Escolha um exercício):\r\nCorrida: 20 minutos\r\nPular Corda: 15 minutos\r\nCiclismo Estacionário: 20 minutos");
                    Console.WriteLine("\nDia C: Parte Superior do Corpo e Core\r\nFlexão de Braços em Triângulo: 3 séries de 12 repetições\r\nPulldown na Polia Alta: 3 séries de 10 repetições\r\nElevação Lateral com Halteres: 3 séries de 12 repetições\r\nPrancha Lateral: 3 séries de 30 segundos a 1 minuto para cada lado\r\nCrunches: 3 séries de 15 repetições\r\nRussian Twist com Peso: 3 séries de 15 repetições para cada lado");
                    break;

                case "ganhar massa":
                    Console.WriteLine("\nAqui está um treino ABC com foco no ganho de massa musucular");
                    Console.WriteLine("\nDia A: Parte Superior do Corpo\r\nSupino Reto: 4 séries de 8-10 repetições\r\nBarra Fixa ou Puxada na Polia Alta: 4 séries de 8-10 repetições\r\nDesenvolvimento Militar com Halteres: 3 séries de 8-10 repetições\r\nRosca Direta com Barra: 3 séries de 10-12 repetições\r\nTríceps Corda ou Francês: 3 séries de 10-12 repetições\r\nPrancha: 3 séries de 30-60 segundos");
                    Console.WriteLine("\nDia B: Inferior do Corpo e Core\r\nAgachamento Livre: 4 séries de 8-10 repetições\r\nLevantamento Terra: 4 séries de 6-8 repetições\r\nLeg Press: 3 séries de 10-12 repetições\r\nCadeira Extensora: 3 séries de 10-12 repetições\r\nFlexão de Perna deitado: 3 séries de 10-12 repetições\r\nPrancha Lateral: 3 séries de 30-60 segundos para cada lado");
                    Console.WriteLine("\nDia C: Parte Superior do Corpo e Braços\r\nSupino Inclinado com Halteres: 4 séries de 8-10 repetições\r\nRemada Curvada com Barra: 4 séries de 8-10 repetições\r\nElevação Lateral com Halteres: 3 séries de 10-12 repetições\r\nRosca Martelo com Halteres: 3 séries de 10-12 repetições\r\nTríceps Testa com Halteres: 3 séries de 10-12 repetições\r\nFlexão de Braços com Pegada Fechada: 3 séries de 8-10 repetições");
                    break;

                case "apenas manter":
                    Console.WriteLine("\nAqui está um treino ABC com foco na manutenção do fisico");
                    Console.WriteLine("\nDia A: Treino de Força e Estabilidade\r\nAgachamento Frontal: 3 séries de 6-8 repetições\r\nSupino: 3 séries de 6-8 repetições\r\nRemada Curvada com Barra: 3 séries de 6-8 repetições\r\nFlexão de Braços: 3 séries de 8-10 repetições\r\nPrancha: 3 séries de 30-60 segundos");
                    Console.WriteLine("\nDia B: Treino de Condicionamento Cardiovascular e Core\r\nCorrida de 20 minutos em ritmo moderado ou outro cardio de sua preferência (como ciclismo ou natação)\r\nAbdominais Crunches: 3 séries de 12-15 repetições\r\nPrancha Lateral: 3 séries de 30 segundos para cada lado\r\nLevantamento Terra Romeno: 3 séries de 8-10 repetições");
                    Console.WriteLine("\nDia C: Treino de Resistência e Equilíbrio\r\nFlexão de Pernas (com Máquina ou no Smith): 3 séries de 10-12 repetições\r\nPulldown na Polia Alta: 3 séries de 8-10 repetições\r\nElevação Lateral com Halteres: 3 séries de 10-12 repetições\r\nRosca Direta com Barra: 3 séries de 8-10 repetições\r\nAgachamento com Peso Corporal ou com Kettlebell: 3 séries de 12-15 repetições");
                    break;

                default:
                    Console.WriteLine("Opcao invalida\n\nDIGITE CORRETAMENTE SEU OBJETIVO, TECLE ENTER PARA TENTAR NOVAMENTE");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        } while (Resposta.ToLower() != "emagrecer" && Resposta.ToLower() != "ganhar massa" && Resposta.ToLower() != "apenas manter");
    }

    public void Apresentar(string nome, int idade)
    {
        Console.WriteLine($"Meu nome é {nome}, tenho {idade} anos  e estou muito empolgado por ter a oportunidade de trabalhar com você em sua jornada de fitness e saúde.\r\nComo personal trainer, meu principal objetivo é ajudá-lo a alcançar seus objetivos de forma eficaz e segura, adaptando os treinos às suas necessidades individuais e garantindo que cada sessão seja desafiadora e gratificante\n");
    }

}
namespace personal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personal Pedro = new Personal();
            Pedro.Apresentar("Luis", 20);
            Pedro.Treinar();
            Console.ReadKey();
        }
    }
}
