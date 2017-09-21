using System;
using System.Collections.Generic;
using System.Globalization;
using curso.dominio;

namespace curso.dominio {
    class Filme {

        public int codigo { get; set; }
        public string titulo { get; set; }
        public int ano { get; set; }

           public List<Participacao> particacaoNoFilme = new List<Participacao>();

        public Filme(int codigo, string titulo, int ano, List<Participacao> list) {
            this.codigo = codigo;
            this.titulo = titulo;
            this.ano = ano;
            this.particacaoNoFilme = list;
        }

        public double ValorTotal() {
            double total = 0.0;
            for (int i = 0; i < particacaoNoFilme.Count; i++) {
                total += particacaoNoFilme[i].Custo();
            }return total;
        }

        public override string ToString() {
            String s = "Filme "
                + codigo
                + ", Títlo: "
                + titulo
                + ", Ano: "
                + ano
            + "\n Participações: ";
            for (int i = 0; i < particacaoNoFilme.Count; i++) {
                s = s +particacaoNoFilme[i];
            }
            s = s + "\n Custo Total do Filme: " + ValorTotal();

            return s;
        }
    }
}
