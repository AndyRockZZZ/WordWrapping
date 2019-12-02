using System;
using System.Collections.Generic;
using System.Text;

namespace WordWrapping
{
    class Wrapping
    {
        public string Wrap(string input, int width) 
        {
            int length = input.Length;

            string output = string.Empty;
            string[] words = input.Split(' ');

            if (length > width)
            {
                int count = 0;

                for (int i = 0; i < words.Length; i++)
                {
                    int outputLength = words[i].Length;

                    if (outputLength + count <= width) 
                    {
                        output += words[i] + ' ';
                        count += outputLength + 1;
                    }

                    else
                    {
                        output += "\n" + words[i] + ' ';
                        count = 0 + outputLength + 1;
                    }
                }
            }

            else 
            {
                output = input;
            }

            return output;
        }
    }
}
