using Business.Entities;
using Business.Logic.Validators;
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
    public class EspecialidadLogic
    {
        private string ErrorText { get; set; }
        private EspecialidadValidator EspecialidadValidator { get; set; }
        private EspecialidadDeleteValidator DeleteValidator {get; set;}
        private ValidationResult ValidationResult { get; set; }
        private MetodosParaCombosBox combos { get; set; }
        EspecialidadAdapter EspecialidadData { get; set; }

        public EspecialidadLogic()
        {
            this.EspecialidadData = new EspecialidadAdapter();
            this.combos = new MetodosParaCombosBox();
            this.EspecialidadValidator = new EspecialidadValidator();
            this.DeleteValidator = new EspecialidadDeleteValidator();
        }

        public List<Especialidad> GetAllForCombo()
        {
            return this.combos.GetAllEspecialidadesForCombo();
        }

        public List<Especialidad> GetAll()
        {
            return this.EspecialidadData.GetAll();
        }

        public Especialidad GetOne(int ID)
        {
            return this.EspecialidadData.GetOne(ID);
        }
        public Especialidad GetOneFromPlan(int ID)
        {
            return this.EspecialidadData.GetOneFromPlan(ID);
        }

        public List<Especialidad> GetAllByIdPlan(int idPlan)
        {
            return this.EspecialidadData.GetAllByIdPlan(idPlan);
        }

        public void Save(Especialidad esp)
        {
            this.ValidationResult = this.EspecialidadValidator.Validate(esp);
            if (this.ValidationResult.IsValid)
            {
               this.EspecialidadData.Save(esp);
            }
            else
            {
               this.ValidationResult.Errors.ToList().ForEach(x => this.ErrorText += $"{x.ErrorMessage}\n");
               throw new Exception(this.ErrorText);
            }   
        }

        public void Delete(int ID)
        {
            var entity = this.GetOne(ID);
            this.ValidationResult = this.DeleteValidator.Validate(this.GetOne(ID));
            if (ValidationResult.IsValid)
            {
                this.EspecialidadData.Delete(ID);
            }
            else
            {
                this.ValidationResult.Errors.ToList().ForEach(x => this.ErrorText += $"{x.ErrorMessage}\n");
                throw new Exception(this.ErrorText);
            }
                 
        }

    }
}
