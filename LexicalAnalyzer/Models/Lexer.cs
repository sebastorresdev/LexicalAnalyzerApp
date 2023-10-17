namespace LexicalAnalyzer.Models;

public class Lexer
{
    public string Code { get; set; } = string.Empty;
    public string Component { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"{Code} -> {Component}";
    }
}