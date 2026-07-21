using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesArray op = new OperacoesArray();

            int[] array = new int[5] {6, 3, 8, 1, 9};
            int[] arrayCopia = new int[10];

            System.Console.WriteLine("Array original: ");
            op.ImprimirArray(array);

            //op.OrdenarBubbleSort(ref array);
            //op.Ordenar(ref array);

            System.Console.WriteLine("Array ordenado");
            op.ImprimirArray(array);

            System.Console.WriteLine("Array antes da copia:");
            op.ImprimirArray(arrayCopia);
            
            op.Copiar(ref array, ref arrayCopia);
            System.Console.WriteLine("Array após a copia");
            op.ImprimirArray(arrayCopia);
        }
    }
}