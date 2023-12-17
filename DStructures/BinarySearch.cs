public class BinarySearch
{
    public int BuscaBinaria(int[] array, int valorProcurado)
    {
        int min = 0;
        int max = array.Length - 1;

        while (min <= max)
        {
            int meio = (min + max) / 2;

            if (valorProcurado == array[meio])
            {
                return meio;
            }
            else if (valorProcurado < array[meio])
            {
                max = meio - 1;
            }
            else
            {
                min = meio + 1;
            }
        }
        return -1;
    }
}
