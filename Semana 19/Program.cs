using System;
class Biblioteca
{
    const int CANTIDAD_CLIENTE = 100;
    const int CANTIDAD_PRODUCTO = 100;
    const int CANTIDAD_VENTA = 100;

    public class Usuario
    {
        public string[,] Tabla_Cliente = new string[100, 6];
        public string cliente_ID = "";
        public string Nombre = "";
        public string Apellido = "";
        public string carne = "";
        public string Telefono = "";
        public string Activo = "";
        public int fila_Maxima = 0;

    }

    public class Producto
    {
        public string[,] Tabla_Producto = new string[100, 2];
        public string producto_ID = "";
        public string Nombre = "";
        public int fila_Maxima = 0;
    }

    public class Venta
    {
        public string[,] Tabla_Venta = new string[100, 3];
        public string Venta_ID = "";
        public string Cliente_ID = "";
        public string Nombre_Producto = "";
        public int fila_Maxima = 0;
    }

    static void Main()
    {
        //Objetos
        Usuario cliente = new Usuario();
        Producto producto = new Producto();
        Venta venta = new Venta();

        int opcion = 0;
        do
        {
            Console.WriteLine("--------- MENU: SISTEMA DE CONTROL DE LA BIBLIOTECA CENTRAL -----------");
            Console.WriteLine("Seleccione una de las siguientes opciones: ");
            Console.WriteLine("0. Si desea ingresar datos sobre las entidades: (Usuario, Libro y Venta");
            Console.WriteLine("1. Si desea consultar el listado de libros comprados por usuario");
            Console.WriteLine("2. Si desea consultar catálogo de libros");
            Console.WriteLine("3. Si desea consultar el listado de usuarios activos");
            Console.WriteLine("4. Salir");
            //opcion = Convert.ToInt32(Console.ReadLine());

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("La opcion debe de ser un número, intente de nuevo.");
            }


            if (opcion == 0)
            {
                ingresar_Datos_Cliente(cliente);
                ingresar_Datos_Producto(producto);
                ingresar_Datos_Venta(venta);
                
            }
            else if (opcion == 1)
            {
                lista_Compra_By_User(venta);
            }
            else if (opcion == 2)
            {
                consultar_Catalogo(producto);
            }
            else if (opcion == 3)
            {
                lista_Usuarios_Activos(cliente);
            }
            else if (opcion == 4)
            {
                Console.WriteLine("¡Hasta pronto!");
            }

        } while (opcion != 4);

    }

