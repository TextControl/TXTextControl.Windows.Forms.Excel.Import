using TXTextControl;

namespace tx_excel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadSheet_Click(object sender, EventArgs e)
        {
            LoadSettings loadSettings = new LoadSettings()
            {
                DocumentPartName = "Sheet1"
            };

            textControl1.Load("pl.xlsx", TXTextControl.StreamType.SpreadsheetML, loadSettings);

            if (cbAdaptSize.Checked)
            {
                TXTextControl.Table table = textControl1.Tables.GetItem();
                table.AdaptSize(textControl1, true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TXTextControl.Table table = textControl1.Tables.GetItem();
            table.ConvertCellsToMergeFields(textControl1, 1, 5, 6, 10);
        }
    }

}
