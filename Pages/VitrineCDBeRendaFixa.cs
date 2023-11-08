using System;
using Core_Automacao.Models.Mobile;

namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Pages
{
    public class VitrineCDBeRendaFixa
    {
        public ElementoMobile TextoTituloVitrineCDBeRendaFixa { get; set; }
        public ElementoMobile TextoTituloCDBDI { get; set; }
        public ElementoMobile TextoTituloLCAIPCAItau { get; set; }

        public VitrineCDBeRendaFixa()
        {
            TextoTituloVitrineCDBeRendaFixa = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "tv_custom_title", string.Empty, "CDB e Renda Fixa", string.Empty);
            TextoTituloCDBDI = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "tv_item_title", string.Empty, "CDB DI Itaú", string.Empty);
            TextoTituloLCAIPCAItau = new ElementoMobile(TipoIdentificador.Id, TipoIdentificador.NaoDefinido, "tv_item_title", string.Empty, "LCA IPCA Itaú", string.Empty);
        }
    }
}