namespace ej1bbdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellidos = new System.Windows.Forms.TextBox();
            this.fechaNac = new System.Windows.Forms.DateTimePicker();
            this.notas = new System.Windows.Forms.TextBox();
            this.principio = new System.Windows.Forms.Button();
            this.volver = new System.Windows.Forms.Button();
            this.subir = new System.Windows.Forms.Button();
            this.final = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.edad = new System.Windows.Forms.Label();
            this.bbdd1DataSet1 = new ej1bbdd.bbdd1DataSet();
            this.bbdd1DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnosTableAdapter = new ej1bbdd.bbdd1DataSetTableAdapters.AlumnosTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.tableAdapterManager1 = new ej1bbdd.bbdd1DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.bbdd1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbdd1DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Notas:";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(405, 41);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 5;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(405, 75);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 6;
            // 
            // apellidos
            // 
            this.apellidos.Location = new System.Drawing.Point(405, 105);
            this.apellidos.Name = "apellidos";
            this.apellidos.Size = new System.Drawing.Size(100, 20);
            this.apellidos.TabIndex = 7;
            // 
            // fechaNac
            // 
            this.fechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaNac.Location = new System.Drawing.Point(405, 141);
            this.fechaNac.Name = "fechaNac";
            this.fechaNac.Size = new System.Drawing.Size(100, 20);
            this.fechaNac.TabIndex = 8;
            // 
            // notas
            // 
            this.notas.Location = new System.Drawing.Point(405, 171);
            this.notas.Name = "notas";
            this.notas.Size = new System.Drawing.Size(100, 20);
            this.notas.TabIndex = 9;
            // 
            // principio
            // 
            this.principio.Location = new System.Drawing.Point(220, 274);
            this.principio.Name = "principio";
            this.principio.Size = new System.Drawing.Size(75, 23);
            this.principio.TabIndex = 10;
            this.principio.Text = "Principio";
            this.principio.UseVisualStyleBackColor = true;
            this.principio.Click += new System.EventHandler(this.principio_Click);
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(320, 274);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(75, 23);
            this.volver.TabIndex = 11;
            this.volver.Text = "Volver 1";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // subir
            // 
            this.subir.Location = new System.Drawing.Point(417, 273);
            this.subir.Name = "subir";
            this.subir.Size = new System.Drawing.Size(75, 23);
            this.subir.TabIndex = 12;
            this.subir.Text = "Subir 1";
            this.subir.UseVisualStyleBackColor = true;
            this.subir.Click += new System.EventHandler(this.subir_Click);
            // 
            // final
            // 
            this.final.Location = new System.Drawing.Point(517, 273);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(75, 23);
            this.final.TabIndex = 13;
            this.final.Text = "Final";
            this.final.UseVisualStyleBackColor = true;
            this.final.Click += new System.EventHandler(this.final_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(550, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Edad:";
            // 
            // edad
            // 
            this.edad.AutoSize = true;
            this.edad.Location = new System.Drawing.Point(609, 147);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(0, 13);
            this.edad.TabIndex = 15;
            // 
            // bbdd1DataSet1
            // 
            this.bbdd1DataSet1.DataSetName = "bbdd1DataSet";
            this.bbdd1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bbdd1DataSet1BindingSource
            // 
            this.bbdd1DataSet1BindingSource.DataSource = this.bbdd1DataSet1;
            this.bbdd1DataSet1BindingSource.Position = 0;
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "Alumnos";
            this.alumnosBindingSource.DataSource = this.bbdd1DataSet1BindingSource;
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Añadir/Borrar/Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AlumnosTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = ej1bbdd.bbdd1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.edad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.final);
            this.Controls.Add(this.subir);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.principio);
            this.Controls.Add(this.notas);
            this.Controls.Add(this.fechaNac);
            this.Controls.Add(this.apellidos);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bbdd1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbdd1DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellidos;
        private System.Windows.Forms.DateTimePicker fechaNac;
        private System.Windows.Forms.TextBox notas;
        private System.Windows.Forms.Button principio;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.Button subir;
        private System.Windows.Forms.Button final;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label edad;
        private bbdd1DataSet bbdd1DataSet1;
        private System.Windows.Forms.BindingSource bbdd1DataSet1BindingSource;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private bbdd1DataSetTableAdapters.AlumnosTableAdapter alumnosTableAdapter;
        private System.Windows.Forms.Button button1;
        private bbdd1DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}

