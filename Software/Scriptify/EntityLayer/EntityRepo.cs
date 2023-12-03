using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityRepo
    {
        public EntityModels dbContext
        { get; set; }
        public EntityRepo()
        {
            dbContext = new EntityModels();
        }
        public IQueryable<Rezervacija_Projection> getRezervacije()
        {
            var query = from r in dbContext.Rezervacija
                        join u in dbContext.User on r.User_id_user equals u.id_user
                        join khk in dbContext.Knjizara_has_Knjige on r.Knjizara_has_Knjige_knjizara_has_knjige_id equals khk.knjizara_has_knjige_id
                        join k in dbContext.Knjige on khk.Knjige_idKnjige equals k.idKnjige
                        join kn in dbContext.Knjizara on khk.Knjizara_idKnjizara equals kn.idKnjizara
                        select new Rezervacija_Projection
                        {
                          id_user =  u.id_user,
                           username = u.username,
                           naziv_knjige = k.naziv_knjige,
                          ime = u.Ime,
                            prezime = u.Prezime
                        };

            return query;

        }
    }
    }
