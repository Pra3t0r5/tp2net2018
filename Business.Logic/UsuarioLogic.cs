using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;


namespace Business.Logic
{
    public class UsuarioLogic : BusinessLogic
    {
        private UsuarioAdapter UsuarioData { get; set; }

        public UsuarioLogic()
        {
            this.UsuarioData = new UsuarioAdapter();
        }

        public List<Usuario> GetAll()
        {
            return this.UsuarioData.GetAll();
        }

        public Usuario GetOne(int ID)
        {
            return this.UsuarioData.GetOne(ID);
        }

        public void Save(Usuario usuario)
        {
            this.UsuarioData.Save(usuario);
        }

        public int getPermissionByID(Usuario usr)
        {
            return this.UsuarioData.getPermissionByID(usr);
        }

        public void Delete(int ID)
        {
            this.UsuarioData.Delete(ID);
        }
    }
}
