﻿/*
Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1,y1) e p2(x2,y2) e calcule a distância entre eles, mostrando 4 casas decimais, segundo a fórmula:

Distancia = V(x2 - x1)2 + (y2 - y1)2

Entrada
O arquivo de entrada contém duas linhas de dados. A primeira linha contém dois valores de ponto flutuante: x1 y1 e a segunda linha contém dois valores de ponto flutuante x2 y2.

Saída
Calcule e imprima o valor da distância segundo a fórmula fornecida, considerando 4 casas decimais.
*/

using System; 

class URI {

    static void Main(string[] args) { 
        string[] p1 = Console.ReadLine().Split(' ');
        string[] p2 = Console.ReadLine().Split(' ');
        double x1 = double.Parse(p1[0]);
        double x2 = double.Parse(p2[0]);
        double y1 = double.Parse(p1[1]);
        double y2 = double.Parse(p2[1]);
        
        double distancia =  Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine($"{distancia:F4}");
    }

}