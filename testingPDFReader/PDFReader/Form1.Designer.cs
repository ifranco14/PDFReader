namespace PDFReader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.btnStartProcess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.txtExcelName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.btnListo = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(42, 236);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(220, 39);
            this.btnSelectFolder.TabIndex = 0;
            this.btnSelectFolder.Text = "Seleccionar carpeta";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // btnStartProcess
            // 
            this.btnStartProcess.Location = new System.Drawing.Point(42, 294);
            this.btnStartProcess.Name = "btnStartProcess";
            this.btnStartProcess.Size = new System.Drawing.Size(220, 39);
            this.btnStartProcess.TabIndex = 1;
            this.btnStartProcess.Text = "Procesar datos";
            this.btnStartProcess.UseVisualStyleBackColor = true;
            this.btnStartProcess.Click += new System.EventHandler(this.btnStartProcess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hola ma :)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // txtExcelName
            // 
            this.txtExcelName.Location = new System.Drawing.Point(42, 101);
            this.txtExcelName.Name = "txtExcelName";
            this.txtExcelName.Size = new System.Drawing.Size(190, 20);
            this.txtExcelName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre persona a facturar:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mes de facturacion";
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(42, 150);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(133, 20);
            this.txtMes.TabIndex = 6;
            // 
            // btnListo
            // 
            this.btnListo.Location = new System.Drawing.Point(42, 176);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(95, 34);
            this.btnListo.TabIndex = 7;
            this.btnListo.Text = "Listo";
            this.btnListo.UseVisualStyleBackColor = true;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(157, 176);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(105, 34);
            this.btnChange.TabIndex = 8;
            this.btnChange.Text = "Cambiar texto";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 345);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnListo);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtExcelName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartProcess);
            this.Controls.Add(this.btnSelectFolder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button btnStartProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox txtExcelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Button btnListo;
        private System.Windows.Forms.Button btnChange;
    }
}

