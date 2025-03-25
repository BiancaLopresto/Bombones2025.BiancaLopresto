// See https://aka.ms/new-console-template for more information
using Bombones2025.Entidades;
using Bombones2025.Servicios;

Console.WriteLine("Hello, Bombones!!!!!!!!");
var paisesServicio = new PaisServicio("Paises.txt");
var fsServicio = new FrutosSecosServicio("FrutosSecos.txt");

try
{
    Console.WriteLine("1 - Pais");
    Console.WriteLine("2 - Fruto Seco");
    Console.WriteLine("3 - Salir");
    Console.Write("Ingrese selección:");
    var opcion = Console.ReadLine();
    switch (opcion)
    {
        case "1":

            List<Pais> paises = paisesServicio.GetPaises();
            foreach (Pais pais in paises)
            {
                Console.WriteLine(pais.ToString());
            }
            break;
        case "2":

            List<FrutosSecos> FrutoSeco = fsServicio.GetFrutoSeco();
            foreach (FrutosSecos fs in FrutoSeco)
            {
                Console.WriteLine(fs.ToString());
            }
            break;
        case "3":
            return;
            
    }

}
catch (Exception ex)
{

    Console.WriteLine(ex.Message); ;
}













