// See https://aka.ms/new-console-template for more information
using ConceptosPOO;
Console.WriteLine("*********MI APLICACION********");

try
{
    Console.WriteLine(new Date(2022, 11, 28).ToString());
}
catch (Exception error)
{

    Console.WriteLine(error.Message);
}



