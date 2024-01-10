namespace MemoriasStackHeap
{
    internal class Program
    {
        //Memória Stack é mais performática do que a Heap
        static void Main(string[] args)
            //Heap(Referencia)                   //Stack(Valor)
            //1abc::10                           //valorA::10
            //                                   //num:100 ==> na linha 31 [destruir a variável da memória]
            //1abc::50        
        {
            //Criou variáveis
            int valorA = 10;
            int valorB = valorA;

            //Exemplo de variável que ao criarmos vai para a Heap
            string x = "";


            AlterarVariavelPorValor(valorA);
            Console.WriteLine("Alterando por valor: " + valorA);

            AlterarVariavelPorReferencia(ref valorB);
            Console.WriteLine("Alterando por referência: " + valorB );

            
        }

        static void AlterarVariavelPorReferencia(ref int num)
        {   //Esse que tem o ref -> Foi no Endereço da Memória
            num = 50;
        }

        static void AlterarVariavelPorValor(int num)
        {   //Faz uma cópia
            num = 100;
        }
    }
}