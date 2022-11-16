namespace CapaEntidades
{
    public class CE_Cubos
    {
        private int[,] _cubos = new int[60, 8];
        private int[] _deco = new int[8];
        

        public int[,] Cubos { get => _cubos; set => _cubos = value; }
        public int[] Deco { get => _deco; set => _deco = value; }
    }
}
