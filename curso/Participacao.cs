using System;
using System.Collections.Generic;
using System.Globalization;
using curso.dominio;


namespace curso {
    class Participacao {

        public double desconto { get; set; }
        public Artista artista { get; set; }
        public Filme filme { get; set; }

        public Participacao(double desconto, Artista artista, Filme filme) {
            this.desconto = desconto;
            this.artista = artista;
            this.filme = filme;
        }

        public double Custo() {
            return artista.cache - desconto;
        }

        public override string ToString() {
            return artista.nome
                + ", Cachê: "
                + artista.cache.ToString("F2", CultureInfo.InvariantCulture)
                + ", Desconto: "
                + desconto.ToString("F2", CultureInfo.InvariantCulture)
                + ", Custo: "
                + Custo().ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
