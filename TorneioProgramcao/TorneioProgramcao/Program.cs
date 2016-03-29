using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorneioProgramcao {
    class Program {
        static void Main(string[] args) {
            int[] vetor = new int[10];

            for (int i = 0; i < 10; i++) {
                Console.WriteLine("Digite um número: ");
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] vetorOrdenado = ordenar(vetor);

            Console.Write("Vetor Ordenado: ");
            for(int i = 0; i< 10; i++) {
                Console.Write(vetorOrdenado[i]+" ");
            }
            Console.ReadKey();
        }
        static int[] ordenar(int [] vetor) {
            int[] vetorOrdenadoAsc = ordenarAsc(vetor);
            int[] vetorOrdenadoDesc = ordenarDesc(vetorOrdenadoAsc);
            int[] vetorRetorno = retonarVetor(vetorOrdenadoAsc, vetorOrdenadoDesc);
            return vetorRetorno;
        }

        static int[] retonarVetor(int[] vetorAsc, int[] vetorDesc) {
            int[] vetor = new int[10];
            for(int i = 0; i < 5; i++) {
                vetor[i] = vetorAsc[i];
            }
            int j = 0;
            for (int i = 5; i < 10; i++) {
                vetor[i] = vetorDesc[j];
                j++;
            }
            return vetor;
        }

        static int[] ordenarDesc(int[] vetor) {
            int[] vetorOrdenadoDesc = new int[5];
            int j = 0;
            for (int i = vetor.Length - 1; i >= 5; i--) {
                vetorOrdenadoDesc[j] = vetor[i];
                j++;
            }
            return vetorOrdenadoDesc;
        }
 
        static int[] ordenarAsc(int[] vetor) {
            int i;
            int j;
            int index;

            for (i = 1; i < vetor.Length; i++) {
                index = vetor[i];
                j = i;
                while ((j > 0) && (vetor[j - 1] > index)) {
                    vetor[j] = vetor[j - 1];
                    j = j - 1;
                }
                vetor[j] = index;
            }
            return vetor;
        }
    }
}
