// See https://aka.ms/new-console-template for more information
using ConsoleAppClases.Garage;
using ConsoleAppClases.Modelo;

// Primera Opcion
ConsoleAppClases.Modelo.Coche MiCitroen = new ConsoleAppClases.Modelo.Coche();
MiCitroen.Matricula = "uahauhsuhs";
MiCitroen.Cabe = true;

//Segunda opcion
ConsoleAppClases.Modelo.Coche MiSeat = new();
MiSeat.Matricula = "fdfdfd";
MiSeat.Cabe = false;

//Tercera opcion. Es la que recomienda C#, porque a la hora de cambiar el coche por otro vehiculo es mucho mas fácil.
var MiFiat = new ConsoleAppClases.Modelo.Coche();
MiFiat.Matricula = "fdfdfd";
MiFiat.Cabe = false;

//Cuarta opcion es la mejor.  La que recomienda Microsoft
var MiMercedes = new ConsoleAppClases.Modelo.Coche() { Matricula="dsdsdsdsdsds",Cabe=true};
var MiPorche = new ConsoleAppClases.Modelo.Coche("dddddddd",false);
var MiFerrari = new ConsoleAppClases.Modelo.Coche("ghhkdh",true);
var MiEjemplo = new ConsoleAppClases.Modelo.Coche("pldybg");

Console.WriteLine(MiMercedes); // Cuando se imprime un objeto de la clase coche.  Para ello sobreescrimos el ToString

IFactoryAlquilable Factoria =new AlquilableFactoryV01();

IAlquilable alquilable = Factoria.dameElemento(EnumTipos.Coche,"aaaaaa",8);
IAlquilable alquilable1 = Factoria.dameElemento(EnumTipos.Furgoneta, "dsdsaa", 9);

//IAlquilable alquilable = new ConsoleAppClases.Garage.Coche() { Identificador = "juju", Tiempo = 2 };

//MiMercedes.Visor = new VisionadorConsola();



IAlquilable alquilable2 = new Furgoneta() { Identificador = "furgo", Tiempo = 6 };

Console.WriteLine(alquilable);
Console.WriteLine(alquilable2);

