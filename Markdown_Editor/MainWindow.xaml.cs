using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Markdown_Editor
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Fluent.RibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string mkdFile;
        private void btnSave_click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = ".mkd";


            if (!File.Exists(mkdFile))
            {
                saveFileDialog.ShowDialog();
                mkdFile = saveFileDialog.FileName;
            }
            try
            {
                StreamWriter sw = new StreamWriter(mkdFile, false);
                sw.Write(new TextRange(rtbMainText.Document.ContentStart, rtbMainText.Document.ContentEnd).Text);
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }

        private void btnSaveAs_click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = ".mkd";

            saveFileDialog.ShowDialog();
            mkdFile = saveFileDialog.FileName;

            try
            {
                StreamWriter sw = new StreamWriter(mkdFile, false);
                sw.Write(new TextRange(rtbMainText.Document.ContentStart, rtbMainText.Document.ContentEnd).Text);
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }

        private void btnLoad_click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlgFileOpen = new OpenFileDialog();

            dlgFileOpen.InitialDirectory =
                 Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            //dlgFileOpen.Filter = "*.markdown|*.mdown|*.mkdn|*.mkd|*.md|*.mdtxt|*mdtext|*.txt|*.text*|.Rmd";
            dlgFileOpen.Filter = "Textdateien *.mkd";

            dlgFileOpen.ShowDialog();

            string content = "";

            try
            {
                StreamReader sr = new StreamReader(dlgFileOpen.FileName);
                content = sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Texteditor");
                return;
            }

            rtbMainText.Document.Blocks.Clear();
            rtbMainText.Document.Blocks.Add(new Paragraph(new Run(content)));

        }
    }
}
