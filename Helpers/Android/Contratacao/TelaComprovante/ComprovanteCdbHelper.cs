// using Automacao_ION_Mobile_Renda_Fixa_CDB.Pages;
// using Core_Automacao.Plataformas.Mobile;

// namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Helpers.Android.Contratacao.TelaComprovante
// {
//     public class ComprovanteCdbHelper
//     {
//         private CotacaoCDB _cotacaoCDB;
//         private ConfirmacaoCDB _confirmacaoCDB;
//         private Token _token;
//         public Sucesso sucesso;
//         public Comprovante comprovante;

//         public ComprovanteCdbHelper()
//         {
//             _cotacaoCDB = new CotacaoCDB();
//             _confirmacaoCDB = new ConfirmacaoCDB();
//             _token = new Token();
//             sucesso = new Sucesso();
//             comprovante = new Comprovante();
//         }

//         public void SnapShotTelaComprovanteHelper(AppiumService appiumService)
//         {
//             appiumService.ClicaIdETexto(_cotacaoCDB.BotaoUmRealInsercaoRapida, _cotacaoCDB.BotaoUmRealInsercaoRapida.TextoEsperado);
//             appiumService.ClicaPorId(_cotacaoCDB.BotaoContinuar);
//             appiumService.BuscaPorId(_confirmacaoCDB.TextoImpostoRenda);
//             appiumService.BuscaPorId(_confirmacaoCDB.TextoDataSolicitacao);
//             appiumService.ScrollDeElementoOrigemParaElementoDestino(_confirmacaoCDB.TextoImpostoRenda, _confirmacaoCDB.TextoDataSolicitacao);
//             appiumService.BuscaPorId(_confirmacaoCDB.TextoTituloConfirmacao);
//             appiumService.BuscaPorId(_confirmacaoCDB.TextoRisco);
//             appiumService.ScrollDeElementoOrigemParaElementoDestino(_confirmacaoCDB.TextoTituloConfirmacao, _confirmacaoCDB.TextoRisco);
//             appiumService.BuscaPorIdETexto(_confirmacaoCDB.TextoAcima720Dias, _confirmacaoCDB.TextoAcima720Dias.TextoEsperado);
//             appiumService.ScrollDeElementoOrigemParaElementoDestino(_confirmacaoCDB.TextoRisco, _confirmacaoCDB.TextoAcima720Dias);
//             appiumService.EscrevePorId(_confirmacaoCDB.CampoIdentificacaoComprovante, "comprovante");
//             appiumService.ClicaPorId(_confirmacaoCDB.BotaoConfirmar);
//             appiumService.ClicaPorIdAcessibilidade(_token.BotaoFechar);
//             appiumService.ClicaPorIdCasoApareca(sucesso.BotaoFecharFeedBack, 5);
//             appiumService.ClicaPorId(sucesso.BotaoVerComprovante);

//             appiumService.BuscaPorId(comprovante.IconeIonItau);
//             appiumService.BuscaPorIdAcessibilidade(comprovante.BotaoFechar);
//             appiumService.BuscaPorId(comprovante.TextoComprovanteAplicacao);
//             appiumService.BuscaPorId(comprovante.TextoSolicitadoData);
//             appiumService.BuscaPorIdETexto(comprovante.TextoValorASerAplicado, comprovante.TextoValorASerAplicado.TextoEsperado);
//             appiumService.BuscaPorIdETexto(comprovante.TextoValorAplicacao, comprovante.TextoValorAplicacao.TextoEsperado);
//             appiumService.BuscaPorIdETexto(comprovante.TextoDataDaSolicitacao, comprovante.TextoDataDaSolicitacao.TextoEsperado);
//             appiumService.BuscaPorIdETexto(comprovante.TextoDataAplicacao, comprovante.TextoDataAplicacao.TextoEsperado);
//             appiumService.BuscaPorIdETexto(comprovante.TextoRendaFixaPosFixado, comprovante.TextoRendaFixaPosFixado.TextoEsperado);
//             appiumService.BuscaPorIdEParteDoTexto(comprovante.TextoNomeProdutoCDB, comprovante.TextoNomeProdutoCDB.TextoEsperado);
//             appiumService.BuscaPorId(comprovante.TextoRentabilidade);
//             appiumService.BuscaPorId(comprovante.TextoValorRentabilidade);
//             appiumService.BuscaPorId(comprovante.TextoRisco);
//             appiumService.BuscaPorId(comprovante.TextoValorRisco);
//             appiumService.ScrollDeElementoOrigemParaElementoDestino(comprovante.TextoComprovanteAplicacao, comprovante.TextoRisco);
//             appiumService.BuscaPorIdETexto(comprovante.TextoDataVencimento, comprovante.TextoDataVencimento.TextoEsperado);
//             appiumService.BuscaPorIdEParteDoTexto(comprovante.TextoValorDataVencimento, comprovante.TextoValorDataVencimento.TextoEsperado);
//             appiumService.BuscaPorIdETexto(comprovante.TextoResgate, comprovante.TextoResgate.TextoEsperado);
//             appiumService.BuscaPorIdETexto(comprovante.TextoValorResgate, comprovante.TextoValorResgate.TextoEsperado);
//             appiumService.BuscaPorId(comprovante.CampoComprovante);
//             appiumService.BuscaPorIdETexto(comprovante.TextoMomentoResgate, comprovante.TextoMomentoResgate.TextoEsperado);
//             appiumService.BuscaPorIdETexto(comprovante.TextoIncidenciaIOF, comprovante.TextoIncidenciaIOF.TextoEsperado);
//             appiumService.BuscaPorIdETexto(comprovante.TextoExibicaoComprovante, comprovante.TextoExibicaoComprovante.TextoEsperado);
//             appiumService.BuscaPorIdETexto(comprovante.TextoFGC, comprovante.TextoFGC.TextoEsperado);
//             appiumService.BuscaPorId(comprovante.BotaoEnviaComprovante);
//         }

