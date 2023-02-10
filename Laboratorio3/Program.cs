namespace Laboratorio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maximo = 100, minimo = 0, tentativas = 0;
            int valorGerado = new Random().Next(minimo, maximo);

            while (true)
            {
                //Toda interação registra uma tentativa
                tentativas++;
                Console.Write($"Informe um valor entre {minimo} e {maximo}: ");
                int valor = int.Parse(Console.ReadLine());

                if (valor < minimo || valor > maximo)
                {
                    continue;
                }

                if (valor < valorGerado)
                {
                    minimo = valor + 1;

                }
                else if (valor > valorGerado)
                {
                    maximo = valor + 1;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"Voce acertou em {tentativas} tentativas.");
            Console.ReadKey();  
        }
    }
}