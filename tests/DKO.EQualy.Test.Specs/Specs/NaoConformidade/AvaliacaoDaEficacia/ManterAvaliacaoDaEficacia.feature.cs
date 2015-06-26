﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18408
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace DKO.EQualy.Test.Specs.Specs.NaoConformidade.AvaliacaoDaEficacia
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class ManterAvaliacaoDaEficaciaFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ManterAvaliacaoDaEficacia.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "ManterAvaliacaoDaEficacia", "\r\nQuero avaliar as soluções propostas para a solução de uma não conformidade", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "ManterAvaliacaoDaEficacia")))
            {
                DKO.EQualy.Test.Specs.Specs.NaoConformidade.AvaliacaoDaEficacia.ManterAvaliacaoDaEficaciaFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 8
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("avaliar uma solução de nao conformidade")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ManterAvaliacaoDaEficacia")]
        public virtual void AvaliarUmaSolucaoDeNaoConformidade()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("avaliar uma solução de nao conformidade", ((string[])(null)));
#line 13
this.ScenarioSetup(scenarioInfo);
#line 8
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Pontuacao",
                        "Observacao"});
            table1.AddRow(new string[] {
                        "5",
                        "\"Solução muito bem elaborada para resolver o problema de produto vencido\""});
#line 15
testRunner.Given("as seguintes informações iniciais para a avaliação da eficacia", ((string)(null)), table1, "Dado ");
#line 19
testRunner.When("salvar a nao conformidade com os dados de avaliação de eficacia", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 20
testRunner.Then("eu espero receber a seguinte informação \"Avaliação da não conformidade realizada " +
                    "com sucesso!\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line 21
testRunner.And("um email de notificação para a equipe envolvida deve ser enviado com a seguinte m" +
                    "ensagem \"A definição de solução para a não conformidade XX foi avaliada com uma " +
                    "pontuação de YY\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
