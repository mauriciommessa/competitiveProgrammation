/*
*Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da 
*mensagem “eh o maior”. Utilize a fórmula:
*(a+b+abs(a-b)) / 2
*Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo,
*portanto é necessário para chegar no resultado esperado.
*
*Entrada
*O arquivo de entrada contém três valores inteiros.
*
*Saída
*Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".
*/

using System; 

class URI {

    static void Main(string[] args) { 
        string[] input = Console.ReadLine().Split(' ');
        int n1 = int.Parse(input[0]);
        int n2 = int.Parse(input[1]);
        int n3 = int.Parse(input[2]);
        
        int maiorAB = (n1 + n2 + Math.Abs(n1 - n2)) / 2;
        int maior = (maiorAB + n3 + Math.Abs(maiorAB - n3)) / 2;
        
        Console.WriteLine($"{maior} eh o maior");
    }

}