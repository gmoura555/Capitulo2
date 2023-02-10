namespace Laboratorio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe seu Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Informe sua Idade: ");
            double idade = Convert.ToDouble(Console.ReadLine());

            double ingresso;

            if (idade <= 17)
            {
                ingresso = 30;

            }
            else if (idade > 17 && idade <= 59)
            {
                ingresso = 40;
            }
            else 
            {
                ingresso = 20;
            }

            string resposta = $"O convidado {nome} tem {idade} anos de Idade, e pagará {ingresso:c}";
            Console.WriteLine(resposta);
            Console.ReadKey();
        }


        
    }

}