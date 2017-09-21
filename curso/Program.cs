using System;
using System.Collections.Generic;
using System.Globalization;
using curso.dominio;


namespace curso {
    class Program {

        public static List<Artista> artistas = new List<Artista>();
        public static List<Filme> filmes = new List<Filme>();

        static void Main(string[] args) {

            artistas.Add(new Artista(101, "Scarlet Johansson", 4000000.00));
            artistas.Add(new Artista(102, "Chris Evans", 2500000.00));
            artistas.Add(new Artista(103, "Robert Downey Jr.", 3000000.00));
            artistas.Add(new Artista(104, "Morgan Freeman", 4000000.00));
            artistas.Sort();

            int opcao = 0;

            while (opcao != 5) {
                Console.Clear(); //Limpar a tela;
                Tela.MostrarMenu(); //Exibir o menu criado;
                try {
                    opcao = int.Parse(Console.ReadLine());
                } catch (Exception e){
                    Console.WriteLine("Erro inesperado: " + e.Message); //Caso o usuário digite uma opção inválida
                    opcao = 0;
                }
                switch (opcao) {
                    case 1:
                        Tela.MostrarArtistas();
                        break;
                    case 2:
                        try {
                            Tela.CadastrarArtista();
                        } catch (ArtistException e) {
                            Console.WriteLine("Artista não encontrado: " + e.Message);
                        } catch (Exception e) {
                            Console.WriteLine("Erro de digitação: " + e.Message);
                        }
                        break;
                    case 3:
                        try {
                            Tela.CadastarFilme();
                        } catch (Exception e) {
                            Console.WriteLine("Erro de digitação: " + e.Message);
                        }
                        break;
                    case 4:
                        try {
                            Tela.MostrarFilme();
                        } catch (Exception e) {
                            Console.WriteLine("Erro de digitação: " + e.Message);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Tchau!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.ReadLine(); //digitou a opção, teclou ENTER e volta pro menu de novo.


            }
        }
    }
}
