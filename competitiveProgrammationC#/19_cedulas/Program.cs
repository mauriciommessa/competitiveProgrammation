/*
Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual 
o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. A seguir 
mostre o valor lido e a relação de notas necessárias.

Entrada
O arquivo de entrada contém um valor inteiro N (0 < N < 1000000).

Saída
Imprima o valor lido e, em seguida, a quantidade mínima de notas de cada tipo necessárias, 
conforme o exemplo fornecido. Não esqueça de imprimir o fim de linha após cada linha, caso 
contrário seu programa apresentará a mensagem: “Presentation Error”.
*/
using System; 

class URI {

    static void Main(string[] args) { 
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine(N);
        
        int[] notas = {100, 50, 20, 10, 5, 2, 1};
        int[] quantidadesNotas = new int[notas.Length];

        for(int i = 0; i < notas.Length; i++){
            quantidadesNotas[i] = N / notas[i];
            N %= notas[i];
        }
        
        for(int i = 0; i <notas.Length; i++){
            Console.WriteLine($"{quantidadesNotas[i]} nota(s) de R$ {notas[i]},00");
        }
    }

}
