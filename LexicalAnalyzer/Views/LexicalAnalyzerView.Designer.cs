namespace LexicalAnalyzer.Views;

partial class LexicalAnalyzerView
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        groupBox1 = new GroupBox();
        dtvAnalysisResult = new DataGridView();
        dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
        groupBox2 = new GroupBox();
        cmbTypeLanguage = new ComboBox();
        lblSelectedLanguage = new Label();
        btnAnalyzer = new Button();
        btnSave = new Button();
        btnOpenFile = new Button();
        btnCancel = new Button();
        btnNew = new Button();
        txtCodeToAnalyze = new TextBox();
        lblTitle = new Label();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dtvAnalysisResult).BeginInit();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(dtvAnalysisResult);
        groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        groupBox1.ForeColor = Color.CornflowerBlue;
        groupBox1.Location = new Point(11, 493);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(1004, 355);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        groupBox1.Text = "Resultado de análisis";
        // 
        // dtvAnalysisResult
        // 
        dtvAnalysisResult.AllowUserToAddRows = false;
        dtvAnalysisResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        dtvAnalysisResult.BackgroundColor = Color.White;
        dtvAnalysisResult.BorderStyle = BorderStyle.None;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = SystemColors.Control;
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dtvAnalysisResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dtvAnalysisResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dtvAnalysisResult.Dock = DockStyle.Fill;
        dtvAnalysisResult.Location = new Point(3, 27);
        dtvAnalysisResult.Margin = new Padding(4, 5, 4, 5);
        dtvAnalysisResult.Name = "dtvAnalysisResult";
        dtvAnalysisResult.RowHeadersVisible = false;
        dtvAnalysisResult.RowHeadersWidth = 62;
        dtvAnalysisResult.RowTemplate.Height = 25;
        dtvAnalysisResult.Size = new Size(998, 325);
        dtvAnalysisResult.TabIndex = 0;
        // 
        // dataGridViewTextBoxColumn1
        // 
        dataGridViewTextBoxColumn1.MinimumWidth = 8;
        dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        dataGridViewTextBoxColumn1.Width = 150;
        // 
        // dataGridViewTextBoxColumn2
        // 
        dataGridViewTextBoxColumn2.MinimumWidth = 8;
        dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        dataGridViewTextBoxColumn2.Width = 150;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(cmbTypeLanguage);
        groupBox2.Controls.Add(lblSelectedLanguage);
        groupBox2.Controls.Add(btnAnalyzer);
        groupBox2.Controls.Add(btnSave);
        groupBox2.Controls.Add(btnOpenFile);
        groupBox2.Controls.Add(btnCancel);
        groupBox2.Controls.Add(btnNew);
        groupBox2.Controls.Add(txtCodeToAnalyze);
        groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        groupBox2.ForeColor = Color.CadetBlue;
        groupBox2.Location = new Point(9, 73);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(1007, 413);
        groupBox2.TabIndex = 2;
        groupBox2.TabStop = false;
        groupBox2.Text = "Código fuente";
        // 
        // cmbTypeLanguage
        // 
        cmbTypeLanguage.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        cmbTypeLanguage.FormattingEnabled = true;
        cmbTypeLanguage.Items.AddRange(new object[] { "C++", "C#" });
        cmbTypeLanguage.Location = new Point(514, 57);
        cmbTypeLanguage.Name = "cmbTypeLanguage";
        cmbTypeLanguage.Size = new Size(171, 33);
        cmbTypeLanguage.TabIndex = 7;
        // 
        // lblSelectedLanguage
        // 
        lblSelectedLanguage.AutoSize = true;
        lblSelectedLanguage.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
        lblSelectedLanguage.ForeColor = Color.Black;
        lblSelectedLanguage.Location = new Point(206, 63);
        lblSelectedLanguage.Name = "lblSelectedLanguage";
        lblSelectedLanguage.Size = new Size(285, 21);
        lblSelectedLanguage.TabIndex = 6;
        lblSelectedLanguage.Text = "Seleccione el lenguaje de programacion";
        // 
        // btnAnalyzer
        // 
        btnAnalyzer.Image = Properties.Resources.retweet_;
        btnAnalyzer.Location = new Point(706, 33);
        btnAnalyzer.Name = "btnAnalyzer";
        btnAnalyzer.Size = new Size(94, 93);
        btnAnalyzer.TabIndex = 5;
        btnAnalyzer.Text = "Analizar";
        btnAnalyzer.TextImageRelation = TextImageRelation.ImageAboveText;
        btnAnalyzer.UseVisualStyleBackColor = true;
        // 
        // btnSave
        // 
        btnSave.Enabled = false;
        btnSave.Image = Properties.Resources.floppy_disk;
        btnSave.Location = new Point(806, 33);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(94, 93);
        btnSave.TabIndex = 4;
        btnSave.Text = "Guardar";
        btnSave.TextImageRelation = TextImageRelation.ImageAboveText;
        btnSave.UseVisualStyleBackColor = true;
        // 
        // btnOpenFile
        // 
        btnOpenFile.Image = Properties.Resources.open_folder;
        btnOpenFile.Location = new Point(104, 38);
        btnOpenFile.Name = "btnOpenFile";
        btnOpenFile.Size = new Size(94, 93);
        btnOpenFile.TabIndex = 3;
        btnOpenFile.Text = "Abrir";
        btnOpenFile.TextImageRelation = TextImageRelation.ImageAboveText;
        btnOpenFile.UseVisualStyleBackColor = true;
        // 
        // btnCancel
        // 
        btnCancel.Image = Properties.Resources.cancel;
        btnCancel.Location = new Point(907, 33);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(94, 93);
        btnCancel.TabIndex = 2;
        btnCancel.Text = "Cancelar";
        btnCancel.TextImageRelation = TextImageRelation.ImageAboveText;
        btnCancel.UseVisualStyleBackColor = true;
        // 
        // btnNew
        // 
        btnNew.Image = Properties.Resources.refresh;
        btnNew.Location = new Point(3, 38);
        btnNew.Name = "btnNew";
        btnNew.Size = new Size(94, 93);
        btnNew.TabIndex = 1;
        btnNew.Text = "Nuevo";
        btnNew.TextImageRelation = TextImageRelation.ImageAboveText;
        btnNew.UseVisualStyleBackColor = true;
        // 
        // txtCodeToAnalyze
        // 
        txtCodeToAnalyze.BackColor = SystemColors.ButtonHighlight;
        txtCodeToAnalyze.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        txtCodeToAnalyze.Location = new Point(3, 160);
        txtCodeToAnalyze.Multiline = true;
        txtCodeToAnalyze.Name = "txtCodeToAnalyze";
        txtCodeToAnalyze.ReadOnly = true;
        txtCodeToAnalyze.ScrollBars = ScrollBars.Vertical;
        txtCodeToAnalyze.Size = new Size(997, 244);
        txtCodeToAnalyze.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
        lblTitle.ForeColor = Color.CadetBlue;
        lblTitle.Location = new Point(309, 28);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(217, 32);
        lblTitle.TabIndex = 3;
        lblTitle.Text = "Analizador Léxico";
        // 
        // LexicalAnalyzerView
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1031, 867);
        Controls.Add(lblTitle);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        MaximizeBox = false;
        Name = "LexicalAnalyzerView";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Analizador Lexico";
        groupBox1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dtvAnalysisResult).EndInit();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private TextBox txtCodeToAnalyze;
    private Button btnNew;
    private Button btnCancel;
    private Button btnOpenFile;
    private Button btnSave;
    private Button btnAnalyzer;
    private Label lblSelectedLanguage;
    private ComboBox cmbTypeLanguage;
    private Label lblTitle;
    private DataGridView dtvAnalysisResult;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
}