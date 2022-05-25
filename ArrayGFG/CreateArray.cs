namespace ArrayGFG
{
    public class CreateArray
    {
        public void Execute()
        {
            int[] numArr = new int[5];
            numArr[0] = 1;
            numArr[1] = 2;
            numArr[2] = 3;
            numArr[3] = 4;
            numArr[4] = 5;
            foreach (var item in numArr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
