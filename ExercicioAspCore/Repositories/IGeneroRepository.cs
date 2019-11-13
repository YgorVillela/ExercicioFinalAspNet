using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAspCore.Repositories
{
    public interface IGeneroRepository
    {
        void Cadastrar(Genero genero);
        IList<Genero> Listar();
        void Atualizar(Genero genero);
        void Remover(int generoId);
        void Salvar();
    }
}
