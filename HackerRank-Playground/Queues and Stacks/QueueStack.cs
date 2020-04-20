using System;
using System.Collections.Generic;

namespace HackerRank_Playground.QueuesandStacks
{
    public class QueueStackHelper
    {
        private char[] stack;
        private List<char> queue = new List<char>();
        private const int defaultSize = 50;
        private int index;

        public QueueStackHelper()
        {
            stack = new char[defaultSize];
            index = 0;
        }

        public void pushCharacter(char character)
        {
            stack[index] = character;
            index++;
        }

        public char popCharacter()
        {
            if (index == 0)
            {
                throw new ArgumentOutOfRangeException("Exception: stack is empty");
            }

            return stack[--index];
        }

        public void enqueueCharacter(char character)
        {
            queue.Add(character);
        }

        public char dequeueCharacter()
        {
            queue.Reverse();

            var queueListToArray = queue.ToArray();

            return queueListToArray[index--];
        }

    }
}