//         public void VerificaBotaoEnviaComprovanteHelper(AppiumService appiumService)
//         {
//             appiumService.ClicaIdETexto(_cotacaoCDB.BotaoUmRealInsercaoRapida, _cotacaoCDB.BotaoUmRealInsercaoRapida.TextoEsperado);
//             appiumService.ClicaPorId(_cotacaoCDB.BotaoContinuar);
//             appiumService.BuscaPorId(_confirmacaoCDB.TextoImpostoRenda);
//             appiumService.BuscaPorId(_confirmacaoCDB.TextoDataSolicitacao);
//             appiumService.ScrollDeElementoOrigemParaElementoDestino(_confirmacaoCDB.TextoImpostoRenda, _confirmacaoCDB.TextoDataSolicitacao);
//             appiumService.BuscaPorId(_confirmacaoCDB.TextoTituloConfirmacao);
//             appiumService.BuscaPorId(_confirmacaoCDB.TextoRisco);
//             appiumService.ScrollDeElementoOrigemParaElementoDestino(_confirmacaoCDB.TextoTituloConfirmacao, _confirmacaoCDB.TextoRisco);
//             appiumService.BuscaPorIdETexto(_confirmacaoCDB.TextoAcima720Dias, _confirmacaoCDB.TextoAcima720Dias.TextoEsperado);
//             appiumService.ScrollDeElementoOrigemParaElementoDestino(_confirmacaoCDB.TextoRisco, _confirmacaoCDB.TextoAcima720Dias);
//             appiumService.EscrevePorId(_confirmacaoCDB.CampoIdentificacaoComprovante, "comprovante");
//             appiumService.ClicaPorId(_confirmacaoCDB.BotaoConfirmar);
//             appiumService.ClicaPorIdAcessibilidade(_token.BotaoFechar);
//             appiumService.ClicaPorIdCasoApareca(sucesso.BotaoFecharFeedBack, 5);
//             appiumService.ClicaPorId(sucesso.BotaoVerComprovante);
//             appiumService.BuscaPorId(comprovante.TextoComprovanteAplicacao);
//             appiumService.BuscaPorId(comprovante.TextoRisco);
//             appiumService.ScrollDeElementoOrigemParaElementoDestino(comprovante.TextoComprovanteAplicacao, comprovante.TextoRisco);
//             appiumService.ClicaPorId(comprovante.BotaoEnviaComprovante);

//             appiumService.BuscaPorId(comprovante.TextoNativoEnviaComprovante);
//         }

//         public string VerificaTextoComprovanteHelper(AppiumService appiumService)
//         {
//             string textoInseridoComprovante = "comprovante";

