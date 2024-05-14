// See https://aka.ms/new-console-template for more information
using Discografica;

IValidable MiValidador = new Validador01();
IFabricaReproducibles MiFabrica =new Fabrica01();
MiFabrica.Validador = MiValidador;
IListasReproduccion ListaRep =new ListasReproduccion();
// Creamos a mano los objetos con unos valores
IReproducible MiCancion1 = MiFabrica.DameReproducible(EnumTipoLista.Canciones, 21);
IReproducible MiCancion2 = MiFabrica.DameReproducible(EnumTipoLista.Canciones, 5);
IReproducible MiCancion3 = MiFabrica.DameReproducible(EnumTipoLista.Canciones, 8);

//Añadimos a la lista las canciones
ListaRep.Add(MiCancion1);
ListaRep.Add(MiCancion2);
ListaRep.Add(MiCancion3);

//Console.WriteLine(MiCancion1.Duracion);
//Console.WriteLine(MiCancion2.Duracion);
//Console.WriteLine(MiCancion3.Duracion);

Console.WriteLine($"Total Duracion Lista Canciones: {ListaRep.TotalDuracionLista()}");
Console.WriteLine($"Total Elementos Lista Canciones: {ListaRep.TotalCanciones()}");

IValidable MiValidadorCorea = new ValidadorCorea();
IFabricaReproducibles MiFabricaCorea = new Fabrica01();
MiFabricaCorea.Validador = MiValidadorCorea;
IListasReproduccion ListaRepCorea = new ListasReproduccion();

IReproducible MiVideo1 = MiFabricaCorea.DameReproducible(EnumTipoLista.Videos, 10);
IReproducible MiVideo2 = MiFabricaCorea.DameReproducible(EnumTipoLista.Videos, 8);
IReproducible MiVideo3 = MiFabricaCorea.DameReproducible(EnumTipoLista.Videos, 2);

ListaRepCorea.Add(MiVideo1);
ListaRepCorea.Add(MiVideo2);
ListaRepCorea.Add(MiVideo3);

Console.WriteLine($"Total Duracion Lista Videos: {ListaRepCorea.TotalDuracionLista()}");
Console.WriteLine($"Total Elementos Lista Videos: {ListaRepCorea.TotalCanciones()}");


IValidable MiValidadorAnuncio = new Validador();
IFabricaReproducibles MiFabrica1=new Fabrica01();
MiFabrica1.Validador = MiValidador;
IListasReproduccion ListaRepAnuncio = new Coleccion02();
IReproducible MiAnuncio = MiFabrica1.DameReproducible(EnumTipoLista.Anuncio, 10);

//(MiAnuncio as ICanon).Coste = 32;
ListaRepAnuncio.Add(MiAnuncio);
Console.WriteLine($"Total Duracion Lista Anuncios: {(ListaRepAnuncio as Coleccion02).TotalDuracionLista()}");
Console.WriteLine($"Total Elementos Lista Anuncios: {(ListaRepAnuncio as Coleccion02).TotalCanciones()}");
Console.WriteLine($"Total Canon: {(ListaRepAnuncio as Coleccion02).TotalDineroListaDistribucion()}");