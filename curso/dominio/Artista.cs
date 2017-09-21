using System;
using System.Collections.Generic;
using System.Globalization;


namespace curso.dominio {
    class Artista : IComparable{

        public int codigo { get; set; }
        public string nome { get; set; }
        public double cache { get; set; }

     

        public Artista(int codigo, string nome, double cache) {
            this.codigo = codigo;
            this.nome = nome;
            this.cache = cache;
        }

        public override string ToString() {
            return codigo
                + ", "
                + nome
                + ", Cachê: "
                + cache.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj) {
            Artista outro = (Artista)obj;                                       //Compara o nome digitado com o outro
            int comp = nome.CompareTo(outro.nome);
            if (comp != 0) {
                return comp;
            } else {
                return -comp;
            }

        }
    }
}
