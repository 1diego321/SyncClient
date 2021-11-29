using SyncClient.Core.Service;

namespace SyncClient.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            string op = "";

            while (true)
            {
                System.Console.WriteLine("***********************************");
                System.Console.WriteLine("*****CLIENTE DE SINCRONIZACION*****");
                System.Console.WriteLine("***********************************");
                System.Console.WriteLine("");
                System.Console.WriteLine("Digite la opcion que desea realizar: ");
                System.Console.WriteLine("0 = Salir");
                System.Console.WriteLine("1 = Sincroniza Articulos");
                System.Console.WriteLine("2 = Sincroniza Clientes");
                System.Console.Write("Opcion: ");
                op = System.Console.ReadLine();

                if (op == "0")
                    break;

                else if (op == "1")
                    SyncArticles();

                else if (op == "2")
                    SyncClients();

                System.Console.Clear();
            }
        }

        static void SyncClients()
        {
            var service = new SyncService();

            System.Console.WriteLine("\nEspere, sincronizando clientes...");
            System.Console.WriteLine("");

            var result = service.SyncClients();

            if (result.Success)
            {
                System.Console.WriteLine("Se realizó la sincronizacion de clientes exitosamente!\n");
                System.Console.WriteLine($"Clientes enviados: {result.SentCount}");
                System.Console.WriteLine($"Clientes agregados: {result.AddedCount}");
                System.Console.WriteLine($"Clientes actualizados: {result.UpdatedCount}");
            }
            else
            {
                System.Console.WriteLine("Error al sincronizar...");
                System.Console.WriteLine($"Código de estado: {(int)result.StatusCode} {result.StatusCode}");
            }

            System.Console.WriteLine("\nPulse cualquier tecla para continuar.");
            System.Console.ReadKey();
        }

        static void SyncArticles()
        {
            var service = new SyncService();

            System.Console.WriteLine("\nEspere, sincronizando articulos...");
            System.Console.WriteLine("");

            var result = service.SyncArticles();

            if (result.Success)
            {
                System.Console.WriteLine("Se realizó la sincronizacion de articulos exitosamente!\n");
                System.Console.WriteLine($"Articulos enviados: {result.SentCount}");
                System.Console.WriteLine($"Articulos agregados: {result.AddedCount}");
                System.Console.WriteLine($"Articulos actualizados: {result.UpdatedCount}");
            }
            else
            {
                System.Console.WriteLine("Error al sincronizar...");
                System.Console.WriteLine($"Código de estado: {(int)result.StatusCode} {result.StatusCode}");
            }

            System.Console.WriteLine("\nPulse cualquier tecla para continuar.");
            System.Console.ReadKey();
        }
    }
}


