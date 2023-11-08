// using Automacao_ION_Mobile_Renda_Fixa_CDB.Pages;
// using Automacao_ION_Mobile_Renda_Fixa_CDB.Commons;
// using Core_Automacao.Plataformas.Mobile;

// namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Helpers.Android.Contratacao.TelaSucesso
// {
//     public class SucessoCdbHelper
//     {
//         private readonly Home _home;
//         public readonly Vitrine vitrine;
//         private readonly VitrineCDBeRendaFixa _vitrineCDBeRendaFixa;
//         public readonly InformacoesGeraisCDB informacoesGeraisCDB;
//         private readonly CotacaoCDB _cotacaoCDB;
//         private readonly ConfirmacaoCDB _confirmacaoCDB;
//         private readonly Token _token;
//         public readonly Sucesso sucesso;
//         public readonly Comprovante comprovante;
//         public readonly Relatorio relatorio;

//         public SucessoCdbHelper()
//         {
//             _home = new Home();
//             vitrine = new Vitrine();
//             _vitrineCDBeRendaFixa = new VitrineCDBeRendaFixa();
//             informacoesGeraisCDB = new InformacoesGeraisCDB();
//             _cotacaoCDB = new CotacaoCDB();
//             _confirmacaoCDB = new ConfirmacaoCDB();
//             _token = new Token();
//             sucesso = new Sucesso();
//             comprovante = new Comprovante();
//             relatorio = new Relatorio();
//         }

//         public void SnapShotTelaSucessoHelper(AppiumService appiumService)
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

//             appiumService.BuscaPorIdAcessibilidade(sucesso.BotaoFechar);
//             appiumService.BuscaPorId(sucesso.TextoSolicitacaoFeita);
//             appiumService.BuscaPorId(sucesso.BotaoVerComprovante);
//             appiumService.BuscaPorId(sucesso.TextoOQueFazer);
//             appiumService.BuscaPorId(sucesso.BotaoAcompanharInvestimento);
//             appiumService.BuscaPorId(sucesso.BotaoInvestirOutroProduto);
//         }

//         public void VerificarBotaoFecharHelper(AppiumService appiumService)
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
//             appiumService.ClicaPorIdAcessibilidade(sucesso.BotaoFechar);

//             appiumService.BuscaPorId(informacoesGeraisCDB.TextoBancoItauAndroid);
//             appiumService.BuscaPorId(informacoesGeraisCDB.TextoCDBDIItau);
//             appiumService.BuscaPorId(informacoesGeraisCDB.BotaoInvestir);
//         }

//         public void VerificarBotaoVerComprovanteHelper(AppiumService appiumService)
//         {
//             //appiumService.ClicaPorTexto(_cotacaoCDB.BotaoUmRealInsercaoRapida, _cotacaoCDB.BotaoUmRealInsercaoRapida.TextoEsperado);
//             appiumService.EscreveTecladoNativo(_cotacaoCDB.TextoValorAplicacao, "100");
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

//             appiumService.BuscaPorIdAcessibilidade(comprovante.BotaoFechar);
//             appiumService.BuscaPorId(comprovante.TextoComprovanteAplicacao);
//             appiumService.BuscaPorId(comprovante.TextoSolicitadoData);
//         }

//         public void VerificarBotaoAcompanharInvestimentoHelper(AppiumService appiumService)
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
//             appiumService.ClicaPorId(sucesso.BotaoAcompanharInvestimento);

//             appiumService.BuscaPorId(relatorio.TextoCarteira);
//             appiumService.BuscaPorId(relatorio.TextoTodosProdutos);
//         }

//         public void VerificarInvestirOutroProdutoHelper(AppiumService appiumService)
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
//             appiumService.ClicaPorId(sucesso.BotaoInvestirOutroProduto);

//             appiumService.BuscaPorId(vitrine.TrilhoCardProdutos);
//             appiumService.ScrollCarroselParaDireitaPorIdParandoComTexto(vitrine.TrilhoCardProdutos, vitrine.CardCdbRendaFixaAndroid, vitrine.CardCdbRendaFixaAndroid.TextoEsperado);
//             appiumService.BuscaPorIdEParteDoTexto(vitrine.CardCdbRendaFixaAndroid, vitrine.CardCdbRendaFixaAndroid.TextoEsperado);
//         }
//     }
// }