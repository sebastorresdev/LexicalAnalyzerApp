using LexicalAnalyzer.Models;

namespace LexicalAnalyzer.Contracts;

public interface ILexerDataService
{
    public IEnumerable<Lexer> GetListLexerDataCpp(List<string> code);
    public IEnumerable<Lexer> GetListLexerDataCSharp(List<string> code);
}
