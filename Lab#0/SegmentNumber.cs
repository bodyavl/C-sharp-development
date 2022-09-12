
namespace Program
{
    class SegmentNumber
    {
        char[,] number;
        const int segmentHeight = 5;
        int input;
        public SegmentNumber(int input)
        {
            this.input = input;
            string strInput = this.input.ToString();
            int arrayLength = segmentHeight * strInput.Length;
            number = new char[segmentHeight, arrayLength];
        }
        private void toSegmentNum(int input)
        {
            char[] chars = input.ToString().ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                string[] currentNum = segments[chars[i]];
                writeStrNumToArray(currentNum, i);
            }
        }
        private void writeStrNumToArray(string[] currentNum, int iterator)
        {
            for (int i = 0; i < currentNum.Length; i++)
            {
                for (int j = 0; j < currentNum[i].Length; j++)
                {
                    if (iterator == 0)
                    {
                        number[i, j] = currentNum[i][j];
                    }
                    else
                    {
                        number[i, j + segmentHeight * iterator] = currentNum[i][j];
                    }
                }
            }
        }
        private void print(char[,] number)
        {
            for (int i = 0; i < number.GetLength(0); i++)
            {
                for (int j = 0; j < number.GetLength(1); j++)
                {
                    Console.Write(number[i, j]);
                }
                Console.WriteLine();

            }
        }

        public void output()
        {
            toSegmentNum(input);

            print(number);
        }
        Dictionary<char, string[]> segments = new Dictionary<char, string[]>
        {
            {
                '1', new string[]
                {"#    ",
                 "#    ",
                 "#    ",
                 "#    ",
                 "#    "
                }
            },
            {
                '2', new string[]
                {
                 "#### ",
                 "   # ",
                 "#### ",
                 "#    ",
                 "#### "
                }
               },
            {
                '3', new string[]
                {
                 "#### ",
                 "   # ",
                 "#### ",
                 "   # ",
                 "#### "
                }
            },
            {
                '4', new string[]
                {
                 "#  # ",
                 "#  # ",
                 "#### ",
                 "   # ",
                 "   # "
                }
            },
            {
                '5', new string[]
                {
                 "#### ",
                 "#    ",
                 "#### ",
                 "   # ",
                 "#### "
                }
            },
            {
                '6', new string[]
                {
                 "#### ",
                 "#    ",
                 "#### ",
                 "#  # ",
                 "#### "
                }

            },
            {
                '7', new string[]
                {
                 "#### ",
                 "   # ",
                 "   # ",
                 "   # ",
                 "   # "
                }
            },
            {
                '8', new string[]
                {
                 "#### ",
                 "#  # ",
                 "#### ",
                 "#  # ",
                 "#### "
                }
            },
            {
                '9', new string[]
                {
                 "#### ",
                 "#  # ",
                 "#### ",
                 "   # ",
                 "#### "
                }
            },
            {
                '0', new string[]
                {
                 "#### ",
                 "#  # ",
                 "#  # ",
                 "#  # ",
                 "#### "
                }
            },
            {
                '-', new string[]
                {
                 "     ",
                 "     ",
                 "#### ",
                 "     ",
                 "     "
                }
            }
        };
    }
}