using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace PDFReader
{
    public class MyClasses
    {
        private static string GetCompleteName(char _char, string _text)
        {
            string name = "";
            int position = 0;
            int _comma = 44;
            char comma = (char)_comma;
            for (int i = 0; i < _text.Length; i++)
            {
                if (i == 900)
                {
                    var a = i;
                }
                if (_text[i] == _char)
                {
                    position = i;

                    if ((_text[i - 1] == 'I') && (_text[i - 2] == 'N'))
                    {
                        position += 3;
                        while (_text[position] != comma)
                        {
                            name += _text[position];
                            position++;
                        }
                        return name;
                    }
                }
            }

            return name;
        }

        private static string FindString(int _from, int _to, string _searching, List<string> _list)
        {
            string _search = "";
            for (int i = _from; i <= _to; i++)
            {
                int x = 0;

            }

            return _search;
        }
                

        private static string Search(string _searching, string _fullText)
        {
            string _search = "";
            var regex = new Regex(".*" + _searching + "(.*)");
            if (regex.IsMatch(_fullText.ToString()))
            {
                var myCapturedText = regex.Match(_fullText).Groups[1].Value;
                return _search = myCapturedText;
                //Console.ReadLine(); 
            }
            else
            {
                Console.WriteLine("Text {0} was not found", _searching);
            }
            return _search;
        }


        public static List<string> SearchAll(string _searching, string _fullText)
        {
            List<string> _searches = new List<string>();
            var regex = new Regex(".*" + _searching + "(.*)");
            if (regex.IsMatch(_fullText.ToString()))
            {
                MatchCollection myCapturedText = regex.Matches(_fullText);

                var matches = new string[myCapturedText.Count];
                for (int i = 0; i < matches.Length; i++)
                {
                    //matches[i] = myCapturedText[i].ToString();
                    _searches.Add(myCapturedText[i].ToString());
                }
                return _searches;
            }
            else
            {
                Console.WriteLine("Text was not found");
            }
            return _searches;


        }

        public static string GetMonth(string _fullText)
        {
                var regex = new Regex(@"ENERO");
                if (regex.IsMatch(_fullText.ToString()))
                {
                    return "ENERO "+ GetYear(_fullText);
                }
                else
                {
                    var regex2 = new Regex(@"FEBRERO");
                    if (regex2.IsMatch(_fullText.ToString()))
                    {
                        return "FEBRERO " + GetYear(_fullText);
                    }
                    else
                    {
                        var regex3 = new Regex(@"MARZO");
                        if (regex3.IsMatch(_fullText.ToString()))
                        {
                            return "MARZO " + GetYear(_fullText);
                        }
                        else
                        {
                            var regex4 = new Regex(@"ABRIL");
                            if (regex4.IsMatch(_fullText.ToString()))
                            {
                                return "ABRIL " + GetYear(_fullText);
                            }
                            else
                            {
                                var regex5= new Regex(@"MAYO");
                                if (regex5.IsMatch(_fullText.ToString()))
                                {
                                    return "MAYO " + GetYear(_fullText);
                                }
                                else
                                {
                                    var regex6 = new Regex(@"JUNIO");
                                    if (regex6.IsMatch(_fullText.ToString()))
                                    {
                                        return "JUNIO " + GetYear(_fullText);
                                    }
                                    else
                                    {
                                        var regex7 = new Regex(@"JULIO");
                                        if (regex7.IsMatch(_fullText.ToString()))
                                        {
                                            return "JULIO " + GetYear(_fullText);
                                        }
                                        else
                                        {
                                            var regex8 = new Regex(@"AGOSTO");
                                            if (regex8.IsMatch(_fullText.ToString()))
                                            {
                                                return "AGOSTO " + GetYear(_fullText);
                                            }
                                            else
                                            {
                                                var regex9 = new Regex(@"SEPTIEMBRE");
                                                if (regex9.IsMatch(_fullText.ToString()))
                                                {
                                                    return "SEPTIEMBRE " + GetYear(_fullText);
                                                }
                                                else
                                                {
                                                    var regex10 = new Regex(@"OCTUBRE");
                                                    if (regex10.IsMatch(_fullText.ToString()))
                                                    {
                                                        return "OCTUBRE " + GetYear(_fullText);
                                                    }
                                                    else
                                                    {
                                                        var regex11 = new Regex(@"NOVIEMBRE");
                                                        if (regex11.IsMatch(_fullText.ToString()))
                                                        {
                                                            return "NOVIEMBRE " + GetYear(_fullText);
                                                        }
                                                        else
                                                        {
                                                            var regex12 = new Regex(@"DICIEMBRE");
                                                            if (regex12.IsMatch(_fullText.ToString()))
                                                            {
                                                                return "DICIEMBRE " + GetYear(_fullText);
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return "~";                       
        }
                

        private static decimal GetImport(string _fullText)
        {
            List<string> _searches = new List<string>();
            var regex = new Regex("[0-9]{3,5},[0-9]{2}");
            if (regex.IsMatch(_fullText))
            {
                MatchCollection myCapturedText = regex.Matches(_fullText);

                var matches = new string[myCapturedText.Count];
                for (int i = 0; i < matches.Length; i++)
                {
                    matches[i] = myCapturedText[i].ToString();
                    _searches.Add(myCapturedText[i].ToString()); //.Replace((char)44, (char)46)
                }
                List<decimal> _results = new List<decimal>();
                foreach (string item in _searches)
                {
                    _results.Add(decimal.Parse(item, System.Globalization.NumberStyles.AllowDecimalPoint));
                }

                return _results.Max();
            }
            return 0;
        }

        public static string GetOS(string _os, List<ObraSocial> ObrasSociales, string _fullText)
        {
            string os = "";
            if (_os == "")
            {
                if(Search("ASOCIACION", _fullText) != "")
                {
                    return "AMDC";
                }
            }
            else
            {
                foreach (var x in ObrasSociales)
                {
                    if (x.strText == _os)
                    {
                        return os = x.sigla;
                    }
                }
            }
            return os;

        }
        public class ObraSocial
        {
            public string strText { get; set; }
            public string sigla { get; set; }

            public ObraSocial(string _strText, string _sigla)
            {
                this.strText = _strText;
                this.sigla = _sigla;
            }
        }        


        public static void formatSrt(List<string> _list)
        {
            for (int i = 0; i < _list.Count; i++)
            {
                if (_list[i].Count() > 0)
                {
                    if (_list[i][_list[i].Count() - 1] == (char)13)
                    {
                        _list[i] = _list[i].Remove(_list[i].Count() - 1);
                    }
                    if (_list[i][0] == (char)10)
                    {
                        _list[i] = _list[i].Remove(0, 1);
                    }
                }
                _list[i] = _list[i].Replace((char)13, (char)32);
                _list[i] = _list[i].Replace((char)10, (char)32);                
            }

        }

        public static string GetYear(string _fullText)
        {
            var regex = new Regex(@"2016.");
            if (regex.IsMatch(_fullText.ToString()))
            {
                return "2016";
            }
            else
            {
                return "2015";
            }
        }

        public static void GetAndProcessData(string f)
        {
            PDDocument document = PDDocument.load(f);
            PDFTextStripper stripper = new PDFTextStripper();
            var fullText = stripper.getText(document).ToString().ToUpper();

            List<string> allData = new List<string>();

            //OS
            string obraSocial = GetOS(Search("OBRA SOCIAL", fullText).ToString().TrimEnd((char)13).TrimStart((char)32), Program.osList, fullText);
            allData.Add(obraSocial);

            //NRO FACT
            string invoiceNumer = Search("PUNTO DE VENTA: COMP. NRO:", fullText).ToString();
            string [] list = invoiceNumer.Split((char)32);
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = list[i].TrimStart(new char[] { '0' });
            }
            string ptoVentaFactura = list[0] + "-" + list[1];
            allData.Add(ptoVentaFactura);
            
            //APELLIDO Y NOM
            var name = GetCompleteName((char)209, fullText);
            name = name.Replace((char)13, (char)32);
            name = name.Replace((char)10, (char)32);
            allData.Add(name);

            //IMPORTE
            decimal import = GetImport(fullText);
            allData.Add(Convert.ToString(import));

            //MES + AÑO
            string mes = GetMonth(fullText);
            if (mes == "~")
            {

            }

            for (int i = 0; i < mes.Count(); i++)
            {
                if ((mes[i] == (char)10) || (mes[i]==(char)13))
                {
                    mes = mes.Remove(i, 1);
                    mes = mes.Insert(i, " ");
                }
            }
            allData.Add(mes);
            

            MyClasses.formatSrt(allData);

            DataRow row = Program.Tabla.NewRow();
            row["ObraSocial"] = allData[0];
            row["NroFactura"] = allData[1];
            row["NombreApellido"] = allData[2];
            row["Importe"] = Convert.ToDecimal(allData[3]);
            row["Mes"] = allData[4];

            Program.Tabla.Rows.Add(row);
        }    
    }


    public static class My_DataTable_Extensions
    {
        /// <summary>
        /// Export DataTable to Excel file
        /// </summary>
        /// <param name="DataTable">Source DataTable</param>
        /// <param name="ExcelFilePath">Path to result file name</param>
        public static void ExportToExcel(this System.Data.DataTable DataTable, string excelName, string ExcelFilePath = null)
        {
            try
            {
                int ColumnsCount;

                if (DataTable == null || (ColumnsCount = DataTable.Columns.Count) == 0)
                    throw new Exception("ExportToExcel: Null or empty input table!\n");

                // load excel, and create a new workbook
                Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
                Excel.Workbooks.Add();

                // single worksheet
                Microsoft.Office.Interop.Excel._Worksheet Worksheet = Excel.ActiveSheet;

                object[] Header = new object[ColumnsCount];

                // column headings               
                for (int i = 0; i < ColumnsCount; i++)
                    Header[i] = DataTable.Columns[i].ColumnName;

                Microsoft.Office.Interop.Excel.Range HeaderRange = Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[1, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[1, ColumnsCount]));
                HeaderRange.Value = Header;
                HeaderRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                HeaderRange.Font.Bold = true;

                // DataCells
                int RowsCount = DataTable.Rows.Count;
                object[,] Cells = new object[RowsCount, ColumnsCount];

                for (int j = 0; j < RowsCount; j++)
                    for (int i = 0; i < ColumnsCount; i++)
                        Cells[j, i] = DataTable.Rows[j][i];

                Worksheet.get_Range((Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[2, 1]), (Microsoft.Office.Interop.Excel.Range)(Worksheet.Cells[RowsCount + 1, ColumnsCount])).Value = Cells;

                // check filepath
                if (ExcelFilePath != null && ExcelFilePath != "")
                {
                    try
                    {
                        Worksheet.SaveAs(excelName);
                        Excel.Quit();
                        //System.Windows.MessageBox.Show("Excel file saved!");
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("ExportToExcel: Excel file could not be saved! Check filepath.\n"
                            + ex.Message);
                    }
                }
                else    // no filepath is given
                {
                    Excel.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ExportToExcel: \n" + ex.Message);
            }
        }
    }
}
