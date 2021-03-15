using Business.Entities;
using Data.Database;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;
using Util.Validators;

namespace Business.Logic
{
    public class ComisionLogic
    {
        private MetodosParaCombosBox combos { get; set; }
        private ComisionAdapter ComisionData { get; set; }
        private ValidationResult ValidationResult { get; set; }
        private ComisionValidator ComisionValidator { get; set; }
        private string ErrorText { get; set; }

        public ComisionLogic()
        {
            this.combos = new MetodosParaCombosBox();
            this.ComisionData = new ComisionAdapter();
            this.ComisionValidator = new ComisionValidator();
        }

        public List<Comision> GetAll()
        {
            return this.ComisionData.GetAll();
        }

        public Comision GetOne(int ID)
        {
            return this.ComisionData.GetOne(ID);
        }

        public void Save(Comision comi)
        {
            this.ValidationResult = this.ComisionValidator.Validate(comi);
            if (this.ValidationResult.IsValid)
            {
                this.ComisionData.Save(comi);
            }
            else
            {
                this.ValidationResult.Errors.ToList().ForEach(x => this.ErrorText += $"{x.ErrorMessage}\n");
                throw new Exception(this.ErrorText);
            }
        }

        public void Delete(int ID)
        {
            try
            {
                this.ComisionData.Delete(ID);
            }
            catch (Exception ex)
            {

                Exception ExcepcionManejada = new Exception("Error al eliminar la comision", ex);
                throw ExcepcionManejada;
            }         
        }

        public List<Comision> GetAllCombo()
        {
            return this.combos.GetAllComisiones();
        }

        public List<Comision> GetAllByMateria(int idPlan)
        {
            return this.ComisionData.GetAllByMateria(idPlan);
        }
    }
}
