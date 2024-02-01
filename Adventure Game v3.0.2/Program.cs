using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adventure_Game
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
            Application.Run(new start_screen());
        }
       
    }
    public static class FormManager
    {
        private static Dictionary<string, Point> formLocations = new Dictionary<string, Point>();
        private static Form lastActiveForm;

        public static void SaveFormLocation(Form form)
        {
            if (form != null)
            {
                formLocations[form.Name] = form.Location;
                lastActiveForm = form;
            }
        }

        public static void RestoreLastActiveFormLocation(Form form)
        {
            if (lastActiveForm != null && formLocations.ContainsKey(lastActiveForm.Name))
            {
                form.Location = formLocations[lastActiveForm.Name];
            }
        }

        static void SaveDataTableToCSV(DataTable dataTable, string filePath)
        {
            // Write the DataTable to a CSV file
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    sw.Write(column.ColumnName);
                    sw.Write(",");
                }
                sw.WriteLine();

                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        sw.Write(row[column]);
                        sw.Write(",");
                    }
                    sw.WriteLine();
                }
            }
        }

        static DataTable LoadDataTableFromCSV(string filePath)
        {
            // Read the CSV file into a DataTable
            DataTable dataTable = new DataTable();

            using (StreamReader sr = new StreamReader(filePath))
            {
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    dataTable.Columns.Add(header);
                }

                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    DataRow dataRow = dataTable.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dataRow[i] = rows[i];
                    }
                    dataTable.Rows.Add(dataRow);
                }
            }

            return dataTable;
        }
    }
}
