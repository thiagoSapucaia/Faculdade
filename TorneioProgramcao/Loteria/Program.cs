using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loteria
{
    class Program
    {
        static bool VerificarDuplicados(int[] numeros) {
            bool valido = true;
            for (int i = 0; i <= numeros.Length; i++) {
                for (int j = i + 1; j < numeros.Length; j++) {
                    if (numeros[i] == numeros[j]) {
                        return false;
                    }
                }
            }
            return valido;
        }

        static void Main(string[] args)
        {
            string[] numerosJogadosChar = new string[6];
            string[] numerosSorteadosChar = new string[6];

            int[] numerosJogadosInt = new int[6];
            int[] numerosSorteadosInt = new int[6];

            int acertos = 0;
            bool valido = false;
            string numerosAux = string.Empty;

            while (numerosAux.Split(' ').Length != 6 || !valido) {
                Console.WriteLine("Informe os Números Jogados: ");
                numerosAux = Console.ReadLine();
                numerosJogadosChar = numerosAux.Split(' ');
                for (int i = 0; i < numerosAux.Split(' ').Length; i++) {
                    try{
                        numerosJogadosInt[i] = Convert.ToInt32(numerosJogadosChar[i]);
                    }
                    catch {
                    }if (numerosJogadosInt[i] > 1 || numerosJogadosInt[i] < 99) { 
                        valido = true;
                    }
                }
                valido = VerificarDuplicados(numerosJogadosInt);
            }
            numerosAux = string.Empty;
            valido = false;
            while (numerosAux.Split(' ').Length != 6 || !valido){
                Console.WriteLine("Informe os Números Sorteados: ");
                numerosAux = Console.ReadLine();
                numerosSorteadosChar = numerosAux.Split(' ');
                for (int i = 0; i < numerosAux.Split(' ').Length; i++){
                    try{
                        numerosSorteadosInt[i] = Convert.ToInt32(numerosSorteadosChar[i]);
                    }catch{
                    }
                    if (numerosSorteadosInt[i] > 1 || numerosSorteadosInt[i] < 99){
                        valido = true;
                    }
                }
                valido = VerificarDuplicados(numerosSorteadosInt);
            }
            for (int i = 0; i < 6; i++) {
                for (int j = 0; j < 6; j++) {
                    if (numerosJogadosChar[i] == numerosSorteadosChar[j]) {
                        acertos++;
                    }
                }
            }
            switch (acertos)
            {
                case 3:
                    Console.WriteLine("Terno");
                    break;
                case 4:
                    Console.WriteLine("Quadra");
                    break;
                case 5:
                    Console.WriteLine("Quina");
                    break;
                case 6:
                    Console.WriteLine("Sena");
                    break;
                default:
                    Console.WriteLine("Azar");
                    break;
            }
            Console.ReadKey();
        }
    }
}
