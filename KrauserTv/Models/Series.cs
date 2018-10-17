using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace KrauserTv.Models
{
    class Series
    {
        krausertvEntities db = new krausertvEntities();
        public int idserie { get; set; }
        public string nombre { get; set; }

        public int guardar(string nombre, int anio, string descripcion, string poster) {
            try
            {
                FileInfo postert = new FileInfo(poster);
                string nombreFile = Utilerias.GetMD5(nombre);
                string fin = "C:/AppServ/www/Krauser/Images/posters/" + nombreFile + ".jpg";
                postert.CopyTo(fin);

                tblseries n = new tblseries();
                n.nombre = nombre;
                n.año = anio;
                n.descripcion = descripcion;
                n.poster = nombreFile + ".jpg";
                db.tblseries.Add(n);
                db.SaveChanges();
                return 1;
            }
            catch {
                return 0;
            }

            

           
        }
      
        public IEnumerable<Series> Listar() {
            IEnumerable<Series> c = db.tblseries.Where(x => x.status == true).Select(p => new Series { idserie = p.idserie, nombre = p.nombre }).ToList();
            return c;
        }

    }
}
