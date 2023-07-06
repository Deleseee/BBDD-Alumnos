namespace ej1bbdd
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.notas = new System.Windows.Forms.TextBox();
            this.fechaNac = new System.Windows.Forms.DateTimePicker();
            this.apellidos = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.añadir = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bbdd1DataSet1 = new ej1bbdd.bbdd1DataSet();
            this.bbdd1DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnosTableAdapter = new ej1bbdd.bbdd1DataSetTableAdapters.AlumnosTableAdapter();
            this.tableAdapterManager1 = new ej1bbdd.bbdd1DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbdd1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbdd1DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // notas
            // 
            this.notas.Enabled = false;
            this.notas.Location = new System.Drawing.Point(286, 177);
            this.notas.Name = "notas";
            this.notas.Size = new System.Drawing.Size(100, 20);
            this.notas.TabIndex = 19;
            // 
            // fechaNac
            // 
            this.fechaNac.Enabled = false;
            this.fechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaNac.Location = new System.Drawing.Point(286, 147);
            this.fechaNac.Name = "fechaNac";
            this.fechaNac.Size = new System.Drawing.Size(100, 20);
            this.fechaNac.TabIndex = 18;
            // 
            // apellidos
            // 
            this.apellidos.Enabled = false;
            this.apellidos.Location = new System.Drawing.Point(286, 111);
            this.apellidos.Name = "apellidos";
            this.apellidos.Size = new System.Drawing.Size(100, 20);
            this.apellidos.TabIndex = 17;
            // 
            // nombre
            // 
            this.nombre.Enabled = false;
            this.nombre.Location = new System.Drawing.Point(286, 81);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 16;
            // 
            // id
            // 
            this.id.Enabled = false;
            this.id.Location = new System.Drawing.Point(286, 47);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Notas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Apellidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Id:";
            // 
            // añadir
            // 
            this.añadir.Location = new System.Drawing.Point(500, 81);
            this.añadir.Name = "añadir";
            this.añadir.Size = new System.Drawing.Size(75, 23);
            this.añadir.TabIndex = 20;
            this.añadir.Text = "Añadir";
            this.añadir.UseVisualStyleBackColor = true;
            this.añadir.Click += new System.EventHandler(this.añadir_Click);
            // 
            // borrar
            // 
            this.borrar.Location = new System.Drawing.Point(500, 118);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(75, 23);
            this.borrar.TabIndex = 21;
            this.borrar.Text = "Borrar";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(500, 153);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(75, 23);
            this.modificar.TabIndex = 22;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(624, 117);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(75, 23);
            this.guardar.TabIndex = 23;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Visible = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(624, 153);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 24;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Visible = false;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
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
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AlumnosTableAdapter = this.alumnosTableAdapter;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = ej1bbdd.bbdd1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.añadir);
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
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbdd1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bbdd1DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox notas;
        private System.Windows.Forms.DateTimePicker fechaNac;
        private System.Windows.Forms.TextBox apellidos;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button añadir;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.BindingSource bindingSource1;
        private bbdd1DataSet bbdd1DataSet1;
        private System.Windows.Forms.BindingSource bbdd1DataSet1BindingSource;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private bbdd1DataSetTableAdapters.AlumnosTableAdapter alumnosTableAdapter;
        private bbdd1DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}