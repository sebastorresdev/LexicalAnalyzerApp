using LexicalAnalyzer.Contracts;
using System.Drawing.Imaging;

namespace LexicalAnalyzer.Views;

public partial class LexicalAnalyzerView : Form, ILexicalAnalyzerView
{
    public LexicalAnalyzerView()
    {
        InitializeComponent();
        AssociateAndRaiseViewEvents();
    }

    private void AssociateAndRaiseViewEvents()
    {
        btnNew.Click += delegate { NewEvent?.Invoke(this, EventArgs.Empty); };
        btnOpenFile.Click += delegate { OpenFileEvent?.Invoke(this, EventArgs.Empty); };
        btnAnalyzer.Click += delegate { AnalyzerEvent?.Invoke(this, EventArgs.Empty); };
        btnSave.Click += delegate { SaveEvent?.Invoke(this, EventArgs.Empty); };
        btnCancel.Click += delegate { CancelEvent?.Invoke(this, EventArgs.Empty); };
    }

    // Properties or fields
    public bool OpenFileIsEnable
    {
        get { return btnOpenFile.Enabled; }
        set { btnOpenFile.Enabled = value; }
    }
    public bool SaveIsEnable
    {
        get { return btnSave.Enabled; }
        set { btnSave.Enabled = value; }
    }
    public string CodeToAnalyze
    {
        get { return txtCodeToAnalyze.Text; }
        set { txtCodeToAnalyze.Text = value; }
    }
    public string SelectedLanguageType
    {
        get { return cmbTypeLanguage.Text; }
        set { cmbTypeLanguage.Text = value; }
    }

    // Events
    public event EventHandler? NewEvent;
    public event EventHandler? OpenFileEvent;
    public event EventHandler? AnalyzerEvent;
    public event EventHandler? SaveEvent;
    public event EventHandler? CancelEvent;

    // Methods
    public void SetLexerListBindingSource(BindingSource lexerList)
    {
        dtvAnalysisResult.DataSource = lexerList;
    }

    public void ClearControls()
    {
        txtCodeToAnalyze.Clear();
        cmbTypeLanguage.Text = "";
        btnOpenFile.Enabled = true;
        btnSave.Enabled = false;
    }
}