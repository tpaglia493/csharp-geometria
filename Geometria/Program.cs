/* 
BONUS:
Aggiungere alla classe Rettangolo un metodo “disegna” che disegna in console il rettangolo con le sue dimensioni, 
ossia tanti “—” (due trattini) orizzontali quanto è grande la sua base e tanti ‘|’ verticali quanto e grande la sua altezza.
*/

//---------------------------- MAIN PROGRAM ------------------------------
using Geometria;

Rectangle[] arrayOfRectangles = CreateArrayFromInput();

Console.WriteLine(arrayOfRectangles.Length);

for (int i = 0; i < arrayOfRectangles.Length; i++)
{
    arrayOfRectangles[i].PrintRectangleDescription();
    arrayOfRectangles[i].DrawPerimeter();
}





//------------------------------ FUNCTIONS --------------------------------

//FUNZIONE PER CREARE ARRAY DA INPUT
Rectangle[] CreateArrayFromInput()
{
    int ArrayLengthFromInput;
    Rectangle[] array;

    Console.Write("How long should the list be? ");
    //TODO: LEARN HOW TO VALIDATE INPUTS
    try
    {
        ArrayLengthFromInput = int.Parse(Console.ReadLine());
    }
    catch (Exception e)
    {
        Console.WriteLine("Please insert a number ");
        Console.Write("How long should the list be? ");
        ArrayLengthFromInput = int.Parse(Console.ReadLine());
    }



    array = new Rectangle[ArrayLengthFromInput];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Please insert the heigth of the rectangle:");
        int rectangleHeigth = int.Parse(Console.ReadLine());

        Console.Write("Please insert the length of the base of the rectangle:");
        int rectangleBaseLength = int.Parse(Console.ReadLine());

        Rectangle newRectangle = new Rectangle(rectangleBaseLength, rectangleHeigth);

        array[i] = newRectangle;
    }

    return array;


}