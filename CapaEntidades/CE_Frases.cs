using System;

namespace CapaEntidades
{
    public class CE_Frases
    {
        private string _ids;
        private int _idi;
        private char[] _letras;
        private string[] _palabras;
        private string[] _autor;
        private string _frase;
        private string _fuente;
        private int _fraseExt;
        private string _idioma;
        private int _idioma_id;
        private string _ident;
        private string _nameArchive;
        private DateTime _creado;
        private int _consonante;
        private int _vocal;

        public string Ids { get => _ids; set => _ids = value; }
        public int Idi { get => _idi; set => _idi = value; }
        public char[] Letras { get => _letras; set => _letras = value; }
        public string[] Palabras { get => _palabras; set => _palabras = value; }
        public string[] Autor { get => _autor; set => _autor = value; }
        public string Frase { get => _frase; set => _frase = value; }
        public string Fuente { get => _fuente; set => _fuente = value; }
        public int FraseExt { get => _fraseExt; set => _fraseExt = value; }
        public string Idioma { get => _idioma; set => _idioma = value; }
        public int IdiomaID { get => _idioma_id; set => _idioma_id = value; }
        public string Ident { get => _ident; set => _ident = value; }
        public string NameArchive { get => _nameArchive; set => _nameArchive = value; }
        public DateTime Creado { get => _creado; set => _creado = value; }
        public int Consonante { get => _consonante; set => _consonante = value; }
        public int Vocal { get => _vocal; set => _vocal = value; }
    }
}
