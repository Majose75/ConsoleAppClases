using Ejercito;
IValidable validable = new Validador();
IFabrica MiFabrica =new Fabrica01(validable);
IColeccion ListaEjercito01 = new Coleccion01();

IMilitable MiArtilleria1 = MiFabrica.dameInstancia(EnumDivisiones.Artilleria,"Cañon Antiaereo",1,0,22,1100);
IMilitable MiArtilleria2 = MiFabrica.dameInstancia(EnumDivisiones.Artilleria, "Torpedero movil", 3, 2, 19, 1350);
IMilitable MiArtilleria3 = MiFabrica.dameInstancia(EnumDivisiones.Artilleria, "Cañon", 0, 0, 14, 1100);

IMilitable MiInfanteria1 = MiFabrica.dameInstancia(EnumDivisiones.Infanteria, "Infanteria Basica", 6, 0, 7, 250);
IMilitable MiInfanteria2 = MiFabrica.dameInstancia(EnumDivisiones.Infanteria, "Ametrallador", 4, 0, 10, 400);
IMilitable MiInfanteria3 = MiFabrica.dameInstancia(EnumDivisiones.Infanteria, "Sanitario", 7, 5, 0, 500);

IMilitable MiCaballeria1 = MiFabrica.dameInstancia(EnumDivisiones.Caballeria, "Transporte MX-7899", 4.5, 1.4, 0, 4200);
IMilitable MiCaballeria2 = MiFabrica.dameInstancia(EnumDivisiones.Caballeria, "Tanque de ataque Sombras-VB98", 7.3, 4.8, 9.8, 15600);
IMilitable MiCaballeria3 = MiFabrica.dameInstancia(EnumDivisiones.Caballeria, "Transporte rapido TAXIN-66", 12, 0, 0, 1600);

ListaEjercito01.Add(MiInfanteria1); 
ListaEjercito01.Add(MiInfanteria2);
ListaEjercito01.Add(MiInfanteria3);
ListaEjercito01.Add(MiCaballeria1);
ListaEjercito01.Add(MiCaballeria2);
ListaEjercito01.Add(MiCaballeria3);
ListaEjercito01.Add(MiArtilleria1);
ListaEjercito01.Add(MiArtilleria2);
ListaEjercito01.Add(MiArtilleria3);


Console.WriteLine("Este ejercito tiene:");
Console.WriteLine($"{ListaEjercito01.DameElementos()} elementos.");
Console.WriteLine($"Potencia Total de Fuego: {ListaEjercito01.DamePotenciaTotal()}.");
Console.WriteLine($"Blindaje Total: {ListaEjercito01.DameBlindajeTotal()}.");
Console.WriteLine($"Capacidad de Movimiento de: {ListaEjercito01.DameMovimientoTotal()}.");
Console.WriteLine($"Total dinero Gastado: {ListaEjercito01.TotalGastado()}.");
Console.WriteLine($"Capacidad Militar de: {ListaEjercito01.CapacidadMilitar()}.");


string MuestraOpciones()
{
    Console.WriteLine("Seleccione Division:");
    Console.WriteLine("1.- ARTILLERIA");
    Console.WriteLine("2.- INFANTERIA");
    Console.WriteLine("3.- CABALLERIA");

    Console.WriteLine("0.- Salir");
    return Console.ReadLine();
}

int entrada = 0;
while(entrada!=0)
{
    entrada = MuestraOpciones();
    switch (entrada)
    {
        case 1: MeteDatos(EnumDivisiones.Artilleria, MeteDatos());break;
        
        default:
            break;
    }
} 
void MeteDatos(EnumDivisiones division, string nombre, double movimiento, double blindaje, double potencia, double precio)
{
    IMilitable MiArtilleria = MiFabrica.dameInstancia(EnumDivisiones.Artilleria,nombre,movimiento,blindaje,potencia,precio);
    if (MiArtilleria != null)
    {
        Console.WriteLine("Introduzca los siguientes datos del elemento:");
        Console.WriteLine("NOMBRE:");
        nombre=Console.ReadLine();
        Console.WriteLine("VELOCIDAD:");
        movimiento= Int32.Parse(Console.ReadLine());
        Console.WriteLine("BLINDAJE:");
        blindaje= Int32.Parse(Console.ReadLine());
        Console.WriteLine("POTENCIA de FUEGO:");
        potencia= Int32.Parse(Console.ReadLine());
        Console.WriteLine("PRECIO:");
       precio=Int32.Parse(Console.ReadLine());
       
           
        ListaEjercito01.Add(MiArtilleria);
        Console.WriteLine($"Creado {division} .....");
    }
    else
    {
        Console.WriteLine($"Error en la creación del elemento {division}");
    }
}