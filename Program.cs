// See https://aka.ms/new-console-template for more information
using csharp_abstract_animals;

/*
 * 
 * 
 * *Esercizio 1 : classi astratte*
    Dobbiamo realizzare un programma che rappresenti il regno animale.
    Creiamo quindi una classe astratta Animale e delle classi che la estendono : Cane, Passerotto, Aquila, Delfino
    Vogliamo che gli animali abbiano i seguenti metodi
    - void Dormi() (mostra a video “Zzz”)
    - void Verso() (mostra a video il verso fatto dall'animale specifico)
    - void Mangia() (mostra a video quello che mangia : erba, carne, ...?)
    Quali di questi metodi devono essere implementati nella classe astratta e quali devono essere lasciati astratti e implementati dalle classi che la estendono?
    Una volta create le classi, nel programma istanziare alcuni animali e utilizzare i metodi implementati.

    *Esercizio 2 : interfacce*
    Alcuni degli animali che abbiamo creato volano, altri nuotano.
    Gli animali che volano hanno il seguente metodo :
    - void Vola() (mostra a video “Sto volando!!!”)
    Gli animali che nuotano hanno il seguente metodo :
    - void Nuota() (mostra a video “Sto nuotando!!!”)
    Scrivere un programma avente 2 metodi :
    - void FaiVolare(IVolante animale)
    - void FaiNuotare(INuotante animale)
    Questi metodi prendono come parametro un animale che può o volare / nuotare e richiamano il corrispondente metodo Vola() / Nuota().
    Scrivere un programma che istanzi animali che volano o nuotano e richiamare i metodi FaiVolare / FaiNuotare passandoglieli come parametro.

 * 
 * */

Cane cane1 = new Cane();
Passerotto passerotto1 = new Passerotto();
Aquila aquila1 = new Aquila();
Delfino delfino1 = new Delfino();


void FaiVolare( )
    {

    }

    void FaiNuotare()
    {

    }

   


Console.WriteLine("Attributi del cane:");
Console.WriteLine($"Puo' dormire?:");
cane1.Dormi();
Console.WriteLine($"Verso: {cane1.VersoEmesso}");
Console.WriteLine($"Cibo: {cane1.Cibo}");

Console.WriteLine(System.Environment.NewLine) ;

Console.WriteLine("Attributi del passerotto:");
Console.WriteLine($"Verso: {passerotto1.VersoEmesso}");
Console.WriteLine($"Cibo: {passerotto1.Cibo}");
passerotto1.Vola();

Console.WriteLine(System.Environment.NewLine);

Console.WriteLine("Attributi dell'aquila:");
Console.WriteLine($"Verso: {aquila1.VersoEmesso}");
Console.WriteLine($"Cibo: {aquila1.Cibo}");
aquila1.Vola();

Console.WriteLine(System.Environment.NewLine);

Console.WriteLine("Attributi del delfino:");
Console.WriteLine($"Verso: {delfino1.VersoEmesso}");
Console.WriteLine($"Cibo: {delfino1.Cibo}");
delfino1.Nuota();

Console.WriteLine(System.Environment.NewLine);


