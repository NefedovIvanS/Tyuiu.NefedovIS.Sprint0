namespace Tyuiu.NefedovIS.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static object AdditionArray(int[] number)
        {
            var total = 0;
            for (var i = 0; i < number.Length; i++)
            {
                total = total + number[i];
            }
            return total;
        }
        public static object SubtructionArray(int[] number)
        {
            var total = 0;
            int index = 0;

            while (index < number.Length)
            {
                total = total - number[index];
                index++;
            }
            return total;
        }
        public static object MultiplicationArray(int[] number)
        {
            var total = 1;
            int index = 0;
            do
            {
                total = total * number[index];
                index++;
            }
            while (index < number.Length);

            return total;
        }
    }
}
