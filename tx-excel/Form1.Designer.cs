namespace tx_excel
{
    partial class Form1
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
            textControl1 = new TXTextControl.TextControl();
            ribbon1 = new TXTextControl.Windows.Forms.Ribbon.Ribbon();
            ribbonFormattingTab1 = new TXTextControl.Windows.Forms.Ribbon.RibbonFormattingTab();
            ribbonFormulaTab1 = new TXTextControl.Windows.Forms.Ribbon.RibbonFormulaTab();
            rulerBar1 = new TXTextControl.RulerBar();
            statusBar1 = new TXTextControl.StatusBar();
            rulerBar2 = new TXTextControl.RulerBar();
            panel1 = new Panel();
            button1 = new Button();
            cbAdaptSize = new CheckBox();
            btnLoadSheet = new Button();
            ribbonReportingTab1 = new TXTextControl.Windows.Forms.Ribbon.RibbonReportingTab();
            ribbon1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textControl1
            // 
            textControl1.Dock = DockStyle.Fill;
            textControl1.Font = new Font("Arial", 10F);
            textControl1.FormattingPrinter = "Standard";
            textControl1.Location = new Point(0, 208);
            textControl1.Name = "textControl1";
            textControl1.Ribbon = ribbon1;
            textControl1.RulerBar = rulerBar1;
            textControl1.Size = new Size(868, 255);
            textControl1.StatusBar = statusBar1;
            textControl1.TabIndex = 0;
            textControl1.UserNames = null;
            textControl1.VerticalRulerBar = rulerBar2;
            // 
            // ribbon1
            // 
            ribbon1.Controls.Add(ribbonFormattingTab1);
            ribbon1.Controls.Add(ribbonFormulaTab1);
            ribbon1.Controls.Add(ribbonReportingTab1);
            ribbon1.Dock = DockStyle.Top;
            ribbon1.Font = new Font("Segoe UI", 9F);
            ribbon1.HotTrack = true;
            ribbon1.Location = new Point(0, 90);
            ribbon1.Name = "ribbon1";
            ribbon1.SelectedIndex = 3;
            ribbon1.Size = new Size(868, 118);
            ribbon1.TabIndex = 1;
            ribbon1.Text = "ribbon1";
            // 
            // ribbonFormattingTab1
            // 
            ribbonFormattingTab1.Location = new Point(4, 24);
            ribbonFormattingTab1.Name = "ribbonFormattingTab1";
            ribbonFormattingTab1.Size = new Size(860, 90);
            ribbonFormattingTab1.TabIndex = 1;
            // 
            // ribbonFormulaTab1
            // 
            ribbonFormulaTab1.Location = new Point(4, 24);
            ribbonFormulaTab1.Name = "ribbonFormulaTab1";
            ribbonFormulaTab1.Size = new Size(860, 90);
            ribbonFormulaTab1.TabIndex = 1;
            // 
            // rulerBar1
            // 
            rulerBar1.Dock = DockStyle.Top;
            rulerBar1.FormulaMode = TXTextControl.RulerBarFormulaMode.Always;
            rulerBar1.Location = new Point(0, 208);
            rulerBar1.Name = "rulerBar1";
            rulerBar1.Size = new Size(868, 25);
            rulerBar1.TabIndex = 3;
            rulerBar1.Text = "rulerBar1";
            // 
            // statusBar1
            // 
            statusBar1.BackColor = SystemColors.Control;
            statusBar1.Dock = DockStyle.Bottom;
            statusBar1.Font = new Font("Segoe UI", 9F);
            statusBar1.Location = new Point(0, 463);
            statusBar1.Name = "statusBar1";
            statusBar1.Size = new Size(868, 22);
            statusBar1.TabIndex = 2;
            // 
            // rulerBar2
            // 
            rulerBar2.Alignment = TXTextControl.RulerBarAlignment.Left;
            rulerBar2.Dock = DockStyle.Left;
            rulerBar2.FormulaMode = TXTextControl.RulerBarFormulaMode.Always;
            rulerBar2.Location = new Point(0, 233);
            rulerBar2.Name = "rulerBar2";
            rulerBar2.Size = new Size(25, 230);
            rulerBar2.TabIndex = 4;
            rulerBar2.Text = "rulerBar2";
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(cbAdaptSize);
            panel1.Controls.Add(btnLoadSheet);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(868, 90);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(176, 40);
            button1.Name = "button1";
            button1.Size = new Size(183, 32);
            button1.TabIndex = 2;
            button1.Text = "Convert Cells to Merge Fields";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cbAdaptSize
            // 
            cbAdaptSize.AutoSize = true;
            cbAdaptSize.Checked = true;
            cbAdaptSize.CheckState = CheckState.Checked;
            cbAdaptSize.Location = new Point(12, 15);
            cbAdaptSize.Name = "cbAdaptSize";
            cbAdaptSize.Size = new Size(111, 19);
            cbAdaptSize.TabIndex = 1;
            cbAdaptSize.Text = "Adapt Table Size";
            cbAdaptSize.UseVisualStyleBackColor = true;
            // 
            // btnLoadSheet
            // 
            btnLoadSheet.Location = new Point(12, 40);
            btnLoadSheet.Name = "btnLoadSheet";
            btnLoadSheet.Size = new Size(134, 32);
            btnLoadSheet.TabIndex = 0;
            btnLoadSheet.Text = "Load Spreadsheet";
            btnLoadSheet.UseVisualStyleBackColor = true;
            btnLoadSheet.Click += btnLoadSheet_Click;
            // 
            // ribbonReportingTab1
            // 
            ribbonReportingTab1.Location = new Point(4, 24);
            ribbonReportingTab1.Name = "ribbonReportingTab1";
            ribbonReportingTab1.Size = new Size(860, 90);
            ribbonReportingTab1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 485);
            Controls.Add(rulerBar2);
            Controls.Add(rulerBar1);
            Controls.Add(textControl1);
            Controls.Add(ribbon1);
            Controls.Add(statusBar1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Importing Excel XLSX Sheets";
            Load += Form1_Load;
            ribbon1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TXTextControl.TextControl textControl1;
        private TXTextControl.Windows.Forms.Ribbon.Ribbon ribbon1;
        private TXTextControl.Windows.Forms.Ribbon.RibbonFormulaTab ribbonFormulaTab1;
        private TXTextControl.Windows.Forms.Ribbon.RibbonFormattingTab ribbonFormattingTab1;
        private TXTextControl.RulerBar rulerBar1;
        private TXTextControl.StatusBar statusBar1;
        private TXTextControl.RulerBar rulerBar2;
        private Panel panel1;
        private CheckBox cbAdaptSize;
        private Button btnLoadSheet;
        private Button button1;
        private TXTextControl.Windows.Forms.Ribbon.RibbonReportingTab ribbonReportingTab1;
    }
}
