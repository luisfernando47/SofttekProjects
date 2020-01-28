using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace SerializarJSon
{
     class Program
    {
        static void Main(string[] args)
        {
            //Crear objeto per1 de tipo persona
            Persona per1 = new Persona
            {
                Name="Fernando",
                LastName="Gonzalez",
                Age=26
            };
            //crear lista de tipo Persona para agregar registro
            List<Persona> ListaDatos = new List<Persona>();
            ListaDatos.Add(per1);

            //Serializar JSON
            var JsonSerializerDoc= JsonSerializer.Serialize(ListaDatos);
            //Guardar el archivo verificando si existe el documento, de lo contrario lo leera
            if (File.Exists(@"C:\Users\Curso\Documents\Proyectos\Json\info.txt"))
            {
                Console.WriteLine("Leyendo documento... ");
                using (StreamReader sr = File.OpenText(@"C:\Users\Curso\Documents\Proyectos\Json\info.txt"))
                {
                    string str = "";
                    while ((str = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(str);
                        Console.ReadLine();
                    }
                }

            }
            else
            {
                File.WriteAllText(@"C:\Users\Curso\Documents\Proyectos\Json\info.txt", JsonSerializerDoc);
                Console.WriteLine("Documento Creado");
                Console.ReadLine();
            }

        }
    }
}
