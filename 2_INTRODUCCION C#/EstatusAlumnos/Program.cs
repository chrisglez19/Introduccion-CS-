﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstatusAlumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            string op;
            do
            {
                Console.Clear();
                Console.WriteLine("1.-Consultar Todos\n2.-Consultar Solo Uno\n3.-Agregar\n4.-Actualizar\n5.-Eliminar\n6.-Termina ");

                Console.WriteLine("Seleccione una opción");
                op = Console.ReadLine();
                switch (op)
                {
                    case "1":
                        ListaEstatus.ConsultarTodos();
                        Console.ReadKey();

                        break;
                    case "2":
                        ListaEstatus.Consultar();
                        Console.ReadKey();
                        break;
                    case "3":
                        ListaEstatus.Agregar();
                        Console.ReadKey();
                        break;
                    case "4":
                        ListaEstatus.Actualizar();
                        Console.ReadKey();
                        break;
                    case "5":
                        ListaEstatus.Eliminar();
                        Console.ReadKey();
                        break;

                }
            } while (op != "6");
        }
    
    }
}
