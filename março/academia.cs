// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class Academia 
{
    private int Supino;
    private int Esteira;
    private int Halter;
    private bool Aberta;
    
    public Academia(int Supino, int Esteira, int Halter)
    {
        this.Supino = Supino;
        this.Esteira = Esteira;
        this.Halter = Halter;
        this.Aberta = true;
    }
        public void Abrir()
        {
            if(Aberta)
            {
                Aberta = false;
                Console.WriteLine("A academia foi aberta");
                
                string Resposta;
                Console.WriteLine("Gostaria de fechar a academia? SIM ou NAO");
               Resposta = Console.ReadLine();
               
               //Tolower Retorna uma cópia dessa cadeia de caracteres convertida em minúsculas.
               switch(Resposta.ToLower())
               {
                case "sim":
                    Console.WriteLine("A academia foi fechada, ate amanha!");
                        break;
                case "nao":
                    Console.WriteLine("OK! A academia continua aberta");
                         break;   
                default:
                    Console.WriteLine("Opcao invalida");
                    break;       
               }
            }
            else
            {
                Console.WriteLine("A academia já está aberta");
            }
        }
        
        public void Fechar()
        {
            if(!Aberta)
            {
                Aberta =  true;
                Console.WriteLine("A academia foi fechada. Bom descanso");
            }
            else
            {
                Console.WriteLine("A academia ja foi fechada.");
            }
        }
        public void Correr()
        {
            Console.WriteLine("Na academia  eu corro");
        }
        
        public void Treinar()
        {
            Console.WriteLine("Na academia eu treino muito");
        }
        
        public int getSupino
        {
            get => Supino;
            set => Supino = value;
        }
        
        public int getEsteira
        {
            get => Esteira;
            set => Esteira = value;
        }
        
        public int getHalter
        {
            get => Halter;
            set => Halter = value;
        }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Academia estacaoX = new Academia(7, 8, 9);
     
        Console.WriteLine($"Peso do supino {estacaoX.getSupino}\nPeso do halter {estacaoX.getHalter}\nQuantidade de esteira {estacaoX.getEsteira}");
    }
}
