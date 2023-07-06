using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej1bbdd
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DataRow dr;
        private void añadir_Click(object sender, EventArgs e)
        {
            activar();
            guardar.Visible = true;
            borrar.Enabled = false;
            modificar.Enabled = false;
        }
        private void activar()
        {
            foreach (TextBox i in Controls.OfType<TextBox>())
            {
                i.Enabled = true;
            }
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            guardar.Visible = true;
            id.Enabled = true;
            modificar.Enabled = false;
            añadir.Enabled = false;
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            id.Enabled = true;
            buscar.Visible = true;
            borrar.Enabled = false;
            añadir.Enabled = false;
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            dr = bbdd1DataSet1.Tables[0].Rows.Find(id.Text);
            if (dr != null)
            {
                nombre.Text = dr.ItemArray[1].ToString();
                apellidos.Text = dr.ItemArray[2].ToString();
                fechaNac.Text = dr.ItemArray[3].ToString();
                notas.Text = dr.ItemArray[4].ToString();
            }
            guardar.Visible = true;
            activar();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bbdd1DataSet1.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.bbdd1DataSet1.Alumnos);
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            dr= bbdd1DataSet1.Tables[0].NewRow();
            dr["id"] = Int32.Parse(id.Text);
            dr["Nombre"] = nombre.Text;
            dr["Apellidos"] = apellidos.Text;
            dr["FechaNac"] = fechaNac.Text;
            dr["Nota"] = Int32.Parse(notas.Text);
            bbdd1DataSet1.Tables[0].Rows.Add(dr);
            this.tableAdapterManager1.UpdateAll(this.bbdd1DataSet1);
            DialogResult = DialogResult.OK;
        }
    }
}
