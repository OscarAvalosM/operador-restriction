using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{

   //se crea una clase y esta se identifica 
   //en mi caso tengo una string para el nombre y una int para los estudiantes
    class centroescolar
    {
        public string nombre { get; set; }
        public int estudiantes { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {



            //se crearia una lista con los datis que requeriremos con los que ocuparemos que seria nombre y estudiantes
            List<centroescolar> aprobadas = new List<centroescolar>()
            {
                new centroescolar(){ nombre = "centro escolar baltazar", estudiantes = 25},//sele asignan un valor a cada uno ejemplo nombre sele da un nombre y una cantidad de estudiantes
                new centroescolar(){ nombre = "centro escolar catolico", estudiantes = 55},
                new centroescolar(){ nombre = "centro escolar las flores", estudiantes = 10},
                new centroescolar(){ nombre = "centro escolar baltzar ", estudiantes = 14},
                new centroescolar(){ nombre = "centro escolar  san pedro ", estudiantes = 18},
             
            };

            var EscuelasConSufienteEstudiantes = aprobadas.Where(x => x.estudiantes >= 15).ToList();//crea un filtro para que no aparescan escuelas con menores a 15 estuantes



            Console.Read();//cerramos 

            //para ejecucion aprete f10 
        }
    }

   

}
