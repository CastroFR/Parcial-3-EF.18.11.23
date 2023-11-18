using Microsoft.Data.SqlClient;

using (var contextdb = new Context()) 
{
    contextdb.Database.EnsureCreated(); 

    bool continuar = true;
    while (continuar)
    {
        Console.WriteLine("Ingrese un Id: ");
        int Id = int.Parse(Console.ReadLine());

        Console.WriteLine("\nIngrese el nombre del estudiante: ");
        string estudiante = Console.ReadLine();
        
        Console.WriteLine("\nIngrese las notas de sus parciales \nTome en cuenta utilizar coma en lugar de punto: ");
        double parciales = float.Parse(Console.ReadLine());

        Console.WriteLine("\nIngrese la nota de sus laboratorios: ");
        double laboratorios = float.Parse(Console.ReadLine());

        Console.WriteLine("\nIngrese la nota final: ");
        double final = float.Parse(Console.ReadLine());

        var Notas = new NOTAS
        {
            Id = Id,
            estudiante = estudiante,
            parciales = parciales,   
            laboratorios = laboratorios,
            final = final,
        };

        contextdb.Add(Notas);  
        contextdb.SaveChanges();    

        Console.Write("¿Desea agregar otro registro? (S/N): ");
        string respuesta = Console.ReadLine();
        continuar = (respuesta.ToLower() == "s \n");

        
        
        
        Console.WriteLine("\nLOS DATOS REGISTRADOS SON LOS SIGUIENTES: \n");

        foreach (var s in contextdb.Notas)
        {
            Console.WriteLine("Id: " + s.Id + "\nestudiante: " + s.estudiante + "\nparciales: " + s.parciales + "\nlaboratorios: " + s.laboratorios + "\nfinal: " + s.final);
        }
    }
}
