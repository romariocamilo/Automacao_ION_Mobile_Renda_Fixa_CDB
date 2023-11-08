using Core_Automacao.Models.Mobile;

namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Pages
{
    public class Vitrine
    {
        public ElementoMobile BotaoLupaPesquisa { get; set; }
        public ElementoMobile TrilhoCardProdutos { get; set; }
        public ElementoMobile CardCdbRendaFixaAndroid { get; set; }
        public ElementoMobile CardCdbRendaFixaIos { get; set; }

        public Vitrine()
        {
            BotaoLupaPesquisa = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "buttonSearch", string.Empty, string.Empty, string.Empty);
            TrilhoCardProdutos = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.IdAcessibilidade, "recyclerViewCategories", "home_vitrine_trail_category", string.Empty, string.Empty);
            CardCdbRendaFixaAndroid = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.IdAcessibilidade, "textViewCategoryTitle", "CDB e Renda Fixa Produtos", "CDB e Renda Fixa", "CDB e Renda Fixa");
        }
    }
}