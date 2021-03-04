using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EnLabel
{
    public class CsvRow : List<string>
    {
        public string LineText { get; set; }
    }

    public class CSVManager
    {
        /// <summary>
        /// Funcion para escribir en un csv. Si el csv no exite se crea. ç
        /// Lo unico que se necesita es una linea tipo string para indexarlo
        /// </summary>
        /// <param name="path">ruta donde se va a guardar</param>
        /// <param name="Nserie"></param>
        /// <param name="observations"></param>
        /// <param name="Ncells"></param>
        /// <param name="type"></param>
        public void WriteInCsv(string path, string nameIm, string label = "-1")
        {
            StringBuilder csvContent = new StringBuilder();
            csvContent.AppendLine(nameIm + ";" + label);
            File.AppendAllText(path, csvContent.ToString());

        }

        public string[] ReadAllLinesInCsv(string _path)
        {
            int lineCount = 0;
            string line;
            // Para iniciarlizar la cantidad de linea antes leemos cuantas lineas tiene el archivo
            string[] lines = new string[LinesInCsv(_path)];

            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader(_path);
            while ((line = file.ReadLine()) != null)
            {
                lines[lineCount] = line;
                //processing line
                lineCount++;
            }

            file.Close();

            return lines;
        }

        public int LinesInCsv(string _path)
        {
            int lineCount = 0;
            using (StreamReader reader = File.OpenText(_path))
            {
                while (reader.ReadLine() != null)
                {
                    lineCount++;
                }
                reader.Close();
            }
            return lineCount;
        }

        public DataTable ConvertCSVtoDataTable(string strFilePath)
        {
            StreamReader sr = new StreamReader(strFilePath);
            DataTable dt = new DataTable();

            /*string[] headers = sr.ReadLine().Split(',');
            foreach (string header in headers)
            {
                dt.Columns.Add(header);
            }*/
            string[] headers = new string[2] { "pictName", "label" };
            while (!sr.EndOfStream)
            {
                string[] rows = Regex.Split(sr.ReadLine(), ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
                DataRow dr = dt.NewRow();
                for (int i = 0; i < headers.Length; i++)
                {
                    dr[i] = rows[i];
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

        public List<string> GetLabelsFromCSV(string csvPath)
        {
            List<string> differentLabels = new List<string>();

            StreamReader reader = File.OpenText(csvPath);
            string[] line = new string[2];
            for (int i = 0; i < System.IO.File.ReadAllLines(csvPath).Length; i++)
            {
                string label = reader.ReadLine().Split(';')[1];
                if (!differentLabels.Contains(label))
                    differentLabels.Add(label);
            }
            return differentLabels;
        }

        public void ModifyLabelinCSV(string csvPath, string name, string newLabel)
        {
            StreamReader reader = File.OpenText(csvPath);
            string[] line = new string[2];
            for (int i = 0; i < System.IO.File.ReadAllLines(csvPath).Length; i++)
            {
                string lineReaded = reader.ReadLine();
                if (lineReaded.Contains(name))
                {
                    string label = lineReaded.Split(';')[1];
                    /*if (!differentLabels.Contains(label))
                        differentLabels.Add(label);*/
                }
                
            }

        }

        public static void ListViewToCSV(ListView listView, string filePath, bool includeHidden)
        {
            //make header string
            StringBuilder result = new StringBuilder();
            WriteCSVRow(result, listView.Columns.Count, i => includeHidden || listView.Columns[i].Width > 0, i => listView.Columns[i].Text);

            //export data rows
            foreach (ListViewItem listItem in listView.Items)
                WriteCSVRow(result, listView.Columns.Count, i => includeHidden || listView.Columns[i].Width > 0, i => listItem.SubItems[i].Text);

            File.WriteAllText(filePath, result.ToString());
        }

        private static void WriteCSVRow(StringBuilder result, int itemsCount, Func<int, bool> isColumnNeeded, Func<int, string> columnValue)
        {
            bool isFirstTime = true;
            for (int i = 0; i < itemsCount; i++)
            {
                if (!isColumnNeeded(i))
                    continue;

                if (!isFirstTime)
                    result.Append(",");
                isFirstTime = false;

                result.Append(String.Format("\"{0}\"", columnValue(i)));
            }
            result.AppendLine();
        }
    }
}