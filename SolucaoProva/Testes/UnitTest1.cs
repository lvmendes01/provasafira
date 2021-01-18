using lvmendes.Prova.Servico;
using lvmendes.Prova.Servico.Interfaces;
using Lvmendes.Prova.Repositorio;
using Lvmendes.Prova.Repositorio.Interfaces;
using Lvmendes.Prova.Servico;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;

namespace Testes
{
    public class Tests
    {
        private readonly IArtistaService artistaService;
        private readonly IUsuarioRepositorio usuarioRepository;
        public Tests()
        {
            var services = new ServiceCollection();
            services.AddTransient<IArtistaService, ArtistaServico>();
            services.AddTransient<IUsuarioServico, UsuarioServico>();
            services.AddTransient<IUsuarioRepositorio, UsuarioRepositorio>();


            var serviceProvider = services.BuildServiceProvider();

            usuarioRepository = serviceProvider.GetService<IUsuarioRepositorio>();
            artistaService = serviceProvider.GetService<IArtistaService>();
        }

        [SetUp]
        public void Setup()
        {
        }
      
        [Test]
        public void TestListaArtista()
        {
            var art = this.artistaService.ListaArtistasPorTotal(10);

            Assert.AreEqual(art.Count , 10);
        }

        [Test]
        public void TestLogin()
        {
            var usuario = this.usuarioRepository.LoginUsuario("test", "123");

            Assert.IsNotNull(usuario);
        }
    }
}