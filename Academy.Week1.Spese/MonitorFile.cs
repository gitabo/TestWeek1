using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Week1.Spese
{
    class MonitorFile
    {

        public static void GestioneFile(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Gestione dell'evento {e.ChangeType} sul file {e.Name}");
            ReadFile(e);

        }

        private static void ReadFile(FileSystemEventArgs e)
        {
            //Lettura da file
            try
            {
                using (StreamReader reader = File.OpenText(e.FullPath))
                {

                    Console.WriteLine($"Lettura del file {e.Name} in corso");
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        
                        Console.WriteLine(line);
                        line = reader.ReadLine();

                        //Spesa[] spese = new Spesa[5]; //conosco a priori che il file contiene 5 spese
                        //int i = 0;


                        //Console.WriteLine(line);
                        //line = reader.ReadLine();
                        //Console.WriteLine(line);

                        //string[] dati = line.Split(";");
                        //string DateString = dati[0];
                        //string[] DateParameters = DateString.Split("/");
                        //DateTime DataSpesa = new DateTime(int.Parse(DateParameters[2]), int.Parse(DateParameters[1]), int.Parse(DateParameters[0]));
                        //string CategoriaRead = dati[1];
                        //string Descr = dati[2];
                        //int importo = int.Parse(dati[3]);

                        //Spesa spesa = new Spesa
                        //{
                        //Data = DataSpesa,
                        //Categoria = CategoriaRead,
                        //Descrizione = Descr,
                        //Importo = importo
                        //};

                        //spese[i] = spesa;


                        //Console.WriteLine("\n Fine del file \n");
                        //return spese;
                    }
                    Console.WriteLine("\n Fine del file \n");
                }
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
