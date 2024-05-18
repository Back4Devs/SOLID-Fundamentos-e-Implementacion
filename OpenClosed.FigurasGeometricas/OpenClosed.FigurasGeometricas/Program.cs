//Calcular area y perimetro de circulo
using OpenClosed.FigurasGeometricas;

var calculoFiguras = new CalculoFiguras();
//Circulo
var areaCirculo = calculoFiguras.CalcularAreaCirculo(10);
var perimetroCirculo = calculoFiguras.CalcularPerimetroCirculo(10);
Console.WriteLine($"Circulo: Area = {areaCirculo} Perimetro = {perimetroCirculo}");
//Cuadrado
var areaCuadrado = calculoFiguras.CalcularAreaCuadrado(8.5);
var perimetroCuadrado = calculoFiguras.CalcularPerimetroCuadrado(8.5);
Console.WriteLine($"Cuadrado: Area = {areaCuadrado} Perimetro = {perimetroCuadrado}");
//Triangulo
var areaTriangulo = calculoFiguras.CalcularAreaTriangulo(6, 4);
var perimetroTriangulo = calculoFiguras.CalcularPerimetroTriangulo(6, 5, 5);
Console.WriteLine($"Triangulo: Area = {areaTriangulo} Perimetro = {perimetroTriangulo}");