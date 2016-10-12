using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFReader
{
    public static class Program
    {
        public static List<MyClasses.ObraSocial> osList = new List<MyClasses.ObraSocial> { new MyClasses.ObraSocial("DEL PERSONAL DE LA ACTIVIDADDEL", "OSPAT"),
                                                                                 new MyClasses.ObraSocial("DEL PERSONAL DE LA INDUSTRIA", "OSPIL"),
                                                                                 new MyClasses.ObraSocial("DE LA UNION OBRERA METALURGICA DE", "UOM"),
                                                                                 new MyClasses.ObraSocial(" DE LA UNION OBRERA METALURGICA DE", "UOM"),
                                                                                 new MyClasses.ObraSocial("DEL PERSONAL DE SERVICIO GARAGES Y", "OSPESGA"),
                                                                                 new MyClasses.ObraSocial("DE LOS TRABAJADORES DE LA CARNE Y", "OSTCARA"),
                                                                                 new MyClasses.ObraSocial("DEL PERSONAL ASOCIADO A ASOCIACION", "OSPERSAAMS"),
                                                                                 new MyClasses.ObraSocial("DEL PERSONAL DE INDUSTRIAS QUIMICAS", "OSPIQYP"),
                                                                                 new MyClasses.ObraSocial("DEL PERSONAL DE LA", "OSPECON"),
                                                                                 new MyClasses.ObraSocial("DEL PERSONAL DEL TURISMO HOTELERO","GASTRONÓMICO"),
                                                                                 new MyClasses.ObraSocial("DEL PERSONAL DE LA INDUSTRIADEL", "OSPIV"),
                                                                                 new MyClasses.ObraSocial("DEL PERSONAL DE LA INDUSTRIA DEL", "OSPIP"),
                                                                                 new MyClasses.ObraSocial("DE LOS SUPERVISORES DE LA INDUSTRIA", "AMUR")};

        public static DataTable Tabla = new DataTable();
        public static DataSet facturasSet = new DataSet();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        


    }
}
