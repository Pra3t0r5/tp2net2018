using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace UI.Desktop
{
    public partial class MateriaDesktop : ApplicationForm
    {
        private MateriaLogic materiaLogic { get; set; }
        private Materia MateriaActual { get; set; }
        private MetodosParaControls metodosParaControls {get; set;}

        public MateriaDesktop()
        {
            InitializeComponent();
            this.materiaLogic = new MateriaLogic();
            this.metodosParaControls = new MetodosParaControls();
        }

        public MateriaDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }

        public MateriaDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            MateriaLogic ml = new MateriaLogic();
            this.MateriaActual = ml.GetOne(ID);
            this.MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtId.Text = this.MateriaActual.ID.ToString();
            this.txtDescripcion.Text = this.MateriaActual.Descripcion;
            this.nudHsSemanales.Value = this.MateriaActual.HSSemanales;
            this.nudHsTotales.Value = this.MateriaActual.HSTotales;
            this.cmbPlanes.DisplayMember = this.MateriaActual.DescripcionPlan;
            this.cmbPlanes.ValueMember = this.MateriaActual.IDPlan.ToString();
            switch (Modo)
            {
                case ModoForm.Alta:
                    this.btnGuardar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    this.btnGuardar.Text = "Eliminar";
                    break;
                case ModoForm.Modificacion:
                    this.btnGuardar.Text = "Guardar";
                    break;
                case ModoForm.Consulta:
                    this.btnGuardar.Text = "Aceptar";
                    break;
            }
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                Materia esp = new Materia();
                this.MateriaActual = esp;
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                MateriaActual.Descripcion = txtDescripcion.Text;
                MateriaActual.HSSemanales = Convert.ToInt32(nudHsSemanales.Value);
                MateriaActual.HSTotales = Convert.ToInt32(nudHsTotales.Value);
                MateriaActual.IDPlan = Convert.ToInt32(cmbPlanes.SelectedValue);
                if (Modo == ModoForm.Modificacion)
                {
                    MateriaActual.ID = Convert.ToInt32(this.txtId.Text);
                }
            }

            switch (Modo)
            {
                case ModoForm.Alta:
                    this.MateriaActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Baja:
                    this.MateriaActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Modificacion:
                    this.MateriaActual.State = BusinessEntity.States.Modified;
                    break;
            }

        }


        public override bool Validar()
        {
            return this.metodosParaControls.validarControlesVacios(this.tblMaterias.Controls);
        }

        public override void GuardarCambios()
        {
            if (this.Validar())
            {
                this.MapearADatos();
                this.materiaLogic.Save(MateriaActual);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
        }

        private void MateriaDesktop_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2_netDataSet.planes' Puede moverla o quitarla según sea necesario.
            this.planesTableAdapter.Fill(this.tp2_netDataSet.planes);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void CargarCombos()
        {
            MateriaLogic mt = new MateriaLogic();
            this.cmbPlanes.DataSource = mt.GetAllForCombo();
            this.cmbPlanes.DisplayMember = "Descripcion";
            this.cmbPlanes.ValueMember = "ID";
        }
    }
}
