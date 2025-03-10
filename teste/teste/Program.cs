using System.ComponentModel;

namespace teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Teste(List<int> lista ){
                                
                bool repetido = false;

                for (int i = 0; i < lista.Count; i++)
                {
                    var cont = 0;

                    for (int j = 0; j < lista.Count; j++)
                    {
                        if (lista[i] == lista[j])
                        {
                            cont++;
                        }
                    }

                    if (cont == 2)
                    {
                        repetido = true;
                    }
                }

                if (repetido)
                {
                    Console.WriteLine("Verdadeiro");
                    return "Vedadeiro";
                }
                else
                {
                    Console.WriteLine("Falso");
                    return "Falso";
                }                
            }

            List<int> lista1 = new List<int> { 1, 2, 3, 1 };
            List<int> lista2 = new List<int> { 1, 2, 3, 4 };
            List<int> lista3 = new List<int> { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

            Teste(lista1);
            Teste(lista2);
            Teste(lista3);
        }
    }
}
