using System;
using System.Collections.Generic;

// CLASE GENÉRICA 
public class ApiGenerica<T>
{
    private List<T> elementos = new List<T>();

    // Agregar un elemento a la lista
    public void Agregar(T elemento)
    {
        elementos.Add(elemento);
    }

    // Actualizar un elemento según su índice
    public void Actualizar(int indice, T nuevoElemento)
    {
        if (indice >= 0 && indice < elementos.Count)
        {
            elementos[indice] = nuevoElemento;
        }
        else
        {
            Console.WriteLine("Índice fuera de rango");
        }
    }

    // Eliminar un elemento según su índice
    public void Eliminar(int indice)
    {
        if (indice >= 0 && indice < elementos.Count)
        {
            elementos.RemoveAt(indice);
        }
        else
        {
            Console.WriteLine("Índice fuera de rango");
        }
    }

    // Obtener un elemento según su índice
    public T Obtener(int indice)
    {
        if (indice >= 0 && indice < elementos.Count)
        {
            return elementos[indice];
        }
        else
        {
            Console.WriteLine("Índice fuera de rango");
            return default(T);
        }
    }

    // Listar todos los elementos
    public void Listar()
    {
        if (elementos.Count == 0)
        {
            Console.WriteLine("No hay elementos.");
            return;
        }

        for (int i = 0; i < elementos.Count; i++)
        {
            Console.WriteLine($"{i} - {elementos[i]}");
        }
    }
}

// CLASES ESPECÍFICAS 

// Clase Producto
public class Producto
{
    public List<string> nombres = new List<string>();
    public List<int> stock = new List<int>();
    public List<float> precios = new List<float>();

    public override string ToString()
    {
        string resultado = "";
        for (int i = 0; i < nombres.Count; i++)
        {
            resultado += $"{nombres[i]} - Stock: {stock[i]} - Precio: {precios[i]:0.00}\n";
        }
        return resultado;
    }
}

// Clase Cliente
public class Cliente
{
    public List<string> nombres = new List<string>();
    public List<int> edades = new List<int>();
    public List<float> saldo = new List<float>();

    public override string ToString()
    {
        string resultado = "";
        for (int i = 0; i < nombres.Count; i++)
        {
            resultado += $"{nombres[i]} - Edad: {edades[i]} - Saldo: {saldo[i]:0.00}\n";
        }
        return resultado;
    }
}

// Clase Empleado
public class Empleado
{
    public List<string> nombres = new List<string>();
    public List<int> horasTrabajadas = new List<int>();
    public List<float> salario = new List<float>();

    public override string ToString()
    {
        string resultado = "";
        for (int i = 0; i < nombres.Count; i++)
        {
            resultado += $"{nombres[i]} - Horas: {horasTrabajadas[i]} - Salario: {salario[i]:0.00}\n";
        }
        return resultado;
    }
}

// ====================== PROGRAMA PRINCIPAL ======================
class Program
{
    static void Main()
    {
        // Crear instancias de la API genérica
        ApiGenerica<Producto> apiProductos = new ApiGenerica<Producto>();
        ApiGenerica<Cliente> apiClientes = new ApiGenerica<Cliente>();
        ApiGenerica<Empleado> apiEmpleados = new ApiGenerica<Empleado>();

        // Crear y agregar un producto
        Producto p = new Producto();
        p.nombres.Add("Laptop");
        p.stock.Add(10);
        p.precios.Add(999.99f);
        apiProductos.Agregar(p);

        // Crear y agregar un cliente
        Cliente c = new Cliente();
        c.nombres.Add("Carlos");
        c.edades.Add(30);
        c.saldo.Add(150.50f);
        apiClientes.Agregar(c);

        // Crear y agregar un empleado
        Empleado e = new Empleado();
        e.nombres.Add("Ana");
        e.horasTrabajadas.Add(40);
        e.salario.Add(1200.50f);
        apiEmpleados.Agregar(e);

        // Mostrar todos los productos
        Console.WriteLine(" PRODUCTOS ===");
        apiProductos.Listar();

        // Mostrar todos los clientes
        Console.WriteLine(" CLIENTES ===");
        apiClientes.Listar();

        // Mostrar todos los empleados
        Console.WriteLine("EMPLEADOS ===");
        apiEmpleados.Listar();

        // Ejemplo de actualización de un producto
        Producto nuevoProducto = new Producto();
        nuevoProducto.nombres.Add("Tablet");
        nuevoProducto.stock.Add(15);
        nuevoProducto.precios.Add(450.75f);
        apiProductos.Actualizar(0, nuevoProducto);

        Console.WriteLine("PRODUCTOS ACTUALIZADOS ===");
        apiProductos.Listar();
    }
}