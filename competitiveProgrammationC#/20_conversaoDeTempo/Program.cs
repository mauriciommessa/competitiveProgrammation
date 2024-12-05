/*
Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma 
fábrica, e informe-o expresso no formato horas:minutos:segundos.

Entrada
O arquivo de entrada contém um valor inteiro N.

Saída
Imprima o tempo lido no arquivo de entrada (segundos), convertido para 
horas:minutos:segundos, conforme exemplo fornecido.
*/

using System; 

class URI {

    static void Main(string[] args) { 
        int segundos = int.Parse(Console.ReadLine());
        
        int min = segundos / 60;
        int horas = min / 60;
        min = min % 60;
        int seg = segundos - (min * 60) - (horas * 60 * 60);

        Console.WriteLine($"{horas}:{min}:{seg}");
    }

}