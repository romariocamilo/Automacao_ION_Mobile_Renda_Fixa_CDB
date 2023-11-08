using Core_Automacao.Models.Mobile;

namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Pages
{
    public class Lupa
    {
        public ElementoMobile CampoPesquisa { get; private set; }
        public ElementoMobile OpcaoCDBDIItau { get; private set; }
        public ElementoMobile OpcaoLCADIItau { get; private set; }

        public Lupa()
        {
            CampoPesquisa = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "et_global_search", string.Empty, string.Empty, string.Empty);
            OpcaoCDBDIItau = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "tv_description", string.Empty, "CDB DI Itaú Pós-Fixado", "CDB DI Itaú Pós-Fixado");
            OpcaoLCADIItau = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "tv_description", string.Empty, "LCA IPCA Itaú Pós-Fixado", "LCA IPCA Itaú Pós-Fixado");
        }
    }
}