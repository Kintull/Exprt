using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicParser
{
    /** Convert reverse poland notaion into STL 
     * 
     */

    class Converter
    {
        private Parser _SourceLexer;
        private bool isFirst = true;
        private Stack<Lexem> stack = new Stack<Lexem>(30);
        public List<string> ProgramBlocks = new List<string>(30);
        public IEnumerable<Lexem> Lexems { get; private set; }
        public string OutCode;

        public Converter( Parser theLexer )
        {
            _SourceLexer = theLexer;
            ParseString();
        }

        void ParseString()
        {
            foreach ( Lexem lexem in _SourceLexer.Lexems )
            {
                switch ( lexem.Type )
                {

                    case ( LexemType.Identifier ):
                        stack.Push(lexem);
                        break;

                    case ( LexemType.Not ):
                        Lexem lex = stack.Pop();
                        lex.isNot = true;
                        stack.Push(lex);
                        break;

                    default:
                        GenerateCode(lexem);
                        break;
                }

            }
            GenerateEnd();
        }

        void GenerateCode( Lexem theLexem )
        {
            string action = "";
            
            string FirstAction = "A";

            switch ( theLexem.Type )
            {
                case ( LexemType.And ):
                    action = "A";
                    break;
                case ( LexemType.Or ):
                    action = "O";
                    break;
                case ( LexemType.Assign ):
                    action = "S";
                    break;
            }
            if (isFirst)
            {
                Lexem operand_B = stack.Pop();
                Lexem operand_A = stack.Pop();
                action += ( operand_B.isNot ) ? "N" : "";
                FirstAction += ( operand_A.isNot ) ? "N" : "";

                int blockNumber = 1;

                ProgramBlocks.Add(string.Format("FUNCTION_BLOCK FB {0}\n" , blockNumber));
                ProgramBlocks.Add(string.Format("TITLE = BLOCK_{0}\n" , blockNumber));
                ProgramBlocks.Add("VERSION : 0.1\n");
                ProgramBlocks.Add("\n");
                ProgramBlocks.Add("BEGIN\n");
                ProgramBlocks.Add("NETWORK\n");
                ProgramBlocks.Add("TITLE = \n");
                ProgramBlocks.Add("\n");
                ProgramBlocks.Add(string.Format("     {0}\t\t\"{1}\";\n" , FirstAction , operand_A.Value));

                ProgramBlocks.Add(string.Format("     {0}\t\t\"{1}\";\n" , action , operand_B.Value));
                isFirst = false;
            }
            else
            {
                Lexem operand_B = stack.Pop();
                action += ( operand_B.isNot ) ? "N" : "";
                ProgramBlocks.Add(string.Format("     {0}\t\t\"{1}\";\n" , action , operand_B.Value));
            }

        }

        void GenerateEnd()
        {
            ProgramBlocks.Add("END_FUNCTION_BLOCK\n");
            OutCode = string.Concat(ProgramBlocks);
        }
    }
}
