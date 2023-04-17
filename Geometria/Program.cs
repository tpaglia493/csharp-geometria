/* Esercitazione di oggi: Geometria
Nome repo: csharp-geometria
Consegna:
Nel progetto csharp-geometria seguite i seguenti passi:
1. Creare una classe Rettangolo con due attributi interi: baseRettangolo e altezzaRettangolo.
Aggiungere un opportuno costruttore con parametri.
Aggiungere due metodi: calcolaArea e calcolaPerimetro che calcolano e restituiscono, rispettivamente, l’area e il perimetro del rettangolo.
2. Poi, nel vostro programma principale (Program.cs) chiedete all’utente di inserire, da console, 
i valori di base e di altezza con cui istanziare un nuovo Rettangolo. 
Dopo averlo istanziato, stampate a video il perimetro e l’area del rettangolo che avete costruito.
3. Provate ad istanziare tanti rettangoli con nome diverso e attributi diversi (baseRettangolo e altezzaRettangolo cambiati) 
e provate a stampare le loro proprietà ad esempio con un metodo StampaRettangolo che vi stampi il vostro rettangolo ad esempio cosi:
 —— Rettangolo ——
base: 20 cm
altezza: 10 cm
Perimetro: 60 cm
Area: 200 cm2
BONUS:
Aggiungere alla classe Rettangolo un metodo “disegna” che disegna in console il rettangolo con le sue dimensioni, 
ossia tanti “—” (due trattini) orizzontali quanto è grande la sua base e tanti ‘|’ verticali quanto e grande la sua altezza.
*/

//---------------------------- MAIN PROGRAM ------------------------------
using Geometria;

Console.Write("Please insert the heigth of the rectangle:");
int rectangleHeigth = int.Parse(Console.ReadLine());

Console.Write("Please insert the length of the base of the rectangle:");
int rectangleBaseLength = int.Parse(Console.ReadLine());

Rectangle newRectangle = new Rectangle(rectangleBaseLength, rectangleHeigth);

Console.WriteLine("The perimeter is " + newRectangle.GetPerimeter()+"cm"); ;
Console.WriteLine("The area is " + newRectangle.GetArea()+"cm^2");