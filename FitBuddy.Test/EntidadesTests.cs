using System;
using BE;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FitBuddy.Test
{
    [TestClass]
    public class EntidadesTests
    {
        [TestMethod]
        public void UsuarioCalculaDvh()
        {
            // Arrange
            var usuario = new Usuario()
            {
                Nombre = "Danisa",
                Apellido = "Jokanovich",
                Estado = Estado.Activo,
                Id = 1,
                IdIdioma = 1,
                IntentosFallidos = 0,
                Password = "123456",
                Username = "djokanovich"
            };

            // Act
            var dvh = usuario.DVH;

            // Assert
            Assert.AreEqual(dvh, 9);
        }
    }
}
