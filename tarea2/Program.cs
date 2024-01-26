using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Datos Usuario
            Console.WriteLine("Ingrese el número de cédula del empleado:");
            string cedula = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre del empleado:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el tipo de empleado (1-Operario, 2-Técnico, 3-Profesional):");
            int tipoEmpleado = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de horas laboradas:");
            int horasLaboradas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el precio por hora:");
            double precioPorHora = Convert.ToDouble(Console.ReadLine());

            // Calcular salario ordinario
            double salarioOrdinario = horasLaboradas * precioPorHora;

            // Calcular aumento según el tipo de empleado
            double porcentajeAumento = 0.0;

            switch (tipoEmpleado)
            {
                case 1: // Operario
                    porcentajeAumento = 0.15;
                    break;
                case 2: // Técnico
                    porcentajeAumento = 0.10;
                    break;
                case 3: // Profesional
                    porcentajeAumento = 0.05;
                    break;
                default:
                    Console.WriteLine("Tipo de empleado no válido");
                    return;
            }
            string empleado = " ";

            switch (tipoEmpleado)
            {
                case 1: // Operario
                    empleado = "Operario";
                    break;
                case 2: // Técnico
                    empleado = "Tecnico";
                    break;
                case 3: // Profesional
                    empleado = "Profesional";
                    break;
                default:
                    Console.WriteLine("Tipo de empleado no válido");
                    return;
            }

            double aumento = salarioOrdinario * porcentajeAumento;

            // Calcular salario bruto (ordinario + aumento)
            double salariobruto = salarioOrdinario + aumento;

            // Calcular deducciones por CCSS (9.17%)
            double deduccionesCCSS = salariobruto * 0.0917;

            // Restar deducciones del salario bruto
            double salarioNeto = salariobruto - deduccionesCCSS;

            // Mostrar la información
            Console.WriteLine("\nInformación del empleado:");
            Console.WriteLine($"Cédula: {cedula}");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Tipo de empleado: {empleado}");
            Console.WriteLine($"Horas laboradas: {horasLaboradas}");
            Console.WriteLine($"Precio por hora : ${precioPorHora}");
            Console.WriteLine($"Salario ordinario : ${salarioOrdinario}");
            Console.WriteLine($"Aumento ({porcentajeAumento * 100}%):  ${aumento}");
            Console.WriteLine($"Salario bruto : ${salariobruto}");
            Console.WriteLine($"Deducciones CCSS (9.17%): {deduccionesCCSS}");
            Console.WriteLine($"Salario neto $: {salarioNeto}");

            Console.Read();
        }
    }
}
