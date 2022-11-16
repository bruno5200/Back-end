using System.IO;
using System.Linq;
using CapaEntidades;


namespace CapaNegocio
{
    public class CN_Operaciones
    {
        int tamaño = 12, reduccion = 0;
        bool bandera = false;
        public void Operaciones(CE_Frases f)
        {
            string fras = f.Frase.ToLower(), sp = " ", str = string.Empty;
            if (f.IdiomaID == 1)
            {
                f.Frase = Inglés(f);
            }
            else if (f.IdiomaID == 2)
            {
                f.Frase = Español(f);
            }
            else if (f.IdiomaID == 3)
            {
                f.Frase = Francés(f);
            }
            else if (f.IdiomaID == 4)
            {
                f.Frase = Alemán(f);
            }
            else if (f.IdiomaID == 5)
            {
                f.Frase = Portugués(f);
            }
            else if (f.IdiomaID == 6)
            {
                //f.Frase = Italiano(f);
            }
            else if (f.IdiomaID == 7)
            {
                //f.Frase = Noruego(f);
            }
            str = string.Empty;
            f.Autor = f.Fuente.Split(' ').ToArray();
            for (int i = 0; i < f.Autor.Length; i++)
            {
                if (bandera == true)
                {
                    tamaño = 12 - reduccion;
                    bandera = false;
                }
                else
                {
                    tamaño = 12;
                }
                string s1 = f.Autor[i], s2, s3, s4;
                if (i == (f.Autor.Length - 1))
                {
                    if (s1.Length > tamaño)
                    {
                        s1 = AutLong(s1);
                    }
                    else if (s1.Length < tamaño)
                    {
                        s1 = Centreado(s1);
                    }
                    else if (tamaño < 12 && s1.Length < tamaño)
                    {
                        for (int j = 0; j < (tamaño - 12); j++)
                        {
                            s1 += sp;
                        }
                    }
                    else if (s1.Length != tamaño)
                    {

                    }
                }
                else if (i == (f.Autor.Length - 2))
                {
                    s2 = f.Autor[i + 1];
                    if ((s1.Length + s2.Length) <= (tamaño - 1))
                    {
                        s1 = s1 + sp + s2;
                        if (s1.Length < tamaño)
                            s1 = Centreado(s1);
                        ++i;
                    }
                    else if (s1.Length > tamaño)
                    {
                        s1 = AutLong(s1);
                    }
                    else if (s1.Length < tamaño)
                    {
                        s1 = Centreado(s1);
                    }
                    else if (s1.Length != tamaño)
                    {

                    }
                }
                else if (i == (f.Autor.Length - 3))
                {
                    s2 = f.Autor[i + 1];
                    s3 = f.Autor[i + 2];
                    if ((s1.Length + s2.Length + s3.Length) <= (tamaño - 2))
                    {
                        s1 = s1 + sp + s2 + sp + s3;
                        if (s1.Length != tamaño)
                            s1 = Centreado(s1);
                        i += 2;
                    }
                    else if ((s1.Length + s2.Length) <= (tamaño - 1))
                    {
                        s1 = s1 + sp + s2;
                        if (s1.Length != tamaño)
                            s1 = Centreado(s1);
                        ++i;
                    }
                    else if (s1.Length > tamaño)
                    {
                        s1 = AutLong(s1);
                    }
                    else if (s1.Length < tamaño && s1.Length >= 3)
                    {
                        s1 = Centreado(s1);
                    }
                    else if (s1.Length != tamaño)
                    {

                    }
                }
                else if (i <= (f.Autor.Length - 4))
                {
                    s2 = f.Autor[i + 1];
                    s3 = f.Autor[i + 2];
                    s4 = f.Autor[i + 3];
                    if ((s1.Length + s2.Length + s3.Length + s4.Length) <= (tamaño - 3))
                    {
                        s1 = s1 + sp + s2 + sp + s3 + sp + s4;
                        if (s1.Length != tamaño)
                            s1 = Centreado(s1);
                        i += 3;
                    }
                    else if ((s1.Length + s2.Length + s3.Length) <= (tamaño - 2))
                    {
                        s1 = s1 + sp + s2 + sp + s3;
                        if (s1.Length != tamaño)
                            s1 = Centreado(s1);
                        i += 2;
                    }
                    else if ((s1.Length + s2.Length) <= (tamaño - 1))
                    {
                        s1 = s1 + sp + s2;
                        if (s1.Length != tamaño)
                            s1 = Centreado(s1);
                        ++i;
                    }
                    else if (s1.Length > tamaño)
                    {
                        s1 = AutLong(s1);
                    }
                    else if (s1.Length < tamaño)
                    {
                        s1 = Centreado(s1);
                    }
                    else if (s1.Length != 12)
                    {

                    }
                }
                str += s1;
            }
            f.Fuente = str;
            f.Letras = fras.ToArray();
            f.Letras = EliminarDuplicados(f.Letras);
            if (f.Frase.Length + f.Fuente.Length <= 168)
            {
                //SaveFile(f);
            }
            else
            {

            }
            SaveFile(f);
        }
        public string Inglés(CE_Frases f)
        {
            string sp = " ", str = string.Empty;
            tamaño = 12; bandera = false;
            f.Palabras = f.Frase.Split(' ').ToArray();

            for (int i = 0; i < f.Palabras.Length; i++)
            {
                if (bandera == true)
                {
                    tamaño = 12 - reduccion;
                    bandera = false;
                }
                else
                {
                    tamaño = 12;
                }
                string s1 = f.Palabras[i], s2, s3, s4;
                if (i == (f.Palabras.Length - 1))
                {
                    if (s1.Length > tamaño)
                    {
                        s1 = Extense(s1);
                    }
                    else if (s1.Length < tamaño)
                    {
                        s1 = Centreado(s1);
                    }
                    else if (s1.Length != tamaño)
                    {

                    }
                }
                else if (i == (f.Palabras.Length - 2))
                {
                    s2 = f.Palabras[i + 1];
                    if ((s1.Length + s2.Length) <= (tamaño - 1))
                    {
                        s1 = s1 + sp + s2;
                        if (s1.Length < tamaño)
                            s1 = Centreado(s1);
                        ++i;
                    }
                    else if (s1.Length > tamaño)
                    {
                        if (s1.Length == (tamaño + 1) && (s1.EndsWith(",") || s1.EndsWith(".") || s1.EndsWith(".") || s1.EndsWith(";") || s1.EndsWith(":") || s1.EndsWith("?") || s1.EndsWith("!") || s1.EndsWith("\"") || s1.EndsWith("”") || s1.EndsWith("'") || s1.EndsWith("-")))
                        {
                            s1 += " ";
                            reduccion = 2; bandera = true;
                        }
                        else
                        {
                            s1 = Extense(s1);
                        }
                    }
                    else if (s1.Length < tamaño)
                    {
                        s1 = Centreado(s1);
                    }
                    else if (s1.Length != tamaño)
                    {

                    }
                }
                else if (i == (f.Palabras.Length - 3))
                {
                    s2 = f.Palabras[i + 1];
                    s3 = f.Palabras[i + 2];
                    if ((s1.Length + s2.Length + s3.Length) <= (tamaño - 2))
                    {
                        s1 = s1 + sp + s2 + sp + s3;
                        if (s1.Length != tamaño)
                            s1 = Centreado(s1);
                        i += 2;
                    }
                    else if ((s1.Length + s2.Length) <= (tamaño - 1))
                    {
                        s1 = s1 + sp + s2;
                        if (s1.Length != tamaño)
                            s1 = Centreado(s1);
                        ++i;
                    }
                    else if (s1.Length > tamaño)
                    {
                        if (s1.Length == (tamaño + 1) && (s1.EndsWith(",") || s1.EndsWith(".") || s1.EndsWith(".") || s1.EndsWith(";") || s1.EndsWith(":") || s1.EndsWith("?") || s1.EndsWith("!") || s1.EndsWith("\"") || s1.EndsWith("”") || s1.EndsWith("'") || s1.EndsWith("-")))
                        {
                            s1 += " ";
                            reduccion = 2; bandera = true;
                        }
                        else
                        {
                            s1 = Extense(s1);
                        }
                    }
                    else if (s1.Length < tamaño && s1.Length >= 3)
                    {
                        s1 = Centreado(s1);
                    }
                    else if (s1.Length != tamaño)
                    {
                        if (s1 == "AN" || s1 == "OF" || s1 == "BY")
                        {
                            s1 += " ";
                            reduccion = 3; bandera = true;
                        }
                    }
                }
                else if (i <= (f.Palabras.Length - 4))
                {
                    s2 = f.Palabras[i + 1];
                    s3 = f.Palabras[i + 2];
                    s4 = f.Palabras[i + 3];
                    if ((s1.Length + s2.Length + s3.Length + s4.Length) <= (tamaño - 3))
                    {
                        s1 = s1 + sp + s2 + sp + s3 + sp + s4;
                        if (s1.Length != tamaño)
                            s1 = Centreado(s1);
                        i += 3;
                    }
                    else if ((s1.Length + s2.Length + s3.Length) <= (tamaño - 2))
                    {
                        s1 = s1 + sp + s2 + sp + s3;
                        if (s1.Length != tamaño)
                            s1 = Centreado(s1);
                        i += 2;
                    }
                    else if ((s1.Length + s2.Length) <= (tamaño - 1))
                    {
                        s1 = s1 + sp + s2;
                        if (s1.Length != tamaño)
                            s1 = Centreado(s1);
                        ++i;
                    }
                    else if (s1.Length > tamaño)
                    {
                        if (s1.Length == (tamaño + 1) && (s1.EndsWith(",") || s1.EndsWith(".") || s1.EndsWith(".") || s1.EndsWith(";") || s1.EndsWith(":") || s1.EndsWith("?") || s1.EndsWith("!") || s1.EndsWith("\"") || s1.EndsWith("”") || s1.EndsWith("'") || s1.EndsWith("-")))
                        {
                            s1 += " ";
                            reduccion = 2; bandera = true;
                        }
                        else
                        {
                            s1 = Extense(s1);
                        }
                    }
                    else if (s1.Length < tamaño)
                    {
                        s1 = Centreado(s1);
                    }
                    else if (s1.Length != tamaño)
                    {

                    }
                }
                str += s1;
            }
            return str;
        }
        public string Español(CE_Frases f)
        {
            string sp = " ", str = string.Empty;
            tamaño = 12; bandera = false;
            f.Palabras = f.Frase.Split(' ').ToArray();
            for (int i = 0; i < f.Palabras.Length; i++)
            {
                if (bandera == true)
                {
                    tamaño = 12 - reduccion;
                    bandera = false;
                }
                else
                {
                    tamaño = 12;
                }
                string s1 = f.Palabras[i], s2, s3, s4;
                if (i == (f.Palabras.Length - 1))
                {
                    if (s1.Length > tamaño)
                    {
                        s1 = Extensivo(s1);
                    }
                    else if (s1.Length < tamaño)
                    {
                        s1 = Centreado(s1);
                    }
                    else if (s1.Length != tamaño)
                    {

                    }
                }
                else if (i == (f.Palabras.Length - 2))
                {
                    s2 = f.Palabras[i + 1];
                    if ((s1.Length + s2.Length) <= (tamaño - 1))
                    {
                        s1 = s1 + sp + s2;
                        if (s1.Length < tamaño)
                            s1 = Centreado(s1);
                        ++i;
                    }
                    else if (tamaño < 9 && s1.Length <= tamaño)
                    {
                        s1 = Centreado(s1);
                    }
                    else if (s1.Length < 4 && (s1.Length + s2.Length) > tamaño)
                    {
                        s1 = Silabas(s1, s2);
                        ++i;
                    }
                    else if (s1.Length > tamaño)
                    {
                        s1 = Extensivo(s1);
                    }
                    else if (s1.Length < tamaño)
                    {
                        s1 = Centreado(s1);
                    }
                    else if (s1.Length != tamaño)
                    {

                    }
                }
                else if (i == (f.Palabras.Length - 3))
                {
                    s2 = f.Palabras[i + 1];
                    s3 = f.Palabras[i + 2];
                    if ((s1.Length + s2.Length + s3.Length) <= (tamaño - 2))
                    {
                        s1 = s1 + sp + s2 + sp + s3;
                        if (s1.Length != tamaño)
                            s1 = Centreado(s1);
                        i += 2;
                    }
                    else if ((s1.Length + s2.Length) <= (tamaño - 1))
                    {
                        s1 = s1 + sp + s2;
                        if (s1.Length != tamaño)
                            s1 = Centreado(s1);
                        ++i;
                    }
                    else if (tamaño < 9 && s1.Length <= tamaño)
                    {
                        s1 = Centreado(s1);
                    }
                    else if (s1.Length < 4 && (s1.Length + s2.Length) > tamaño)
                    {
                        s1 = Silabas(s1, s2);
                        ++i;
                    }
                    else if (s1.Length > tamaño)
                    {
                        s1 = Extensivo(s1);
                    }
                    else if (s1.Length < tamaño && s1.Length >= 3)
                    {
                        s1 = Centreado(s1);
                    }
                    else if (s1.Length != tamaño)
                    {

                    }
                }
                else if (i <= (f.Palabras.Length - 4))
                {
                    s2 = f.Palabras[i + 1];
                    s3 = f.Palabras[i + 2];
                    s4 = f.Palabras[i + 3];
                    if ((s1.Length + s2.Length + s3.Length + s4.Length) <= (tamaño - 3))
                    {
                        s1 = s1 + sp + s2 + sp + s3 + sp + s4;
                        if (s1.Length != tamaño)
                            s1 = Centreado(s1);
                        i += 3;
                    }
                    else if ((s1.Length + s2.Length + s3.Length) <= (tamaño - 2))
                    {
                        s1 = s1 + sp + s2 + sp + s3;
                        if (s1.Length != tamaño)
                            s1 = Centreado(s1);
                        i += 2;
                    }
                    else if ((s1.Length + s2.Length) <= (tamaño - 1))
                    {
                        s1 = s1 + sp + s2;
                        if (s1.Length != tamaño)
                            s1 = Centreado(s1);
                        ++i;
                    }
                    else if (tamaño < 9 && s1.Length <= tamaño)
                    {
                        s1 = Centreado(s1);
                    }
                    else if (s1.Length < 4 && (s1.Length + s2.Length) > tamaño)
                    {
                        s1 = Silabas(s1, s2);
                        ++i;
                    }
                    else if (s1.Length > tamaño)
                    {
                        s1 = Extensivo(s1);
                    }
                    else if (s1.Length < tamaño && s1.Length > 3)
                    {
                        s1 = Centreado(s1);
                    }
                    else if (s1.Length != 12)
                    {

                    }
                }
                str += s1;
            }
            return str;
        }
        public string Francés(CE_Frases f)
        {
            string sp = " ", str = string.Empty;
            tamaño = 12; bandera = false;
            f.Palabras = f.Frase.Split(' ').ToArray();

            for (int i = 0; i < f.Palabras.Length; i++)
            {
                if (bandera == true)
                {
                    tamaño = 12 - reduccion;
                    bandera = false;
                }
                else
                {
                    tamaño = 12;
                }
                string s1 = f.Palabras[i], s2, s3, s4;
                if (i == (f.Palabras.Length - 1))
                {
                    if (s1.Length > tamaño)
                    {
                        //s1 = Estesiu(s1);
                        reduccion = s1.Length - 12; bandera = true;
                    }
                    else if (s1.Length < tamaño)
                    {
                        s1 = Centreado(s1);
                    }
                    else if (s1.Length == tamaño)
                    {
                        s1 += sp;
                        reduccion = 1; bandera = true;
                    }
                    else if (s1.Length != tamaño)
                    {

                    }
                }
                else if (i == (f.Palabras.Length - 2))
                {
                    s2 = f.Palabras[i + 1];
                    if ((s1.Length + s2.Length) <= (tamaño - 1))
                    {
                        s1 = s1 + sp + s2 + sp;
                        if (s1.Length < tamaño)
                            s1 = Centreado(s1);
                        else if (s1.Length > tamaño)
                            reduccion = 1; bandera = true;
                        ++i;
                    }
                    else if (s1.Length > tamaño)
                    {
                        if (s1.Length == (tamaño + 1) && (s1.EndsWith(",") || s1.EndsWith(".") || s1.EndsWith(".") || s1.EndsWith(";") || s1.EndsWith(":") || s1.EndsWith("?") || s1.EndsWith("!") || s1.EndsWith("\"") || s1.EndsWith("”") || s1.EndsWith("'") || s1.EndsWith("-")))
                        {
                            s1 += " ";
                            reduccion = 2; bandera = true;
                        }
                        else
                        {
                            //s1 = Estesiu(s1);
                            reduccion = s1.Length - 12; bandera = true;
                        }
                    }
                    else if (s1.Length < tamaño)
                    {
                        s1 = Centreado(s1);
                    }
                    else if (s1.Length == tamaño)
                    {
                        s1 += sp;
                        reduccion = 1; bandera = true;
                    }
                    else if (s1.Length != tamaño)
                    {

                    }
                }
                else if (i == (f.Palabras.Length - 3))
                {
                    s2 = f.Palabras[i + 1];
                    s3 = f.Palabras[i + 2];
                    if ((s1.Length + s2.Length + s3.Length) <= (tamaño - 2))
                    {
                        s1 = s1 + sp + s2 + sp + s3 + sp;
                        if (s1.Length != tamaño)
                            s1 = Centreado(s1);
                        else if (s1.Length > tamaño)
                            reduccion = 1; bandera = true;
                        i += 2;
                    }
                    else if ((s1.Length + s2.Length) <= (tamaño - 1))
                    {
                        s1 = s1 + sp + s2 + sp;
                        if (s1.Length != tamaño)
                            s1 = Centreado(s1);
                        else if (s1.Length > tamaño)
                            reduccion = 1; bandera = true;
                        ++i;
                    }
                    else if (s1.Length > tamaño)
                    {
                        if (s1.Length == (tamaño + 1) && (s1.EndsWith(",") || s1.EndsWith(".") || s1.EndsWith(".") || s1.EndsWith(";") || s1.EndsWith(":") || s1.EndsWith("?") || s1.EndsWith("!") || s1.EndsWith("\"") || s1.EndsWith("”") || s1.EndsWith("'") || s1.EndsWith("-")))
                        {
                            s1 += " ";
                            reduccion = 2; bandera = true;
                        }
                        else
                        {
                            //s1 = Estesiu(s1);
                            reduccion = s1.Length - 12; bandera = true;
                        }
                    }
                    else if (s1.Length < tamaño && s1.Length >= 3)
                    {
                        s1 = Centreado(s1);
                    }
                    else if (s1.Length == tamaño)
                    {
                        s1 += sp;
                        reduccion = 1; bandera = true;
                    }
                    else if (s1.Length != tamaño)
                    {

                    }
                }
                else if (i <= (f.Palabras.Length - 4))
                {
                    s2 = f.Palabras[i + 1];
                    s3 = f.Palabras[i + 2];
                    s4 = f.Palabras[i + 3];
                    if ((s1.Length + s2.Length + s3.Length + s4.Length) <= (tamaño - 3))
                    {
                        s1 = s1 + sp + s2 + sp + s3 + sp + s4 + sp;
                        if (s1.Length < tamaño)
                            s1 = Centreado(s1);
                        else if (s1.Length > tamaño)
                            reduccion = 1; bandera = true;
                        i += 3;
                    }
                    else if ((s1.Length + s2.Length + s3.Length) <= (tamaño - 2))
                    {
                        s1 = s1 + sp + s2 + sp + s3 + sp;
                        if (s1.Length < tamaño)
                            s1 = Centreado(s1);
                        else if (s1.Length > tamaño)
                            reduccion = 1; bandera = true;
                        i += 2;
                    }
                    else if ((s1.Length + s2.Length) <= (tamaño - 1))
                    {
                        s1 = s1 + sp + s2 + sp;
                        if (s1.Length != tamaño)
                            s1 = Centreado(s1);
                        else if (s1.Length > tamaño)
                            reduccion = 1; bandera = true;
                        ++i;
                    }
                    else if (s1.Length > tamaño)
                    {
                        if (s1.Length == (tamaño + 1) && (s1.EndsWith(",") || s1.EndsWith(".") || s1.EndsWith(".") || s1.EndsWith(";") || s1.EndsWith(":") || s1.EndsWith("?") || s1.EndsWith("!") || s1.EndsWith("\"") || s1.EndsWith("”") || s1.EndsWith("'") || s1.EndsWith("-")))
                        {
                            s1 += " ";
                            reduccion = 2; bandera = true;
                        }
                        else
                        {
                            //s1 = Extensiu(s1);
                            reduccion = s1.Length - 12; bandera = true;
                        }
                    }
                    else if (s1.Length < tamaño)
                    {
                        s1 = Centreado(s1);
                    }
                    else if (s1.Length == tamaño)
                    {
                        s1 += sp;
                        reduccion = 1; bandera = true;
                    }
                    else if (s1.Length != 12)
                    {

                    }
                }
                str += s1;
            }
            return str;
        }
        public string Alemán(CE_Frases f)
        {
            string sp = " ", str = string.Empty;
            tamaño = 12; bandera = false;
            f.Palabras = f.Frase.Split(' ').ToArray();

            for (int i = 0; i < f.Palabras.Length; i++)
            {
                if (bandera == true)
                {
                    tamaño = 12 - reduccion;
                    bandera = false;
                }
                else
                {
                    tamaño = 12;
                }
                string s1 = f.Palabras[i], s2, s3, s4;
                if (i == (f.Palabras.Length - 1))
                {
                    if (s1.Length > tamaño)
                    {
                        //s1 = Estesire(s1);
                        reduccion = s1.Length - 12; bandera = true;
                    }
                    else if (s1.Length < tamaño)
                    {
                        s1 = Centreado(s1);
                    }
                    else if (s1.Length == tamaño)
                    {
                        s1 += sp;
                        reduccion = 1; bandera = true;
                    }
                    else if (s1.Length != tamaño)
                    {

                    }
                }
                else if (i == (f.Palabras.Length - 2))
                {
                    s2 = f.Palabras[i + 1];
                    if ((s1.Length + s2.Length) <= (tamaño - 1))
                    {
                        s1 = s1 + sp + s2 + sp;
                        if (s1.Length < tamaño)
                            s1 = Centreado(s1);
                        else if (s1.Length > tamaño)
                            reduccion = 1; bandera = true;
                        ++i;
                    }
                    else if (s1.Length > tamaño)
                    {
                        if (s1.Length == (tamaño + 1) && (s1.EndsWith(",") || s1.EndsWith(".") || s1.EndsWith(".") || s1.EndsWith(";") || s1.EndsWith(":") || s1.EndsWith("?") || s1.EndsWith("!") || s1.EndsWith("\"") || s1.EndsWith("”") || s1.EndsWith("'") || s1.EndsWith("-")))
                        {
                            s1 += " ";
                            reduccion = 2; bandera = true;
                        }
                        else
                        {
                            //s1 = Estesire(s1);
                            reduccion = s1.Length - 12; bandera = true;
                        }
                    }
                    else if (s1.Length < tamaño)
                    {
                        s1 = Centreado(s1);
                    }
                    else if (s1.Length == tamaño)
                    {
                        s1 += sp;
                        reduccion = 1; bandera = true;
                    }
                    else if (s1.Length != tamaño)
                    {

                    }
                }
                else if (i == (f.Palabras.Length - 3))
                {
                    s2 = f.Palabras[i + 1];
                    s3 = f.Palabras[i + 2];
                    if ((s1.Length + s2.Length + s3.Length) <= (tamaño - 2))
                    {
                        s1 = s1 + sp + s2 + sp + s3 + sp;
                        if (s1.Length != tamaño)
                            s1 = Centreado(s1);
                        else if (s1.Length > tamaño)
                            reduccion = 1; bandera = true;
                        i += 2;
                    }
                    else if ((s1.Length + s2.Length) <= (tamaño - 1))
                    {
                        s1 = s1 + sp + s2 + sp;
                        if (s1.Length != tamaño)
                            s1 = Centreado(s1);
                        else if (s1.Length > tamaño)
                            reduccion = 1; bandera = true;
                        ++i;
                    }
                    else if (s1.Length > tamaño)
                    {
                        if (s1.Length == (tamaño + 1) && (s1.EndsWith(",") || s1.EndsWith(".") || s1.EndsWith(".") || s1.EndsWith(";") || s1.EndsWith(":") || s1.EndsWith("?") || s1.EndsWith("!") || s1.EndsWith("\"") || s1.EndsWith("”") || s1.EndsWith("'") || s1.EndsWith("-")))
                        {
                            s1 += " ";
                            reduccion = 2; bandera = true;
                        }
                        else
                        {
                            //s1 = Estesire(s1);
                            reduccion = s1.Length - 12; bandera = true;
                        }
                    }
                    else if (s1.Length < tamaño && s1.Length >= 3)
                    {
                        s1 = Centreado(s1);
                    }
                    else if (s1.Length == tamaño)
                    {
                        s1 += sp;
                        reduccion = 1; bandera = true;
                    }
                    else if (s1.Length != tamaño)
                    {

                    }
                }
                else if (i <= (f.Palabras.Length - 4))
                {
                    s2 = f.Palabras[i + 1];
                    s3 = f.Palabras[i + 2];
                    s4 = f.Palabras[i + 3];
                    if ((s1.Length + s2.Length + s3.Length + s4.Length) <= (tamaño - 3))
                    {
                        s1 = s1 + sp + s2 + sp + s3 + sp + s4 + sp;
                        if (s1.Length < tamaño)
                            s1 = Centreado(s1);
                        else if (s1.Length > tamaño)
                            reduccion = 1; bandera = true;
                        i += 3;
                    }
                    else if ((s1.Length + s2.Length + s3.Length) <= (tamaño - 2))
                    {
                        s1 = s1 + sp + s2 + sp + s3 + sp;
                        if (s1.Length < tamaño)
                            s1 = Centreado(s1);
                        else if (s1.Length > tamaño)
                            reduccion = 1; bandera = true;
                        i += 2;
                    }
                    else if ((s1.Length + s2.Length) <= (tamaño - 1))
                    {
                        s1 = s1 + sp + s2 + sp;
                        if (s1.Length != tamaño)
                            s1 = Centreado(s1);
                        else if (s1.Length > tamaño)
                            reduccion = 1; bandera = true;
                        ++i;
                    }
                    else if (s1.Length > tamaño)
                    {
                        if (s1.Length == (tamaño + 1) && (s1.EndsWith(",") || s1.EndsWith(".") || s1.EndsWith(".") || s1.EndsWith(";") || s1.EndsWith(":") || s1.EndsWith("?") || s1.EndsWith("!") || s1.EndsWith("\"") || s1.EndsWith("”") || s1.EndsWith("'") || s1.EndsWith("-")))
                        {
                            s1 += " ";
                            reduccion = 2; bandera = true;
                        }
                        else
                        {
                            //s1 = Extensire(s1);
                            reduccion = s1.Length - 12; bandera = true;
                        }
                    }
                    else if (s1.Length < tamaño)
                    {
                        s1 = Centreado(s1);
                    }
                    else if (s1.Length == tamaño)
                    {
                        s1 += sp;
                        reduccion = 1; bandera = true;
                    }
                    else if (s1.Length != 12)
                    {

                    }
                }
                str += s1;
            }
            return str;
        }
        public string Portugués(CE_Frases f)
        {
            string sp = " ", str = string.Empty;
            tamaño = 11; bandera = false;
            f.Palabras = f.Frase.Split(' ').ToArray();

            for (int i = 0; i < f.Palabras.Length; i++)
            {
                if (bandera == true)
                {
                    tamaño = 11 - reduccion;
                    bandera = false;
                }
                else
                {
                    tamaño = 11;
                }
                string s1 = f.Palabras[i], s2, s3, s4;
                if (i == (f.Palabras.Length - 1))
                {
                    if (s1.Length > tamaño)
                    {
                        //s1 = Extensao(s1);
                        reduccion = s1.Length - 11; bandera = true;
                    }
                    else if (s1.Length < tamaño)
                    {
                        s1 = Centreado(s1);
                    }
                    else if (s1.Length != tamaño)
                    {

                    }
                }
                else if (i == (f.Palabras.Length - 2))
                {
                    s2 = f.Palabras[i + 1];
                    if ((s1.Length + s2.Length) <= (tamaño - 1))
                    {
                        s1 = s1 + sp + s2;
                        if (s1.Length < tamaño)
                            s1 = Centreado(s1);
                        ++i;
                    }
                    else if (s1.Length > tamaño)
                    {
                        if (s1.Length == (tamaño + 1) && (s1.EndsWith(",") || s1.EndsWith(".") || s1.EndsWith(".") || s1.EndsWith(";") || s1.EndsWith(":") || s1.EndsWith("?") || s1.EndsWith("!") || s1.EndsWith("\"") || s1.EndsWith("”") || s1.EndsWith("'") || s1.EndsWith("-")))
                        {
                            s1 += " ";
                            reduccion = 2; bandera = true;
                        }
                        else
                        {
                            //s1 = Extensao(s1);
                            reduccion = s1.Length - 11; bandera = true;
                        }
                    }
                    else if (s1.Length < tamaño)
                    {
                        s1 = Centreado(s1);
                    }
                    else if (s1.Length != tamaño)
                    {

                    }
                }
                else if (i == (f.Palabras.Length - 3))
                {
                    s2 = f.Palabras[i + 1];
                    s3 = f.Palabras[i + 2];
                    if ((s1.Length + s2.Length + s3.Length) <= (tamaño - 2))
                    {
                        s1 = s1 + sp + s2 + sp + s3;
                        if (s1.Length != tamaño)
                            s1 = Centreado(s1);
                        i += 2;
                    }
                    else if ((s1.Length + s2.Length) <= (tamaño - 1))
                    {
                        s1 = s1 + sp + s2;
                        if (s1.Length != tamaño)
                            s1 = Centreado(s1);
                        ++i;
                    }
                    else if (s1.Length > tamaño)
                    {
                        if (s1.Length == (tamaño + 1) && (s1.EndsWith(",") || s1.EndsWith(".") || s1.EndsWith(".") || s1.EndsWith(";") || s1.EndsWith(":") || s1.EndsWith("?") || s1.EndsWith("!") || s1.EndsWith("\"") || s1.EndsWith("”") || s1.EndsWith("'") || s1.EndsWith("-")))
                        {
                            s1 += " ";
                            reduccion = 2; bandera = true;
                        }
                        else
                        {
                            //s1 = Extensao(s1);
                            reduccion = s1.Length - 11; bandera = true;
                        }
                    }
                    else if (s1.Length < tamaño && s1.Length >= 3)
                    {
                        s1 = Centreado(s1);
                    }
                    else if (s1.Length != tamaño)
                    {

                    }
                }
                else if (i <= (f.Palabras.Length - 4))
                {
                    s2 = f.Palabras[i + 1];
                    s3 = f.Palabras[i + 2];
                    s4 = f.Palabras[i + 3];
                    if ((s1.Length + s2.Length + s3.Length + s4.Length) <= (tamaño - 3))
                    {
                        s1 = s1 + sp + s2 + sp + s3 + sp + s4;
                        if (s1.Length != tamaño)
                            s1 = Centreado(s1);
                        i += 3;
                    }
                    else if ((s1.Length + s2.Length + s3.Length) <= (tamaño - 2))
                    {
                        s1 = s1 + sp + s2 + sp + s3;
                        if (s1.Length != tamaño)
                            s1 = Centreado(s1);
                        i += 2;
                    }
                    else if ((s1.Length + s2.Length) <= (tamaño - 1))
                    {
                        s1 = s1 + sp + s2;
                        if (s1.Length != tamaño)
                            s1 = Centreado(s1);
                        ++i;
                    }
                    else if (s1.Length > tamaño)
                    {
                        if (s1.Length == (tamaño + 1) && (s1.EndsWith(",") || s1.EndsWith(".") || s1.EndsWith(".") || s1.EndsWith(";") || s1.EndsWith(":") || s1.EndsWith("?") || s1.EndsWith("!") || s1.EndsWith("\"") || s1.EndsWith("”") || s1.EndsWith("'") || s1.EndsWith("-")))
                        {
                            s1 += " ";
                            reduccion = 2; bandera = true;
                        }
                        else
                        {
                            //s1 = Extensao(s1);
                            reduccion = s1.Length - 11; bandera = true;
                        }
                    }
                    else if (s1.Length < tamaño)
                    {
                        s1 = Centreado(s1);
                    }
                    else if (s1.Length != 12)
                    {

                    }
                }
                str += s1 + sp;
            }
            return str;
        }
        public string Italiano(CE_Frases f)
        {
            string sp = " ", str = string.Empty;
            tamaño = 12; bandera = false;
            f.Palabras = f.Frase.Split(' ').ToArray();

            for (int i = 0; i < f.Palabras.Length; i++)
            {
                if (bandera == true)
                {
                    tamaño = 12 - reduccion;
                    bandera = false;
                }
                else
                {
                    tamaño = 12;
                }
                string s1 = f.Palabras[i], s2, s3, s4;
                if (i == (f.Palabras.Length - 1))
                {
                    if (s1.Length > tamaño)
                    {
                        //s1 = Esteso(s1);
                        reduccion = s1.Length - 12; bandera = true;
                    }
                    else if (s1.Length < tamaño)
                    {
                        s1 = Centreado(s1);
                    }
                    else if (s1.Length == tamaño)
                    {
                        s1 += sp;
                        reduccion = 1; bandera = true;
                    }
                    else if (s1.Length != tamaño)
                    {

                    }
                }
                else if (i == (f.Palabras.Length - 2))
                {
                    s2 = f.Palabras[i + 1];
                    if ((s1.Length + s2.Length) <= (tamaño - 1))
                    {
                        s1 = s1 + sp + s2 + sp;
                        if (s1.Length < tamaño)
                            s1 = Centreado(s1);
                        else if (s1.Length > tamaño)
                            reduccion = 1; bandera = true;
                        ++i;
                    }
                    else if (s1.Length > tamaño)
                    {
                        if (s1.Length == (tamaño + 1) && (s1.EndsWith(",") || s1.EndsWith(".") || s1.EndsWith(".") || s1.EndsWith(";") || s1.EndsWith(":") || s1.EndsWith("?") || s1.EndsWith("!") || s1.EndsWith("\"") || s1.EndsWith("”") || s1.EndsWith("'") || s1.EndsWith("-")))
                        {
                            s1 += " ";
                            reduccion = 2; bandera = true;
                        }
                        else
                        {
                            //s1 = Esteso(s1);
                            reduccion = s1.Length - 12; bandera = true;
                        }
                    }
                    else if (s1.Length < tamaño)
                    {
                        s1 = Centreado(s1);
                    }
                    else if (s1.Length == tamaño)
                    {
                        s1 += sp;
                        reduccion = 1; bandera = true;
                    }
                    else if (s1.Length != tamaño)
                    {

                    }
                }
                else if (i == (f.Palabras.Length - 3))
                {
                    s2 = f.Palabras[i + 1];
                    s3 = f.Palabras[i + 2];
                    if ((s1.Length + s2.Length + s3.Length) <= (tamaño - 2))
                    {
                        s1 = s1 + sp + s2 + sp + s3 + sp;
                        if (s1.Length != tamaño)
                            s1 = Centreado(s1);
                        else if (s1.Length > tamaño)
                            reduccion = 1; bandera = true;
                        i += 2;
                    }
                    else if ((s1.Length + s2.Length) <= (tamaño - 1))
                    {
                        s1 = s1 + sp + s2 + sp;
                        if (s1.Length != tamaño)
                            s1 = Centreado(s1);
                        else if (s1.Length > tamaño)
                            reduccion = 1; bandera = true;
                        ++i;
                    }
                    else if (s1.Length > tamaño)
                    {
                        if (s1.Length == (tamaño + 1) && (s1.EndsWith(",") || s1.EndsWith(".") || s1.EndsWith(".") || s1.EndsWith(";") || s1.EndsWith(":") || s1.EndsWith("?") || s1.EndsWith("!") || s1.EndsWith("\"") || s1.EndsWith("”") || s1.EndsWith("'") || s1.EndsWith("-")))
                        {
                            s1 += " ";
                            reduccion = 2; bandera = true;
                        }
                        else
                        {
                            //s1 = Esteso(s1);
                            reduccion = s1.Length - 12; bandera = true;
                        }
                    }
                    else if (s1.Length < tamaño && s1.Length >= 3)
                    {
                        s1 = Centreado(s1);
                    }
                    else if (s1.Length == tamaño)
                    {
                        s1 += sp;
                        reduccion = 1; bandera = true;
                    }
                    else if (s1.Length != tamaño)
                    {

                    }
                }
                else if (i <= (f.Palabras.Length - 4))
                {
                    s2 = f.Palabras[i + 1];
                    s3 = f.Palabras[i + 2];
                    s4 = f.Palabras[i + 3];
                    if ((s1.Length + s2.Length + s3.Length + s4.Length) <= (tamaño - 3))
                    {
                        s1 = s1 + sp + s2 + sp + s3 + sp + s4 + sp;
                        if (s1.Length < tamaño)
                            s1 = Centreado(s1);
                        else if (s1.Length > tamaño)
                            reduccion = 1; bandera = true;
                        i += 3;
                    }
                    else if ((s1.Length + s2.Length + s3.Length) <= (tamaño - 2))
                    {
                        s1 = s1 + sp + s2 + sp + s3 + sp;
                        if (s1.Length < tamaño)
                            s1 = Centreado(s1);
                        else if (s1.Length > tamaño)
                            reduccion = 1; bandera = true;
                        i += 2;
                    }
                    else if ((s1.Length + s2.Length) <= (tamaño - 1))
                    {
                        s1 = s1 + sp + s2 + sp;
                        if (s1.Length != tamaño)
                            s1 = Centreado(s1);
                        else if (s1.Length > tamaño)
                            reduccion = 1; bandera = true;
                        ++i;
                    }
                    else if (s1.Length > tamaño)
                    {
                        if (s1.Length == (tamaño + 1) && (s1.EndsWith(",") || s1.EndsWith(".") || s1.EndsWith(".") || s1.EndsWith(";") || s1.EndsWith(":") || s1.EndsWith("?") || s1.EndsWith("!") || s1.EndsWith("\"") || s1.EndsWith("”") || s1.EndsWith("'") || s1.EndsWith("-")))
                        {
                            s1 += " ";
                            reduccion = 2; bandera = true;
                        }
                        else
                        {
                            //s1 = Extensao(s1);
                            reduccion = s1.Length - 12; bandera = true;
                        }
                    }
                    else if (s1.Length < tamaño)
                    {
                        s1 = Centreado(s1);
                    }
                    else if (s1.Length == tamaño)
                    {
                        s1 += sp;
                        reduccion = 1; bandera = true;
                    }
                    else if (s1.Length != 12)
                    {

                    }
                }
                str += s1;
            }
            return str;
        }
        public string Noruego(CE_Frases f)
        {
            string sp = " ", str = string.Empty;
            return str;
        }
        public string AutLong(string text)
        {
            int l = text.Length;
            string text2 = string.Empty;

            if (text.EndsWith("CLÉOPÂTRE-SHAKESPEARE") || text.EndsWith("null"))
            {
                text2 = Centreado(text.Substring((l - 11), 11));
                text = Centreado(text.Substring(0, (l - 11))) + text2;
            }
            else if (text.EndsWith("MORENO-CANTINFLAS") || text.EndsWith("MARIE-ANTOINETTE,") || text.EndsWith("null"))
            {
                text2 = Centreado(text.Substring((l - 10), 10));
                text = Centreado(text.Substring(0, (l - 10))) + text2;
            }
            else if (text.EndsWith("JEAN-SÉBASTIEN"))
            {
                text2 = Centreado(text.Substring((l - 9), 9));
                text = Centreado(text.Substring(0, (l - 9))) + text2;
            }
            else if (text.EndsWith("AROUET-VOLTAIRE") || text.EndsWith("JEAN-BAPTISTE") || text.EndsWith("TALLEYRAND-PÉRIGORD") || text.EndsWith("CHARLES-AUGUSTIN"))
            {
                text2 = Centreado(text.Substring((l - 8), 8));
                text = Centreado(text.Substring(0, (l - 8))) + text2;
            }
            else if (text.EndsWith("SANTOS-DUMONT"))
            {
                text2 = Centreado(text.Substring((l - 6), 6));
                text = Centreado(text.Substring(0, (l - 6))) + text2;
            }
            else if (text.EndsWith("FRANÇOIS-MARIE"))
            {
                text2 = Centreado(text.Substring((l - 5), 5));
                text = Centreado(text.Substring(0, (l - 5))) + text2;
            }
            else if (text.EndsWith("JEANNERET-GRIS") || text.EndsWith("LEVI-MONTALCINI"))
            {
                text2 = Centreado(text.Substring((l - 4), 4));
                text = Centreado(text.Substring(0, (l - 4))) + text2;
            }
            else if (text.EndsWith("SAINT-EXUPERY") || text.EndsWith("SAINT-EXUPÉRY") || text.EndsWith("CHARLES-EDOUARD") || text.EndsWith("TOULOUSE-LAUTREC") || text.EndsWith("CHARLES-MAURICE") || text.EndsWith("GRABAR-KITAROVIC"))
            {
                text2 = Centreado(text.Substring((l - 7), 7));
                text = Centreado(text.Substring(0, (l - 7))) + text2;
            }
            else if (text.EndsWith("ROCHEFOUCAULD"))
            {
                text2 = Centreado(text.Substring((l - 5), 5));
                text = Centreado(text.Substring(0, (l - 5))) + text2;
            }
            else if (text.EndsWith("PROVÉRBIO") || text.EndsWith("ARTHUR") || text.EndsWith("WINSTON") || text.EndsWith("EUGÉNE") || text.EndsWith("ALEXANDER") || text.EndsWith("GIOVANNI"))
            {
                text2 = Centreado(" ");
                text = text2 + Centreado(text);
            }
            else
            {

            }
            return text;
        }
        public string Silabas(string text, string text2)
        {
            string sp = " ";
            //regla el maximo de extensión que puede teneer el texto 2 es = 9 + exedente 
            if (text.Length + text2.Length == (tamaño) && (text2.EndsWith(",") || text2.EndsWith(".") || text2.EndsWith(".") || text2.EndsWith(";") || text2.EndsWith(":") || text2.EndsWith("?") || text2.EndsWith("!") || text2.EndsWith("\"") || text2.EndsWith("”") || text2.EndsWith("'") || text2.EndsWith("-")))
            {
                text = text + sp + text2 + sp;
                reduccion = 2; bandera = true;
            }
            else if (text.Length == 1)
            {
                if (text2.EndsWith("MENTE") && text2.Length > (tamaño))
                {
                    text = text + sp + text2.Substring(0, (text2.Length - 5)) + "-";
                    if (text.Length < tamaño)
                        text = Centreado(text);
                    text2 = text2.Substring((text2.Length - 5), 5) + sp;
                    text += text2;
                    reduccion = 6; bandera = true;
                }
                else if (text2.EndsWith("TIRSE") || text2.EndsWith("TIRSE") || text2.EndsWith("TIVAS") && text2.Length < (tamaño + 3))
                {
                    text = text + sp + text2.Substring(0, (text2.Length - 5)) + "-";
                    if (text.Length < tamaño)
                        text = Centreado(text);
                    text2 = text2.Substring((text2.Length - 5), 5) + sp;
                    text += text2;
                    reduccion = 6; bandera = true;
                }
                else if (text2.EndsWith("LLADOS,"))
                {
                    text = text + sp + text2.Substring(0, (text2.Length - 7)) + "-";
                    if (text.Length < tamaño)
                        text = Centreado(text);
                    text2 = text2.Substring(text2.Length - 7, 7) + sp;
                    text += text2;
                    reduccion = 8; bandera = true;
                }
                else if (text2.EndsWith("DER") && tamaño < 12)
                {
                    text = text + sp + text2.Substring(0, (text2.Length - 3)) + "-";
                    if (text.Length < tamaño)
                        text = Centreado(text);
                    text2 = text2.Substring(text2.Length - 3, 3) + sp;
                    text += text2;
                    reduccion = 4; bandera = true;
                }
                else if (text2.EndsWith("BAJO") && tamaño < 12)
                {
                    text = text + sp + text2.Substring(0, (text2.Length - 4)) + "-";
                    if (text.Length < tamaño)
                        text = Centreado(text);
                    text2 = text2.Substring(text2.Length - 4, 4) + sp;
                    text += text2;
                    reduccion = 5; bandera = true;
                }
                else if (text2.EndsWith("DIENTE") && tamaño < 12)
                {
                    text = text + sp + text2.Substring(0, (text2.Length - 6)) + "-";
                    if (text.Length < tamaño)
                        text = Centreado(text);
                    text2 = text2.Substring(text2.Length - 6, 6) + sp;
                    text += text2;
                    reduccion = 7; bandera = true;
                }

                else
                {

                }
            }
            else if (text.Length == 2)
            {
                //regla el maximo de extensión que puede teneer el texto 2 es = 8 + exedente 
                if (text2.EndsWith("ZA") || text2.EndsWith("NA") || text2.EndsWith("DO") || text2.EndsWith("TE") || text2.EndsWith("RA") && text2.Length < tamaño)
                {
                    text = text + sp + text2.Substring(0, (text2.Length - 2)) + "-";
                    if (text.Length < tamaño)
                        text = Centreado(text);
                    text2 = text2.Substring((text2.Length - 2), 2) + sp;
                    text += text2;
                    reduccion = 3; bandera = true;
                }
                else if (text2.EndsWith("MENTE") || text2.EndsWith("METEN") && (text2.Length - 2) < tamaño)
                {
                    text = text + sp + text2.Substring(0, (text2.Length - 5)) + "-";
                    if (text.Length < tamaño)
                        text = Centreado(text);
                    text2 = text2.Substring((text2.Length - 5), 5) + sp;
                    text += text2;
                    reduccion = 6; bandera = true;
                }
                else if (text2.EndsWith("ESTAMOS") && tamaño < 8)// no mover de encima de este por la exepción MOS
                {
                    text = Centreado(text);
                    text2 = Completado(text2);
                    text += text2;
                }
                else if (text2.EndsWith("CIA") || text2.EndsWith("TAD") || text2.EndsWith("DAD") || text2.EndsWith("BLE") || text2.EndsWith("TES") || text2.EndsWith("ZA,") || text2.EndsWith("MOS") || text2.EndsWith("LLO") || text2.EndsWith("RIA") || text2.EndsWith("RIO") || text2.EndsWith("CER") && text2.Length < tamaño)
                {
                    text = text + sp + text2.Substring(0, (text2.Length - 3)) + "-";
                    if (text.Length < tamaño)
                        text = Centreado(text);
                    text2 = text2.Substring((text2.Length - 3), 3) + sp;
                    text += text2;
                    reduccion = 4; bandera = true;
                }
                else if (text2.EndsWith("DAD.") || text2.EndsWith("CIA,") || text2.EndsWith("DAD,") || text2.EndsWith("CIÓN") || text2.EndsWith("SIÓN") || text2.EndsWith("ZAJE") || text2.EndsWith("GUEN") && text2.Length < tamaño + 1)
                {
                    text = text + sp + text2.Substring(0, (text2.Length - 4)) + "-";
                    if (text.Length < tamaño)
                        text = Centreado(text);
                    text2 = text2.Substring((text2.Length - 4), 4) + sp;
                    text += text2;
                    reduccion = 5; bandera = true;
                }
                else if (text2.EndsWith("PAÑÍA") || text2.EndsWith("PONDE") || text2.EndsWith("TIVO,") || text2.EndsWith("CIÓN,"))
                {
                    text = text + sp + text2.Substring(0, (text2.Length - 5)) + "-";
                    if (text.Length < 12)
                        text = Centreado(text);
                    text2 = text2.Substring((text2.Length - 5), 5) + sp;
                    text += text2;
                    reduccion = 6; bandera = true;
                }
                else if (text2.EndsWith("CACIÓN") || text2.EndsWith("TRARSE"))
                {
                    text = text + sp + text2.Substring(0, (text2.Length - 6)) + "-";
                    if (text.Length < 12)
                        text = Centreado(text);
                    text2 = text2.Substring((text2.Length - 6), 6) + sp;
                    text += text2;
                    reduccion = 7; bandera = true;
                }
                else if (text2.EndsWith("CAMENTE,"))
                {
                    text = text + sp + text2.Substring(0, (text2.Length - 8)) + "-";
                    if (text.Length < 12)
                        text = Centreado(text);
                    text2 = text2.Substring((text2.Length - 8), 8) + sp;
                    text += text2;
                    reduccion = 9; bandera = true;
                }
                else if (text2.EndsWith("MIENTO,") || text2.EndsWith("CIONAN.") && text2.Length < tamaño + 2)
                {
                    text = text + sp + text2.Substring(0, (text2.Length - 7)) + "-";
                    if (text.Length < 12)
                        text = Centreado(text);
                    text2 = text2.Substring((text2.Length - 7), 7) + sp;
                    text += text2;
                    reduccion = 8; bandera = true;
                }
                else
                {
                    if (text2.EndsWith("RADO") && tamaño < 12)
                    {
                        text = text + sp + text2.Substring(0, (text2.Length - 4)) + "-";
                        if (text.Length < tamaño)
                            text = Centreado(text);
                        text2 = text2.Substring((text2.Length - 4), 4) + sp;
                        text += text2;
                        reduccion = 5; bandera = true;
                    }
                    else if (text2.EndsWith("TODAS"))
                    {
                        text = Centreado(text);
                        text2 += sp;
                        text = text + text2;
                        reduccion = 6; bandera = true;
                    }
                    else if (text2.EndsWith("ZA.") || text2.EndsWith("NE.") || text2.EndsWith("TE.") && text2.Length < 12)
                    {
                        text = text + sp + text2.Substring(0, (text2.Length - 3)) + "-";
                        text2 = text2.Substring((text2.Length - 3), 3) + sp;
                        text += text2;
                    }
                    else if (text2.EndsWith("ESTOY") || text2.EndsWith("ÚNICO") || text2.EndsWith("TENDRÍA") || text2.EndsWith("PALABRAS") || text2.EndsWith("ENSEÑA") || text2.EndsWith("SILENCIO,") && tamaño < 12)
                    {
                        text = Centreado(text);
                        text2 = Completado(text2);
                        text = text + text2;
                    }
                    else if (text2.EndsWith("TRAS."))
                    {
                        text = text + sp + text2.Substring(0, (text2.Length - 5)) + "-";
                        if (text.Length < tamaño)
                            text = Centreado(text);
                        text2 = Completado(text2.Substring((text2.Length - 5), 5));
                        text += text2;
                    }
                    else
                    {

                    }
                }
            }
            else if (text.Length < 4)
            {
                //regla el maximo de extensión que puede teneer el texto 2 es = 7 + exedente 
                if (text2.EndsWith("DO") || text2.EndsWith("TE") && text2.Length < tamaño - 2)
                {
                    text = text + sp + text2.Substring(0, (text2.Length - 2)) + "-";
                    if (text.Length < tamaño)
                        text = Centreado(text);
                    text2 = text2.Substring((text2.Length - 2), 2) + sp;
                    text += text2;
                    reduccion = 3; bandera = true;
                }
                else if (text2.EndsWith("TES") || text2.EndsWith("TOS") || text2.EndsWith("TAR") || text2.EndsWith("RAS") || text2.EndsWith("NOS") || text2.EndsWith("COS") || text2.EndsWith("DAS") || text2.EndsWith("DAD") || text2.EndsWith("MAS") || text2.EndsWith("MOS") || text2.EndsWith("CIA") || text2.EndsWith("CEN") || text2.EndsWith("LOS") && text2.Length < tamaño - 1)
                {
                    text = text + sp + text2.Substring(0, (text2.Length - 3)) + "-";
                    if (text.Length < tamaño)
                        text = Centreado(text);
                    text2 = text2.Substring((text2.Length - 3), 3) + sp;
                    text += text2;
                    reduccion = 4; bandera = true;
                }
                else if (text2.EndsWith("ZAS.") || text2.EndsWith("CIÓN") || text2.EndsWith("null") || text2.EndsWith("null") || text2.EndsWith("null") || text2.EndsWith("null") && text2.Length < tamaño + 1)
                {
                    text = text + sp + text2.Substring(0, (text2.Length - 4)) + "-";
                    if (text.Length < tamaño)
                        text = Centreado(text);
                    text2 = text2.Substring((text2.Length - 4), 4) + sp;
                    text += text2;
                }
                else if (text2.EndsWith("CIOS") || text2.EndsWith("CIAS") || text2.EndsWith("NIOS") || text2.EndsWith("DAD.") || text2.EndsWith("TES.") || text2.EndsWith("TES,") || text2.EndsWith("DOS:") && text2.Length < tamaño) // TES. posiblemnte se quite esa frase ridicula de con chocolates
                {
                    text = text + sp + text2.Substring(0, (text2.Length - 4)) + "-";
                    if (text.Length < tamaño)
                        text = Centreado(text);
                    text2 = text2.Substring((text2.Length - 4), 4) + sp;
                    text += text2;
                    reduccion = 5; bandera = true;
                }
                else if (text2.EndsWith("TIRSE") || text2.EndsWith("TADES") || text2.EndsWith("TALES") || text2.EndsWith("DADES") || text2.EndsWith("GENTE") || text2.EndsWith("NARÁ,") || text2.EndsWith("TIVAS") && text2.Length < tamaño + 1)
                {
                    text = text + sp + text2.Substring(0, (text2.Length - 5)) + "-";
                    if (text.Length < 12)
                        text = Centreado(text);
                    text2 = text2.Substring((text2.Length - 5), 5) + sp;
                    text += text2;
                    reduccion = 6; bandera = true;
                }
                else if (text2.EndsWith("SABLES") || text2.EndsWith("TANTES") || text2.EndsWith("CIONES") || text2.EndsWith("GRAFÍA") || text2.EndsWith("MIENTO") || text2.EndsWith("SIONES") && text2.Length < tamaño + 2)
                {
                    text = text + sp + text2.Substring(0, (text2.Length - 6)) + "-";
                    if (text.Length < tamaño)
                        text = Centreado(text);
                    text2 = text2.Substring((text2.Length - 6), 6) + sp;
                    text += text2;
                    reduccion = 7; bandera = true;
                }
                else if (text2.EndsWith("CIONADO") || text2.EndsWith("LIDADES") || text2.EndsWith("null") && text2.Length < tamaño + 3)
                {
                    text = text + sp + text2.Substring(0, (text2.Length - 7)) + "-";
                    if (text.Length < tamaño)
                        text = Centreado(text);
                    text2 = text2.Substring((text2.Length - 7), 7) + sp;
                    text += text2;
                    reduccion = 8; bandera = true;
                }
                else if (text2.EndsWith("DENTALES") || text2.EndsWith("NULL") || text2.EndsWith("null") && text2.Length < tamaño + 4)
                {
                    text = text + sp + text2.Substring(0, (text2.Length - 8)) + "-";
                    if (text.Length < tamaño)
                        text = Centreado(text);
                    text2 = text2.Substring((text2.Length - 8), 8) + sp;
                    text += text2;
                    reduccion = 9; bandera = true;
                }
                else if (text2.EndsWith("FICANTE."))
                {
                    text = text + sp + text2.Substring(0, (text2.Length - 8)) + "-";
                    text2 = sp + sp + text2.Substring((text2.Length - 8), 8) + sp + sp;
                    text += text2;
                }
                else if (text2.EndsWith("ORDINARIAS,"))
                {
                    text = sp + text + sp + text2.Substring(0, (text2.Length - 11)) + "-";
                    text2 = sp + text2.Substring((text2.Length - 11), 11) + sp;
                    text += text2;
                }
                else
                {
                    if (text2.EndsWith("DO,"))
                    {
                        text = text + sp + text2.Substring(0, (text2.Length - 3)) + "-";
                        text2 = Centreado(text2.Substring((text2.Length - 3), 3));
                        text += text2;
                    }
                    else if (text2.EndsWith("MIENTOS") || text2.EndsWith("TAMENTE") || text2.EndsWith("RABLES.") || text2.EndsWith("CIONES."))
                    {
                        text2 = Completado(text2.Substring((text2.Length - 7), 7));
                        text = text + sp + text2.Substring(0, (text2.Length - 7)) + "-";
                        if (text.Length < tamaño)
                            text = Centreado(text);
                        text += text2;
                    }
                    else if (text2.EndsWith("LES") && text2.Length < 8)
                    {
                        text = Centreado(text);
                        text2 += sp;
                        text = text + text2;
                        reduccion = 8; bandera = true;
                    }
                    else if (text2.EndsWith("PROFUNDAMENTE"))
                    {
                        text = Centreado(text);
                        text2 = Extense(text2);
                        text = text + text2;
                    }
                    else if (text2.EndsWith("PELIGROSAS") || text2.EndsWith("DICES") || text2.EndsWith("EDUCATIVA.") || text2.EndsWith("VENCER") && tamaño < 12)
                    {
                        text = Centreado(text);
                        text2 = Completado(text2);
                        text += text2;
                    }
                    else if (text2.EndsWith("PERSONA") || text2.EndsWith("MOVIMIENTOS.") || text2.EndsWith("MIENTOS."))
                    {
                        text = Centreado(text);
                        text2 = Completado(text2);
                        text = text + text2;
                    }
                    else
                    {

                    }
                }
            }
            return text;
        }
        public string Esteso(string text)
        {
            string text2 = string.Empty;
            if (text.EndsWith("null") || text.EndsWith("null") || text.EndsWith("null") || text.EndsWith("null") || text.EndsWith("null") && text.Length <= (tamaño + 6))
            {
                text2 = text.Substring((text.Length - 6), 6) + " ";
                text = text.Substring(0, (text.Length - 6));
                if (text.Length < tamaño)
                    text = Centreado(text);
                text += text2;
                reduccion = 7; bandera = true;
            }
            else if (text.EndsWith("null") || text.EndsWith("null") || text.EndsWith("null") || text.EndsWith("null") || text.EndsWith("null") && text.Length <= (tamaño + 5))
            {
                text2 = text.Substring((text.Length - 5), 5) + " ";
                text = text.Substring(0, (text.Length - 5));
                if (text.Length < tamaño)
                    text = Centreado(text);
                text += text2;
                reduccion = 6; bandera = true;
            }
            else if (text.EndsWith("null") || text.EndsWith("null") || text.EndsWith("null") || text.EndsWith("null") || text.EndsWith("null") && text.Length <= (tamaño + 4))
            {
                text2 = text.Substring((text.Length - 4), 4) + " ";
                text = text.Substring(0, (text.Length - 4));
                if (text.Length < tamaño)
                    text = Centreado(text);
                text += text2;
                reduccion = 5; bandera = true;
            }
            else if (text.EndsWith("null") || text.EndsWith("null") || text.EndsWith("null") || text.EndsWith("null") || text.EndsWith("null") && text.Length <= (tamaño + 3))
            {
                text2 = text.Substring((text.Length - 3), 3) + " ";
                text = text.Substring(0, (text.Length - 3));
                if (text.Length < tamaño)
                    text = Centreado(text);
                text += text2;
                reduccion = 4; bandera = true;
            }
            else
            {
                text2 = text.Substring((text.Length - 2), 2) + " ";
                text = text.Substring(0, (text.Length - 2));
                if (text.Length < tamaño)
                    text = Centreado(text);
                text += text2;
                reduccion = 3; bandera = true;
            }
            return text;
        }
        public string Extensao(string text)
        {
            string text2 = string.Empty;
            if (text.EndsWith("CANTE,") || text.EndsWith("MENTE,") || text.EndsWith("MENTE.") || text.EndsWith("MENTO,") || text.EndsWith("MENTO.") || text.EndsWith("MENTO;") || text.EndsWith("MENTOS") || text.EndsWith("NESS\".") || text.EndsWith("CAÇÃO,") || text.EndsWith("null") && text.Length <= (tamaño + 6))
            {
                text2 = text.Substring((text.Length - 6), 6) + " ";
                text = text.Substring(0, (text.Length - 6));
                if (text.Length < tamaño)
                    text = Centreado(text);
                text += text2;
                reduccion = 7; bandera = true;
            }
            else if (text.EndsWith("DADE,") || text.EndsWith("DADE.") || text.EndsWith("CIAS.") || text.EndsWith("MENTE") || text.EndsWith("MENTO") || text.EndsWith("TÓRIO") || text.EndsWith("TIMOS") || text.EndsWith("MANDO") || text.EndsWith("NEOS.") || text.EndsWith("VEIS,") || text.EndsWith("null") && (text.Length > (tamaño + 3) && text.Length <= (tamaño + 5)))
            {
                text2 = text.Substring((text.Length - 5), 5) + " ";
                text = text.Substring(0, (text.Length - 5));
                if (text.Length < tamaño)
                    text = Centreado(text);
                text += text2;
                reduccion = 6; bandera = true;
            }
            else if (text.EndsWith("DADE") || text.EndsWith("VEIS") || text.EndsWith("RETO") || text.EndsWith("RIAS") || text.EndsWith("CIA,") || text.EndsWith("NOS,") || text.EndsWith("OSO.") || text.EndsWith("ZAR,") || text.EndsWith("TIS.") || text.EndsWith("TAL.") || text.EndsWith("TOS.") || text.EndsWith("-ME,") || text.EndsWith("RES,") || text.EndsWith("RAS.") || text.EndsWith("LAS.") || text.EndsWith("VOS.") || text.EndsWith("DIA.") || text.EndsWith("DES.") || text.EndsWith("DAS,") || text.EndsWith("DES,") || text.EndsWith("DOS.") || text.EndsWith("-LA,") || text.EndsWith("-LHE") || text.EndsWith("-LO.") || text.EndsWith("RAS,") || text.EndsWith("NALS") || text.EndsWith("HADO") || text.EndsWith("TIVO") || text.EndsWith("CIAS") || text.EndsWith("ÇÃO.") || text.EndsWith("ÇÃO,") || text.EndsWith("ÇÕES") || text.EndsWith("-NOS") || text.EndsWith("VEL,") && text.Length <= (tamaño + 4))
            {
                text2 = text.Substring((text.Length - 4), 4) + " ";
                text = text.Substring(0, (text.Length - 4));
                if (text.Length < tamaño)
                    text = Centreado(text);
                text += text2;
                reduccion = 5; bandera = true;
            }
            else if (text.EndsWith("TA.") || text.EndsWith("TO,") || text.EndsWith("DE.") || text.EndsWith("DA.") || text.EndsWith("DO.") || text.EndsWith("ÍDA") || text.EndsWith("LOS") || text.EndsWith("DE;") || text.EndsWith("ÇÃO") || text.EndsWith("RES") || text.EndsWith("TES") || text.EndsWith("RAS") || text.EndsWith("CIA") || text.EndsWith("VEL") || text.EndsWith("DOS") || text.EndsWith("DES") || text.EndsWith("RIA") || text.EndsWith("NOU") || text.EndsWith("DO,") || text.EndsWith("DOS") || text.EndsWith("-SE") || text.EndsWith("PAZ") || text.EndsWith("DO,") || text.EndsWith("OSO") && text.Length <= (tamaño + 3))
            {
                text2 = text.Substring((text.Length - 3), 3) + " ";
                text = text.Substring(0, (text.Length - 3));
                if (text.Length < tamaño)
                    text = Centreado(text);
                text += text2;
                reduccion = 4; bandera = true;
            }
            else
            {
                text2 = text.Substring((text.Length - 2), 2) + " ";
                text = text.Substring(0, (text.Length - 2));
                if (text.Length < tamaño)
                    text = Centreado(text);
                text += text2;
                reduccion = 3; bandera = true;
            }
            return text;
        }
        public string Extense(string text)
        {
            string text2 = string.Empty;

            if (text.EndsWith("TRAITS") || text.EndsWith("null") || text.EndsWith("null") && text.Length < (tamaño + 6))
            {
                text2 = text.Substring((text.Length - 6), 6) + " ";
                text = text.Substring(0, (text.Length - 6));
                if (text.Length < tamaño)
                    text = Centreado(text);
                text += text2;
                reduccion = 7; bandera = true;
            }
            if (text.EndsWith("TION.") || text.EndsWith("CALLY") || text.EndsWith("TIES.") || text.EndsWith("TELY,") || text.EndsWith("TION,") || text.EndsWith("DING,") || text.EndsWith("DENCE") || text.EndsWith("NESS.") || text.EndsWith("NIST,") || text.EndsWith("RANCE") && text.Length < (tamaño + 5))
            {
                text2 = text.Substring((text.Length - 5), 5) + " ";
                text = text.Substring(0, (text.Length - 5));
                if (text.Length < tamaño)
                    text = Centreado(text);
                text += text2;
                reduccion = 6; bandera = true;
            }
            else if (text.EndsWith("FICE") || text.EndsWith("CIAN") || text.EndsWith("CES,") || text.EndsWith("TORY") || text.EndsWith("NESS") || text.EndsWith("NARY") || text.EndsWith("TIES") || text.EndsWith("MATE") || text.EndsWith("TION") || text.EndsWith("LIEF") || text.EndsWith("DING") || text.EndsWith("WARD") || text.EndsWith("TICS") || text.EndsWith("ING,") || text.EndsWith("IST.") || text.EndsWith("LITY") || text.EndsWith("TING") && text.Length < (tamaño + 4))
            {
                text2 = text.Substring((text.Length - 4), 4) + " ";
                text = text.Substring(0, (text.Length - 4));
                if (text.Length < 12)
                    text = Centreado(text);
                text += text2;
                reduccion = 5; bandera = true;
            }
            else if (text.EndsWith("URS") || text.EndsWith("FUL") || text.EndsWith("BLE") || text.EndsWith("TY,") || text.EndsWith("CED") || text.EndsWith("ING") || text.EndsWith("CES") && text.Length < (tamaño + 3))
            {
                text2 = text.Substring((text.Length - 3), 3) + " ";
                text = text.Substring(0, (text.Length - 3));
                if (text.Length < 12)
                    text = Centreado(text);
                text += text2;
                reduccion = 4; bandera = true;
            }
            else if (text.EndsWith("SE") || text.EndsWith("TY") || text.EndsWith("ES") || text.EndsWith("LY") || text.EndsWith("US") || text.EndsWith("RY") || text.EndsWith("null") && text.Length < (tamaño + 2))
            {
                text2 = text.Substring((text.Length - 2), 2) + " ";
                text = text.Substring(0, (text.Length - 2));
                if (text.Length < 12)
                    text = Centreado(text);
                text += text2;
                reduccion = 3; bandera = true;
            }
            else
            {
                if (text.EndsWith("DESTINY.") || text.EndsWith("PHILOSOPHERS.") || text.EndsWith("PERSEVERANCE.") || text.EndsWith("INTELLIGENCE.") || text.EndsWith("SIGNIFICANCE.") || text.EndsWith("IMPERFECTION.") || text.EndsWith("CO-OPERATION.") || text.EndsWith("PROBLEMS.") || text.EndsWith("INDEPENDENCE."))
                {
                    text = text.Substring(0, (text.Length - 1));
                }
            }
            return text;
        }
        public string Extensivo(string text)
        {
            string text2 = string.Empty;
            if (text.Length == (tamaño + 1) && (text.EndsWith(",") || text.EndsWith(".") || text.EndsWith(".") || text.EndsWith(";") || text.EndsWith(":") || text.EndsWith("?") || text.EndsWith("!") || text.EndsWith("\"") || text.EndsWith("”") || text.EndsWith("'") || text.EndsWith("-")))
            {
                text += " ";
                reduccion = 2; bandera = true;
            }
            else if (text.EndsWith("MENTE") || text.EndsWith("MARSE") || text.EndsWith("MOSLO") && text.Length < (tamaño + 5))
            {
                text2 = text.Substring((text.Length - 5), 5) + " ";
                text = text.Substring(0, (text.Length - 5)) + "-";
                if (text.Length < tamaño)
                    text = Centreado(text);
                text += text2;
                reduccion = 6; bandera = true;
            }
            else if (text.EndsWith("CIÓN") && text.Length < (tamaño + 5))
            {
                text2 = text.Substring(0, (text.Length - 4)) + "-";
                if (text2.Length < tamaño)
                {
                    text = Centreado(text2);
                }
                text = text + "CIÓN ";
                reduccion = 5; bandera = true;
            }
            else if (text.EndsWith("TES") || text.EndsWith("RIO") || text.EndsWith("TOS") || text.EndsWith("DES") || text.EndsWith("NES") || text.EndsWith("SAS") || text.EndsWith("CIA") && text.Length < (tamaño + 3))
            {
                text2 = text.Substring((text.Length - 3), 3) + " ";
                text = text.Substring(0, (text.Length - 3)) + "-";
                if (text.Length < 12)
                    text = Centreado(text);
                text += text2;
                reduccion = 4; bandera = true;
            }
            else
            {
                if (text.EndsWith("CIÓN.") && text.Length < (tamaño + 6))
                {
                    text2 = text.Substring(0, (text.Length - 5)) + "-";
                    if (text2.Length < tamaño)
                    {
                        text = Centreado(text2);
                    }
                    text = text + "CIÓN.";
                }
                else if (text.EndsWith("CIA.") && text.Length < (tamaño + 3))
                {
                    text2 = text.Substring(0, (text.Length - 4)) + "-";
                    if (text2.Length < tamaño)
                    {
                        text = Centreado(text2);
                    }
                    text = text + "CIA.";
                }
                else if (text.EndsWith("DADES.") || text.EndsWith("SIONES") && text.Length < (tamaño + 6))
                {
                    text2 = text.Substring((text.Length - 6), 6) + " ";
                    text = text.Substring(0, (text.Length - 6)) + "-";
                    if (text.Length < tamaño)
                        text = Centreado(text);
                    text += text2;
                    reduccion = 7; bandera = true;
                }
                else if (text.EndsWith("DIOSOS,") || text.EndsWith("CIÓNES.") && text.Length < (tamaño + 6))
                {
                    text2 = text.Substring((text.Length - 7), 7) + " ";
                    text = text.Substring(0, (text.Length - 7)) + "-";
                    if (text.Length < tamaño)
                        text = Centreado(text);
                    text += text2;
                    reduccion = 8; bandera = true;
                }
                else if (text.EndsWith("CIA,") || text.EndsWith("DAD.") && text.Length < (tamaño + 3))
                {
                    text2 = text.Substring((text.Length - 4), 4) + " ";
                    text = text.Substring(0, (text.Length - 4)) + "-";
                    if (text.Length < 12)
                        text = Centreado(text);
                    text += text2;
                    reduccion = 5; bandera = true;
                }
                else if (text.EndsWith("LOS.") || text.EndsWith("LAS.") || text.EndsWith("RIO.") && text.Length <= (tamaño + 3))
                {
                    text2 = text.Substring((text.Length - 4), 4) + " ";
                    text = text.Substring(0, (text.Length - 4)) + "-";
                    if (text.Length < 12)
                        text = Centreado(text);
                    text = text + text2;
                }
                else if (text.EndsWith("TAN,") && text.Length < (tamaño + 1))
                {
                    text = text.Substring(0, (text.Length - 4)) + "-";
                    text2 = Centreado("TAN,");
                    text = text + text2;
                }
                else if (text.EndsWith("DO,"))
                {
                    text2 = text.Substring((text.Length - 3), 3) + " ";
                    text = text.Substring(0, (text.Length - 3)) + "-";
                    if (text.Length < 12)
                        text = Centreado(text);
                    text += text2;
                    reduccion = 3; bandera = true;
                }
                else
                {

                }
            }
            return text;
        }
        public string Centreado(string text)
        {
            string espacio = " ";
            if (text.Length < (tamaño - 1))
            {
                int extension = text.Length;
                for (int j = 0; j < ((tamaño - extension) / 2); j++)
                {
                    text = espacio + text + espacio;
                }
            }
            if (text.Length < tamaño)
            {
                text += espacio;
            }
            return text;
        }
        public string Completado(string text)
        {
            string espacio = " ";
            if (text.Length < (12 - 1))
            {
                int extension = text.Length;
                for (int j = 0; j < ((12 - extension) / 2); j++)
                {
                    text = espacio + text + espacio;
                }
            }
            if (text.Length < 12)
            {
                text += espacio;
            }
            return text;
        }

