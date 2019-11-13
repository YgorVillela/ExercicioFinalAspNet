using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAspCore.Repositories
{
    public class JogoRepository : IJogoRepository
    {

        private GameStoreContext _context;

        public JogoRepository(GameStoreContext context)
        {
            _context = context;
        }
        public void Atualizar(Jogo jogo)
        {
            _context.Jogos.Update(jogo);
        }

        public void Cadastrar(Jogo jogo)
        {
            _context.Jogos.Add(jogo);
        }

        //Como retornarei o jogo mais genero, precisarei usar o include

        public IList<Jogo> Listar()
        {
            return _context.Jogos.Include(c => c.Genero).ToList(); 
        }

        public void Remover(int jogoId)
        {
            var jogo = _context.Jogos.Find(jogoId);
            _context.Jogos.Remove(jogo);

        }
        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
