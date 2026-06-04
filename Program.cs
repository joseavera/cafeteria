using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("╔══════════════════════════════════╗");
        Console.WriteLine("║    CAFETERÍA DIGITAL v1.0        ║");
        Console.WriteLine("╚══════════════════════════════════╝\n");

        // ── MÓDULO 1: Menú (Array — fijo, nunca cambia) ──────────────
        ModuloMenu.MostrarMenu();
        ModuloMenu.MostrarExtremos();

        Console.WriteLine();

        // ── MÓDULO 2: Alumnos (LinkedList — crece y encoge) ──────────
        ModuloAlumnos.Inscribir("Ana Ramírez");
        ModuloAlumnos.Inscribir("Luis Torres");
        ModuloAlumnos.Inscribir("Sofía Gómez");
        ModuloAlumnos.DarDeBaja("Luis Torres");
        ModuloAlumnos.MostrarInscritos();

        Console.WriteLine();

        // ── MÓDULO 3: Pedidos (Queue + Stack — orden + historial) ─────
        ModuloPedidos.RegistrarPedido("Ana Ramírez",  "Tacos x2");
        ModuloPedidos.RegistrarPedido("Sofía Gómez",  "Café americano");
        ModuloPedidos.RegistrarPedido("Marco Díaz",   "Torta de jamón");

        ModuloPedidos.VerEstado();
        ModuloPedidos.AtenderSiguiente();
        ModuloPedidos.AtenderSiguiente();
        ModuloPedidos.CancelarUltimo();
        ModuloPedidos.VerEstado();
    }
}
