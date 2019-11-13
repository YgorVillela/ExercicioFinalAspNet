using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAspCore.Repositories
{
   public interface IJogoRepository
    {
        void Cadastrar(Jogo jogo);
        IList<Jogo> Listar();
        void Atualizar(Jogo jogo);
        void Remover(int jogoId);
        void Salvar();
    }
}
