using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAspCore.Repositories
{
    public class GeneroRepository : IGeneroRepository
    {
        private GameStoreContext _context;

        public GeneroRepository(GameStoreContext context)
        {
            _context = context;
        }

        public void Atualizar(Genero genero)
        {
            _context.Generos.Update(genero);
        }

        public void Cadastrar(Genero genero)
        {
            _context.Generos.Add(genero);
        }

        public IList<Genero> Listar()
        {
            return _context.Generos.ToList();
        }

        public void Remover(int generoId)
        {
            var genero = _context.Generos.Find(generoId);
            _context.Generos.Remove(genero);
        }
        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
