using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrauserTv.Models
{
    class Servidores
    {
        public int idservidor { get; set; }
        public string nombre { get; set; }

        krausertvEntities db = new krausertvEntities();
        public IEnumerable<Servidores> Listar() {
            IEnumerable<Servidores> c = db.tblservidores
                .Where(x => x.status == true)
                .Select(p => new Servidores {idservidor=p.idservidor, nombre=p.nombre })
                .ToList();
            return c;
        }

        public int Guardar(string nombre, Boolean status) {
            try{
            tblservidores n = new tblservidores();
            n.nombre = nombre;
            n.status = status;
            db.tblservidores.Add(n);
            db.SaveChanges();
                 return 1;
            }
                catch{
                return 0;
                }
        }
    }
}
