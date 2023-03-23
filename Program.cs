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

 * 
 * */

Cane cane1 = new Cane();
Passerotto passerotto1 = new Passerotto();
Aquila aquila1 = new Aquila();
Delfino delfino1 = new Delfino();

Console.WriteLine("Attributi del cane:");
Console.WriteLine($"Verso: {cane1.VersoEmesso}");
Console.WriteLine($"Cibo: {cane1.Cibo}");

Console.WriteLine(System.Environment.NewLine) ;

Console.WriteLine("Attributi del passerotto:");
Console.WriteLine($"Verso: {passerotto1.VersoEmesso}");
Console.WriteLine($"Cibo: {passerotto1.Cibo}");

Console.WriteLine(System.Environment.NewLine);

Console.WriteLine("Attributi dell'aquila:");
Console.WriteLine($"Verso: {aquila1.VersoEmesso}");
Console.WriteLine($"Cibo: {aquila1.Cibo}");

Console.WriteLine(System.Environment.NewLine);

Console.WriteLine("Attributi del delfino:");
Console.WriteLine($"Verso: {delfino1.VersoEmesso}");
Console.WriteLine($"Cibo: {delfino1.Cibo}");

Console.WriteLine(System.Environment.NewLine);


