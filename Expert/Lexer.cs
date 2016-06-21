using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LogicParser
{
    enum LexemType
    {
        Var,
        Print,

        Plus,
        Minus,
        Multiply,
        Divide,

        Equals,
        Greater,
        Lower,
        GreaterEquals,
        LowerEquals,

        Not,
        And,
        Or,

        LBracket,
        RBracket,

        Assign,
        Semicolon,
        Identifier,
        Number,
        String
    }

    class LocationEntity
    {
        public int Offset;
        public int Length;
        public int StartLocation;
        public int EndLocation;
    }

    class Lexem : LocationEntity
    {
        public LexemType Type;
        public string Value;
        public bool isNot;
        public bool isFirst;
    }

    class LexemDefinition<T>
    {
        public LexemType Kind { get; protected set; }
        public T Representation { get; protected set; }
    }

    class StaticLexemDefinition : LexemDefinition<string>
    {
        public bool IsKeyword;

        public StaticLexemDefinition(string rep, LexemType kind, bool isKeyword = false)
        {
            Representation = rep;
            Kind = kind;
            IsKeyword = isKeyword;
        }
    }

    class DynamicLexemDefinition : LexemDefinition<Regex>
    {
        public DynamicLexemDefinition(string rep, LexemType kind)
        {
            Representation = new Regex(@"\G" + rep, RegexOptions.Compiled);
            Kind = kind;
        }
    }

    static class LexemDefinitions
    {
        public static StaticLexemDefinition[] Statics = new[]
        {
            new StaticLexemDefinition("+", LexemType.Plus),
            new StaticLexemDefinition("-", LexemType.Minus),
            new StaticLexemDefinition("*", LexemType.Multiply),
            new StaticLexemDefinition("/", LexemType.Divide),

            new StaticLexemDefinition("==", LexemType.Equals),
            new StaticLexemDefinition(">=", LexemType.GreaterEquals),
            new StaticLexemDefinition("<=", LexemType.LowerEquals),
            new StaticLexemDefinition(">", LexemType.Greater),
            new StaticLexemDefinition("<", LexemType.Lower),

            new StaticLexemDefinition("!", LexemType.Not),
            new StaticLexemDefinition("&&", LexemType.And),
            new StaticLexemDefinition("||", LexemType.Or),

            new StaticLexemDefinition("(", LexemType.LBracket),
            new StaticLexemDefinition(")", LexemType.RBracket),

            new StaticLexemDefinition("=", LexemType.Assign)


        };

        public static DynamicLexemDefinition[] Dynamics = new[]
        {
            new DynamicLexemDefinition("[a-zA-Z_][a-zA-Z0-9_]*", LexemType.Identifier),
            new DynamicLexemDefinition(@"([0-9]*\.?[0-9]+)", LexemType.Number),
        };
    }

    class Lexer
    {
        private char[] SpaceChars = new[] { ' ', '\n', '\r', '\t' };
        private string _Source;
        private int Offset;

        public IEnumerable<Lexem> Lexems { get; private set; }

        public Lexer(string src)
        {
            _Source = src;
            Parse();
        }

        private void Parse()
        {
            var lexems = new List<Lexem>();

            while (InBounds())
            {
                SkipSpaces();
                if (!InBounds()) break;

                var lex = ProcessStatic() ?? ProcessDynamic();
                if (lex == null)
                    throw new Exception(string.Format("Unknown lexem at {0}", Offset));

                lexems.Add(lex);
            }

            Lexems = lexems;
        }

        private void SkipSpaces()
        {
            while ( InBounds() && ( _Source[Offset].ToString().IndexOfAny(SpaceChars) >= 0) )
                Offset++;
        }

        private Lexem ProcessStatic()
        {
            foreach (var def in LexemDefinitions.Statics)
            {
                var rep = def.Representation;
                var len = rep.Length;

                if (Offset + len > _Source.Length || _Source.Substring(Offset, len) != rep)
                    continue;

                if (Offset + len < _Source.Length && def.IsKeyword)
                {
                    var nextChar = _Source[Offset + len];
                    if (nextChar == '_' || char.IsLetterOrDigit(nextChar))
                        continue;
                }

                Offset += len;
                return new Lexem { Type = def.Kind, Offset = Offset, Length = len };
            }

            return null;
        }

        private Lexem ProcessDynamic()
        {
            foreach (var def in LexemDefinitions.Dynamics)
            {
                var match = def.Representation.Match(_Source, Offset);
                if (!match.Success)
                    continue;

                Offset += match.Length;
                return new Lexem { Type = def.Kind, Offset = Offset, Length = match.Length, Value = match.Value, isNot = false };
            }

            return null;
        }

        private bool InBounds()
        {
            return Offset < _Source.Length;
        }

        public void SetNot(Lexem theLexem)
        {
            theLexem.isNot = true;
        }
    }

}
