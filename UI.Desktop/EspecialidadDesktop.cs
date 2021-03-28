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
    public partial class EspecialidadDesktop : ApplicationForm
    {

        private Especialidad EspecialidadActual { get; set; }
        private MetodosParaControls metodoParaControles { get; set; }
        
        public EspecialidadDesktop()
        {
            InitializeComponent();
            this.metodoParaControles = new MetodosParaControls();
        }

        public EspecialidadDesktop(ModoForm modo) : this()
        {
            Modo = modo;
            if(modo == ModoForm.Alta)
            {
                txtId.Visible = false;
                lblID.Visible = false;
            }
        }

        public EspecialidadDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            EspecialidadLogic el = new EspecialidadLogic();
            this.EspecialidadActual = el.GetOne(ID);
            this.MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtId.Text = this.EspecialidadActual.ID.ToString();
            this.txtDescripcion.Text = this.EspecialidadActual.Descripcion;
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
                Especialidad esp = new Especialidad();
                this.EspecialidadActual = esp;
            }
            if(Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                EspecialidadActual.Descripcion = txtDescripcion.Text;
                if(Modo == ModoForm.Modificacion)
                {
                    EspecialidadActual.ID = Convert.ToInt32(this.txtId.Text);
                }
            }

            switch (Modo)
            {
                case ModoForm.Alta:
                    this.EspecialidadActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Baja:
                    this.EspecialidadActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Modificacion:
                    this.EspecialidadActual.State = BusinessEntity.States.Modified;
                    break;
            }

        }

        
        public override bool Validar()
        {
            return this.metodoParaControles.validarControlesVacios(this.tlpEspecialidades.Controls);
        }

        public override void GuardarCambios()
        {
            try
            {
                this.MapearADatos();
                EspecialidadLogic el = new EspecialidadLogic();
                if (this.EspecialidadActual.State != BusinessEntity.States.Deleted)
                    el.Save(EspecialidadActual);
                else
                    el.Delete(EspecialidadActual.ID);
                MessageBox.Show("Se ha realizado la operaciòn existosamente", "Accion completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error al guardar especialidad",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult dr = DialogResult.None;
            switch (Modo)
            {
                case ModoForm.Alta:
                    break;
                case ModoForm.Baja:
                    dr = MessageBox.Show("¿Desea dar de baja la especialidad?", "Baja de especialidad", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    break;
                case ModoForm.Modificacion:
                    dr = MessageBox.Show("¿Desea guardar los cambios de la especialidad?", "Modificaciòn", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    break;
            };
            if(dr == DialogResult.Yes || dr == DialogResult.None)
                this.GuardarCambios();
        }
    }
}
