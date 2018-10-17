using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrauserTv.Models
{
    class Links
    {

        public int idservidor { get; set; }
        public string nombreserver { get; set; }
        public int idcapitulo { get; set; }
        public string link { get; set; }
        public bool status { get; set; }

        krausertvEntities db = new krausertvEntities();

        public IEnumerable<Links> ListarLinks() {
            IEnumerable<Links> c = db.tblcapituloservers
                .Where(x => x.idcapitulo == idcapitulo)
                .Select(p => new Links { nombreserver = p.tblservidores.nombre, link = p.link })
                .ToList();
            return c;
        }

        public bool GuardarLink() {
            try {
                var  c = db.tblcapituloservers
                    .Where(x => x.idcapitulo == idcapitulo && x.idservidor == idservidor)
                    .Select(p => new Links {idcapitulo=p.idcapitulo,idservidor=p.idservidor })
                    .FirstOrDefault();

                if (c == null)
                {
                    tblcapituloservers n = new tblcapituloservers();
                    n.idcapitulo = idcapitulo;
                    n.idservidor = idservidor;
                    n.link = link;
                    n.status = status;
                    db.tblcapituloservers.Add(n);
                    db.SaveChanges();
                    return true;
                }
                else {

                    return false;
                }
            }

            catch (Exception ex){
                return false;
            }

            
        }

    }
}
