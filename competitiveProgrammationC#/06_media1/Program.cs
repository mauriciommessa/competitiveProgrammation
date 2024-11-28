/*
*Leia dois valores inteiros. A seguir, calcule o produto entre estes dois valores e atribua esta *operação à variável PROD. A seguir mostre a variável PROD com mensagem correspondente.   
*
*Entrada
*O arquivo de entrada contém 2 valores inteiros.
*
*Saída
*Imprima a mensagem "PROD" e a variável PROD conforme exemplo abaixo, com um espaço em branco antes e 
*depois da igualdade. Não esqueça de imprimir o fim de linha após o produto, caso contrário seu programa 
*apresentará a mensagem: “Presentation Error”.
*/

using System; 

class URI {

    static void Main(string[] args) { 
        double notaA = double.Parse(Console.ReadLine());
        double notaB = double.Parse(Console.ReadLine());
        
        double pesoA = 3.5;
        double pesoB = 7.5;
        
        double media = (notaA * pesoA + notaB * pesoB) / (pesoA + pesoB);
        Console.WriteLine($"MEDIA = {media:F5}");
    }

}