using System;
using System.Collections.Generic;
using System.Globalization;
using curso.dominio;

namespace curso {
    class Tela {

        public static void MostrarMenu() {
            Console.WriteLine("1 - Listar artistas ordenadamente");
            Console.WriteLine("2 - Cadastrar artistas");
            Console.WriteLine("3 - Cadastrar filme");
            Console.WriteLine("4 - Mostrar dados de um filme");
            Console.WriteLine("5 - Sair");

            Console.Write("Digite uma opção válida: ");
        }

        public static void MostrarArtistas() {
            Console.WriteLine("LISTAGEM DE ARTISTAS");
            for (int i = 0; i < Program.artistas.Count; i++) {
                Console.WriteLine(Program.artistas[i].ToString());
            }
        }

        public static void CadastrarArtista() {
            Console.WriteLine("Digite os dados do artista: ");
            Console.Write("Código: ");
            int cod = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Valor do cachê: ");
            double cache = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Program.artistas.Add(new Artista(cod, nome, cache));
            Program.artistas.Sort();
        }

        public static void CadastarFilme() {
            Console.WriteLine("Digite os dados do filme: ");
            Console.Write("Código: ");
            int cod = int.Parse(Console.ReadLine());
            Console.Write("Título: ");
            string titulo = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());

            List<Participacao> list = new List<Participacao>();

            Filme filme = new Filme(cod, titulo, ano, list);

            Program.filmes.Add(filme);
            Console.WriteLine();
            Console.Write("Quantas participações tem o filme? ");
            int part = int.Parse(Console.ReadLine());

            for (int i = 0; i < part; i++) {
                Console.WriteLine("Digite os dados da " + (i + 1) + "ª partitipação: ");
                Console.Write("Artista (código):");
                int cd = int.Parse(Console.ReadLine());
                int pos = Program.artistas.FindIndex(x => x.codigo == cd);
                if (pos < 0) {
                    throw new ArtistException("Artista Inexistente" + cd);
                }
                Console.Write("Desconto:");
                double desc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Participacao participacao = new Participacao(desc, Program.artistas[pos], filme); //Para declarar o artista e o filme que serão tratados
                participacao.Custo();
                list.Add(participacao);
                Console.WriteLine();
            }
            
        }
        public static void MostrarFilme() {
            Console.Write("Digite o código do filme: ");
            int cod = int.Parse(Console.ReadLine());
            int pos = Program.filmes.FindIndex(x=> x.codigo == cod);
            Console.WriteLine(Program.filmes[pos]);
            
        }
    }
}
