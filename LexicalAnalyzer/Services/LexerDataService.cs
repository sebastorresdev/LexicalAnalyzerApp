using LexicalAnalyzer.Models;
using System.Text.RegularExpressions;
using System.Text;
using LexicalAnalyzer.Contracts;

namespace LexicalAnalyzer.Services;

public class LexerDataService : ILexerDataService
{
    private readonly List<Lexer> _lexers = new();

    // Diccionario para las palabras reservadas
    private readonly Dictionary<string, string> _tokensCpp = new()
    {
        {"include","Palabra reservada"},
        {"iostream","Palabra reservada"},
        {"and","Palabra reservada"},
        {"bitand","Palabra reservada"},
        {"case","Palabra reservada"},
        {"compl","Palabra reservada"},
        {"continue","Palabra reservada"},
        {"do","Palabra reservada"},
        {"enum","Palabra reservada"},
        {"FALSE","Palabra reservada"},
        {"goto","Palabra reservada"},
        {"long","Palabra reservada"},
        {"not","Palabra reservada"},
        {"or","Palabra reservada"},
        {"public","Palabra reservada"},
        {"short","Palabra reservada"},
        {"static_assert","Palabra reservada"},
        {"template","Palabra reservada"},
        {"try","Palabra reservada"},
        {"union","Palabra reservada"},
        {"void","Palabra reservada"},
        {"xor","Palabra reservada"},
        {"and_eq","Palabra reservada"},
        {"bitor","Palabra reservada"},
        {"catch","Palabra reservada"},
        {"const","Palabra reservada"},
        {"decltype","Palabra reservada"},
        {"double","Palabra reservada"},
        {"explicit","Palabra reservada"},
        {"float","Palabra reservada"},
        {"if","Palabra reservada"},
        {"mutable","Palabra reservada"},
        {"not_eq","Palabra reservada"},
        {"or_eq","Palabra reservada"},
        {"register","Palabra reservada"},
        {"signed","Palabra reservada"},
        {"static_cast","Palabra reservada"},
        {"this","Palabra reservada"},
        {"typedef","Palabra reservada"},
        {"unsigned","Palabra reservada"},
        {"volatile","Palabra reservada"},
        {"xor_eq","Palabra reservada"},
        {"asm","Palabra reservada"},
        {"bool","Palabra reservada"},
        {"char","Palabra reservada"},
        {"constexpr","Palabra reservada"},
        {"default","Palabra reservada"},
        {"dynamic_cast","Palabra reservada"},
        {"export","Palabra reservada"},
        {"for","Palabra reservada"},
        {"inline","Palabra reservada"},
        {"namespace","Palabra reservada"},
        {"nullptr","Palabra reservada"},
        {"private","Palabra reservada"},
        {"reinterpret_cast","Palabra reservada"},
        {"sizeof","Palabra reservada"},
        {"struct","Palabra reservada"},
        {"throw","Palabra reservada"},
        {"typeid","Palabra reservada"},
        {"using","Palabra reservada"},
        {"wchar_t","Palabra reservada"},
        {"auto","Palabra reservada"},
        {"break","Palabra reservada"},
        {"class","Palabra reservada"},
        {"const_cast","Palabra reservada"},
        {"delete","Palabra reservada"},
        {"else","Palabra reservada"},
        {"extern","Palabra reservada"},
        {"friend","Palabra reservada"},
        {"int","Palabra reservada"},
        {"new","Palabra reservada"},
        {"operator","Palabra reservada"},
        {"protected","Palabra reservada"},
        {"return","Palabra reservada"},
        {"static","Palabra reservada"},
        {"switch","Palabra reservada"},
        {"TRUE","Palabra reservada"},
        {"typename","Palabra reservada"},
        {"virtual","Palabra reservada"},
        {"while","Palabra reservada"},
        { "+", "Operador aritmetico" },
        { "-", "Operador aritmetico" },
        { "*", "Operador aritmetico" },
        { "/", "Operador aritmetico" },
        { "%", "Operador aritmetico" },
        { "=", "Operador asignacion" },
        {"+=", "Operador asignacion" },
        {"-=", "Operador asignacion" },
        {"*=", "Operador asignacion" },
        {"/=", "Operador asignacion" },
        {"%=", "Operador asignacion" },
        {"&=", "Operador asignacion" },
        {"|=", "Operador asignacion" },
        {"^=", "Operador asignacion" },
        {"<<=","Operador asignacion" },
        {">>=","Operador asignacion" },
        {"==", "Operador relacional" },
        {"!=", "Operador relacional" },
        {"<",  "Operador relacional" },
        {">",  "Operador relacional" },
        {"<=", "Operador relacional" },
        {">=", "Operador relacional" },
        {";", "Operador fin de linea" },
        {"<<", "Operador Desplazamiento" },
        {">>", "Operador Desplazamiento" },
    };
    private readonly Dictionary<string, string> _tokensCSharp = new()
    {
        {"abstract", "Palabra reservada"},
        {"as", "Palabra reservada"},
        {"base", "Palabra reservada"},
        {"bool", "Palabra reservada"},
        {"break", "Palabra reservada"},
        {"byte", "Palabra reservada"},
        {"case", "Palabra reservada"},
        {"catch", "Palabra reservada"},
        {"char", "Palabra reservada"},
        {"checked", "Palabra reservada"},
        {"class", "Palabra reservada"},
        {"const", "Palabra reservada"},
        {"continue", "Palabra reservada"},
        {"decimal", "Palabra reservada"},
        {"default", "Palabra reservada"},
        {"delegate", "Palabra reservada"},
        {"do", "Palabra reservada"},
        {"double", "Palabra reservada"},
        {"else", "Palabra reservada"},
        {"enum", "Palabra reservada"},
        {"event", "Palabra reservada"},
        {"explicit", "Palabra reservada"},
        {"extern", "Palabra reservada"},
        {"false", "Palabra reservada"},
        {"finally", "Palabra reservada"},
        {"fixed", "Palabra reservada"},
        {"float", "Palabra reservada"},
        {"for", "Palabra reservada"},
        {"foreach", "Palabra reservada"},
        {"goto", "Palabra reservada"},
        {"if", "Palabra reservada"},
        {"implicit", "Palabra reservada"},
        {"in", "Palabra reservada"},
        {"int", "Palabra reservada"},
        {"interface", "Palabra reservada"},
        {"internal", "Palabra reservada"},
        {"is", "Palabra reservada"},
        {"lock", "Palabra reservada"},
        {"long", "Palabra reservada"},
        {"namespace", "Palabra reservada"},
        {"new", "Palabra reservada"},
        {"null", "Palabra reservada"},
        {"object", "Palabra reservada"},
        {"operator", "Palabra reservada"},
        {"out", "Palabra reservada"},
        {"override", "Palabra reservada"},
        {"params", "Palabra reservada"},
        {"private", "Palabra reservada"},
        {"protected", "Palabra reservada"},
        {"public", "Palabra reservada"},
        {"readonly", "Palabra reservada"},
        {"ref", "Palabra reservada"},
        {"return", "Palabra reservada"},
        {"sbyte", "Palabra reservada"},
        {"sealed", "Palabra reservada"},
        {"short", "Palabra reservada"},
        {"sizeof", "Palabra reservada"},
        {"stackalloc", "Palabra reservada"},
        {"static", "Palabra reservada"},
        {"string", "Palabra reservada"},
        {"struct", "Palabra reservada"},
        {"switch", "Palabra reservada"},
        {"this", "Palabra reservada"},
        {"throw", "Palabra reservada"},
        {"true", "Palabra reservada"},
        {"try", "Palabra reservada"},
        {"typeof", "Palabra reservada"},
        {"uint", "Palabra reservada"},
        {"ulong", "Palabra reservada"},
        {"unchecked", "Palabra reservada"},
        {"unsafe", "Palabra reservada"},
        {"ushort", "Palabra reservada"},
        {"using", "Palabra reservada"},
        {"var", "Palabra reservada"},
        {"virtual", "Palabra reservada"},
        {"void", "Palabra reservada"},
        {"volatile", "Palabra reservada"},
        {"while", "Palabra reservada"},
        { "+", "Operador aritmético" },
        { "-", "Operador aritmético" },
        { "*", "Operador aritmético" },
        { "/", "Operador aritmético" },
        { "%", "Operador aritmético" },
        { "=", "Operador de asignación" },
        {"+=", "Operador de asignación" },
        {"-=", "Operador de asignación" },
        {"*=", "Operador de asignación" },
        {"/=", "Operador de asignación" },
        {"%=", "Operador de asignación" },
        {"&=", "Operador de asignación" },
        {"|=", "Operador de asignación" },
        {"^=", "Operador de asignación" },
        {"<<=","Operador de asignación" },
        {">>=","Operador de asignación" },
        {"==", "Operador relacional" },
        {"!=", "Operador relacional" },
        {"<",  "Operador relacional" },
        {">",  "Operador relacional" },
        {"<=", "Operador relacional" },
        {">=", "Operador relacional" },
        {";", "Operador de fin de línea" },
        {"<<", "Operador de desplazamiento izquierdo" },
        {">>", "Operador de desplazamiento derecho" },
        {"&&", "Operador lógico AND" },
        {"||", "Operador lógico OR" },
        {"!", "Operador lógico NOT" },
        {"~", "Operador de inversión" },
        {"&", "Operador de bits AND" },
        {"|", "Operador de bits OR" },
        {"^", "Operador de bits XOR" },
        {"?", "Operador condicional" },
        {"=>", "Operador de expresión lambda" }
    };


