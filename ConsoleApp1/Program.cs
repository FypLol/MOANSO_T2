Console.WriteLine("Hello, World!");
MostrarIntegrante("Ever");

static void MostrarIntegrante(string nombre)
{
    Console.WriteLine("Cambio realizado por: " + nombre);
    Console.WriteLine("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy"));
}