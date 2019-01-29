﻿using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace UI.Desktop
{
    public partial class ComisionDesktop : ApplicationForm
    {
        private Comision ComisionActual {get; set;}
        private MetodosParaControls metodoParaControles { get; set; }
        
        public ComisionDesktop()
        {
            InitializeComponent();
            this.metodoParaControles = new MetodosParaControls();
            this.CargarCombos();
        }

        public ComisionDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }

        public ComisionDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            ComisionLogic cl = new ComisionLogic();
            this.ComisionActual = cl.GetOne(ID);
            this.MapearDeDatos();
        }

        public void CargarCombos()
        {
            PlanLogic pl = new PlanLogic();
            this.cmbPlanes.DataSource = pl.GetAllForCombo();
            this.cmbPlanes.DisplayMember = "Descripcion";
            this.cmbPlanes.ValueMember = "ID";
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.ComisionActual.ID.ToString();
            this.txtDescripcion.Text = this.ComisionActual.Descripcion;
            this.numericUpDown1.Value = (decimal)this.ComisionActual.AnioEspecialidad;
            this.cmbPlanes.SelectedItem = this.ComisionActual.IDPlan;
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
                Comision com = new Comision();
                this.ComisionActual = com;
            }

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                ComisionActual.Descripcion = this.txtDescripcion.Text;
                ComisionActual.AnioEspecialidad = (int)this.numericUpDown1.Value;
                ComisionActual.IDPlan = (int)this.cmbPlanes.SelectedValue;
            }
            if (Modo == ModoForm.Modificacion)
            {
                ComisionActual.ID = Convert.ToInt32(this.txtID.Text);
            }

            switch (Modo)
            {
                case ModoForm.Alta:
                    this.ComisionActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Baja:
                    this.ComisionActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Modificacion:
                    this.ComisionActual.State = BusinessEntity.States.Modified;
                    break;
            }

        }
        
        public override bool Validar()
        {
            return this.metodoParaControles.validarControlesVacios(this.tlpComision.Controls);
        }

        public override void GuardarCambios()
        {
            if (this.Validar())
            {
                this.MapearADatos();
                ComisionLogic cl = new ComisionLogic();
                cl.Save(this.ComisionActual);
                this.Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //try
            //{
                this.GuardarCambios();
            //}    
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error al eliminar curso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
