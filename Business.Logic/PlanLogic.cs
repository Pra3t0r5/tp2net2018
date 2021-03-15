using Business.Entities;
using Data.Database;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;
using Util.Validators;

namespace Business.Logic
{
    public class PlanLogic
    {
        private MetodosParaCombosBox Metodos { get; set; }      
        private PlanAdapter PlanData { get; set; }
        private string ErrorText { get; set; }
        private PlanValidator PlanValidator { get; set; }

        private ValidationResult ValidateResult { get; set; }

        public PlanLogic()
        {
            this.Metodos = new MetodosParaCombosBox();
            this.PlanData = new PlanAdapter();
            this.PlanValidator = new PlanValidator();
        }

        public List<Plan> GetAllForCombo()
        {
            return this.Metodos.GetAllPlanesForCombo();
        }

        public List<Plan> GetAll()
        {
            return this.PlanData.GetAll();
        }

        public Plan GetOne(int ID)
        {
            return this.PlanData.GetOne(ID);
        }

        public void Save(Plan plan)
        {
            this.ValidateResult = this.PlanValidator.Validate(plan);
            if (ValidateResult.IsValid)
            {
                this.PlanData.Save(plan);
            }
            else
            {
                ValidateResult.Errors.ToList().ForEach(x => this.ErrorText += $"{x.ErrorMessage}\n");
                throw new Exception(this.ErrorText);
            }
        }

        public void Delete(int ID)
        {
            try
            {

                this.PlanData.Delete(ID);
            }

            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar el plan", ex);
                throw ExcepcionManejada;
            }
        }
    }
}
