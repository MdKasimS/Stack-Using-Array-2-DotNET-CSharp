namespace DSA
{
    public class StackArray
    {
        private int[] arrayStack;
        private int index;
        public int Index { get => index; set => index = value; }
        public int[] ArrayStack { get => arrayStack; set => arrayStack = value; }

        public StackArray(int size)
        {
            Index = -1;
            ArrayStack = new int[size];
        }
        public void Push(int data)
        {
            if (Index == -1)
            {
                ++Index;
                ArrayStack[index] = data;
            }
            else if (IsFull().Equals("Yes"))
            {
                Console.WriteLine("Stack Is Full. No More Elements Can Be Added.");
                Console.ReadKey();
            }
            else
            {
                ++Index;
                ArrayStack[index] = data;
            }
        }
        public void PrintStack()
        {
            String? indicator = "";

            if (Index != -1)
            {
                for (int j = Index; j > -1; --j)
                {
                    if (j == Index)
                    {
                        indicator = "<--- Top";
                    }

                    Console.WriteLine($"|{ArrayStack[j],6}| {indicator}");
                    Console.WriteLine("--------");
                    indicator = "";
                }
            }
            else
            {
                Console.WriteLine("Stack Is Empty");
            }
            Console.WriteLine();
        }
        public void Pop()
        {
            if (Index > -1)
            {
                ArrayStack[Index] = 0;
                --Index;
            }
            else
            {
                Console.WriteLine("Stack Is Empty");
            }
        }
        public int Size()
        {
            return Index + 1;
        }
        public string Peek()
        {
            if (Index > -1)
                return ArrayStack[Index].ToString();
            else
                return "[Stack Is Empty]";
        }
        public string IsEmpty()
        {
            if (Index == -1)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }

        public string IsFull()
        {
            if (Index + 1 == ArrayStack.Length)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }
    }
}
