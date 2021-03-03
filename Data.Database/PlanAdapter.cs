using Business.Entities;
using Data.Database.context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class PlanAdapter : Adapter
    {
        public List<Plan> GetAll()
        {
            using (var context = new AcademiaContext())
            {
                return context.Database.SqlQuery<Plan>("PlanGetAll").ToList();
            }
        }

        public Plan GetOne(int ID)
        {
            using (var context = new AcademiaContext())
            {
                var parametros = $"@Id={ID}";
                return context.Database.SqlQuery<Plan>($"PlanGetOne {parametros}").FirstOrDefault();
            }
        }

        public void Delete(int ID)
        {
            using (var context = new AcademiaContext())
            {
                var parametros = $"@Id={ID}";
                context.Database.ExecuteSqlCommand($"PlanDelete {parametros}");
            }
        }

        protected void Update(Plan plan)
        {
            using (var context = new AcademiaContext())
            {
                var parametros = $"@Id={plan.ID}, @Descripcion='{plan.Descripcion}', @IdEspecialidad={plan.IDEspecialidad}";
                context.Database.ExecuteSqlCommand($"PlanUpdate {parametros}");
            }
        }

        protected void Insert(Plan plan)
        {
            using (var context = new AcademiaContext())
            {
                var parametros = $"@Descripcion='{plan.Descripcion}', @IdEspecialidad={plan.IDEspecialidad}";
                context.Database.ExecuteSqlCommand($"PlanInsert {parametros}");
            }
        }

        public void Save(Plan plan)
        {
            if (plan.State == BusinessEntity.States.Deleted)
            {
                this.Delete(plan.ID);
            }
            else if (plan.State == BusinessEntity.States.New)
            {
                this.Insert(plan);
            }
            else if (plan.State == BusinessEntity.States.Modified)
            {
                this.Update(plan);
            }
            plan.State = BusinessEntity.States.Unmodified;
        }

    }
}
