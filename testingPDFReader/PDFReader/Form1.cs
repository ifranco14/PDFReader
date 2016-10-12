using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace PDFReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string[] files = Directory.GetFiles(folderBrowserDialog.SelectedPath, "*.pdf");                
                MessageBox.Show("Archivos encontrados " + files.Length.ToString(), "Mensaje");
                btnStartProcess.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataColumn OS = new DataColumn("ObraSocial", typeof(string));
            Program.Tabla.Columns.Add(OS);
            DataColumn NroFact = new DataColumn("NroFactura", typeof(string));
            Program.Tabla.Columns.Add(NroFact);
            DataColumn NomApe = new DataColumn("NombreApellido", typeof(string));
            Program.Tabla.Columns.Add(NomApe);
            DataColumn Importe = new DataColumn("Importe", typeof(decimal));
            Program.Tabla.Columns.Add(Importe);
            DataColumn Mes = new DataColumn("Mes", typeof(string));
            Program.Tabla.Columns.Add(Mes);
            Program.facturasSet.Tables.Add(Program.Tabla);

            btnChange.Enabled = false;
            btnStartProcess.Enabled = false;
            btnSelectFolder.Enabled = false;



        }

        private void btnStartProcess_Click(object sender, EventArgs e)
        {
            //Obtengo y guardo los datos en datatable
            foreach (string f in Directory.GetFiles(folderBrowserDialog.SelectedPath, "*.pdf"))
            {
                MyClasses.GetAndProcessData(f);                
            }

            //Pasar el dataset.table a un excel
            string excelName = txtExcelName.Text + "_" + txtMes.Text;
            Program.Tabla.ExportToExcel( excelName, folderBrowserDialog.SelectedPath);
            MessageBox.Show("Proceso terminado! Buscá en 'Mis documentos' el archivo con el nombre y mes que especificaste");

            //volvemos todo a cero
            Program.Tabla.Rows.Clear();
            txtMes.Text = "";
            txtExcelName.Text = "";
            txtExcelName.Enabled = true;
            txtMes.Enabled = true;
            btnListo.Enabled = true;
            btnChange.Enabled = false;
            btnStartProcess.Enabled = false;
            btnSelectFolder.Enabled = false;

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            btnListo.Enabled = false;
            btnChange.Enabled = true;
            btnSelectFolder.Enabled = true;
            txtMes.Enabled = false;
            txtExcelName.Enabled = false;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            btnListo.Enabled = true;
            btnChange.Enabled = false;
            btnSelectFolder.Enabled = false;
            txtMes.Enabled = true;
            txtExcelName.Enabled = true;
        }
    }
}
