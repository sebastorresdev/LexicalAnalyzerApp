using LexicalAnalyzer.Contracts;

namespace LexicalAnalyzer.Presenters;

public class LexicalAnalyzerPresenter
{
    private readonly IRepositoryService _repository;
    private readonly ILexerDataService _lexerDataService;
    private readonly ILexicalAnalyzerView _view;
    private BindingSource _lexerBindingSource;
    private List<string> _codeToAnalyzer;

    public LexicalAnalyzerPresenter(IRepositoryService repository, ILexerDataService lexerCollection, ILexicalAnalyzerView view)
    {
        // Inicializar campos
        _lexerBindingSource = new();
        _codeToAnalyzer = new();

        // Inyeccion de dependencias
        _repository = repository;
        _lexerDataService = lexerCollection;
        _view = view;

        // Asignacion de los eventos
        _view.NewEvent += NewAnalysis;
        _view.OpenFileEvent += OpenFileToAnalyzer;
        _view.AnalyzerEvent += AnalyzeCode;
        //_view.SaveEvent += SaveAnalysis;
        _view.CancelEvent += CancelAnalysis;

        // Enlazar la fuente de datos
        _view.SetLexerListBindingSource(_lexerBindingSource);

    }

    private void SaveAnalysis(object? sender, EventArgs e)
    {
        
    }

    private void CancelAnalysis(object? sender, EventArgs e)
    {
        Application.Exit();
    }

    private void AnalyzeCode(object? sender, EventArgs e)
    {

        if (!string.IsNullOrEmpty(_view.CodeToAnalyze))
        {
            if (_view.SelectedLanguageType == "C++")
                _lexerBindingSource.DataSource = _lexerDataService.GetListLexerDataCpp(_codeToAnalyzer);
            else if (_view.SelectedLanguageType == "C#")
                _lexerBindingSource.DataSource = _lexerDataService.GetListLexerDataCSharp(_codeToAnalyzer);
            else
            {
                MessageBox.Show("Falta seleccionar el lenguaje de programación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _view.SaveIsEnable = true;
        }
        else
        {
            MessageBox.Show("Falta ingresar el codigo", "Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }

    private void OpenFileToAnalyzer(object? sender, EventArgs e)
    {
        // revisar si bloqueo el control caso 1
        //NewAnalysis(sender, e);
        OpenFileDialog openFileDialog = new()
        {
            Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        };
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            // Manejar posibles errores
            var pathName = openFileDialog.FileName;
            _codeToAnalyzer = _repository.GetRepository(pathName).ToList();

            if (_codeToAnalyzer != null)
            {
                _view.CodeToAnalyze = string.Join(Environment.NewLine, _codeToAnalyzer);
                // caso 2
                _view.OpenFileIsEnable = false;
            }
        }
    }

    private void NewAnalysis(object? sender, EventArgs e)
    {
        _view.ClearControls();

        _lexerBindingSource.Clear();
        _lexerBindingSource = new BindingSource(); // Crear una nueva instancia
        _view.SetLexerListBindingSource(_lexerBindingSource);
    }


}
