using CrudExtra.Models;

namespace CrudExtra.Interfaces
{
    public interface IFrutaRepository
    {


        public void Cadastrar(FrutaModel fruta);

        public List<FrutaModel> Listar();

        public void Deletar(int id);

        public void Atualizar(int id, FrutaModel fruta);

    }
}
