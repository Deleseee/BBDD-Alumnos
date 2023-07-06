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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataRow dr;

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bbdd1DataSet1.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.bbdd1DataSet1.Alumnos);
            dr = bbdd1DataSet1.Tables[0].Rows[0];
            if (dr != null)
            {
                id.Text = dr.ItemArray[0].ToString();
                nombre.Text = dr.ItemArray[1].ToString();
                apellidos.Text = dr.ItemArray[2].ToString();
                fechaNac.Text = dr.ItemArray[3].ToString();
                notas.Text = dr.ItemArray[4].ToString();
            }
        }

        private void principio_Click(object sender, EventArgs e)
        {
            dr = bbdd1DataSet1.Tables[0].Rows[0];
            if (dr != null)
            {
                id.Text = dr.ItemArray[0].ToString();
                nombre.Text = dr.ItemArray[1].ToString();
                apellidos.Text = dr.ItemArray[2].ToString();
                fechaNac.Text = dr.ItemArray[3].ToString();
                notas.Text = dr.ItemArray[4].ToString();
            }
        }

        private void final_Click(object sender, EventArgs e)
        {
            int fin = bbdd1DataSet1.Tables[0].Rows.Count;
            dr = bbdd1DataSet1.Tables[0].Rows[fin-1];
            if (dr != null)
            {
                id.Text = dr.ItemArray[0].ToString();
                nombre.Text = dr.ItemArray[1].ToString();
                apellidos.Text = dr.ItemArray[2].ToString();
                fechaNac.Text = dr.ItemArray[3].ToString();
                notas.Text = dr.ItemArray[4].ToString();
            }
        }

        private void volver_Click(object sender, EventArgs e)
        {
            int actual = bbdd1DataSet1.Tables[0].Rows.IndexOf(dr);
            if (actual - 1 >= 0)
            {
                dr = bbdd1DataSet1.Tables[0].Rows[actual - 1];
                id.Text = dr.ItemArray[0].ToString();
                nombre.Text = dr.ItemArray[1].ToString();
                apellidos.Text = dr.ItemArray[2].ToString();
                fechaNac.Text = dr.ItemArray[3].ToString();
                notas.Text = dr.ItemArray[4].ToString();
            }
        }

        private void subir_Click(object sender, EventArgs e)
        {
            int actual = bbdd1DataSet1.Tables[0].Rows.IndexOf(dr);
            if (actual + 1 < bbdd1DataSet1.Tables[0].Rows.Count)
            {
                dr = bbdd1DataSet1.Tables[0].Rows[actual + 1];
                id.Text = dr.ItemArray[0].ToString();
                nombre.Text = dr.ItemArray[1].ToString();
                apellidos.Text = dr.ItemArray[2].ToString();
                fechaNac.Text = dr.ItemArray[3].ToString();
                notas.Text = dr.ItemArray[4].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            if (f.ShowDialog() == DialogResult.OK)
            {
                this.tableAdapterManager1.UpdateAll(this.bbdd1DataSet1);
            }
        }
    }
}
