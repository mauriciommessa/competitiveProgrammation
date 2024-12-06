/*
Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor 
monetário. A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode 
ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2. As moedas possíveis são 
de 1, 0.50, 0.25, 0.10, 0.05 e 0.01. A seguir mostre a relação de notas necessárias.

Entrada
O arquivo de entrada contém um valor de ponto flutuante N (0 ≤ N ≤ 1000000.00).

Saída
Imprima a quantidade mínima de notas e moedas necessárias para trocar o valor inicial, 
conforme exemplo fornecido.

Obs: Utilize ponto (.) para separar a parte decimal.
*/

using System; 

class URI {

    static void Main(string[] args) { 
        double N = double.Parse(Console.ReadLine());
        
        int[] notas = {100, 50, 20, 10, 5, 2};
        int[] quantNotas = new int [notas.Length];
        
        double[] moedas = {1.0, 0.50, 0.25, 0.10, 0.05, 0.01};
        int[] quantMoedas = new int [moedas.Length];
        
        //Notas
        for(int i = 0; i < notas.Length; i ++){
            quantNotas[i] = (int)(N / notas[i]);
            N %= notas[i];
        }

        Console.WriteLine("NOTAS:");
        for(int j = 0; j < notas.Length; j++) {
            Console.WriteLine($"{quantNotas[j]} nota(s) de R$ {notas[j]}.00");
        }

        //Moedas
        
        for(int i = 0; i < moedas.Length; i++) {
            quantMoedas[i] =  (int)(N / (moedas[i]));
            N = Math.Round(N % moedas[i], 2);
        }

        Console.WriteLine("MOEDAS:");
        for(int k = 0; k < moedas.Length; k++) {
            Console.WriteLine($"{quantMoedas[k]} moeda(s) de R$ {moedas[k]:0.00}");
        }
    }

}