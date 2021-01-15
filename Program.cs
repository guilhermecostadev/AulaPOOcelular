using System;
using AulaPOOCelular.classes;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano). - Com os métodos, ligar, desligar, fazer ligação, enviar mensagem. - Só será possível executar tais métodos se o celular estiver ligado.

            Celular telefone = new Celular();

            Console.WriteLine("CELULAR");
            //CARACTERISTICAS DO APARELHO
            System.Console.WriteLine("Qual o modelo do aparelho?");
            telefone.modelo = Console.ReadLine();
            
            System.Console.WriteLine("Qual a cor do aparelho?");
            telefone.cor = Console.ReadLine();
            
            System.Console.WriteLine("Qual o tamanho?");
            telefone.tamanho = float.Parse(Console.ReadLine());

            //ESTADO DO APARELHO
            System.Console.WriteLine("O telefone está ligado? S/N");
            string escolha = Console.ReadLine(); 

            if(escolha == "s"){
                telefone.status=true;
            }else{
                telefone.status = false;
                System.Console.WriteLine("Não é possível acessar os recursos do aparelho. Ligue e volte mais tarde");
            }

            
            //MENU
            string menu;
            do
            {
                System.Console.WriteLine("MENU");

                System.Console.WriteLine("[a] - Chamar");
                System.Console.WriteLine("[b] - Enviar Mensagem");
                System.Console.WriteLine("[c] - Ligar Aparelho");
                System.Console.WriteLine("[0] - Desligar Aparelho");
                menu = Console.ReadLine();

                int numero=0;
                int contato=0;                
                int envio=0;
                string texto= "s";

                switch (menu)
            {
                case "a":
                    if(numero == 0){
                    System.Console.WriteLine(telefone.Chamada(numero));// repetindo o numero digitado 2X ????
                    numero= int.Parse(Console.ReadLine());
                    break;                   

                    }else{
                        System.Console.WriteLine("Por favor, dgite um número válido para completar a ligação!");
                    }                   
                    break;
                 case "b":
                    if (numero==0)
                    {
                    System.Console.WriteLine(telefone.Mensagem(contato,texto,envio));
                    texto = Console.ReadLine(); 
                    break;
                    
                      
                    }else{
                        System.Console.WriteLine("Por favor, dgite um número válido para enviar a mensagem!");
                    }
                    break;
                 case "c":
                    System.Console.WriteLine("Ligando");
                    break;
                    case "0":
                    System.Console.WriteLine("Desligando");
                    break;
                default:
                    System.Console.WriteLine("Opção inválida");
                    break;
            }

            } while (menu !="0");
            
            
        }
    }
}
