using pjGestionEmpleados.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjGestionEmpleados.Presentación
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }
        #region "Métodos"

        private void CargarEmpleados(string Buscar)
        {
            D_Empleados Datos = new D_Empleados();
            dgvLista.DataSource = Datos.Listar_Empleados(Buscar);

            FormatoListaEmpleados();
        }

        private void FormatoListaEmpleados()
        {
            dgvLista.Columns[0].Width = 45;
            dgvLista.Columns[1].Width = 170;
            dgvLista.Columns[2].Width = 150;
            dgvLista.Columns[7].Width = 170;

        }

        private void CargarDepartamentos()
        {
            D_Departamentos Datos = new D_Departamentos();
            cmbDepartamento.DataSource = Datos.Listar_Departamentos();
            cmbDepartamento.ValueMember = "id_departamento";
            cmbDepartamento.DisplayMember = "nombre_departamento";
            cmbDepartamento.SelectedIndex = -1;
        }

        private void CargarCargos()
        {
            D_Cargos Datos = new D_Cargos();
            cmbCargo.DataSource = Datos.Listar_Cargos();
            cmbCargo.ValueMember = "id_cargo";
            cmbCargo.DisplayMember = "nombre_cargo";
            cmbCargo.SelectedIndex = -1;
        }
        #endregion

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            CargarEmpleados("%");
            CargarDepartamentos();
            CargarCargos(); 
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarEmpleados(txtBuscar.Text);
        }
    }
}
