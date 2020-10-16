using System;

namespace senha
{
    class Program
    {
        static void Main(string[] args)
        {
            string senhaCorreta = "1234abcd";
            string senhaDigitadaUsuario;

            Console.Clear();
            Console.WriteLine("--- Senha");

            Console.Write("Olá, usuário. Por favor, digite sua senha: ");
            senhaDigitadaUsuario = Console.ReadLine();

            if(senhaDigitadaUsuario != senhaCorreta)
            {
               Console.WriteLine("Acesso negado");
               Environment.Exit(-1);
            }
            else
            {
               Console.WriteLine("Acesso permitido");
            }
            
            
 
        }
    }
}