        public static char[] EliminarDuplicados(char[] Letras)
        {
            char[] sinDuplicadosLetras = Letras.Distinct().ToArray();

            return sinDuplicadosLetras;
        }
        private void SaveFile(CE_Frases f)
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

            string[] archivos = System.IO.Directory.GetFiles(pathString);
            int numer = archivos.Length;

            string fileName = $"{f.NameArchive}-{numer}.bin";

            pathString = System.IO.Path.Combine(pathString, fileName);

            using (System.IO.FileStream fs = new System.IO.FileStream(pathString, FileMode.Append))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    f.FraseExt = f.Letras.Length;
                    bw.Write(f.Frase);
                    bw.Write(f.Fuente);
                    bw.Write(f.FraseExt);
                    for (int i = 0; i < f.FraseExt; i++)
                    {
                        if (f.Letras[i] != '.' && f.Letras[i] != ' ' && f.Letras[i] != '-' && f.Letras[i] != ',' && f.Letras[i] != '\'' && f.Letras[i] != '´' && f.Letras[i] != ';' && f.Letras[i] != ':' && f.Letras[i] != '¿' && f.Letras[i] != '?' && f.Letras[i] != '¡' && f.Letras[i] != '!')
                        {
                            bw.Write(f.Letras[i]);
                        }
                    }
                }
            }
        }
    }
}