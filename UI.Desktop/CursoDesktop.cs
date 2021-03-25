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
    public partial class CursoDesktop : ApplicationForm
    {
        private Curso CursoActual { get; set; }
        private MetodosParaControls metodoParaControles { get; set; }

        public CursoDesktop()
        {
            InitializeComponent();
            this.CargarCombos();
            this.metodoParaControles = new MetodosParaControls();
        }

        public CursoDesktop(ModoForm modo):this()
        {
            Modo = modo;
        }

        public CursoDesktop(int ID, ModoForm modo):this()
        {
            Modo = modo;
            CursoLogic cl = new CursoLogic();
            this.CursoActual = cl.GetOne(ID);
            this.MapearDeDatos();
        }

        public void CargarCombos()
        {
            ComisionLogic cl = new ComisionLogic();
            MateriaLogic ml = new MateriaLogic();
            cmbComision.DataSource = cl.GetAllCombo();
            cmbComision.DisplayMember = "Descripcion";
            cmbComision.ValueMember = "ID";
            cmbMaterias.DataSource = ml.GetAllForCombo();
            cmbMaterias.DisplayMember = "Descripcion";
            cmbMaterias.ValueMember = "ID";
        }

        public override void MapearDeDatos()
        {
            this.txtId.Text = this.CursoActual.ID.ToString();
            this.cmbMaterias.SelectedText = this.CursoActual.Materia.Descripcion;
            this.cmbMaterias.SelectedValue = this.CursoActual.IDMateria;
            this.cmbComision.SelectedText = this.CursoActual.Comision.Descripcion;
            this.cmbComision.SelectedValue = this.CursoActual.IDComision;
            this.nmdAnio.Value = this.CursoActual.AnioCalendario;
            this.nmdCupo.Value = this.CursoActual.Cupo;


            switch (Modo)
            {
                case ModoForm.Alta:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    break;
                case ModoForm.Modificacion:
                    this.btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    break;
            }
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                Curso cur = new Curso();
                this.CursoActual = cur;
            }
            if(Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                CursoActual.IDComision = (int)cmbComision.SelectedValue;
                CursoActual.IDMateria = (int)cmbMaterias.SelectedValue;
                CursoActual.AnioCalendario = Convert.ToInt32(nmdAnio.Value);
                CursoActual.Cupo = Convert.ToInt32(nmdCupo.Value);
            }
            if(Modo == ModoForm.Modificacion)
            {
                CursoActual.ID = Convert.ToInt32(txtId.Text);
            }
            else if (Modo == ModoForm.Alta)
            {
                this.txtId.ReadOnly = true;
            }

            switch (Modo)
            {
                case ModoForm.Alta:
                    this.CursoActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Baja:
                    this.CursoActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Modificacion:
                    this.CursoActual.State = BusinessEntity.States.Modified;
                    break;
            }


        }


        public override bool Validar()
        {
            return this.metodoParaControles.validarControlesVacios(this.tblCurso.Controls);
        }

        public override void GuardarCambios()
        {
            if (this.Validar())
            {
                this.MapearADatos();
                CursoLogic cl = new CursoLogic();
                cl.Save(this.CursoActual);
                this.Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
