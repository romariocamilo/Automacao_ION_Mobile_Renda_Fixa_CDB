// using Automacao_ION_Mobile_Renda_Fixa_CDB.Pages;
// using Automacao_ION_Mobile_Renda_Fixa_CDB.Commons;
// using Core_Automacao.Plataformas.Mobile;

// namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Helpers.Android.Contratacao.TelaToken
// {
//     public class TokenCdbHelper
//     {
//         private readonly CotacaoCDB _cotacaoCDB;
//         private readonly ConfirmacaoCDB _confirmacaoCDB;
//         public readonly Token token;

//         public TokenCdbHelper()
//         {
//             _cotacaoCDB = new CotacaoCDB();
//             _confirmacaoCDB = new ConfirmacaoCDB();
//             token = new Token();
//         }

//         public void SnapShotTelaTokenHelper(AppiumService appiumService)
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

//             appiumService.BuscaPorIdAcessibilidade(token.BotaoFechar);
//             appiumService.BuscaPorId(token.TextoTudoCerto);
//         }
//     }
// }