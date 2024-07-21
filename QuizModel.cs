using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizMaker
{
    public class QuizModel
    {
        public QuizModel() { }
        public QuizModel(string q, string a) 
        { 
            question = q;
            answer = a;
        }
        public string? question { get; set; }
        public string? answer { get; set; }
    }
}
