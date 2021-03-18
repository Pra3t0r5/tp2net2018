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
                return context.Planes.Include("Especialidad").ToList();
            }
        }

        public Plan GetOne(int ID)
        {
            using (var context = new AcademiaContext())
            {
                return context.Planes.Include("Especialidad").FirstOrDefault(x => x.ID == ID);
            }
        }

        public void Delete(int ID)
        {
            using (var context = new AcademiaContext())
            {
                var plan = context.Planes.Find(ID);
                context.Planes.Remove(plan);
                context.SaveChanges();
            }
        }

        protected void Update(Plan plan)
        {
            using (var context = new AcademiaContext())
            {
                var planEntity = context.Planes.Find(plan.ID);
                context.Entry(plan).CurrentValues.SetValues(plan);
                context.SaveChanges();
            }
        }

        protected void Insert(Plan plan)
        {
            using (var context = new AcademiaContext())
            {
                context.Planes.Add(plan);
                context.SaveChanges();
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
