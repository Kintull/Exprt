using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicParser
{
    class Parser
    {
        private Lexer _SourceLexer;
        public IEnumerable<Lexem> Lexems { get; private set; }

        public Parser( Lexer theLexer )
        {
            _SourceLexer = theLexer;
            ParseString();
        }
        

        void ParseString()
        {
            Stack<Lexem> outStack = new Stack<Lexem>(30);
            Stack<Lexem> opStack = new Stack<Lexem>(30);
            bool isFirst = true;
            foreach ( Lexem lexem in _SourceLexer.Lexems )
            {
                
                switch ( lexem.Type )
                {
                    case ( LexemType.LBracket ):
                        opStack.Push(lexem);
                        break;

                    case ( LexemType.RBracket ):
                        while ( opStack.Peek().Type != LexemType.LBracket )
                        { 
                            outStack.Push( opStack.Pop() );
                        }
                        opStack.Pop(); // Remove LBracket

                        break;

                    case ( LexemType.Identifier ):
                        outStack.Push(lexem);
                        break;

                    default:                         
                        if ( ( opStack.Count == 0 ) || ( lexem.Type <= opStack.Peek().Type ) )
                        {
                            opStack.Push(lexem);
                        }
                        else
                        {
                            outStack.Push(opStack.Pop());
                            opStack.Push(lexem);
                        }
                        break;
                }
                
            }
            for ( int i = opStack.Count; i > 0; i-- )
            {
                outStack.Push(opStack.Pop());
            }

            Lexems = outStack.Reverse(); 
        }
    }
}
