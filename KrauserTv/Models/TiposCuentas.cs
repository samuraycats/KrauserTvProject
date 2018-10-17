using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrauserTv.Models
{
    class TiposCuentas
    {
        krausertvEntities db = new krausertvEntities();
        public int idtipocuenta { get; set; }
        public string descripcion { get; set; }
        public Boolean status { get; set; }

        public IEnumerable<TiposCuentas> Listar() {
            IEnumerable<TiposCuentas> c = db.tbltipocuentas
                .Where(x => x.status == true)
                .Select(p => new TiposCuentas { idtipocuenta = p.idtipocuenta, descripcion = p.descripcion })
                .ToList();
            return c;
        }

    }
}
