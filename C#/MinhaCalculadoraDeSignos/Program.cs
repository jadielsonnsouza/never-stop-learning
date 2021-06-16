using System;

namespace MinhaCalculadoraDeSignos
{
    class Program
    {
        static void Main(string[] args)
        {
            Signo signo = new Signo();
            signo.nome = "Libra";

            Console.WriteLine("Seu signo é : " + signo.nome);
        }
    }
}
