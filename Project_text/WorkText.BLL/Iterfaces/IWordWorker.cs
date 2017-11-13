using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Project_text
{
    public interface IWordWorker
    {
        int GetWordLength(ISentenceElement element);
        bool FirstLetterIsConsonant(ISentenceElement element);
        void ReplaceValue(int wordLenght, ISentenceElement element, string newValue);
    }
}
