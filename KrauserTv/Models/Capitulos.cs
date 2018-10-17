using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.Entity.Validation;

namespace KrauserTv.Models
{
    class Capitulos
    {
        public int idserie { get; set; }
        public string nombre { get; set; }

        public string titulo { get; set; }
        public int idcapitulo { get; set; }


        public int idtemporada { get; set; }
        public string miniatura { get; set; }
        public int consecutivo { get; set; }
        public bool status { get; set; }
                

        krausertvEntities db = new krausertvEntities();

        //public IEnumerable<Capitulos> ListarSeries() {
        //    IEnumerable<Capitulos> c = db.tblseries.Where(x => x.status == true).Select(x => new Capitulos {idserie= x.idserie,nombre = x.nombre }).ToList();
        //    return c;

        //}

        public IEnumerable<Capitulos> GetCapitulos() {
            IEnumerable<Capitulos> c= db.tblcapitulos
                .Where(x => x.idserie == idserie && x.idtemporada == idtemporada)
                .Select(p=> new Capitulos {nombre=p.titulo, idcapitulo = p.idcapitulo, consecutivo = p.consecutivo.Value } )
                .ToList();
            return c;
        }

        public IEnumerable<Temporadas> ListarTemporadasFiltro() {
            IEnumerable < Temporadas > c = db.tblcapitulos
                .Where(x => x.idserie == idserie)
                .Select(p => new Temporadas { idtemporada = p.idtemporada, descripcion = p.tbltemporadas.descripcion })
                .Distinct()
                .ToList();
            return c;
        }

        public IEnumerable<Capitulos> ListarCapitulosFiltro()
        {
            IEnumerable<Capitulos> c = db.tblcapitulos
                .Where(x => x.idserie == idserie && x.idtemporada==idtemporada)
                .Select(p => new Capitulos { idcapitulo = p.idcapitulo, consecutivo = p.consecutivo.Value })
                .ToList();
            return c;
        }

        public Boolean GuardarCapitulo()
        {
            try
            {
                FileInfo postert = new FileInfo(miniatura);
               // int min = idserie + idtemporada+consecutivo;
               // string nombreFile = Utilerias.GetMD5(min.ToString());
                string nombreFile = Guid.NewGuid().ToString();
                string fin = "C:/AppServ/www/Krauser/Images/capitulos/" + nombreFile + ".jpg";
                
                


                tblcapitulos n = new tblcapitulos();
                n.idserie = idserie;
                n.idtemporada = idtemporada;
                n.miniatura = nombreFile;
                n.consecutivo = consecutivo;
                n.status = status;
                n.titulo = titulo;

                n.alta = DateTime.Today;
                db.tblcapitulos.Add(n);
                db.SaveChanges();
                postert.CopyTo(fin);
                return true;
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                   string mensaje= ""+ ve.PropertyName +" "+ ve.ErrorMessage;
                    }
                }
                return false;
                throw;
            }

        }

    }
}
