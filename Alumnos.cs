using System;
using System.Collections.Generic;

class ModuloAlumnos
{
    // LinkedList porque la lista CAMBIA constantemente.
    // Insertar/eliminar NO requiere mover otros elementos.
    static LinkedList<string> inscritos = new LinkedList<string>();

    public static void Inscribir(string nombre)
    {
        inscritos.AddLast(nombre);           // O(1) — no mueve a nadie
        Console.WriteLine($"✔ {nombre} inscrito. Total: {inscritos.Count}");
    }

    public static void DarDeBaja(string nombre)
    {
        if (inscritos.Contains(nombre))
        {
            inscritos.Remove(nombre);        // Solo redirige punteros
            Console.WriteLine($"✖ {nombre} dado de baja.");
        }
        else
        {
            Console.WriteLine($"⚠ {nombre} no está inscrito.");
        }
    }

    public static void MostrarInscritos()
    {
        Console.WriteLine("=== ALUMNOS INSCRITOS ===");
        foreach (string a in inscritos)
            Console.WriteLine($"  · {a}");
        Console.WriteLine($"Total: {inscritos.Count}");
    }
}
