public class LinearSearch
{
    public int BuscaLinear(int[] array, int valorProcurado)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == valorProcurado)
            {
                return i;
            }
        }
        return -1;
    }
}