using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KrauserTv.Models
{

    class Usuarios
    {
        krausertvEntities db = new krausertvEntities();
        public int idusuario { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public string movil { get; set; }
        public int idtipocuenta { get; set; }

        public Usuarios() { 
        }

        public Usuarios(string usuario, string password, string nombre, string email, string movil, int idtipocuenta) {
            this.usuario = usuario;
            this.password = password;
            this.nombre = nombre;
            this.email = email;
            this.movil = movil;
            this.idtipocuenta = idtipocuenta;
        }

        public Boolean Guardar() {
            try {
                tblpersonas n = new tblpersonas();
                n.nombre = this.nombre;
                n.email = this.email;
                n.status = true;
                db.tblpersonas.Add(n);
                db.SaveChanges();

                tblusuarios n2 = new tblusuarios();
                n2.idusuario = UltimoUser();

                n2.idtipocuenta = this.idtipocuenta;

                n2.usuario = this.usuario ;
                n2.password= this.password = password;
                db.tblusuarios.Add(n2);
               
                db.SaveChanges();

                return true;
            }
            catch(Exception ex) {
                return false;
            }
        }

        public int UltimoUser() {
            int c = db.tblpersonas.Select(p => new {  p.idusuario })
                .Max(x => x.idusuario);
            return c;
                
        }
    }
}
