using CrudExtra.Context;
using CrudExtra.Interfaces;
using CrudExtra.Models;

namespace CrudExtra.Repositories
{
    public class FrutaRepository : IFrutaRepository
    {

        public FrutaContext ctx = new FrutaContext();
        public void Atualizar(int id, FrutaModel fruta)
        {
            FrutaModel frutaAchada = ctx.Frutas.FirstOrDefault(f => f.id == id);



            if (frutaAchada != null)
            {

                frutaAchada.Name = fruta.Name;

                ctx.Frutas.Update(frutaAchada);
                ctx.SaveChanges();

            }
        }

        public void Cadastrar(FrutaModel fruta)
        {
            ctx.Frutas.Add(fruta);
            ctx.Frutas.SaveChanges();
        }

        public void Deletar(int id)
        {
            FrutaModel frutaAchada = ctx.FirstOrDefault(f => f.id == id);



            if (frutaAchada != null)
            {



                ctx.Frutas.Remove(frutaAchada);
                ctx.SaveChanges();
            }


        }



        public List<FrutaModel> Listar()
        {
            return ctx.Frutas
                .Select(c => new FrutaModel
                {
                    Id = c.Id,
                    Name = c.Name,

                })
                .ToList();
        }
    }
}
