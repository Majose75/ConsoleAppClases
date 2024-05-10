// See https://aka.ms/new-console-template for more information


using EjercicioSuperficieperimetro.Modelo;

//////////IFactoriaMedibles Figuras = new Factoria();
//////////IMedible Objeto = Figuras.dameFigura(EnumTipos.Circulo,12);
//////////IMedible Objeto1 = Figuras.dameFigura(EnumTipos.Cuadrado, 5);

//////////(Objeto1 as Cuadrado).Visor = new VisionadorConsola();
//////////Console.WriteLine(Objeto);
//////////Console.WriteLine(Objeto1);


//Factoria01 MiFactoria = new();
//var MiCuadrado = MiFactoria.DameFigura(TipoFigura.Cuadrado, 4);
//MiFactoria.DameFigura(TipoFigura.Circulo, 9);
//Console.WriteLine($"Soy un cuadrado de area {MiCuadrado.dameSuperficie()}");

Factoria MiFactoria = new();
var MiCuadrado = MiFactoria.dameFigura(EnumTipos.Cuadrado, 5);
var MiCirculo= MiFactoria.dameFigura(EnumTipos.Circulo, 12);
var MiCuadrado2=MiFactoria.dameFigura(EnumTipos.Cuadrado, 2);
Console.WriteLine(MiCuadrado);
Console.WriteLine(MiCirculo);

TableroFiguras MiTablero = new();
MiTablero.Add(MiCuadrado);
MiTablero.Add(MiCirculo);
MiTablero.Add(MiCuadrado2);
Console.WriteLine("El Total de Figuras es: " + MiTablero.dameTotalFiguras());
Console.WriteLine("El Perimetro Total es de: " + MiTablero.damePerimetroTotal());
Console.WriteLine("La Superficie Total es de: " + MiTablero.dameSuperficieTotal());
Console.WriteLine("La Figura más pequeña es: " + MiTablero.dameFiguraMinima());
Console.WriteLine("La Figura más grande es: " + MiTablero.dameFiguraMaxima());
Console.WriteLine("La media del Perimetro Total es de: " + MiTablero.mediaPerimetro());
Console.WriteLine("La Media de la Superficie Total es de: " + MiTablero.mediaSuperficie());

