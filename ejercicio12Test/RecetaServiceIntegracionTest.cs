using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Practices.Unity;
using ejercicio12;

namespace ejercicio12Test
{
    [TestClass]
    public class RecetaServiceIntegracionTest
    {
        IUnityContainer container;

          [TestInitialize]
        public void init()
        {
            container= new UnityContainer();
            container.RegisterType<IRecetaService, RecetaService>();
            container.RegisterType<IRecetaRepository, RecetaRepository>();
        }
        [TestMethod]
        public void TestCreate()
        {
            IRecetaService sut = container.Resolve<IRecetaService>();
            Receta receta = new Receta();
            receta.Nombre = "Arroz negro";
            receta.Peso = 100;

            Receta resultado = sut.Create(receta);

            Assert.AreEqual(2 * 100.0, resultado.Peso);
        }
    }
}
