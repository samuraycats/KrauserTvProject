using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrauserTv.Models
{
    class Temporadas
    {
        krausertvEntities db = new krausertvEntities();

        public int idtemporada {get; set;}
        public string descripcion { get; set; }
        public Boolean status { get; set; }

        public IEnumerable<Temporadas> ListarTemporadas() {

            IEnumerable<Temporadas> c = db.tbltemporadas
                .Where(x => x.status == true)
                .Select(p => new Temporadas { idtemporada = p.idtemporada, descripcion = p.descripcion }).ToList();
            return c;
        }

    }
}
