using Academy.Week1.Spese.Handlers;
using Academy.Week1.Spese.Importo;
using System;
using System.Collections.Generic;
using System.IO;

namespace Academy.Week1.Spese
{
    
    class Program
    {
        //Ho dovuto lascire commentata la parte di lettura da file perché mi dava problemi
        //Il filesystemwatcher funzionva, ho lasciato il codice commentato per potere andare avanti con gli altri punti
        //Ho preso i dati da una lista
        static List<Spesa> spese = new List<Spesa>
        {
            new Spesa {Data = new DateTime(2021,5,9), Categoria = "Viaggio", Descrizione = "Prova", Importo = 100},
            new Spesa {Data = new DateTime(2021,6,9), Categoria = "Alloggio", Descrizione = "Prova", Importo = 200},
            new Spesa {Data = new DateTime(2021,6,9), Categoria = "Vitto", Descrizione = "Prova", Importo = 300},
            new Spesa {Data = new DateTime(2021,6,9), Categoria = "Altro", Descrizione = "Prova", Importo = 10000}
        };
        static void Main(string[] args)
        {
            FileSystemWatcher fsw = new FileSystemWatcher
            {
                Path = @"C:\Users\User\source\repos\Academy.Week1.Prova\TestWeek1\Academy.Week1.Spese",
                Filter = "*.txt"
            };

            fsw.EnableRaisingEvents = true;
            fsw.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.LastAccess
                | NotifyFilters.DirectoryName | NotifyFilters.FileName;
            fsw.Created += MonitorFile.GestioneFile;

            //Console.WriteLine("Premi q per uscire");
            //while (Console.Read() != 'q')
            //{

            //}

            IHandler managerHandler = new ManagerHandler();
            IHandler opHandler = new OperationalHandler();
            IHandler ceoHandler = new CEOHandler();

            managerHandler.SetNext(opHandler).SetNext(ceoHandler);
            List<IImporto> rimborsi = new List<IImporto>();
            string path =  @"C:\Users\User\source\repos\Academy.Week1.Prova\TestWeek1\Academy.Week1.Spese\spese_elaborate.txt";


            foreach (Spesa s in spese)
            {
                int rimb = 0;
                try
                {
                    using (StreamWriter writer = File.CreateText(path))
                    {
                        if (managerHandler.HandleApprovazione(s) > 0)
                        {
                            ImportoFactory factory = new ImportoFactory(s);
                            IImporto rimborso = factory.GetCategory();
                            rimborsi.Add(rimborso);
                            rimb = rimborso.CalcolaImporto();
                            Console.WriteLine("Rimborso: " + rimb);
                            Console.WriteLine("Spesa di livello " + managerHandler.HandleApprovazione(s));
                            //try
                            //{
                            //using (StreamWriter writer = File.CreateText(path)) 
                            //{
                            writer.WriteLine(s.Data.ToShortDateString() + ";" + s.Categoria + ";" +
                                s.Descrizione + ";Approvata" + ";" + managerHandler.HandleApprovazione(s) + ";" +
                                rimb);
                            //}
                            //}
                            // catch (Exception ex)
                            //{
                            //Console.WriteLine($"Errore: {ex.Message}");
                            //}

                        }
                        else
                        {
                            //try
                            //{
                            //using (StreamWriter writer = File.CreateText(path))
                            //{
                            writer.WriteLine(s.Data.ToShortDateString() + ";" + s.Categoria + ";" +
                                s.Descrizione + "Respinta" + ";-;-");
                            //}
                            //}
                            //catch (Exception ex)
                            //{
                            //Console.WriteLine($"Errore: {ex.Message}");
                            //}
                        }
                    }
                
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Errore: {ex.Message}");
                }


            }



        }
    }
}
