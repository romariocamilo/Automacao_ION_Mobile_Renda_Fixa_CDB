// using Automacao_ION_Mobile_Renda_Fixa_CDB.Commons;
// using Core_Automacao.Models;
// using Core_Automacao.Plataformas.Mobile;
// using NUnit.Framework;
// using Automacao_ION_Mobile_Renda_Fixa_CDB.Helpers.Android.Contratacao.TelaToken;

// namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Tests.Android.Contratacao.TelaToken
// {
//     public class TokenCdbAndroidTest
//     {
//         private readonly TokenCdbHelper _tokenCdbHelper;
//         private AppiumService _service;
//         private Uteis _uteis;

//         public TokenCdbAndroidTest()
//         {
//             _tokenCdbHelper = new TokenCdbHelper();
//             _uteis = new Uteis();
//         }

//         [SetUp, Retry(3)]
//         public void Setup()
//         {
//             _service = new AppiumService(PlataformaMobile.Android);
//             _uteis.AcessoPadraoTelaCotacaoCDBAndroid(_service, Constants.AGENCIA, Constants.CONTA, Constants.SENHA);
//         }

//         [TearDown]
//         public void TearDown()
//         {
//             if (_service is not null)
//             {
//                 _service.Desliga_Conexao();
//             }
//         }

//         [Test, Retry(3)]
//         public void SnapShotTelaTokenTest()
//         {
//             _tokenCdbHelper.SnapShotTelaTokenHelper(_service);

//             Assert.IsNotNull(_tokenCdbHelper.token.BotaoFechar);
//             Assert.AreEqual(_tokenCdbHelper.token.TextoTudoCerto.TextoEsperado, _tokenCdbHelper.token.TextoTudoCerto.TextoObtido.Substring(0, 12));
//         }
//     }
// }