using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseLearning
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //createPlayerData();
            /*
            // Create sample data
            string[] names = { "Alice", "Bob", "Charlie", "David" };
            int[] ages = { 25, 30, 22, 28 };

            // Specify the CSV file path
            string filePath = "sample.csv";

            // Write data to the CSV file
            WriteDataToCSV(filePath, names, ages);

            Console.WriteLine($"CSV file created at: {Path.GetFullPath(filePath)}");
            */
        }

        static void WriteDataToCSV(string filePath, string[] names, int[] levels)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
                {
                    // Write header
                    writer.WriteLine("Name,Level");

                    // Write data
                    for (int i = 0; i < names.Length; i++)
                    {
                        writer.WriteLine($"{names[i]},{levels[i]}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing data to CSV: {ex.Message}");
            }
        }
    }
   
    }