    // Expresion regulares para encontrar texto o numeros
    private const string _expresionRegularTexto = @"""([^""]*)""";
    private const string _expresionRegularNumero = @"[-+]?\d+(\.\d+)?";

    // Obtencion de datos
    public IEnumerable<Lexer> GetListLexerDataCpp(List<string> code)
    {
        // Procesar cada línea del código
        foreach (var line in code)
        {
            var tokens = GetTokens(line);

            foreach (var token in tokens)
            {
                var lexer = new Lexer();

                if (_tokensCpp.TryGetValue(token, out string? value))
                {
                    lexer.Code = token;
                    lexer.Component = value;
                    _lexers.Add(lexer);
                }
                // Verificar si es una expresion texto
                else if (Regex.IsMatch(token, _expresionRegularTexto))
                {
                    lexer.Code = token;
                    lexer.Component = "Constante Texto";
                    _lexers.Add(lexer);
                }
                else if (Regex.IsMatch(token, _expresionRegularNumero))
                {
                    lexer.Code = token;
                    lexer.Component = "Constante numerica";
                    _lexers.Add(lexer);
                }
                // Si no es palabra reservada ni operador, asumimos que es un identificador
                else
                {
                    lexer.Code = token;
                    lexer.Component = "Identificador";
                    _lexers.Add(lexer);
                }
            }
        }
        return _lexers;
    }
    public IEnumerable<Lexer> GetListLexerDataCSharp(List<string> code)
    {
        foreach (var line in code)
        {
            var tokens = GetTokens(line);

            foreach (var token in tokens)
            {
                var lexer = new Lexer();

                if (_tokensCSharp.TryGetValue(token, out string? value))
                {
                    lexer.Code = token;
                    lexer.Component = value;
                    _lexers.Add(lexer);
                }
                // Verificar si es una expresion texto
                else if (Regex.IsMatch(token, _expresionRegularTexto))
                {
                    lexer.Code = token;
                    lexer.Component = "Constante Texto";
                    _lexers.Add(lexer);
                }
                else if (Regex.IsMatch(token, _expresionRegularNumero))
                {
                    lexer.Code = token;
                    lexer.Component = "Constante numerica";
                    _lexers.Add(lexer);
                }
                // Si no es palabra reservada ni operador, asumimos que es un identificador
                else
                {
                    lexer.Code = token;
                    lexer.Component = "Identificador";
                    _lexers.Add(lexer);
                }
            }
        }
        return _lexers;
    }
    
