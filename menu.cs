using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Examen1.Empleado;

namespace Examen1
{
    internal class Menu
    {
      
        
            private List<Empleado> empleados = new List<Empleado>();

            public void MostrarMenu()
            {
                int opcion;
                do
                {
                    Console.WriteLine("Menú Principal:");
                    Console.WriteLine("1. Agregar Empleados");
                    Console.WriteLine("2. Consultar Empleados");
                    Console.WriteLine("3. Modificar Empleados");
                    Console.WriteLine("4. Borrar Empleados");
                    Console.WriteLine("5. Inicializar Arreglos");
                    Console.WriteLine("6. Reportes");
                    Console.WriteLine("7. Salir");
                    Console.Write("Seleccione una opción: ");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            AgregarEmpleado();
                            break;
                        case 2:
                            ConsultarEmpleado();
                            break;
                        case 3:
                            ModificarEmpleado();
                            break;
                        case 4:
                            BorrarEmpleado();
                            break;
                        case 5:
                            InicializarArreglos();
                            break;
                        case 6:
                            MostrarReportes();
                            break;
                        case 7:
                            Console.WriteLine("Saliendo del sistema...");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Intente de nuevo.");
                            break;
                    }
                } while (opcion != 7);
            }

            private void AgregarEmpleado()
            {
                Console.Write("Ingrese la cédula: ");
                string cedula = Console.ReadLine();
                Console.Write("Ingrese el nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingrese la dirección: ");
                string direccion = Console.ReadLine();
                Console.Write("Ingrese el teléfono: ");
                string telefono = Console.ReadLine();
                Console.Write("Ingrese el salario: ");
                double salario = double.Parse(Console.ReadLine());

                Empleado nuevoEmpleado = new Empleado(cedula, nombre, direccion, telefono, salario);
                empleados.Add(nuevoEmpleado);
                Console.WriteLine("Empleado agregado");
            }

            private void ConsultarEmpleado()
            {
                Console.Write("Ingrese la cédula del empleado a consultar: ");
                string cedula = Console.ReadLine();
                Empleado empleado = empleados.FirstOrDefault(e => e.Cedula == cedula);

                if (empleado != null)
                {
                    empleado.MostrarEmpleado();
                }
                else
                {
                    Console.WriteLine("Empleado no encontrado.");
                }
            }

            private void ModificarEmpleado()
            {
                Console.Write("Ingrese la cédula del empleado a modificar: ");
                string cedula = Console.ReadLine();
                Empleado empleado = empleados.FirstOrDefault(e => e.Cedula == cedula);

                if (empleado != null)
                {
                    Console.Write("Ingrese el nuevo nombre: ");
                    empleado.Nombre = Console.ReadLine();
                    Console.Write("Ingrese la nueva dirección: ");
                    empleado.Direccion = Console.ReadLine();
                    Console.Write("Ingrese el nuevo teléfono: ");
                    empleado.Telefono = Console.ReadLine();
                    Console.Write("Ingrese el nuevo salario: ");
                    empleado.Salario = double.Parse(Console.ReadLine());
                    Console.WriteLine("Empleado modificado exitosamente.");
                }
                else
                {
                    Console.WriteLine("Empleado no encontrado.");
                }
            }

            private void BorrarEmpleado()
            {
                Console.Write("Ingrese la cédula del empleado a borrar: ");
                string cedula = Console.ReadLine();
                Empleado empleado = empleados.FirstOrDefault(e => e.Cedula == cedula);

                if (empleado != null)
                {
                    empleados.Remove(empleado);
                    Console.WriteLine("Empleado borrado exitosamente.");
                }
                else
                {
                    Console.WriteLine("Empleado no encontrado.");
                }
            }

            private void InicializarArreglos()
            {
                empleados.Clear();
                Console.WriteLine("Arreglos inicializados.");
            }

            private void MostrarReportes()
            {
                int opcion;
                do
                {
                    Console.WriteLine("Menú de Reportes:");
                    Console.WriteLine("1. Listar todos los empleados ordenados por nombre");
                    Console.WriteLine("2. Calcular y mostrar el promedio de los salarios");
                    Console.WriteLine("3. Volver al menú principal");
                    Console.Write("Seleccione una opción: ");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            ListarEmpleadosPorNombre();
                            break;
                        case 2:
                            MostrarPromedioSalarios();
                            break;
                        case 3:
                            Console.WriteLine("Volviendo al menú principal");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Intente de nuevo.");
                            break;
                    }
                } while (opcion != 3);
            }

            private void ListarEmpleadosPorNombre()
            {
                var empleadosOrdenados = empleados.OrderBy(e => e.Nombre).ToList();
                foreach (var empleado in empleadosOrdenados)
                {
                    empleado.MostrarEmpleado();
                }
            }

            private void MostrarPromedioSalarios()
            {
                if (empleados.Count > 0)
                {
                    double promedio = empleados.Average(e => e.Salario);
                    Console.WriteLine($"El promedio de los salarios es: {promedio}");
                }
                else
                {
                    Console.WriteLine("No hay empleados para calcular el promedio.");
                }
        