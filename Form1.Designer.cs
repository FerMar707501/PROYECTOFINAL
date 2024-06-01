namespace ProyectoFinalGasolineras
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MandarDatos = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.galones = new System.Windows.Forms.TextBox();
            this.num = new System.Windows.Forms.TextBox();
            this.nit = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.hora = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.prueba = new System.Windows.Forms.TextBox();
            this.Arduino = new System.IO.Ports.SerialPort(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MandarDatos
            // 
            this.MandarDatos.Location = new System.Drawing.Point(35, 336);
            this.MandarDatos.Name = "MandarDatos";
            this.MandarDatos.Size = new System.Drawing.Size(224, 36);
            this.MandarDatos.TabIndex = 41;
            this.MandarDatos.Text = "Agregar";
            this.MandarDatos.UseVisualStyleBackColor = true;
            this.MandarDatos.Click += new System.EventHandler(this.MandarDatos_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(340, 120);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(666, 228);
            this.listView.TabIndex = 40;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fecha";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hora";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nombre";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "NIT:";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Precio día:";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Galones:";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Total:";
            // 
            // galones
            // 
            this.galones.Location = new System.Drawing.Point(159, 255);
            this.galones.Name = "galones";
            this.galones.Size = new System.Drawing.Size(100, 22);
            this.galones.TabIndex = 39;
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(159, 195);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(100, 22);
            this.num.TabIndex = 38;
            // 
            // nit
            // 
            this.nit.Location = new System.Drawing.Point(159, 159);
            this.nit.Name = "nit";
            this.nit.Size = new System.Drawing.Size(100, 22);
            this.nit.TabIndex = 37;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(159, 120);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 22);
            this.nombre.TabIndex = 36;
            // 
            // hora
            // 
            this.hora.AutoSize = true;
            this.hora.Location = new System.Drawing.Point(677, 78);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(34, 16);
            this.hora.TabIndex = 35;
            this.hora.Text = "hora";
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Location = new System.Drawing.Point(337, 78);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(40, 16);
            this.fecha.TabIndex = 34;
            this.fecha.Text = "fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Prepago:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Datos Compra:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Número Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Datos del cliente:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 406);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(255, 119);
            this.dataGridView1.TabIndex = 43;
            // 
            // prueba
            // 
            this.prueba.Location = new System.Drawing.Point(35, 378);
            this.prueba.Name = "prueba";
            this.prueba.Size = new System.Drawing.Size(255, 22);
            this.prueba.TabIndex = 44;
            // 
            // Arduino
            // 
            this.Arduino.PortName = "COM7";
            this.Arduino.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(340, 363);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(666, 148);
            this.listBox1.TabIndex = 45;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 529);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.prueba);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MandarDatos);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.galones);
            this.Controls.Add(this.num);
            this.Controls.Add(this.nit);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.hora);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MandarDatos;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TextBox galones;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.TextBox nit;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label hora;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox prueba;
        public System.IO.Ports.SerialPort Arduino;
        private System.Windows.Forms.ListBox listBox1;
    }
}