    // Este es el algoritmo principal y que maneja todo
    // Aqui se crea el arbol de todas las palabras
    // Analizar y mejorar el codigo
    private static List<string> GetTokens(string code)
    {
        var tokens = new List<string>();
        var linea = code.Trim();
        StringBuilder sb = new();
        const char caracterVacio = ' ';
        const char dobleComillas = '"';
        const char punto = '.';
        const string operadores = "+-*/%=<>!|&";


        for (int c = 0; c < linea.Length; c++)
        {
            char caracterActual = linea[c];

            // Verifica si es una letra o un digito
            if (char.IsLetterOrDigit(caracterActual))
            {
                sb.Append(linea[c]);
            }
            // verifica si es un punto para ver si es un numero decimal
            else if (caracterActual == punto)
            {
                if (int.TryParse(sb.ToString(), out _))
                {
                    sb.Append(caracterActual);
                }
                else
                {
                    tokens.Add(sb.ToString());
                    tokens.Add(caracterActual.ToString());
                    sb.Clear();
                }
            }
            else
            {
                if (sb.Length > 0)
                {
                    tokens.Add(sb.ToString());
                    sb.Clear();
                }

                // Verifica si es un caracter vacio, para obviarlo
                if (caracterActual == caracterVacio)
                {
                    continue;
                }
                // Verifica si es un texto en comillas dobles
                else if (caracterActual == dobleComillas)
                {
                    sb.Append(caracterActual);
                    c++;
                    while (linea[c] != dobleComillas)
                    {
                        sb.Append(linea[c]);
                        c++;
                    }
                    sb.Append(dobleComillas);
                    tokens.Add(sb.ToString());
                    sb.Clear();
                }
                else if (operadores.Contains(caracterActual))
                {
                    sb.Append(caracterActual);
                    if (c + 1 < linea.Length && linea[c + 1] == '=')
                    {
                        sb.Append('=');
                        c++;
                    }
                    else if (c + 1 < linea.Length && linea[c + 1] == caracterActual)
                    {
                        sb.Append(caracterActual);
                        c++;
                    }
                    tokens.Add(sb.ToString());
                    sb.Clear();
                }
                else
                {
                    tokens.Add(caracterActual.ToString());
                }
            }
        }
        return tokens;
    }


}
