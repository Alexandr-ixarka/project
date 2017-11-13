using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Project_text
{
    public class PunctuationMarkWorker : IPunctuationMarkWorker
    {
        public bool IsQuestionMark(ISentenceElement element)
        {
            if (element.SentenceElementType == SentenceElementType.PunctuationMark)
            {
                if (element.Value.Equals("?"))
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }
    }
}
