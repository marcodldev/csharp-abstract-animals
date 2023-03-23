﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
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
    public abstract class Animale
    {
      
        public void Dormi()
        {
            Console.WriteLine("ZZzzzz...");
        }

        public abstract void Verso();
        public abstract void Mangia();
    }
}