//***************************************************************************
    static void ingresar_Datos_Cliente(Usuario cliente)
    {
        int incorrecto = 1;
        int opcion = 0;
        int seguir_Añadiendo = 0;
      
            do
            {
                do
                {
                    //Leyendo el ID del cliente
                    Console.WriteLine("Ingrese el ID del cliente: ");

                    try
                    {
                        incorrecto = 0;
                        cliente.cliente_ID = Console.ReadLine();
                    }
                    catch (FormatException)
                    {

                        incorrecto = 1;
                        Console.WriteLine("ID inválido, ingrese el ID en números");
                    }

                } while (incorrecto == 1);



                Console.WriteLine("Ingrese el nombre del cliente: ");
                cliente.Nombre = Console.ReadLine();


                Console.WriteLine("Ingrese el apellido del cliente: ");
                cliente.Apellido = Console.ReadLine();

                Console.WriteLine("Ingrese el carne del cliente: ");
                cliente.carne = Console.ReadLine();

                Console.WriteLine("Ingrese el telefono del cliente: ");
                cliente.Telefono = Console.ReadLine();

                do
                {
                    Console.WriteLine("Ingrese el estado del cliente: ");
                    Console.WriteLine("0: Inactivo ");
                    Console.WriteLine("1: Activo ");


                    if (!int.TryParse(Console.ReadLine(), out opcion))
                    {
                        Console.WriteLine("La opcion debe de ser un número, intente de nuevo.");
                        Console.WriteLine("Recuerde: La opcion debe de ser 0 o 1. Intente de nuevo.");
                    }
                } while (opcion != 0 && opcion != 1);

                cliente.Activo = Convert.ToString(opcion);

                cliente.Tabla_Cliente[cliente.fila_Maxima, 0] = cliente.cliente_ID;
                cliente.Tabla_Cliente[cliente.fila_Maxima, 1] = cliente.Nombre;
                cliente.Tabla_Cliente[cliente.fila_Maxima, 2] = cliente.Apellido;
                cliente.Tabla_Cliente[cliente.fila_Maxima, 3] = cliente.carne;
                cliente.Tabla_Cliente[cliente.fila_Maxima, 4] = cliente.Telefono;
                cliente.Tabla_Cliente[cliente.fila_Maxima, 5] = cliente.Activo;

                do
                {
                    Console.WriteLine("¿Desea seguir añadiendo usuarios?");
                    Console.WriteLine("1. SI");
                    Console.WriteLine("2. NO");


                    if (!int.TryParse(Console.ReadLine(), out seguir_Añadiendo))
                    {
                        Console.WriteLine("La opcion debe ser 1 o 2, intente de nuevo.");
                    }
                } while (seguir_Añadiendo != 1 && seguir_Añadiendo != 2);

                if (seguir_Añadiendo == 1)
                {
                    cliente.fila_Maxima++;
                }

            } while (seguir_Añadiendo == 1);

    }

    //***************************************************************************

    static void ingresar_Datos_Producto(Producto producto)
    {
        int incorrecto = 1;
        int opcion = 0;
        int seguir_Añadiendo = 0;
      
            do
            {
                do
                {
                    //Leyendo el producto 
                    Console.WriteLine("Ingrese el ID del producto: ");

                    try
                    {
                        incorrecto = 0;
                        producto.producto_ID = Console.ReadLine();
                    }
                    catch (FormatException)
                    {

                        incorrecto = 1;
                        Console.WriteLine("ID inválido, ingrese el ID del producto en números");
                    }

                } while (incorrecto == 1);



                Console.WriteLine("Ingrese el nombre del producto: ");
                producto.Nombre = Console.ReadLine();



                producto.Tabla_Producto[producto.fila_Maxima, 0] = producto.producto_ID;
                producto.Tabla_Producto[producto.fila_Maxima, 1] = producto.Nombre;
                
                do
                {
                    Console.WriteLine("¿Desea seguir añadiendo productos?");
                    Console.WriteLine("1. SI");
                    Console.WriteLine("2. NO");

                    if (!int.TryParse(Console.ReadLine(), out seguir_Añadiendo))
                    {
                        Console.WriteLine("La opcion debe ser 1 o 2, intente de nuevo.");
                    }
                } while (seguir_Añadiendo != 1 && seguir_Añadiendo != 2);

                if (seguir_Añadiendo == 1)
                {
                    producto.fila_Maxima++;
                }

            } while (seguir_Añadiendo == 1);

    }

    //***************************************************************************

    static void ingresar_Datos_Venta(Venta venta)
    {
        int incorrecto = 1;
        int opcion = 0;
        int seguir_Añadiendo = 0;
      
            do
            {
                do
                {
                    //Leyendo la venta 
                    Console.WriteLine("Ingrese el ID de la venta: ");

                    try
                    {
                        incorrecto = 0;
                        venta.Venta_ID = Convert.ToString(Convert.ToInt32(Console.ReadLine()));
                    }
                    catch (FormatException)
                    {

                        incorrecto = 1;
                        Console.WriteLine("ID inválido, ingrese el ID de la venta en números");
                    }

                } while (incorrecto == 1);


            incorrecto = 1;
                do
                {
                    //Leyendo el ID del cliente
                    Console.WriteLine("Ingrese el ID del cliente: ");

                    try
                    {
                        incorrecto = 0;
                        venta.Cliente_ID = Console.ReadLine();
                    }
                    catch (FormatException)
                    {

                        incorrecto = 1;
                        Console.WriteLine("ID inválido, ingrese el ID en números");
                    }

                } while (incorrecto == 1);

                Console.WriteLine("Ingrese el nombre del producto: ");
                venta.Nombre_Producto = Console.ReadLine();



                venta.Tabla_Venta[venta.fila_Maxima, 0] = venta.Venta_ID;
                venta.Tabla_Venta[venta.fila_Maxima, 1] = venta.Cliente_ID;
                venta.Tabla_Venta[venta.fila_Maxima, 2] = venta.Nombre_Producto;
            

                do
            {
                Console.WriteLine("¿Desea seguir añadiendo ventas?");
                Console.WriteLine("1. SI");
                Console.WriteLine("2. NO");

                if (!int.TryParse(Console.ReadLine(), out seguir_Añadiendo))
                {
                    Console.WriteLine("La opcion debe ser 1 o 2, intente de nuevo.");
                }
            } while (seguir_Añadiendo != 1 && seguir_Añadiendo != 2);

                if (seguir_Añadiendo == 1)
                {
                    venta.fila_Maxima++;
                }

            } while (seguir_Añadiendo == 1);

    }

    //***************************************************************************


    static void lista_Compra_By_User(Venta venta)
    {

        Console.Write("  ");

        Console.Write($" Venta ID:      Cliente ID :        Nombre:");
        Console.WriteLine();

        for (int i = 0; i <= venta.fila_Maxima; i++)
        {
            Console.Write($"{(char)('A' + i)} ");
            Console.Write($" {venta.Tabla_Venta[i, 0]}");
            Console.Write($"               {venta.Tabla_Venta[i, 1]}");
            Console.Write($"                    {venta.Tabla_Venta[i, 2]}");

            //for (int j = 0; j <= 3; j++)
            //{
            //    string c = venta.Tabla_Venta[i, j];
            //    Console.Write($" {c}");
            //}
            Console.WriteLine();
        }
    }
    
    static void consultar_Catalogo(Producto producto)
    {
        Console.Write("  ");

        Console.Write($" Producto ID:        Nombre:");
        Console.WriteLine();

        for (int i = 0; i <= producto.fila_Maxima; i++)
        {
            Console.Write($"{(char)('A' + i)} ");
            Console.Write($" {producto.Tabla_Producto[i, 0]}");
            Console.Write($"                     {producto.Tabla_Producto[i, 1]}");

            //for (int j = 0; j < 1; j++)
            //{
            //    string c = producto.Tabla_Producto[i, j];
            //    Console.Write($" {c}");
            //}

            Console.WriteLine();
        }
    }
    static void lista_Usuarios_Activos(Usuario usuario)
    {
        Console.Write("  ");

        Console.Write($" Usuario ID:        Nombre:         Apellido:           Carne:          Telefeno:           Activo:");
        Console.WriteLine();

        for (int i = 0; i <= usuario.fila_Maxima; i++)
        {
            Console.Write($"{(char)('A' + i)} ");

            Console.Write($" {usuario.Tabla_Cliente[i, 0]}");
            Console.Write($"                    {usuario.Tabla_Cliente[i, 1]}");
            Console.Write($"               {usuario.Tabla_Cliente[i, 2]}");
            Console.Write($"                    {usuario.Tabla_Cliente[i, 3]}");
            Console.Write($"               {usuario.Tabla_Cliente[i, 4]}");
            Console.Write($"                    {usuario.Tabla_Cliente[i, 5]}");

            //for (int j = 0; j < 1; j++)
            //{
            //    string c = usuario.Tabla_Cliente[i, j];
            //    Console.Write($" {c}");
            //}
            Console.WriteLine();
        }
    }
    
}