internal class Program
{
    private static void Main(string[] args)
    {
        int n, totalPar, totalImpar;

        totalPar = 0;
        totalImpar = 0;
        n = 0;
        while (n < 1000)
        {
            if ((n > 1000)&&(n > 0))
            {
                Console.WriteLine("Digite um número: ");
                n = int.Parse(Console.ReadLine());

                if (n % 2 == 0 )
                {
                    totalPar += n;
                }
                else
                {
                    totalImpar += n;
                }
            }


        }
            Console.WriteLine("A soma dos números pares é: " + totalPar + " E dos impares é: " + totalImpar);
    }
}