using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using testingPDFReader;



namespace testingPDFReader
{
    class Program
    {
        public static void Main(string[] args)
        {
            PDDocument document = PDDocument.load("hola.pdf");
            PDFTextStripper stripper = new PDFTextStripper();
            var fullText = stripper.getText(document).ToString().ToUpper();

            MyClasses.ObraSocial os1 = new MyClasses.ObraSocial("DEL PERSONAL DE LA ACTIVIDADDEL", "OSPAT");
            MyClasses.ObraSocial os2 = new MyClasses.ObraSocial("DEL PERSONAL DE LA INDUSTRIA", "OSPIL");
            MyClasses.ObraSocial os3 = new MyClasses.ObraSocial("DE LA UNION OBRERA METALURGICA DE", "UOM");
            MyClasses.ObraSocial os4 = new MyClasses.ObraSocial("DEL PERSONAL DE SERVICIO DE GARAGES Y", "OSPESGA");
            var os5 = new MyClasses.ObraSocial("DE LOS TRABAJADORES DE LA CARNE Y", "OSTCARA");
            var osList = new List<MyClasses.ObraSocial>();
            osList.Add(os1);
            osList.Add(os2);
            osList.Add(os3);
            osList.Add(os4);
            osList.Add(os5);


            //cuando no empiece con "OBRA SOCIAL" realizar verificaciones
            var obraSocial = MyClasses.GetOS(testingPDFReader.MyClasses.Search("OBRA SOCIAL", fullText).ToString().TrimEnd((char)13).TrimStart((char)32), osList);

            var name = testingPDFReader.MyClasses.GetCompleteName((char)209, fullText);
            name = name.Replace((char)13, (char)32);
            name = name.Replace((char)10, (char)32);

            //punto de venta y numero de factura
            var invoiceNumer = testingPDFReader.MyClasses.Search("PUNTO DE VENTA: COMP. NRO:", fullText).ToString();
            var list = invoiceNumer.Split((char)32);
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = list[i].TrimStart(new char[] { '0' });
            }



            //que pasa si "MES DE " es lo ultimo de la linea?
            var month = testingPDFReader.MyClasses.Search("MES DE ", fullText);
            month = MyClasses.GetOnlyMonth(month);
            var year = "20" + testingPDFReader.MyClasses.Search("20", fullText);
            var iva = testingPDFReader.MyClasses.SearchAll("FACTURA", fullText)[1];
            var import = testingPDFReader.MyClasses.GetImport(fullText);
            
            

            var requiredInfo = new List<string>();
            requiredInfo.Add(iva);
            requiredInfo.Add(obraSocial);
            requiredInfo.Add(list[0]);
            requiredInfo.Add(list[1]);
            requiredInfo.Add(name);
            requiredInfo.Add(Convert.ToString(import));
            requiredInfo.Add(month);
            requiredInfo.Add(year);

            MyClasses.formatSrt(requiredInfo);

            foreach (var item in requiredInfo)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }




            var x = MyClasses.GetMonth(fullText);
            var c = "";









            Console.WriteLine(stripper.getText(document));

            Console.ReadLine();
        }
    }
}
