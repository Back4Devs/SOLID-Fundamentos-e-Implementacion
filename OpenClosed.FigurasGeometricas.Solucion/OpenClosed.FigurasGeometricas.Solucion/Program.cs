// See https://aka.ms/new-console-template for more information
using OpenClosed.FigurasGeometricas.Solucion;

var calculadoraFiguras = new CalculadoraFiguras();
//Circulo
var circulo = new Circulo(10);
calculadoraFiguras.CalcularAreaPerimetro(circulo);
//Cuadrado
var cuadrado = new Cuadrado(8.5);
calculadoraFiguras.CalcularAreaPerimetro(cuadrado);
//Triangulo
var triangulo = new Triangulo(5, 5, 6, 4);
calculadoraFiguras.CalcularAreaPerimetro(triangulo);
