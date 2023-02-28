using System.Collections;

namespace Collections_Less32
{
    public class MyCollection : IEnumerable
    {
        private int[] _monthNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new MyEnumerator(_monthNumbers);
        }
    }

    public class MyEnumerator : IEnumerator
    {
        private int index = -1;
        private int[] _monthNumbers;

        public MyEnumerator(int[] numbers)
        {
            _monthNumbers = numbers;
        }
        public bool MoveNext()
        {
            if (index < _monthNumbers.Length)
                index++;

            return (!(index == _monthNumbers.Length));
        }

        public void Reset()
        {
            index = -1;
        }

        public object Current
        {
            get
            {
                if (index < 0 || index == _monthNumbers.Length)
                    throw new InvalidOperationException();
                return _monthNumbers[index];
            }
        }
    }
}
