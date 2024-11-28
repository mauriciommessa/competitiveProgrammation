/*
Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.

Entrada
O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, respectivamente dois inteiros e um valor com 2 casas decimais.

Saída
A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de deixar um espaço após os dois pontos e um espaço após o "R$". O valor deverá ser apresentado com 2 casas após o ponto.
*/

using System; 

class URI {

    static void Main(string[] args) { 
        // Leitura e separação da primeira linha
        string[] input1 = Console.ReadLine().Split(' ');
        int cod1 = int.Parse(input1[0]);
        int num1 = int.Parse(input1[1]);
        double valor1 = double.Parse(input1[2]);
        
        // Leitura e separação da segunda linha
        string[] input2 = Console.ReadLine().Split(' ');
        int cod2 = int.Parse(input2[0]);
        int num2 = int.Parse(input2[1]);
        double valor2 = double.Parse(input2[2]);
        
        // Cálculo do total
        double total = (num1 * valor1) + (num2 * valor2);
        
        // Formatação e exibição do resultado
        Console.WriteLine($"VALOR A PAGAR: R$ {total:F2}");
    }

}
