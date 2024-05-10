// See https://aka.ms/new-console-template for more information
using ConsoleAppClases.Modelo;
using System;

Console.WriteLine("Introduce la Potencia del coche 1: ");
String damePotencia = Console.ReadLine();
Console.WriteLine("Introduce el numero de Ruedas del coche 1: ");
String dameRuedas = Console.ReadLine();
Console.WriteLine("Introduce la Velocidad del coche 1: ");
String dameVelocidad = Console.ReadLine();
Console.WriteLine("Introduce la Potencia del coche 2: ");
String damePotencia2 = Console.ReadLine();
Console.WriteLine("Introduce el numero de Ruedas del coche 2: ");
String dameRuedas2 = Console.ReadLine();
Console.WriteLine("Introduce la Velocidad del coche 2: ");
String dameVelocidad2 = Console.ReadLine();
Console.WriteLine("Introduce la Potencia del coche 2: ");

var MiCoche1 = new Vehiculo(Convert.ToDouble(damePotencia),Convert.ToInt16(dameRuedas), Convert.ToDouble(dameVelocidad));
var MiCoche2 = new Vehiculo(Convert.ToDouble(damePotencia2), Convert.ToInt16(dameRuedas2), Convert.ToDouble(dameVelocidad2));


Console.WriteLine(MiCoche1);
Console.WriteLine(MiCoche2);