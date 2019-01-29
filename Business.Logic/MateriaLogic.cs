using Business.Entities;
using Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class MateriaLogic
    {
        private MateriaAdapter MateriaData { get; set; }

        public MateriaLogic()
        {
            this.MateriaData = new MateriaAdapter();
        }

        public List<Materia> GetAllForCombo()
        {
            return this.MateriaData.GetAllForCombo();
        }

        public List<Materia> GetAll()
        {
            return this.MateriaData.GetAll();
        }

        public Materia GetOne(int ID)
        {
            return this.MateriaData.GetOne(ID);
        }

        public void Save(Materia mat)
        {
            this.MateriaData.Save(mat);
        }

        public void Delete(int ID)
        {
            this.MateriaData.Delete(ID);
        }

    }
}
