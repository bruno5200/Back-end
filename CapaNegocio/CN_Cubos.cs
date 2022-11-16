using System;
using System.IO;
using System.Linq;
using System.Text;
using CapaEntidades;

namespace CapaNegocio
{
    public class CN_Cubos
    {
        int Count, pass = 1;
        bool k;
        public CE_Cubos Decodifcar(CE_Cubos c)
        {
            Count = 0;
            string folderName = @"c:\ArchivosApp";

            string fileName = $"Cubos.txt";

            string pathString = System.IO.Path.Combine(folderName, fileName);

            using (FileStream fs = new FileStream(pathString, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.Default))
                {
                    string cadena = string.Empty;
                    while ((cadena = sr.ReadLine()) != null)
                    {
                        string[] Decoded = cadena.Split('#').ToArray();
                        c = Index(c, Decoded);
                        c = AddCubos(c);
                        Count++;
                    }
                }
            }
            SaveCubos(c);
            return c;
        }
        public CE_Cubos AddCubos(CE_Cubos c)
        {
            if (Count > 1)
            {
                for (int i = 0; i < pass; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (Comp(c.Cubos[i, j], c.Deco[0]))
                        {
                            if (Comp(c.Cubos[i, j], c.Deco[1]))
                            {
                                if (Comp(c.Cubos[i, j], c.Deco[2]))
                                {
                                    if (Comp(c.Cubos[i, j], c.Deco[3]))
                                    {
                                        if (Comp(c.Cubos[i, j], c.Deco[4]))
                                        {
                                            if (Comp(c.Cubos[i, j], c.Deco[5]))
                                            {
                                                if (Comp(c.Cubos[i, j], c.Deco[6]))
                                                {
                                                    if (Comp(c.Cubos[i, j], c.Deco[7]))
                                                    {
                                                        if (i == (pass - 1) && j == 7)
                                                        {
                                                            c.Cubos[i+1, 0] = c.Deco[0];
                                                            c.Cubos[i+1, 1] = c.Deco[1];
                                                            c.Cubos[i+1, 2] = c.Deco[2];
                                                            c.Cubos[i+1, 3] = c.Deco[3];
                                                            c.Cubos[i+1, 4] = c.Deco[4];
                                                            c.Cubos[i+1, 5] = c.Deco[5];
                                                            c.Cubos[i+1, 6] = c.Deco[6];
                                                            c.Cubos[i+1, 7] = c.Deco[7];
                                                            k = true; 
                                                        }
                                                    }
                                                    else
                                                        break;
                                                }
                                                else
                                                    break;
                                            }
                                            else
                                                break;
                                        }
                                        else
                                            break;
                                    }
                                    else
                                        break;
                                }
                                else
                                    break;
                            }
                            else
                                break;
                        }
                        else
                            break;
                    }
                }
            }
            else
            {
                c.Cubos[0, 0] = c.Deco[0];
                c.Cubos[0, 1] = c.Deco[1];
                c.Cubos[0, 2] = c.Deco[2];
                c.Cubos[0, 3] = c.Deco[3];
                c.Cubos[0, 4] = c.Deco[4];
                c.Cubos[0, 5] = c.Deco[5];
                c.Cubos[0, 6] = c.Deco[6];
                c.Cubos[0, 7] = c.Deco[7];
            }
            if (k)
            {
                pass++;
                k = false;
            }
            return c;
        }
        public void SaveCubos(CE_Cubos c)
        {
            string folderName = @"c:\ArchivosApp";

            string fileName = $"Cubos Process.txt";

            string pathString = System.IO.Path.Combine(folderName, fileName);

            using (System.IO.FileStream fs = new System.IO.FileStream(pathString, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                {
                    for (int i = 0; i < 60; i++)
                    {
                        sw.WriteLine($"{c.Cubos[i,0]} {c.Cubos[i,1]} {c.Cubos[i,2]} {c.Cubos[i,3]} {c.Cubos[i,4]} {c.Cubos[i,5]} {c.Cubos[i,6]} {c.Cubos[i,7]}");
                    }
                }
            }
        }
        private bool Comp(int a, int b)
        {
            if (a != b)
                return true;
            else
                return false;
        }
        private CE_Cubos Index(CE_Cubos c, string[] Decoded)
        {
            for (int i = 0; i < 8; i++)
            {
                c.Deco[i] = Convert.ToInt32(Decoded[i]);
            }
            return c;
        }
        
    }
}
