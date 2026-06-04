using System;
using System.Collections.Generic;

class ModuloPedidos
{
    // Queue — FIFO: el primero en llegar es el primero en ser atendido
    static Queue<string> fila = new Queue<string>();

    // Stack — LIFO: para cancelar el último pedido registrado (como Ctrl+Z)
    static Stack<string> historial = new Stack<string>();

    public static void RegistrarPedido(string alumno, string platillo)
    {
        string pedido = $"{alumno}: {platillo}";
        fila.Enqueue(pedido);     // entra al final de la fila
        historial.Push(pedido);   // se apila en el historial
        Console.WriteLine($"✔ Pedido registrado: {pedido}");
    }

    public static void AtenderSiguiente()
    {
        if (fila.Count == 0)
        {
            Console.WriteLine("⚠ No hay pedidos en espera.");
            return;
        }
        string siguiente = fila.Dequeue();   // sale del frente de la fila
        Console.WriteLine($"🍽 Atendiendo: {siguiente}");
    }

    public static void CancelarUltimo()
    {
        if (historial.Count == 0)
        {
            Console.WriteLine("⚠ No hay pedidos en el historial.");
            return;
        }
        // Pop saca el último pedido registrado (LIFO)
        string cancelado = historial.Pop();
        // Reconstruye la fila sin el pedido cancelado
        fila = new Queue<string>(historial);
        Console.WriteLine($"✖ Cancelado: {cancelado}");
    }

    public static void VerEstado()
    {
        Console.WriteLine($"En fila: {fila.Count} · Historial: {historial.Count}");
        if (fila.Count > 0)
            Console.WriteLine($"  Siguiente a atender: {fila.Peek()}");
    }
}
