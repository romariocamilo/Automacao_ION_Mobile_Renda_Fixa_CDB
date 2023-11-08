using Automacao_ION_Mobile_Renda_Fixa_CDB.Pages;
using Core_Automacao.Plataformas.Mobile;


namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Helpers.Android.Contratacao.TelaConfirmacao
{
    public class ConfirmacaoCdbHelper
    {
        public readonly CotacaoCDB cotacaoCDB;
        public readonly ConfirmacaoCDB confirmacaoCDB;
        public readonly PoliticaPrivacidade politicaPrivacidade;

        public ConfirmacaoCdbHelper()
        {
            cotacaoCDB = new CotacaoCDB();
            confirmacaoCDB = new ConfirmacaoCDB();
            politicaPrivacidade = new PoliticaPrivacidade();
        }

        public void SnapShotTelaConfirmaçãoHelper(AppiumServiceNew appiumServiceNew)
        {
            appiumServiceNew.ClicaNoElementoMobileDaListaPeloTextoDesejado(cotacaoCDB.BotaoUmRealInsercaoRapida, cotacaoCDB.BotaoUmRealInsercaoRapida.TextoEsperadoAndroid);
            appiumServiceNew.ClicaNoElementoMobile(cotacaoCDB.BotaoContinuar);

            // ACHO QUE POSSO APAGAR PORQUE NÃO PRECISA DE SCROLL   
            // appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoImpostoRenda);
            // appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoDataSolicitacao);
            // appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(confirmacaoCDB.TextoImpostoRenda, confirmacaoCDB.TextoDataSolicitacao);

            appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.BotaoVoltar);
            appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoTituloCDB);
            appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.Paginacao);
            appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoTituloConfirmacao);

            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(confirmacaoCDB.TextoValorASerAplicado, confirmacaoCDB.TextoValorASerAplicado.TextoEsperadoAndroid);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(confirmacaoCDB.TextoValorMonetario, confirmacaoCDB.TextoValorMonetario.TextoEsperadoAndroid);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(confirmacaoCDB.TextoDataSolicitacao, confirmacaoCDB.TextoDataSolicitacao.TextoEsperadoAndroid);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(confirmacaoCDB.TextoDataSolicitacaoHoje, confirmacaoCDB.TextoDataSolicitacaoHoje.TextoEsperadoAndroid);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(confirmacaoCDB.TextoRendaFixaPosFixado, confirmacaoCDB.TextoRendaFixaPosFixado.TextoEsperadoAndroid);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(confirmacaoCDB.TextoProdutoCDBDIItau, confirmacaoCDB.TextoProdutoCDBDIItau.TextoEsperadoAndroid);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(confirmacaoCDB.TextoRentabilidade, confirmacaoCDB.TextoRentabilidade.TextoEsperadoAndroid);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(confirmacaoCDB.TextoValorPorcentagemRentabilidade, confirmacaoCDB.TextoValorPorcentagemRentabilidade.TextoEsperadoAndroid);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(confirmacaoCDB.TextoRisco, confirmacaoCDB.TextoRisco.TextoEsperadoAndroid);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(confirmacaoCDB.TextoValorRisco, confirmacaoCDB.TextoValorRisco.TextoEsperadoAndroid);
            appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(confirmacaoCDB.TextoTituloConfirmacao, confirmacaoCDB.TextoRisco);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(confirmacaoCDB.TextoImpostoRenda, confirmacaoCDB.TextoImpostoRenda.TextoEsperadoAndroid);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(confirmacaoCDB.Texto180Dias, confirmacaoCDB.Texto180Dias.TextoEsperadoAndroid);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(confirmacaoCDB.Texto225Porcento, confirmacaoCDB.Texto225Porcento.TextoEsperadoAndroid);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(confirmacaoCDB.Texto181_360Dias, confirmacaoCDB.Texto181_360Dias.TextoEsperadoAndroid);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(confirmacaoCDB.Texto20Porcento, confirmacaoCDB.Texto20Porcento.TextoEsperadoAndroid);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(confirmacaoCDB.Texto361_720Dias, confirmacaoCDB.Texto361_720Dias.TextoEsperadoAndroid);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(confirmacaoCDB.Texto175Porcento, confirmacaoCDB.Texto175Porcento.TextoEsperadoAndroid);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(confirmacaoCDB.TextoAcima720Dias, confirmacaoCDB.TextoAcima720Dias.TextoEsperadoAndroid);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(confirmacaoCDB.Texto15Porcento, confirmacaoCDB.Texto15Porcento.TextoEsperadoAndroid);
            appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(confirmacaoCDB.TextoRisco, confirmacaoCDB.TextoAcima720Dias);
            //appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(confirmacaoCDB.TextoResgate, confirmacaoCDB.TextoResgate.TextoEsperadoAndroid);
            //appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(confirmacaoCDB.TextoValorResgate, confirmacaoCDB.TextoValorResgate.TextoEsperadoAndroid);
            appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.CampoIdentificacaoComprovante);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(confirmacaoCDB.TextoInformativoResgate, confirmacaoCDB.TextoInformativoResgate.TextoEsperadoAndroid);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(confirmacaoCDB.TextoInformativoIof, confirmacaoCDB.TextoInformativoIof.TextoEsperadoAndroid);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(confirmacaoCDB.TextoInformativoComprovante, confirmacaoCDB.TextoInformativoComprovante.TextoEsperadoAndroid);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(confirmacaoCDB.TextoInformativoFgc, confirmacaoCDB.TextoInformativoFgc.TextoEsperadoAndroid);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(confirmacaoCDB.TextoInformativoLgpd, confirmacaoCDB.TextoInformativoLgpd.TextoEsperadoAndroid);
            appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.BotaoPoliticaPrivacidade);
            appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.BotaoConfirmar);
        }

        public void VerificaBotaoVoltarTelaConfimacaoHelper(AppiumServiceNew appiumServiceNew)
        {
            appiumServiceNew.ClicaNoElementoMobileDaListaPeloTextoDesejado(cotacaoCDB.BotaoUmRealInsercaoRapida, cotacaoCDB.BotaoUmRealInsercaoRapida.TextoEsperadoAndroid);
            appiumServiceNew.ClicaNoElementoMobile(cotacaoCDB.BotaoContinuar);
            appiumServiceNew.ClicaNoElementoMobile(confirmacaoCDB.BotaoVoltar);

            appiumServiceNew.BuscaElementoMobile(cotacaoCDB.TextoPaginacao);
        }

        public void VerificaCampoIdentificacaoComprovanteHelper(AppiumServiceNew appiumServiceNew, string textoIdentificacao)
        {
            appiumServiceNew.ClicaNoElementoMobileDaListaPeloTextoDesejado(cotacaoCDB.BotaoUmRealInsercaoRapida, cotacaoCDB.BotaoUmRealInsercaoRapida.TextoEsperadoAndroid);
            appiumServiceNew.ClicaNoElementoMobile(cotacaoCDB.BotaoContinuar);
            appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoImpostoRenda);
            appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoDataSolicitacao);
            appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(confirmacaoCDB.TextoImpostoRenda, confirmacaoCDB.TextoDataSolicitacao);
            appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoTituloConfirmacao);
            appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoRisco);
            appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(confirmacaoCDB.TextoTituloConfirmacao, confirmacaoCDB.TextoRisco);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(confirmacaoCDB.TextoAcima720Dias, confirmacaoCDB.TextoAcima720Dias.TextoEsperadoAndroid);
            appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(confirmacaoCDB.TextoRisco, confirmacaoCDB.TextoAcima720Dias);

            appiumServiceNew.EscreveTecladoNativo(confirmacaoCDB.CampoIdentificacaoComprovante, textoIdentificacao);
            appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.CampoIdentificacaoComprovante);
        }

        public void VerificaBotaoPoliticaPrivacidadeHelper(AppiumServiceNew appiumServiceNew)
        {
            appiumServiceNew.ClicaNoElementoMobileDaListaPeloTextoDesejado(cotacaoCDB.BotaoUmRealInsercaoRapida, cotacaoCDB.BotaoUmRealInsercaoRapida.TextoEsperadoAndroid);
            appiumServiceNew.ClicaNoElementoMobile(cotacaoCDB.BotaoContinuar);
            appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoImpostoRenda);
            appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoDataSolicitacao);
            appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(confirmacaoCDB.TextoImpostoRenda, confirmacaoCDB.TextoDataSolicitacao);
            appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoTituloConfirmacao);
            appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoRisco);
            appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(confirmacaoCDB.TextoTituloConfirmacao, confirmacaoCDB.TextoRisco);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(confirmacaoCDB.TextoAcima720Dias, confirmacaoCDB.TextoAcima720Dias.TextoEsperadoAndroid);
            appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(confirmacaoCDB.TextoRisco, confirmacaoCDB.TextoAcima720Dias);

            appiumServiceNew.ClicaNoElementoMobile(confirmacaoCDB.BotaoPoliticaPrivacidade);
            appiumServiceNew.BuscaElementoMobile(politicaPrivacidade.TextoPoliticaPrivacidade);
        }

        public void VerificaBotaoVoltarPoliticaPrivacidadeHelper(AppiumServiceNew appiumServiceNew)
        {
            appiumServiceNew.ClicaNoElementoMobileDaListaPeloTextoDesejado(cotacaoCDB.BotaoUmRealInsercaoRapida, cotacaoCDB.BotaoUmRealInsercaoRapida.TextoEsperadoAndroid);
            appiumServiceNew.ClicaNoElementoMobile(cotacaoCDB.BotaoContinuar);
            appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoImpostoRenda);
            appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoDataSolicitacao);
            appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(confirmacaoCDB.TextoImpostoRenda, confirmacaoCDB.TextoDataSolicitacao);
            appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoTituloConfirmacao);
            appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoRisco);
            appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(confirmacaoCDB.TextoTituloConfirmacao, confirmacaoCDB.TextoRisco);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(confirmacaoCDB.TextoAcima720Dias, confirmacaoCDB.TextoAcima720Dias.TextoEsperadoAndroid);
            appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(confirmacaoCDB.TextoRisco, confirmacaoCDB.TextoAcima720Dias);
            appiumServiceNew.ClicaNoElementoMobile(confirmacaoCDB.BotaoPoliticaPrivacidade);
            appiumServiceNew.ClicaNoElementoMobile(politicaPrivacidade.BotaoVoltar);

            appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.BotaoPoliticaPrivacidade);
            appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.BotaoConfirmar);
        }

        public void VerificaConteudoPoliticaPrivacidadeHelper(AppiumServiceNew appiumServiceNew)
        {
            appiumServiceNew.ClicaNoElementoMobileDaListaPeloTextoDesejado(cotacaoCDB.BotaoUmRealInsercaoRapida, cotacaoCDB.BotaoUmRealInsercaoRapida.TextoEsperadoAndroid);
            appiumServiceNew.ClicaNoElementoMobile(cotacaoCDB.BotaoContinuar);
            appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoImpostoRenda);
            appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoDataSolicitacao);
            appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(confirmacaoCDB.TextoImpostoRenda, confirmacaoCDB.TextoDataSolicitacao);
            appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoTituloConfirmacao);
            appiumServiceNew.BuscaElementoMobile(confirmacaoCDB.TextoRisco);
            appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(confirmacaoCDB.TextoTituloConfirmacao, confirmacaoCDB.TextoRisco);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(confirmacaoCDB.TextoAcima720Dias, confirmacaoCDB.TextoAcima720Dias.TextoEsperadoAndroid);
            appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(confirmacaoCDB.TextoRisco, confirmacaoCDB.TextoAcima720Dias);
            appiumServiceNew.ClicaNoElementoMobile(confirmacaoCDB.BotaoPoliticaPrivacidade);

            appiumServiceNew.BuscaElementoMobile(politicaPrivacidade.BotaoVoltar);
            appiumServiceNew.BuscaElementoMobile(politicaPrivacidade.TextoPoliticaPrivacidade);
            appiumServiceNew.BuscaElementoMobile(politicaPrivacidade.TextoTratamentoDadosPessoais);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(politicaPrivacidade.TextoInformativoItau, politicaPrivacidade.TextoInformativoItau.TextoEsperadoAndroid);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(politicaPrivacidade.TextoInformativoItemResumo, politicaPrivacidade.TextoInformativoItemResumo.TextoEsperadoAndroid);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(politicaPrivacidade.BotaoDadosColetados, politicaPrivacidade.BotaoDadosColetados.TextoEsperadoAndroid);
            appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(politicaPrivacidade.TextoTratamentoDadosPessoais, politicaPrivacidade.BotaoDadosColetados);
            appiumServiceNew.ClicaNoElementoMobileDaListaPeloTextoDesejado(politicaPrivacidade.BotaoDadosColetados, politicaPrivacidade.BotaoDadosColetados.TextoEsperadoAndroid);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(politicaPrivacidade.TextoInformativoDadosColetados, politicaPrivacidade.TextoInformativoDadosColetados.TextoEsperadoAndroid);
            appiumServiceNew.ClicaNoElementoMobileDaListaPeloTextoDesejado(politicaPrivacidade.BotaoDadosColetados, politicaPrivacidade.BotaoDadosColetados.TextoEsperadoAndroid);
            appiumServiceNew.ClicaNoElementoMobileDaListaPeloTextoDesejado(politicaPrivacidade.BotaoFinalidadeUsoDados, politicaPrivacidade.BotaoFinalidadeUsoDados.TextoEsperadoAndroid);
            //appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(politicaPrivacidade.TextoFinalidadeUsoDados, politicaPrivacidade.TextoFinalidadeUsoDados.TextoEsperadoAndroid);
            appiumServiceNew.ClicaNoElementoMobileDaListaPeloTextoDesejado(politicaPrivacidade.BotaoFinalidadeUsoDados, politicaPrivacidade.BotaoFinalidadeUsoDados.TextoEsperadoAndroid);
            appiumServiceNew.ClicaNoElementoMobileDaListaPeloTextoDesejado(politicaPrivacidade.BotaoDadosBiometricos, politicaPrivacidade.BotaoDadosBiometricos.TextoEsperadoAndroid);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(politicaPrivacidade.TextoDadosBiometricos, politicaPrivacidade.TextoDadosBiometricos.TextoEsperadoAndroid);
            appiumServiceNew.ClicaNoElementoMobileDaListaPeloTextoDesejado(politicaPrivacidade.BotaoDadosBiometricos, politicaPrivacidade.BotaoDadosBiometricos.TextoEsperadoAndroid);
            appiumServiceNew.ClicaNoElementoMobileDaListaPeloTextoDesejado(politicaPrivacidade.BotaoCompartilhamentoDados, politicaPrivacidade.BotaoCompartilhamentoDados.TextoEsperadoAndroid);
            appiumServiceNew.BuscaElementoMobileDaListaPeloTextoDesejado(politicaPrivacidade.TextoInformativoCompartilhamentoDados, politicaPrivacidade.TextoInformativoCompartilhamentoDados.TextoEsperadoAndroid);
            appiumServiceNew.ScrollDeElementoOrigemParaElementoDestino(politicaPrivacidade.TextoInformativoItemResumo, politicaPrivacidade.TextoInformativoCompartilhamentoDados);
            appiumServiceNew.ClicaNoElementoMobileDaListaPeloTextoDesejado(politicaPrivacidade.BotaoCompartilhamentoDados, politicaPrivacidade.BotaoCompartilhamentoDados.TextoEsperadoAndroid);
        }
    }
}