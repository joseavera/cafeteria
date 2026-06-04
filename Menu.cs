using System;

class ModuloMenu
{
    // Arreglo fijo: el menú siempre tiene exactamente 6 platillos
    // No usamos List<T> porque el tamaño nunca cambia
    static string[] platillos = {
        "Tacos x2", "Torta de jamón", "Agua 500ml",
        "Jugo naranja", "Café americano", "Arroz con leche"
    };

    // Arreglo paralelo: platillos[i] ↔ precios[i]
    static double[] precios = {
        35.0, 45.0, 18.0,
        25.0, 22.0, 20.0
    };

    public static void MostrarMenu()
    {
        Console.WriteLine("=== MENÚ CAFETERÍA ===");
        for (int i = 0; i < platillos.Length; i++)
        {
            Console.WriteLine($"[{i}] {platillos[i],-20} ${precios[i]:F2}");
        }
    }

    public static void MostrarExtremos()
    {
        // Empezamos en i=1 porque ya asumimos que [0] es el máximo y mínimo
        double max = precios[0], min = precios[0];
        int    iMax = 0,        iMin = 0;

        for (int i = 1; i < precios.Length; i++)
        {
            if (precios[i] > max) { max = precios[i]; iMax = i; }
            if (precios[i] < min) { min = precios[i]; iMin = i; }
        }

        Console.WriteLine($"Más caro:   {platillos[iMax]} (${max:F2})");
        Console.WriteLine($"Más barato: {platillos[iMin]} (${min:F2})");
    }
}
