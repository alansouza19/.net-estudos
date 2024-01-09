namespace EstudosCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var xx = Console.Read();//Refere-se ao código ASCII do teclado
            var yy = Console.ReadKey();
            Console.WriteLine("O que é: "+ xx); 
            Console.WriteLine("O que é: "+ yy);


            //O ponto de interrogação(?) permite que o valor possa ser null.
            bool ? ativo;
           
            var idade1 = 100;
            Console.WriteLine("Tipo da idade1 com VAR " + idade1.GetType());
            idade1 = 101;
            Console.WriteLine("Tipo da idade1 s/VAR " + idade1.GetType());




            dynamic idade3 = 100;
            Console.WriteLine("Tipo da idade3 s/dynamic" + idade3.GetType());

            idade3= 100;
            Console.WriteLine("Tipo idade3 com dynamic" + idade3.GetType());

            Object idade4 = 100;
            Console.WriteLine("Tipo idade4 com Object" + idade4.GetType());

            idade4 = "100";
            Console.WriteLine("Tipo idade4 s/Object" + idade4.GetType());

            Console.WriteLine("Digite um nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a sua idade: ");
            string idade = Console.ReadLine();


            Console.WriteLine($"Olá, {nome}!");
            Console.WriteLine($"Sua idade é: {idade} anos");

            Console.WriteLine($"{nome}, aperte qualquer tecla para finalizar o programa ");
        }
    }
}