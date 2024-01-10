namespace MetodoMain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Somar();
            int resultado = Somando();
            Console.WriteLine("int: " + resultado);
            Console.WriteLine("Chamando a função direto: " + Somando());
            Console.WriteLine(concatenador());
            Console.WriteLine(dataAgora());
            Console.WriteLine(Somando(5,8));
           
        }
        static string concatenador() //função static que retorna uma string
        {
            return "100" + "100";
        }

        static void Somar() //A função precisa ser chamada no método Main()
                            //A função é static do tipo void(void não retorna nada)
        {
            Console.WriteLine("Realiza a soma");
        }

        static int Somando()
        {
            return 10 + 10;
        }
                                                       //Usamos o mesmo nome para as duas funções
                                                       //porém uma passa dois argumentos e a outra nada
        static int Somando(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        static DateTime dataAgora()
        {
            return DateTime.Now;
        }
    }
}