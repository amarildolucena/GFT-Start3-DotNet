using ProjetoFinal.src.Interfaces;

namespace ProjetoFinal.src.Entities
{
    public class SerieRepositorio : IRepositorio<Series>
    {

        private List<Series> listaSeries = new List<Series>();

        public void Atualizar(int id, Series entidade)
        {
            listaSeries[id] = entidade;
        }

        public void Excluir(int id)
        {
            listaSeries[id].Excluir();
        }

        public void Inserir(Series entidade)
        {
            listaSeries.Add(entidade);
        }

        public List<Series> Listar()
        {
            return listaSeries;
        }

        public int ProximoId()
        {
            return listaSeries.Count;
        }

        public Series RetornarPorId(int id)
        {
            return listaSeries[id];
        }

    }

}