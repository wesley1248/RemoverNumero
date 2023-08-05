using System;

namespace RemoverNumeros
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite primeiro o numero que sera removido, e depois o valor");
            string[] valores = Console.ReadLine().Split(' ');
            string numeroAretirar = valores[0];
            string numero = valores[1];
            
            string resultado = numero.Replace(numeroAretirar, "");
            
            Console.WriteLine(resultado);
        }
    }
}