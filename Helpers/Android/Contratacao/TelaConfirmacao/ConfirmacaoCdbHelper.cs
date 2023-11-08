using Automacao_ION_Mobile_Renda_Fixa_CDB.Pages;
using Core_Automacao.Plataformas.Mobile;


namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Helpers.Android.Contratacao.TelaConfirmacao
{
    public class ConfirmacaoCdbHelper
    {
        public readonly CotacaoCDB cotacaoCDB;
        public readonly ConfirmacaoCDB confirmacaoCDB;
        //public readonly PoliticaPrivacidade politicaPrivacidade;

        public ConfirmacaoCdbHelper()
        {
            cotacaoCDB = new CotacaoCDB();
            confirmacaoCDB = new ConfirmacaoCDB();
            //politicaPrivacidade = new PoliticaPrivacidade();
        }

        public void SnapShotTelaConfirmaçãoHelper(AppiumServiceNew appiumServiceNew)
        {
            var listaElementosMobile = appiumServiceNew.BuscaVariosElementoMobile(cotacaoCDB.BotaoUmRealInsercaoRapida);
            appiumServiceNew.ClicaNoElementoMobileDaListaPeloTextoDesejado(listaElementosMobile, cotacaoCDB.BotaoUmRealInsercaoRapida.TextoEsperadoAndroid);
            appiumServiceNew.ClicaNoElementoMobile(cotacaoCDB.BotaoContinuar);

            // ACHO QUE POSSO APAGAR PORQUE NÃO PRECISA DE SCROLL   
            // appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoImpostoRenda);
            // appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoDataSolicitacao);
            // appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(confirmacaoCDB.TextoImpostoRenda, confirmacaoCDB.TextoDataSolicitacao);

            appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.BotaoVoltar);
            appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoTituloCDB);
            appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.Paginacao);
            appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoTituloConfirmacao);

            listaElementosMobile = appiumServiceNew.BuscaVariosElementoMobile(confirmacaoCDB.TextoValorASerAplicado);
            confirmacaoCDB.TextoValorASerAplicado = appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(listaElementosMobile, confirmacaoCDB.TextoValorASerAplicado.TextoEsperadoAndroid);

            listaElementosMobile = appiumServiceNew.BuscaVariosElementoMobile(confirmacaoCDB.TextoValorMonetario);
            confirmacaoCDB.TextoValorMonetario = appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(listaElementosMobile, confirmacaoCDB.TextoValorMonetario.TextoEsperadoAndroid);

            listaElementosMobile = appiumServiceNew.BuscaVariosElementoMobile(confirmacaoCDB.TextoDataSolicitacao);
            confirmacaoCDB.TextoDataSolicitacao = appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(listaElementosMobile, confirmacaoCDB.TextoDataSolicitacao.TextoEsperadoAndroid);

            listaElementosMobile = appiumServiceNew.BuscaVariosElementoMobile(confirmacaoCDB.TextoDataSolicitacaoHoje);
            confirmacaoCDB.TextoDataSolicitacaoHoje = appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(listaElementosMobile, confirmacaoCDB.TextoDataSolicitacaoHoje.TextoEsperadoAndroid);

            listaElementosMobile = appiumServiceNew.BuscaVariosElementoMobile(confirmacaoCDB.TextoRendaFixaPosFixado);
            confirmacaoCDB.TextoRendaFixaPosFixado = appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(listaElementosMobile, confirmacaoCDB.TextoRendaFixaPosFixado.TextoEsperadoAndroid);

            listaElementosMobile = appiumServiceNew.BuscaVariosElementoMobile(confirmacaoCDB.TextoProdutoCDBDIItau);
            confirmacaoCDB.TextoProdutoCDBDIItau = appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(listaElementosMobile, confirmacaoCDB.TextoProdutoCDBDIItau.TextoEsperadoAndroid);

            listaElementosMobile = appiumServiceNew.BuscaVariosElementoMobile(confirmacaoCDB.TextoRentabilidade);
            confirmacaoCDB.TextoRentabilidade = appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(listaElementosMobile, confirmacaoCDB.TextoRentabilidade.TextoEsperadoAndroid);

            listaElementosMobile = appiumServiceNew.BuscaVariosElementoMobile(confirmacaoCDB.TextoValorPorcentagemRentabilidade);
            confirmacaoCDB.TextoValorPorcentagemRentabilidade = appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(listaElementosMobile, confirmacaoCDB.TextoValorPorcentagemRentabilidade.TextoEsperadoAndroid);

            listaElementosMobile = appiumServiceNew.BuscaVariosElementoMobile(confirmacaoCDB.TextoRisco);
            confirmacaoCDB.TextoRisco = appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(listaElementosMobile, confirmacaoCDB.TextoRisco.TextoEsperadoAndroid);

            listaElementosMobile = appiumServiceNew.BuscaVariosElementoMobile(confirmacaoCDB.TextoValorRisco);
            confirmacaoCDB.TextoValorRisco = appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(listaElementosMobile, confirmacaoCDB.TextoValorRisco.TextoEsperadoAndroid);

            //AQUI
            appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(confirmacaoCDB.TextoTituloConfirmacao, confirmacaoCDB.TextoRisco);

            listaElementosMobile = appiumServiceNew.BuscaVariosElementoMobile(confirmacaoCDB.TextoImpostoRenda);
            confirmacaoCDB.TextoImpostoRenda = appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(listaElementosMobile, confirmacaoCDB.TextoImpostoRenda.TextoEsperadoAndroid);

            listaElementosMobile = appiumServiceNew.BuscaVariosElementoMobile(confirmacaoCDB.Texto180Dias);
            confirmacaoCDB.Texto180Dias = appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(listaElementosMobile, confirmacaoCDB.Texto180Dias.TextoEsperadoAndroid);

            listaElementosMobile = appiumServiceNew.BuscaVariosElementoMobile(confirmacaoCDB.Texto225Porcento);
            confirmacaoCDB.Texto225Porcento = appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(listaElementosMobile, confirmacaoCDB.Texto225Porcento.TextoEsperadoAndroid);

            listaElementosMobile = appiumServiceNew.BuscaVariosElementoMobile(confirmacaoCDB.Texto181_360Dias);
            confirmacaoCDB.Texto181_360Dias = appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(listaElementosMobile, confirmacaoCDB.Texto181_360Dias.TextoEsperadoAndroid);

            listaElementosMobile = appiumServiceNew.BuscaVariosElementoMobile(confirmacaoCDB.Texto20Porcento);
            confirmacaoCDB.Texto20Porcento = appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(listaElementosMobile, confirmacaoCDB.Texto20Porcento.TextoEsperadoAndroid);

            listaElementosMobile = appiumServiceNew.BuscaVariosElementoMobile(confirmacaoCDB.Texto361_720Dias);
            confirmacaoCDB.Texto361_720Dias = appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(listaElementosMobile, confirmacaoCDB.Texto361_720Dias.TextoEsperadoAndroid);

            listaElementosMobile = appiumServiceNew.BuscaVariosElementoMobile(confirmacaoCDB.Texto175Porcento);
            confirmacaoCDB.Texto175Porcento = appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(listaElementosMobile, confirmacaoCDB.Texto175Porcento.TextoEsperadoAndroid);

            listaElementosMobile = appiumServiceNew.BuscaVariosElementoMobile(confirmacaoCDB.TextoAcima720Dias);
            confirmacaoCDB.TextoAcima720Dias = appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(listaElementosMobile, confirmacaoCDB.TextoAcima720Dias.TextoEsperadoAndroid);

            listaElementosMobile = appiumServiceNew.BuscaVariosElementoMobile(confirmacaoCDB.Texto15Porcento);
            confirmacaoCDB.Texto15Porcento = appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(listaElementosMobile, confirmacaoCDB.Texto15Porcento.TextoEsperadoAndroid);





            appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(confirmacaoCDB.TextoRisco, confirmacaoCDB.TextoAcima720Dias);
            // appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoResgate);
            // appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoValorResgate);
            // appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.CampoIdentificacaoComprovante);
            // listaElementosMobile = appiumServiceNew.BuscaVariosElementoMobile(confirmacaoCDB.TextoInformativoResgate, confirmacaoCDB.TextoInformativoResgate.TextoEsperadoAndroid);
            // listaElementosMobile = appiumServiceNew.BuscaVariosElementoMobile(confirmacaoCDB.TextoInformativoIof, confirmacaoCDB.TextoInformativoIof.TextoEsperadoAndroid);
            // listaElementosMobile = appiumServiceNew.BuscaVariosElementoMobile(confirmacaoCDB.TextoInformativoComprovante, confirmacaoCDB.TextoInformativoComprovante.TextoEsperadoAndroid);
            // listaElementosMobile = appiumServiceNew.BuscaVariosElementoMobile(confirmacaoCDB.TextoInformativoFgc, confirmacaoCDB.TextoInformativoFgc.TextoEsperadoAndroid);
            // listaElementosMobile = appiumServiceNew.BuscaVariosElementoMobile(confirmacaoCDB.TextoInformativoLgpd, confirmacaoCDB.TextoInformativoLgpd.TextoEsperadoAndroid);
            // appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.BotaoPoliticaPrivacidade);
            // appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.BotaoConfirmar);
        }

        // public void VerificaBotaoVoltarTelaConfimacaoHelper(AppiumServiceNew appiumServiceNew)
        // {
        //     appiumServiceNew.ClicaIdETexto(cotacaoCDB.BotaoUmRealInsercaoRapida, cotacaoCDB.BotaoUmRealInsercaoRapida.TextoEsperadoAndroid);
        //     appiumServiceNew.ClicaNoElementoMobile(cotacaoCDB.BotaoContinuar);
        //     appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoValorMonetario);
        //     appiumServiceNew.ClicaNoElementoMobile(confirmacaoCDB.BotaoVoltar);
        //     appiumServiceNew.BuscaElementoMobile(cotacaoCDB.PaginacaoAndroid);
        //     appiumServiceNew.BuscaElementoMobile(cotacaoCDB.TextoDisponivelParaAplicacao);
        //     appiumServiceNew.BuscaElementoMobile(cotacaoCDB.TextoValorAplicacao);
        // }

        // public void VerificaCampoIdentificacaoComprovanteHelper(AppiumServiceNew appiumServiceNew, string textoIdentificacao)
        // {
        //     appiumServiceNew.ClicaIdETexto(cotacaoCDB.BotaoUmRealInsercaoRapida, cotacaoCDB.BotaoUmRealInsercaoRapida.TextoEsperadoAndroid);
        //     appiumServiceNew.ClicaNoElementoMobile(cotacaoCDB.BotaoContinuar);
        //     appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoImpostoRenda);
        //     appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoDataSolicitacao);
        //     appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(confirmacaoCDB.TextoImpostoRenda, confirmacaoCDB.TextoDataSolicitacao);
        //     appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoTituloConfirmacao);
        //     appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoRisco);
        //     appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(confirmacaoCDB.TextoTituloConfirmacao, confirmacaoCDB.TextoRisco);
        //     appiumServiceNew.BuscaPorIdETexto(confirmacaoCDB.TextoAcima720Dias, confirmacaoCDB.TextoAcima720Dias.TextoEsperadoAndroid);
        //     appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(confirmacaoCDB.TextoRisco, confirmacaoCDB.TextoAcima720Dias);

        //     appiumServiceNew.EscreveTecladoNativo(confirmacaoCDB.CampoIdentificacaoComprovante, textoIdentificacao);
        //     appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.CampoIdentificacaoComprovante);
        // }

        // public void VerificaBotaoPoliticaPrivacidadeHelper(AppiumServiceNew appiumServiceNew)
        // {
        //     appiumServiceNew.ClicaIdETexto(cotacaoCDB.BotaoUmRealInsercaoRapida, cotacaoCDB.BotaoUmRealInsercaoRapida.TextoEsperadoAndroid);
        //     appiumServiceNew.ClicaNoElementoMobile(cotacaoCDB.BotaoContinuar);
        //     appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoImpostoRenda);
        //     appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoDataSolicitacao);
        //     appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(confirmacaoCDB.TextoImpostoRenda, confirmacaoCDB.TextoDataSolicitacao);
        //     appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoTituloConfirmacao);
        //     appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoRisco);
        //     appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(confirmacaoCDB.TextoTituloConfirmacao, confirmacaoCDB.TextoRisco);
        //     appiumServiceNew.BuscaPorIdETexto(confirmacaoCDB.TextoAcima720Dias, confirmacaoCDB.TextoAcima720Dias.TextoEsperadoAndroid);
        //     appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(confirmacaoCDB.TextoRisco, confirmacaoCDB.TextoAcima720Dias);

        //     appiumServiceNew.ClicaNoElementoMobile(confirmacaoCDB.BotaoPoliticaPrivacidade);
        //     appiumServiceNew.BuscaElementoMobile(politicaPrivacidade.BotaoVoltar);
        //     appiumServiceNew.BuscaElementoMobile(politicaPrivacidade.TextoPoliticaPrivacidade);
        // }

        // public void VerificaBotaoVoltarPoliticaPrivacidadeHelper(AppiumServiceNew appiumServiceNew)
        // {
        //     appiumServiceNew.ClicaIdETexto(cotacaoCDB.BotaoUmRealInsercaoRapida, cotacaoCDB.BotaoUmRealInsercaoRapida.TextoEsperadoAndroid);
        //     appiumServiceNew.ClicaNoElementoMobile(cotacaoCDB.BotaoContinuar);
        //     appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoImpostoRenda);
        //     appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoDataSolicitacao);
        //     appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(confirmacaoCDB.TextoImpostoRenda, confirmacaoCDB.TextoDataSolicitacao);
        //     appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoTituloConfirmacao);
        //     appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoRisco);
        //     appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(confirmacaoCDB.TextoTituloConfirmacao, confirmacaoCDB.TextoRisco);
        //     appiumServiceNew.BuscaPorIdETexto(confirmacaoCDB.TextoAcima720Dias, confirmacaoCDB.TextoAcima720Dias.TextoEsperadoAndroid);
        //     appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(confirmacaoCDB.TextoRisco, confirmacaoCDB.TextoAcima720Dias);
        //     appiumServiceNew.ClicaNoElementoMobile(confirmacaoCDB.BotaoPoliticaPrivacidade);
        //     appiumServiceNew.ClicaNoElementoMobile(politicaPrivacidade.BotaoVoltar);

        //     appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.BotaoPoliticaPrivacidade);
        //     appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.BotaoConfirmar);
        // }

        // public void VerificaConteudoPoliticaPrivacidadeHelper(AppiumServiceNew appiumServiceNew)
        // {
        //     appiumServiceNew.ClicaIdETexto(cotacaoCDB.BotaoUmRealInsercaoRapida, cotacaoCDB.BotaoUmRealInsercaoRapida.TextoEsperadoAndroid);
        //     appiumServiceNew.ClicaNoElementoMobile(cotacaoCDB.BotaoContinuar);
        //     appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoImpostoRenda);
        //     appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoDataSolicitacao);
        //     appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(confirmacaoCDB.TextoImpostoRenda, confirmacaoCDB.TextoDataSolicitacao);
        //     appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoTituloConfirmacao);
        //     appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoRisco);
        //     appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(confirmacaoCDB.TextoTituloConfirmacao, confirmacaoCDB.TextoRisco);
        //     appiumServiceNew.BuscaPorIdETexto(confirmacaoCDB.TextoAcima720Dias, confirmacaoCDB.TextoAcima720Dias.TextoEsperadoAndroid);
        //     appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(confirmacaoCDB.TextoRisco, confirmacaoCDB.TextoAcima720Dias);
        //     appiumServiceNew.ClicaNoElementoMobile(confirmacaoCDB.BotaoPoliticaPrivacidade);

        //     appiumServiceNew.BuscaElementoMobile(politicaPrivacidade.BotaoVoltar);
        //     appiumServiceNew.BuscaElementoMobile(politicaPrivacidade.TextoPoliticaPrivacidade);
        //     appiumServiceNew.BuscaElementoMobile(politicaPrivacidade.TextoTratamentoDadosPessoais);
        //     appiumServiceNew.BuscaPorIdETexto(politicaPrivacidade.TextoInformativoItau, politicaPrivacidade.TextoInformativoItau.TextoEsperadoAndroid);
        //     appiumServiceNew.BuscaPorIdETexto(politicaPrivacidade.TextoInformativoItemResumo, politicaPrivacidade.TextoInformativoItemResumo.TextoEsperadoAndroid);
        //     appiumServiceNew.BuscaPorIdETexto(politicaPrivacidade.BotaoDadosColetados, politicaPrivacidade.BotaoDadosColetados.TextoEsperadoAndroid);
        //     appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(politicaPrivacidade.TextoTratamentoDadosPessoais, politicaPrivacidade.BotaoDadosColetados);
        //     appiumServiceNew.ClicaIdETexto(politicaPrivacidade.BotaoDadosColetados, politicaPrivacidade.BotaoDadosColetados.TextoEsperadoAndroid);
        //     appiumServiceNew.BuscaPorIdETexto(politicaPrivacidade.TextoInformativoDadosColetados, politicaPrivacidade.TextoInformativoDadosColetados.TextoEsperadoAndroid);
        //     appiumServiceNew.ClicaIdETexto(politicaPrivacidade.BotaoDadosColetados, politicaPrivacidade.BotaoDadosColetados.TextoEsperadoAndroid);
        //     appiumServiceNew.ClicaIdETexto(politicaPrivacidade.BotaoFinalidadeUsoDados, politicaPrivacidade.BotaoFinalidadeUsoDados.TextoEsperadoAndroid);
        //     appiumServiceNew.BuscaPorIdETexto(politicaPrivacidade.TextoFinalidadeUsoDados, politicaPrivacidade.TextoFinalidadeUsoDados.TextoEsperadoAndroid);
        //     appiumServiceNew.ClicaIdETexto(politicaPrivacidade.BotaoFinalidadeUsoDados, politicaPrivacidade.BotaoFinalidadeUsoDados.TextoEsperadoAndroid);
        //     appiumServiceNew.ClicaIdETexto(politicaPrivacidade.BotaoDadosBiometricos, politicaPrivacidade.BotaoDadosBiometricos.TextoEsperadoAndroid);
        //     appiumServiceNew.BuscaPorIdETexto(politicaPrivacidade.TextoDadosBiometricos, politicaPrivacidade.TextoDadosBiometricos.TextoEsperadoAndroid);
        //     appiumServiceNew.ClicaIdETexto(politicaPrivacidade.BotaoDadosBiometricos, politicaPrivacidade.BotaoDadosBiometricos.TextoEsperadoAndroid);
        //     appiumServiceNew.ClicaIdETexto(politicaPrivacidade.BotaoCompartilhamentoDados, politicaPrivacidade.BotaoCompartilhamentoDados.TextoEsperadoAndroid);
        //     appiumServiceNew.BuscaPorIdETexto(politicaPrivacidade.TextoInformativoCompartilhamentoDados, politicaPrivacidade.TextoInformativoCompartilhamentoDados.TextoEsperadoAndroid);
        //     appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(politicaPrivacidade.TextoInformativoItemResumo, politicaPrivacidade.TextoInformativoCompartilhamentoDados);
        //     appiumServiceNew.ClicaIdETexto(politicaPrivacidade.BotaoCompartilhamentoDados, politicaPrivacidade.BotaoCompartilhamentoDados.TextoEsperadoAndroid);
        // }
    }
}