using LexicalAnalyzer.Contracts;
using LexicalAnalyzer.Services;
using LexicalAnalyzer.Presenters;
using LexicalAnalyzer.Views;

namespace LexicalAnalyzer;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        // Inyeccion de dependencias
        IRepositoryService repository = new RepositoryService();
        ILexicalAnalyzerView view = new LexicalAnalyzerView();
        ILexerDataService lexerCollection = new LexerDataService();
        _ = new LexicalAnalyzerPresenter(repository, lexerCollection, view);

        Application.Run((Form)view);
    }
}