using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SGD.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SGD.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

				//Categoria
				if (!context.Categorias.Any())
				{
					context.Categorias.AddRange(new List<Categoria>()
					{
						new Categoria()
						{
							Nome = "Artigo Científico",
							Descricao = "É uma pesquisa ou comunicação científica publicada em uma revista especializada. Também é denominado documento científico ou simplesmente artigo ou publicação.",

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now.AddDays(-10)
						},
						new Categoria()
						{
							Nome = "Livro",
							Descricao = "É um objeto transportável ou  digital, composto por páginas encadernadas, contendo texto manuscrito ou impresso e/ou imagens e que forma uma publicação unitária (ou foi concebido como tal) ou a parte principal de um trabalho literário, científico ou outro, formando um volume.",

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now
						},
						new Categoria()
						{
							Nome = "Revista",
							Descricao = "É uma publicação periódica de cunho informativo, jornalístico ou de entretenimento, geralmente voltada para o público em geral.",

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now.AddDays(3)
						}
					});
					context.SaveChanges();
				}
				//SubCategoria
				if (!context.SubCategorias.Any())
				{
					context.SubCategorias.AddRange(new List<SubCategoria>()
					{
						new SubCategoria()
						{
							Nome = "Administração",
							Descricao = "É uma pesquisa ou comunicação científica publicada em uma revista especializada. Também é denominado documento científico ou simplesmente artigo ou publicação.",
							CategoriaId = 2,

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now
						},
						new SubCategoria()
						{
							Nome = "Agropecuária",
							Descricao = "É uma pesquisa ou comunicação científica publicada em uma revista especializada. Também é denominado documento científico ou simplesmente artigo ou publicação.",
							CategoriaId = 2,

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now
						},
						new SubCategoria()
						{
							Nome = "Artes",
							Descricao = "É uma pesquisa ou comunicação científica publicada em uma revista especializada. Também é denominado documento científico ou simplesmente artigo ou publicação.",
							CategoriaId = 2,

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now
						},
						new SubCategoria()
						{
							Nome = "AudioLivro",
							Descricao = "É uma pesquisa ou comunicação científica publicada em uma revista especializada. Também é denominado documento científico ou simplesmente artigo ou publicação.",
							CategoriaId = 2,

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now
						},
						new SubCategoria()
						{
							Nome = "Autoajuda",
							Descricao = "É uma pesquisa ou comunicação científica publicada em uma revista especializada. Também é denominado documento científico ou simplesmente artigo ou publicação.",
							CategoriaId = 2,

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now
						},
						new SubCategoria()
						{
							Nome = "Ciências Biológicas",
							Descricao = "É uma pesquisa ou comunicação científica publicada em uma revista especializada. Também é denominado documento científico ou simplesmente artigo ou publicação.",
							CategoriaId = 2,

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now
						},
						new SubCategoria()
						{
							Nome = "Ciências Exatas",
							Descricao = "É uma pesquisa ou comunicação científica publicada em uma revista especializada. Também é denominado documento científico ou simplesmente artigo ou publicação.",
							CategoriaId = 2,

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now
						},
						new SubCategoria()
						{
							Nome = "Ciências Humanas e Sociais",
							Descricao = "É uma pesquisa ou comunicação científica publicada em uma revista especializada. Também é denominado documento científico ou simplesmente artigo ou publicação.",
							CategoriaId = 2,

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now
						},
						new SubCategoria()
						{
							Nome = "Contabilidade",
							Descricao = "É uma pesquisa ou comunicação científica publicada em uma revista especializada. Também é denominado documento científico ou simplesmente artigo ou publicação.",
							CategoriaId = 2,

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now
						},
						new SubCategoria()
						{
							Nome = "Cursos e Idiomas",
							Descricao = "É uma pesquisa ou comunicação científica publicada em uma revista especializada. Também é denominado documento científico ou simplesmente artigo ou publicação.",
							CategoriaId = 2,

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now
						},
						new SubCategoria()
						{
							Nome = "Dicionários e Manuais de Conversação",
							Descricao = "É uma pesquisa ou comunicação científica publicada em uma revista especializada. Também é denominado documento científico ou simplesmente artigo ou publicação.",
							CategoriaId = 2,

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now
						},
						new SubCategoria()
						{
							Nome = "Didáticos",
							Descricao = "É uma pesquisa ou comunicação científica publicada em uma revista especializada. Também é denominado documento científico ou simplesmente artigo ou publicação.",
							CategoriaId = 2,

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now
						},
						new SubCategoria()
						{
							Nome = "Direito",
							Descricao = "É uma pesquisa ou comunicação científica publicada em uma revista especializada. Também é denominado documento científico ou simplesmente artigo ou publicação.",
							CategoriaId = 2,

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now
						},
						new SubCategoria()
						{
							Nome = "Diversos",
							Descricao = "É uma pesquisa ou comunicação científica publicada em uma revista especializada. Também é denominado documento científico ou simplesmente artigo ou publicação.",
							CategoriaId = 2,

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now
						},
						new SubCategoria()
						{
							Nome = "Economia",
							Descricao = "É uma pesquisa ou comunicação científica publicada em uma revista especializada. Também é denominado documento científico ou simplesmente artigo ou publicação.",
							CategoriaId = 2,

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now
						},
						new SubCategoria()
						{
							Nome = "Engenharia e Tecnologia",
							Descricao = "É uma pesquisa ou comunicação científica publicada em uma revista especializada. Também é denominado documento científico ou simplesmente artigo ou publicação.",
							CategoriaId = 2,

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now
						},
						new SubCategoria()
						{
							Nome = "Esoterismo",
							Descricao = "É uma pesquisa ou comunicação científica publicada em uma revista especializada. Também é denominado documento científico ou simplesmente artigo ou publicação.",
							CategoriaId = 2,

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now
						},
						new SubCategoria()
						{
							Nome = "Espiritismo",
							Descricao = "É uma pesquisa ou comunicação científica publicada em uma revista especializada. Também é denominado documento científico ou simplesmente artigo ou publicação.",
							CategoriaId = 2,

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now
						},
						new SubCategoria()
						{
							Nome = "Esportes e Lazer",
							Descricao = "É uma pesquisa ou comunicação científica publicada em uma revista especializada. Também é denominado documento científico ou simplesmente artigo ou publicação.",
							CategoriaId = 2,

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now
						},
						new SubCategoria()
						{
							Nome = "Gastronomia",
							Descricao = "É uma pesquisa ou comunicação científica publicada em uma revista especializada. Também é denominado documento científico ou simplesmente artigo ou publicação.",
							CategoriaId = 2,

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now
						},
						new SubCategoria()
						{
							Nome = "Geografia e Historia",
							Descricao = "É uma pesquisa ou comunicação científica publicada em uma revista especializada. Também é denominado documento científico ou simplesmente artigo ou publicação.",
							CategoriaId = 2,

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now
						},
						new SubCategoria()
						{
							Nome = "Informática",
							Descricao = "É uma pesquisa ou comunicação científica publicada em uma revista especializada. Também é denominado documento científico ou simplesmente artigo ou publicação.",
							CategoriaId = 2,

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now
						},
						new SubCategoria()
						{
							Nome = "Linguística",
							Descricao = "É uma pesquisa ou comunicação científica publicada em uma revista especializada. Também é denominado documento científico ou simplesmente artigo ou publicação.",
							CategoriaId = 2,

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now
						},
						new SubCategoria()
						{
							Nome = "Literatura Estrangeira",
							Descricao = "É uma pesquisa ou comunicação científica publicada em uma revista especializada. Também é denominado documento científico ou simplesmente artigo ou publicação.",
							CategoriaId = 2,

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now
						},
						new SubCategoria()
						{
							Nome = "Literatura Infantojuvenil",
							Descricao = "É uma pesquisa ou comunicação científica publicada em uma revista especializada. Também é denominado documento científico ou simplesmente artigo ou publicação.",
							CategoriaId = 2,

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now
						},
						new SubCategoria()
						{
							Nome = "Medicina",
							Descricao = "É uma pesquisa ou comunicação científica publicada em uma revista especializada. Também é denominado documento científico ou simplesmente artigo ou publicação.",
							CategoriaId = 2,

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now
						},
						new SubCategoria()
						{
							Nome = "Pocket Books",
							Descricao = "É uma pesquisa ou comunicação científica publicada em uma revista especializada. Também é denominado documento científico ou simplesmente artigo ou publicação.",
							CategoriaId = 2,

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now
						},
						new SubCategoria()
						{
							Nome = "Psicologia e Psicanálise",
							Descricao = "É uma pesquisa ou comunicação científica publicada em uma revista especializada. Também é denominado documento científico ou simplesmente artigo ou publicação.",
							CategoriaId = 2,

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now
						},
						new SubCategoria()
						{
							Nome = "Quadrinhos e Mangás",
							Descricao = "É uma pesquisa ou comunicação científica publicada em uma revista especializada. Também é denominado documento científico ou simplesmente artigo ou publicação.",
							CategoriaId = 2,

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now
						},
						new SubCategoria()
						{
							Nome = "Religião",
							Descricao = "É uma pesquisa ou comunicação científica publicada em uma revista especializada. Também é denominado documento científico ou simplesmente artigo ou publicação.",
							CategoriaId = 2,

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now
						},
						new SubCategoria()
						{
							Nome = "Turismo",
							Descricao = "É uma pesquisa ou comunicação científica publicada em uma revista especializada. Também é denominado documento científico ou simplesmente artigo ou publicação.",
							CategoriaId = 2,

							AtivoEstado = true,
							DeleteEstado = false,
							DataCadastro = DateTime.Now
						}
					});
					context.SaveChanges();
				}
				//Pais
				if (!context.Paises.Any())
				{
					context.Paises.AddRange(new List<Pais>()
					{
						new Pais()
						{
							Nome = "Afeganistão"
						},
						new Pais()
						{
							Nome = "África do Sul"
						},
						new Pais()
						{
							Nome = "Albânia"
						},
						new Pais()
						{
							Nome = "Alemanha"
						},
						new Pais()
						{
							Nome = "Andorra"
						},
						new Pais()
						{
							Nome = "Angola"
						},
						new Pais()
						{
							Nome = "Antiga e Barbuda"
						},
						new Pais()
						{
							Nome = "Arábia Saudita"
						},
						new Pais()
						{
							Nome = "Argélia"
						},
						new Pais()
						{
							Nome = "Argentina"
						},
						new Pais()
						{
							Nome = "Arménia"
						},
						new Pais()
						{
							Nome = "Austrália"
						},
						new Pais()
						{
							Nome = "Áustria"
						},
						new Pais()
						{
							Nome = "Azerbaijão"
						},
						new Pais()
						{
							Nome = "Bahamas"
						},
						new Pais()
						{
							Nome = "Bangladexe"
						},
						new Pais()
						{
							Nome = "Barbados"
						},
						new Pais()
						{
							Nome = "Barém"
						},
						new Pais()
						{
							Nome = "Bélgica"
						},
						new Pais()
						{
							Nome = "Belize"
						},
						new Pais()
						{
							Nome = "Benim"
						},
						new Pais()
						{
							Nome = "Bielorrússia"
						},
						new Pais()
						{
							Nome = "Bolívia"
						},
						new Pais()
						{
							Nome = "Bósnia e Herzegovina"
						},
						new Pais()
						{
							Nome = "Botsuana"
						},
						new Pais()
						{
							Nome = "Brasil"
						},
						new Pais()
						{
							Nome = "Brunei"
						},
						new Pais()
						{
							Nome = "Bulgária"
						},
						new Pais()
						{
							Nome = "Burquina Faso"
						},
						new Pais()
						{
							Nome = "Burúndi"
						},
						new Pais()
						{
							Nome = "Butão"
						},
						new Pais()
						{
							Nome = "Cabo Verde"
						},
						new Pais()
						{
							Nome = "Camarões"
						},
						new Pais()
						{
							Nome = "Camboja"
						},
						new Pais()
						{
							Nome = "Canadá"
						},
						new Pais()
						{
							Nome = "Catar"
						},
						new Pais()
						{
							Nome = "Cazaquistão"
						},
						new Pais()
						{
							Nome = "Chade"
						},
						new Pais()
						{
							Nome = "Chile"
						},
						new Pais()
						{
							Nome = "China"
						},
						new Pais()
						{
							Nome = "Chipre"
						},
						new Pais()
						{
							Nome = "Colômbia"
						},
						new Pais()
						{
							Nome = "Comores"
						},
						new Pais()
						{
							Nome = "Congo-Brazzaville"
						},
						new Pais()
						{
							Nome = "Coreia do Norte"
						},
						new Pais()
						{
							Nome = "Coreia do Sul"
						},
						new Pais()
						{
							Nome = "Cosovo"
						},
						new Pais()
						{
							Nome = "Costa do Marfim"
						},
						new Pais()
						{
							Nome = "Costa Rica"
						},
						new Pais()
						{
							Nome = "Croácia"
						},
						new Pais()
						{
							Nome = "Cuaite"
						},
						new Pais()
						{
							Nome = "Cuba"
						},
						new Pais()
						{
							Nome = "Dinamarca"
						},
						new Pais()
						{
							Nome = "Dominica"
						},
						new Pais()
						{
							Nome = "Egito"
						},
						new Pais()
						{
							Nome = "Emirados Árabes Unidos"
						},
						new Pais()
						{
							Nome = "Equador"
						},
						new Pais()
						{
							Nome = "Eritreia"
						},
						new Pais()
						{
							Nome = "Eslováquia"
						},
						new Pais()
						{
							Nome = "Eslovénia"
						},
						new Pais()
						{
							Nome = "Espanha"
						},
						new Pais()
						{
							Nome = "Estado da Palestina"
						},
						new Pais()
						{
							Nome = "Estados Unidos"
						},
						new Pais()
						{
							Nome = "Estónia"
						},
						new Pais()
						{
							Nome = "Etiópia"
						},
						new Pais()
						{
							Nome = "Fiji"
						},
						new Pais()
						{
							Nome = "Filipinas"
						},
						new Pais()
						{
							Nome = "Finlândia"
						},
						new Pais()
						{
							Nome = "França"
						},
						new Pais()
						{
							Nome = "Gabão"
						},
						new Pais()
						{
							Nome = "Gâmbia"
						},
						new Pais()
						{
							Nome = "Gana"
						},
						new Pais()
						{
							Nome = "Geórgia"
						},
						new Pais()
						{
							Nome = "Granada"
						},
						new Pais()
						{
							Nome = "Grécia"
						},
						new Pais()
						{
							Nome = "Guatemala"
						},
						new Pais()
						{
							Nome = "Guiana"
						},
						new Pais()
						{
							Nome = "Guiné"
						},
						new Pais()
						{
							Nome = "Guiné Equatorial"
						},
						new Pais()
						{
							Nome = "Guiné-Bissau"
						},
						new Pais()
						{
							Nome = "Haiti"
						},
						new Pais()
						{
							Nome = "Honduras"
						},
						new Pais()
						{
							Nome = "Hungria"
						},
						new Pais()
						{
							Nome = "Iémen"
						},
						new Pais()
						{
							Nome = "Ilhas Marechal"
						},
						new Pais()
						{
							Nome = "Índia"
						},
						new Pais()
						{
							Nome = "Indonésia"
						},
						new Pais()
						{
							Nome = "Irão"
						},
						new Pais()
						{
							Nome = "Iraque"
						},
						new Pais()
						{
							Nome = "Irlanda"
						},
						new Pais()
						{
							Nome = "Islândia"
						},
						new Pais()
						{
							Nome = "Israel"
						},
						new Pais()
						{
							Nome = "Itália"
						},
						new Pais()
						{
							Nome = "Jamaica"
						},
						new Pais()
						{
							Nome = "Japão"
						},
						new Pais()
						{
							Nome = "Jibuti"
						},
						new Pais()
						{
							Nome = "Jordânia"
						},
						new Pais()
						{
							Nome = "Laus"
						},
						new Pais()
						{
							Nome = "Lesoto"
						},
						new Pais()
						{
							Nome = "LetóniaLíbano"
						},
						new Pais()
						{
							Nome = "Libéria"
						},
						new Pais()
						{
							Nome = "Líbia"
						},
						new Pais()
						{
							Nome = "Listenstaine"
						},
						new Pais()
						{
							Nome = "Lituânia"
						},
						new Pais()
						{
							Nome = "Luxemburgo"
						},
						new Pais()
						{
							Nome = "Macedónia"
						},
						new Pais()
						{
							Nome = "Madagáscar"
						},
						new Pais()
						{
							Nome = "Malásia"
						},
						new Pais()
						{
							Nome = "Maláui"
						},
						new Pais()
						{
							Nome = "Maldivas"
						},
						new Pais()
						{
							Nome = "Mali"
						},
						new Pais()
						{
							Nome = "Malta"
						},
						new Pais()
						{
							Nome = "Marrocos"
						},
						new Pais()
						{
							Nome = "Maurícia"
						},
						new Pais()
						{
							Nome = "Mauritânia"
						},
						new Pais()
						{
							Nome = "México"
						},
						new Pais()
						{
							Nome = "Mianmar"
						},
						new Pais()
						{
							Nome = "Micronésia"
						},
						new Pais()
						{
							Nome = "Moçambique"
						},
						new Pais()
						{
							Nome = "Moldávia"
						},
						new Pais()
						{
							Nome = "Mónaco"
						},
						new Pais()
						{
							Nome = "Mongólia"
						},
						new Pais()
						{
							Nome = "Montenegro"
						},
						new Pais()
						{
							Nome = "Namíbia"
						},
						new Pais()
						{
							Nome = "Nauru"
						},
						new Pais()
						{
							Nome = "Nepal"
						},
						new Pais()
						{
							Nome = "Nicarágua"
						},
						new Pais()
						{
							Nome = "Níger"
						},
						new Pais()
						{
							Nome = "Nigéria"
						},
						new Pais()
						{
							Nome = "Noruega"
						},
						new Pais()
						{
							Nome = "Nova Zelândia"
						},
						new Pais()
						{
							Nome = "Omã"
						},
						new Pais()
						{
							Nome = "Países Baixos"
						},
						new Pais()
						{
							Nome = "Palau"
						},
						new Pais()
						{
							Nome = "Panamá"
						},
						new Pais()
						{
							Nome = "Papua Nova Guiné"
						},
						new Pais()
						{
							Nome = "Paquistão"
						},
						new Pais()
						{
							Nome = "Paraguai"
						},
						new Pais()
						{
							Nome = "Peru"
						},
						new Pais()
						{
							Nome = "Polónia"
						},
						new Pais()
						{
							Nome = "Portugal"
						},
						new Pais()
						{
							Nome = "Quénia"
						},
						new Pais()
						{
							Nome = "Quirguistão"
						},
						new Pais()
						{
							Nome = "Quiribáti"
						},
						new Pais()
						{
							Nome = "Reino Unido"
						},
						new Pais()
						{
							Nome = "República Centro-Africana"
						},
						new Pais()
						{
							Nome = "República Checa"
						},
						new Pais()
						{
							Nome = "República Democrática do Congo"
						},
						new Pais()
						{
							Nome = "República DominicanaRoménia"
						},
						new Pais()
						{
							Nome = "Ruanda"
						},
						new Pais()
						{
							Nome = "Rússia"
						},
						new Pais()
						{
							Nome = "Salomão"
						},
						new Pais()
						{
							Nome = "Salvador"
						},
						new Pais()
						{
							Nome = "Samoa"
						},
						new Pais()
						{
							Nome = "Santa Lúcia"
						},
						new Pais()
						{
							Nome = "São Cristóvão e Neves"
						},
						new Pais()
						{
							Nome = "São Marinho"
						},
						new Pais()
						{
							Nome = "São Tomé e Príncipe"
						},
						new Pais()
						{
							Nome = "São Vicente e Granadinas"
						},
						new Pais()
						{
							Nome = "Seicheles"
						},
						new Pais()
						{
							Nome = "Senegal"
						},
						new Pais()
						{
							Nome = "Serra Leoa"
						},
						new Pais()
						{
							Nome = "Sérvia"
						},
						new Pais()
						{
							Nome = "Singapura"
						},
						new Pais()
						{
							Nome = "Síria"
						},
						new Pais()
						{
							Nome = "Somália"
						},
						new Pais()
						{
							Nome = "Sri Lanca"
						},
						new Pais()
						{
							Nome = "Suazilândia"
						},
						new Pais()
						{
							Nome = "Sudão"
						},
						new Pais()
						{
							Nome = "Sudão do Sul"
						},
						new Pais()
						{
							Nome = "Suécia"
						},
						new Pais()
						{
							Nome = "Suíça"
						},
						new Pais()
						{
							Nome = "Suriname"
						},
						new Pais()
						{
							Nome = "Tailândia"
						},
						new Pais()
						{
							Nome = "Taiuã"
						},
						new Pais()
						{
							Nome = "Tajiquistão"
						},
						new Pais()
						{
							Nome = "Tanzânia"
						},
						new Pais()
						{
							Nome = "Timor-Leste"
						},
						new Pais()
						{
							Nome = "Togo"
						},
						new Pais()
						{
							Nome = "Tonga"
						},
						new Pais()
						{
							Nome = "Trindade e Tobago"
						},
						new Pais()
						{
							Nome = "Tunísia"
						},
						new Pais()
						{
							Nome = "Turcomenistão"
						},
						new Pais()
						{
							Nome = "Turquia"
						},
						new Pais()
						{
							Nome = "Tuvalu"
						},
						new Pais()
						{
							Nome = "Ucrânia"
						},
						new Pais()
						{
							Nome = "Uganda"
						},
						new Pais()
						{
							Nome = "Uruguai"
						},
						new Pais()
						{
							Nome = "Usbequistão"
						},
						new Pais()
						{
							Nome = "Vanuatu"
						},
						new Pais()
						{
							Nome = "Vaticano"
						},
						new Pais()
						{
							Nome = "Venezuela"
						},
						new Pais()
						{
							Nome = "Vietname"
						},
						new Pais()
						{
							Nome = "Zâmbia"
						},
						new Pais()
						{
							Nome = "Zimbábue"
						}
					});
					context.SaveChanges();
				}
			}
        }
    }
}