//             appiumService.ClicaIdETexto(_cotacaoCDB.BotaoUmRealInsercaoRapida, _cotacaoCDB.BotaoUmRealInsercaoRapida.TextoEsperado);
//             appiumService.ClicaPorId(_cotacaoCDB.BotaoContinuar);
//             appiumService.BuscaPorId(_confirmacaoCDB.TextoImpostoRenda);
//             appiumService.BuscaPorId(_confirmacaoCDB.TextoDataSolicitacao);
//             appiumService.ScrollDeElementoOrigemParaElementoDestino(_confirmacaoCDB.TextoImpostoRenda, _confirmacaoCDB.TextoDataSolicitacao);
//             appiumService.BuscaPorId(_confirmacaoCDB.TextoTituloConfirmacao);
//             appiumService.BuscaPorId(_confirmacaoCDB.TextoRisco);
//             appiumService.ScrollDeElementoOrigemParaElementoDestino(_confirmacaoCDB.TextoTituloConfirmacao, _confirmacaoCDB.TextoRisco);
//             appiumService.BuscaPorIdETexto(_confirmacaoCDB.TextoAcima720Dias, _confirmacaoCDB.TextoAcima720Dias.TextoEsperado);
//             appiumService.ScrollDeElementoOrigemParaElementoDestino(_confirmacaoCDB.TextoRisco, _confirmacaoCDB.TextoAcima720Dias);
//             appiumService.EscrevePorId(_confirmacaoCDB.CampoIdentificacaoComprovante, textoInseridoComprovante);
//             appiumService.ClicaPorId(_confirmacaoCDB.BotaoConfirmar);
//             appiumService.ClicaPorIdAcessibilidade(_token.BotaoFechar);
//             appiumService.ClicaPorIdCasoApareca(sucesso.BotaoFecharFeedBack, 5);
//             appiumService.ClicaPorId(sucesso.BotaoVerComprovante);
//             appiumService.BuscaPorId(comprovante.TextoComprovanteAplicacao);
//             appiumService.BuscaPorId(comprovante.TextoRisco);
//             appiumService.ScrollDeElementoOrigemParaElementoDestino(comprovante.TextoComprovanteAplicacao, comprovante.TextoRisco);

//             appiumService.BuscaPorId(comprovante.CampoComprovante);
//             return textoInseridoComprovante;
//         }

//         public void VerificaBotaoVoltarTelaComprovanteHelper(AppiumService appiumService)
//         {
//             appiumService.ClicaIdETexto(_cotacaoCDB.BotaoUmRealInsercaoRapida, _cotacaoCDB.BotaoUmRealInsercaoRapida.TextoEsperado);
//             appiumService.ClicaPorId(_cotacaoCDB.BotaoContinuar);
//             appiumService.BuscaPorId(_confirmacaoCDB.TextoImpostoRenda);
//             appiumService.BuscaPorId(_confirmacaoCDB.TextoDataSolicitacao);
//             appiumService.ScrollDeElementoOrigemParaElementoDestino(_confirmacaoCDB.TextoImpostoRenda, _confirmacaoCDB.TextoDataSolicitacao);
//             appiumService.BuscaPorId(_confirmacaoCDB.TextoTituloConfirmacao);
//             appiumService.BuscaPorId(_confirmacaoCDB.TextoRisco);
//             appiumService.ScrollDeElementoOrigemParaElementoDestino(_confirmacaoCDB.TextoTituloConfirmacao, _confirmacaoCDB.TextoRisco);
//             appiumService.BuscaPorIdETexto(_confirmacaoCDB.TextoAcima720Dias, _confirmacaoCDB.TextoAcima720Dias.TextoEsperado);
//             appiumService.ScrollDeElementoOrigemParaElementoDestino(_confirmacaoCDB.TextoRisco, _confirmacaoCDB.TextoAcima720Dias);
//             appiumService.EscrevePorId(_confirmacaoCDB.CampoIdentificacaoComprovante, "comprovante");
//             appiumService.ClicaPorId(_confirmacaoCDB.BotaoConfirmar);
//             appiumService.ClicaPorIdAcessibilidade(_token.BotaoFechar);
//             appiumService.ClicaPorIdCasoApareca(sucesso.BotaoFecharFeedBack, 5);
//             appiumService.ClicaPorId(sucesso.BotaoVerComprovante);
//             appiumService.ClicaPorIdAcessibilidade(comprovante.BotaoFechar);

//             appiumService.BuscaPorIdAcessibilidade(sucesso.BotaoFechar);
//             appiumService.BuscaPorId(sucesso.TextoSolicitacaoFeita);
//             appiumService.BuscaPorId(sucesso.BotaoVerComprovante);
//             appiumService.BuscaPorId(sucesso.TextoOQueFazer);
//             appiumService.BuscaPorId(sucesso.BotaoAcompanharInvestimento);
//             appiumService.BuscaPorId(sucesso.BotaoInvestirOutroProduto);
//         }
//     }
// }