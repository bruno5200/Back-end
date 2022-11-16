using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class CN_Frases
    {
        private CN_Operaciones SF = new CN_Operaciones();
        private CD_Frases ObjetoCD = new CD_Frases();
        /*public void InsertarFrases(int idioma, string cadena)
        {
            string[] Decoded = cadena.Split('#').ToArray();
            string _frase = Decoded[0];
            string _fuente = Decoded[1];
            DateTime _creado = DateTime.Now;
            SF.Operaciones(_frase, _fuente, idioma);
            ObjetoCD.AgregarFrase(idioma, _frase, _fuente, _creado);
        }*/
        public void Frases(CE_Frases f)
        {
            if (f.IdiomaID == 1)
            {
                f.Ident = "inglés";
                f.NameArchive = "INGLES";
            }
            else if (f.IdiomaID == 2)
            {
                f.Ident = "español";
                f.NameArchive = "ESPAÑOL";
            }
            else if (f.IdiomaID == 3)
            {
                f.Ident = "francés";
                f.NameArchive = "FRANCES";
            }
            else if (f.IdiomaID == 4)
            {
                f.Ident = "alemán";
                f.NameArchive = "ALEMAN";
            }
            else if (f.IdiomaID == 5)
            {
                f.Ident = "portugués";
                f.NameArchive = "PORTUGUES";
            }
            else if (f.IdiomaID == 6)
            {
                f.Ident = "italiano";
                f.NameArchive = "ITALIANO";
            }
            else if (f.IdiomaID == 7)
            {
                f.Ident = "noruego";
                f.NameArchive = "NORUEGO";
            }
            string folderName = @"c:\ArchivosApp";

            string pathString = System.IO.Path.Combine(folderName, $"{f.Ident}");

            string fileName = $"{f.NameArchive}.txt";

            pathString = System.IO.Path.Combine(pathString, fileName);

            using (FileStream fs = new FileStream(pathString, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.Default))
                {
                    string cadena = string.Empty;
                    while ((cadena = sr.ReadLine()) != null)
                    {
                        string[] Decoded = cadena.Split('#').ToArray();
                        f.Frase = Decoded[0];
                        f.Fuente = Decoded[1];
                        f.Creado = DateTime.Now;
                        ObjetoCD.AgregarFrase(f);
                        SF.Operaciones(f);
                    }
                }
            }
        }
        public static char[] EliminarDuplicados(char[] Letras)
        {
            char[] sinDuplicadosLetras = Letras.Distinct().ToArray();

            return sinDuplicadosLetras;
        }
        public static char[] Remover(char[] Letras)
        {
            char[] Removido = new char[Letras.Length];
            for (int i = 0; i < Letras.Length; i++)
            {
                if (Letras[i] != ' ' && Letras[i] != '.' && Letras[i] != ',' && Letras[i] != '“' && Letras[i] != '”' && Letras[i] != '-' && Letras[i] != '’' && Letras[i] != '"' && Letras[i] != '´' && Letras[i] != '\'' && Letras[i] != ';' && Letras[i] != ':' && Letras[i] != '¿' && Letras[i] != '?' && Letras[i] != '¡' && Letras[i] != '!')
                {
                    Removido[i] += Letras[i];
                }
            }
            return Removido;
        }
        private CE_Frases Simplificar(CE_Frases f)
        {
            f.Vocal = 0; f.Consonante = 0;

            char[] simplificado = new char[f.Letras.Length];
            for (int i = 0; i < f.Letras.Length; i++)
            {
                if (f.Letras[i] == 'a' || f.Letras[i] == 'á' || f.Letras[i] == 'â' || f.Letras[i] == 'ä' || f.Letras[i] == 'à' || f.Letras[i] == 'ã'|| f.Letras[i] == 'ӕ')
                {
                    simplificado[i] = 'a';
                    f.Vocal++;
                }
                else if (f.Letras[i] == 'e' || f.Letras[i] == 'é' || f.Letras[i] == 'ê' || f.Letras[i] == 'ë' || f.Letras[i] == 'è')
                {
                    simplificado[i] = 'e';
                    f.Vocal++;
                }
                else if (f.Letras[i] == 'i' || f.Letras[i] == 'í' || f.Letras[i] == 'î' || f.Letras[i] == 'ï' || f.Letras[i] == 'ì')
                {
                    simplificado[i] = 'i';
                    f.Vocal++;
                }
                else if (f.Letras[i] == 'o' || f.Letras[i] == 'ó' || f.Letras[i] == 'ô' || f.Letras[i] == 'ö' || f.Letras[i] == 'ò' || f.Letras[i] == 'õ' || f.Letras[i] == 'œ')
                {
                    simplificado[i] = 'o';
                    f.Vocal++;
                }
                else if (f.Letras[i] == 'u' || f.Letras[i] == 'ú' || f.Letras[i] == 'û' || f.Letras[i] == 'ü' || f.Letras[i] == 'ù')
                {
                    simplificado[i] = 'u';
                    f.Vocal++;
                }
                else if (f.Letras[i] == 'b' || f.Letras[i] == 'c' || f.Letras[i] == 'd' || f.Letras[i] == 'f' || f.Letras[i] == 'g' || f.Letras[i] == 'h' || f.Letras[i] == 'i' || f.Letras[i] == 'j' || f.Letras[i] == 'k' || f.Letras[i] == 'l' || f.Letras[i] == 'm' ||
                        f.Letras[i] == 'n' || f.Letras[i] == 'ñ' || f.Letras[i] == 'p' || f.Letras[i] == 'q' || f.Letras[i] == 'r' || f.Letras[i] == 's' || f.Letras[i] == 't' || f.Letras[i] == 'v' || f.Letras[i] == 'w' || f.Letras[i] == 'x' || f.Letras[i] == 'y' ||
                        f.Letras[i] == 'z' || f.Letras[i] == 'ß' || f.Letras[i] == 'š' || f.Letras[i] == 'ç' || f.Letras[i] == 'č')
                {
                    simplificado[i] = f.Letras[i];
                    f.Consonante++;
                }
            }
            f.Letras = simplificado;
            return f;
        }
        public string Extended(string texto)
        {
            int Exlength = 0;
            if (texto.Length >= 12)
            {
                if (texto.Length >= 24)
                {
                    if (texto.Length >= 36)
                    {
                        if (texto.Length >= 48)
                        {
                            Exlength = texto.Length - 48;
                        }
                        else
                            Exlength = texto.Length - 36;
                    }
                    else
                        Exlength = texto.Length - 24;
                }
                else
                    Exlength = texto.Length - 12;
            }
            texto = texto.Substring(0, (texto.Length - Exlength));
            return texto;
        }
        public void EditarFrase(CE_Frases f)
        {
            CD_Frases ObjetoCD = new CD_Frases();

            f.Idi = Convert.ToInt32(f.Ids);

            string fras = f.Frase.ToLower();

            f.Letras = fras.ToArray();
            f.Letras = Remover(f.Letras);
            f = Simplificar(f);
            f.Letras = EliminarDuplicados(f.Letras);

            ObjetoCD.EditarFrase(f);
            if (f.Idioma == "Inglés")
            {
                f.Frase = SF.Inglés(f);
                f.Ident = "inglés";
                f.NameArchive = "In";
            }
            else if (f.Idioma == "Español")
            {
                f.Frase = SF.Español(f);
                f.Ident = "español";
                f.NameArchive = "Es";
                f.Idi = f.Idi - 1000;
            }
            else if (f.Idioma == "Francés")
            {
                //f.Frase = SF.Francés(f);
                f.Ident = "francés";
                f.NameArchive = "Fr";
                f.Idi = f.Idi - 4000;
            }
            else if (f.Idioma == "Portugués")
            {
                f.Frase = SF.Portugués(f);
                f.Ident = "portugués";
                f.NameArchive = "Pg";
                f.Idi = f.Idi - 2000;
            }
            else if (f.Idioma == "Italiano")
            {
                //f.Frase = SF.Italiano(f);
                f.Ident = "italiano";
                f.NameArchive = "It";
                f.Idi = f.Idi - 3000;
            }
            else if (f.Idioma == "Alemán")
            {
                //f.Frase = SF.Alemán(f);
                f.Ident = "alemán";
                f.NameArchive = "Al";
                f.Idi = f.Idi - 5000;
            }
            else if (f.Idioma == "Noruego")
            {
                //f.Frase = SF.Noruego(f);
                f.Ident = "noruego";
                f.NameArchive = "No";
                f.Idi = f.Idi - 6000;
            }

            string folderName = @"c:\ArchivosApp";

            string pathString = System.IO.Path.Combine(folderName, $"{f.Ident}");

            System.IO.Directory.CreateDirectory(pathString);

            string fileName = $"{f.NameArchive}-{f.Idi}.bin";

            pathString = System.IO.Path.Combine(pathString, fileName);

            using (System.IO.FileStream fs = new System.IO.FileStream(pathString, FileMode.Truncate))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    f.FraseExt = f.Letras.Length;
                    bw.Write(f.Frase);
                    bw.Write(f.Fuente);
                    bw.Write(f.FraseExt);
                    for (int i = 0; i < f.Letras.Length; i++)
                    {
                        bw.Write(f.Letras[i]);
                    }
                }
            }
        }
        public void ModificarBin(CE_Frases f)
        {
            CD_Frases ObjetoCD = new CD_Frases();

            string fras = f.Frase.ToLower();

            f.Fuente = Extended(f.Fuente);
            f.Letras = fras.ToArray();
            f = Simplificar(f);
            f.Letras = Remover(f.Letras);
            f.Letras = EliminarDuplicados(f.Letras);

            if (f.IdiomaID == 1)
            {
                f.Ident = "inglés";
                f.NameArchive = "In";
            }
            else if (f.IdiomaID == 2)
            {
                f.Ident = "español";
                f.NameArchive = "Es";
            }
            else if (f.IdiomaID == 3)
            {
                f.Ident = "francés";
                f.NameArchive = "Fr";
            }
            else if (f.IdiomaID == 4)
            {
                f.Ident = "alemán";
                f.NameArchive = "Al";
            }
            else if (f.IdiomaID == 5)
            {
                f.Ident = "portugués";
                f.NameArchive = "Pg";
            }
            else if (f.IdiomaID == 6)
            {
                f.Ident = "italiano";
                f.NameArchive = "It";
            }
            else if (f.IdiomaID == 7)
            {
                f.Ident = "noruego";
                f.NameArchive = "No";
            }

            string folderName = @"c:\ArchivosApp";

            string pathString = System.IO.Path.Combine(folderName, $"{f.Ident}");

            System.IO.Directory.CreateDirectory(pathString);

            string fileName = $"{f.NameArchive}-{f.Idi}.bin";

            pathString = System.IO.Path.Combine(pathString, fileName);

            using (System.IO.FileStream fs = new System.IO.FileStream(pathString, FileMode.Truncate))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    f.FraseExt = f.Letras.Length;
                    bw.Write(f.Frase);
                    bw.Write(f.Fuente);
                    bw.Write(f.FraseExt);
                    for (int i = 0; i < f.Letras.Length; i++)
                    {
                        bw.Write(f.Letras[i]);
                    }
                }
            }
        }
        public void Rebuild(CE_Frases f)
        {
            string fras = f.Frase.ToLower() + f.Fuente.ToLower();
            int u = (f.Idi % 10);

            f.Fuente = Extended(f.Fuente);
            f.Letras = fras.ToArray();
            f = Simplificar(f);
            f.Letras = Remover(f.Letras);
            f.Letras = EliminarDuplicados(f.Letras);

            if (f.IdiomaID == 1)
            {
                f.Ident = "inglés";
                f.NameArchive = "In";
            }
            else if (f.IdiomaID == 2)
            {
                f.Ident = "español";
                f.NameArchive = "Es";
            }
            else if (f.IdiomaID == 3)
            {
                f.Ident = "francés";
                f.NameArchive = "Fr";
            }
            else if (f.IdiomaID == 4)
            {
                f.Ident = "alemán";
                f.NameArchive = "Al";
            }
            else if (f.IdiomaID == 5)
            {
                f.Ident = "portugués";
                f.NameArchive = "Pg";
            }
            else if (f.IdiomaID == 6)
            {
                f.Ident = "italiano";
                f.NameArchive = "It";
            }
            else if (f.IdiomaID == 7)
            {
                f.Ident = "noruego";
                f.NameArchive = "No";
            }

            string folderName = @"c:\ArchivosApp";

            string pathString = System.IO.Path.Combine(folderName, $"{f.Ident}");

            System.IO.Directory.CreateDirectory(pathString);

            string fileName = $"{f.NameArchive}.txt";

            pathString = System.IO.Path.Combine(pathString, fileName);

            using (System.IO.FileStream fs = new System.IO.FileStream(pathString, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                {
                    f.FraseExt = f.Letras.Length;
                    string text = $"case {u}: f.Compuesto = \"{f.Frase}#{f.Fuente}#";
                    for (int i = 0; i < f.FraseExt; i++)
                    {
                        text += f.Letras[i];
                    }
                    text += $"#{f.Vocal}#{f.Consonante}";
                    text += "\"; break;";
                    sw.WriteLine(text);
                }
            }
        }
        public CE_Frases CargarFrase(CE_Frases f)
        {
            if (f.IdiomaID == 1)
            {
                f.Ident = "inglés";
                f.NameArchive = "In";
            }
            else if (f.IdiomaID == 2)
            {
                f.Ident = "español";
                f.NameArchive = "Es";
            }
            else if (f.IdiomaID == 3)
            {
                f.Ident = "francés";
                f.NameArchive = "Fr";
            }
            else if (f.IdiomaID == 4)
            {
                f.Ident = "alemán";
                f.NameArchive = "Al";
            }
            else if (f.IdiomaID == 5)
            {
                f.Ident = "portugués";
                f.NameArchive = "Pg";
            }
            else if (f.IdiomaID == 6)
            {
                f.Ident = "italiano";
                f.NameArchive = "It";
            }
            else if (f.IdiomaID == 7)
            {
                f.Ident = "noruego";
                f.NameArchive = "No";
            }
            string folderName = @"c:\ArchivosApp";

            string pathString = System.IO.Path.Combine(folderName, $"{f.Ident}");

            System.IO.Directory.CreateDirectory(pathString);

            string fileName = $"{f.NameArchive}-{f.Idi}.bin";

            pathString = System.IO.Path.Combine(pathString, fileName);
            using (System.IO.FileStream fs = new System.IO.FileStream(pathString, FileMode.Open))
            {
                fs.Position = 0;
                using (BinaryReader br = new BinaryReader(fs))
                {
                    f.Frase = br.ReadString();
                    f.Fuente = br.ReadString();
                    f.FraseExt = br.ReadInt32();
                    f.Letras = br.ReadChars(f.FraseExt);
                }
            }
            return f;
        }
        public DataTable ListarFrases()
        {
            DataTable frases = new DataTable();
            frases = ObjetoCD.ListarFrases();
            return frases;
        }
        public DataTable ListarFrasesIdioma(CE_Frases f)
        {
            DataTable frases = new DataTable();
            frases = ObjetoCD.ListarFrasesIdioma(f);
            return frases;
        }
        public DataTable ListarIdiomas()
        {
            DataTable idiomas = new DataTable();
            idiomas = ObjetoCD.ListarIdiomas();
            return idiomas;
        }
    }
}
