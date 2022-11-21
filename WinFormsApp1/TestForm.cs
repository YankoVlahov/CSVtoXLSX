using IronXL;

namespace CSVtoXLSX
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e  )
        {
            string path = @"C:\Users\YankoVlahov\Desktop\MovementsExport_2022-09-30_2022-10-07.csv";
            // Create LoadOptions for CSV file
            WorkBook workbook = WorkBook.LoadCSV(path, fileFormat: ExcelFileFormat.XLSX, ListDelimiter: ";");
            //WorkSheet ws = workbook.DefaultWorkSheet;
            using (SaveFileDialog openFileDialog = new SaveFileDialog())
            {
                openFileDialog.FileName = "CsvToExcelConversion.xlsx";
                openFileDialog.ShowDialog();              
                string  file = openFileDialog.FileName;              
                workbook.SaveAs(file);
                // (@"C:\CsvToExcelConversion.xlsx");
                string getpath = @file + "CsvToExcelConversion.xlsx";
                    
                
            }

                
            
            
            
        }
    }
}