namespace LexicalAnalyzer.Contracts;

public interface ILexicalAnalyzerView
{
    // Properties - Fields
    bool OpenFileIsEnable { get; set; }
    bool SaveIsEnable { get; set; }
    string CodeToAnalyze { get; set; }
    string SelectedLanguageType { get; set; }

    // Events
    event EventHandler NewEvent;
    event EventHandler OpenFileEvent;
    event EventHandler AnalyzerEvent;
    event EventHandler SaveEvent;
    event EventHandler CancelEvent;

    // Methods
    void SetLexerListBindingSource(BindingSource lexerList);
    void ClearControls();
    void Show();
}
