namespace AulaPOOCelular.classes
{
    public class Celular
    {
        public string modelo;
        public string cor;
        public float tamanho;
        public bool status;
        // int numeroCelular;
        // int destinatario;
        // string mensagem;
        // string confirmacao;
        

        
        public bool Estado(bool status)
        {
            bool estado;
            if(status == true){
                estado = this.status;
            }else{
                estado = this.status;
            }

            return estado;
        }

        public int Chamada(int numeroCelular){
            System.Console.WriteLine("Ligar para qual número?");
            numeroCelular = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine($"Ligando para {numeroCelular}");
            return numeroCelular;//ENCONTRADO O ERRO PARA DUPLICAR, PORÉM COMO RESOLVER???
        }

        public int Mensagem(int destinatario, string mensagem, int confirmacao){
            System.Console.WriteLine("Enviar mensagem para qual número?");
            destinatario = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Digite a mensagem:");
            mensagem = System.Console.ReadLine();

            System.Console.WriteLine("Mensagem enviada!");
            confirmacao = int.Parse(System.Console.ReadLine()); 
            
            return confirmacao;
        }
    }

}