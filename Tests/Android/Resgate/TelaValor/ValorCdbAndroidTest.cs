// using Automacao_ION_Mobile_Renda_Fixa_CDB.Commons;
// using Core_Automacao.Plataformas.Mobile;
// using Core_Automacao.Models;
// using NUnit.Framework;
// using System.Threading;

// namespace Automacao_ION_Mobile_Renda_Fixa_CDB.Tests.Android.Resgate.TelaValor
// {
//     public class ValorCdbAndroidTest
//     {
//         private AppiumService _service;
//         private Uteis _uteis;

//         public ValorCdbAndroidTest()
//         {
//             _uteis = new Uteis();
//         }

//         [SetUp, Retry(3)]
//         public void Setup()
//         {
//             _service = new AppiumService(PlataformaMobile.Android);
//             _uteis.AcessoPadraoTelaValorCDBAndroid(_service, Constants.AGENCIA, Constants.CONTA, Constants.SENHA);
//         }

//         [TearDown]
//         public void TearDown()
//         {
//             if (_service is not null)
//             {
//                 Thread.Sleep(5000);
//                 _service.Desliga_Conexao();
//             }
//         }


//         [Test, Order(2), Retry(3)]
//         public void TesteTelaValor()
//         {

//         }
//     }
// }