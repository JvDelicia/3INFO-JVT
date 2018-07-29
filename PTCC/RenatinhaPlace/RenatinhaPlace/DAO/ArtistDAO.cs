using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RenatinhaPlace.Entity;


namespace RenatinhaPlace.DAO
{
    public class ArtistDAO
    {
        private EntitiesContext context;

        public ArtistDAO() { context = new EntitiesContext(); }

        public void Add(Artist artist)
        {
            context.Artists.Add(artist);
            context.SaveChanges();
        }
        /* public Artist FindId(int id) {
             return context.Artist.FirstOrDefault(u => u.PeopleId == id);
         }/*/
        public void Remove(Artist artist)
        {
            context.Artists.Remove(artist);
            context.SaveChanges();
        }
        public void Update()
        {
            context.SaveChanges();
        }

        public IList<Artist> List()
        {
            var busca = from p in context.Artists select p;
            return busca.ToList();

        }

        public int FindIdByCb(string artistcb)
        {
            int posicao = artistcb.IndexOf('-');
            artistcb = artistcb.Substring(0, posicao);
            return int.Parse(artistcb);
        }
    }
}
