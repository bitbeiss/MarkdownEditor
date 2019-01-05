using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Documents;
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
            //dlgFileOpen.Filter = "*.markdown|*.mdown|*.mkdn|*.mkd|*.md|*.mdtxt|*mdtext|*.txt|*.text*|.Rmd";
            dlgFileOpen.Filter = "Textdateien (*.mkd)|*.mkd";

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

        private void btnBold_click(object sender, RoutedEventArgs e)
        {
            //Fett **txt**
            rtbMainText.Selection.Start.InsertTextInRun("**");
            rtbMainText.Selection.End.InsertTextInRun("**");
        }

        private void btnItalic_click(object sender, RoutedEventArgs e)
        {
            //Kursiv *txt*
            rtbMainText.Selection.Start.InsertTextInRun("*");
            rtbMainText.Selection.End.InsertTextInRun("*");
        }

        private void btnCode_click(object sender, RoutedEventArgs e)
        {
            bool selectedTextStartsInMiddleOfLine = false;
            TextPointer position = rtbMainText.Selection.Start;
            if (!position.IsAtLineStartPosition)
            {
                position = position.InsertLineBreak();
                selectedTextStartsInMiddleOfLine = true;
            }
            position.InsertTextInRun("\t");

            Regex reg = new Regex("(\n)", RegexOptions.Compiled);

            int i = 0;
            MatchCollection matches = reg.Matches(rtbMainText.Selection.Text);
            Int32 addOffset = 0;
            foreach (Match ma in matches)
            {
                if ((i <= 0) && selectedTextStartsInMiddleOfLine)
                {
                    i++;
                    continue;
                }
                if(selectedTextStartsInMiddleOfLine)
                    rtbMainText.CaretPosition = position.GetPositionAtOffset(ma.Index + addOffset + 3, LogicalDirection.Forward);
                else
                    rtbMainText.CaretPosition = position.GetPositionAtOffset(ma.Index + addOffset + 4, LogicalDirection.Forward);
                rtbMainText.CaretPosition.InsertTextInRun("\t");
                addOffset = addOffset + 4;
            }

        }

        private void btnSeparator_click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLineBreak_click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnParagraph_click(object sender, RoutedEventArgs e)
        {
            rtbMainText.Selection.Start.InsertLineBreak();
        }

        private void btnQuote_click(object sender, RoutedEventArgs e)
        {
            rtbMainText.Selection.Start.InsertTextInRun(">");
        }

        private void btnUnQuote_click(object sender, RoutedEventArgs e)
        {
           
        }

        private void OnClickHeading1Level(object sender, RoutedEventArgs e)
        {
            //heading level 1 #txt#
            rtbMainText.Selection.Start.InsertTextInRun("#");
            rtbMainText.Selection.End.InsertTextInRun("#");
        }

        private void OnClickHeading2Level(object sender, RoutedEventArgs e)
        {
            //heading level 2 #txt#
            rtbMainText.Selection.Start.InsertTextInRun("##");
            rtbMainText.Selection.End.InsertTextInRun("##");
        }

        private void OnClickHeading3Level(object sender, RoutedEventArgs e)
        {
            //heading level 3 #txt#
            rtbMainText.Selection.Start.InsertTextInRun("###");
            rtbMainText.Selection.End.InsertTextInRun("###");
        }

        private void OnClickHeading4Level(object sender, RoutedEventArgs e)
        {
            //heading level 4 #txt#
            rtbMainText.Selection.Start.InsertTextInRun("####");
            rtbMainText.Selection.End.InsertTextInRun("####");
        }

        private void OnClickHeading5Level(object sender, RoutedEventArgs e)
        {
            //heading level 5 #txt#
            rtbMainText.Selection.Start.InsertTextInRun("#####");
            rtbMainText.Selection.End.InsertTextInRun("#####");
        }

        private void OnClickHeading6Level(object sender, RoutedEventArgs e)
        {
            //heading level 6 #txt#
            rtbMainText.Selection.Start.InsertTextInRun("######");
            rtbMainText.Selection.End.InsertTextInRun("######");
        }

        private void btnList_click(object sender, RoutedEventArgs e)
        {
            rtbMainText.Selection.Start.InsertTextInRun("+ ");

            //Regex reg = new Regex("(\n|\r\n?)", RegexOptions.Compiled);
            Regex reg = new Regex("(\n)", RegexOptions.Compiled);
            TextPointer position = rtbMainText.Selection.Start;

            MatchCollection matches = reg.Matches(rtbMainText.Selection.Text);
            Int32 addOffset = 0;
            foreach (Match ma in matches) {
                //System.Diagnostics.Debug.WriteLine("%i:"+ i.ToString());
                rtbMainText.CaretPosition = position.GetPositionAtOffset(ma.Index+addOffset+2, LogicalDirection.Forward); 
                rtbMainText.CaretPosition.InsertTextInRun("+ ");
                //Inserted "+" offset: shifted by +3!  ("\n" and one position to end up at the beginning of the next line.)
                addOffset = addOffset + 4;
            }
        }

        private void btnNumberedList_click(object sender, RoutedEventArgs e)
        {
            rtbMainText.Selection.Start.InsertTextInRun("1. ");

            //Regex reg = new Regex("(\n|\r\n?)", RegexOptions.Compiled);
            Regex reg = new Regex("(\n)", RegexOptions.Compiled);
            TextPointer position = rtbMainText.Selection.Start;

            MatchCollection matches = reg.Matches(rtbMainText.Selection.Text);
            Int32 addOffset = 0;
            foreach (Match ma in matches)
            {
                //System.Diagnostics.Debug.WriteLine("%i:"+ i.ToString());
                rtbMainText.CaretPosition = position.GetPositionAtOffset(ma.Index + addOffset + 3, LogicalDirection.Forward);
                rtbMainText.CaretPosition.InsertTextInRun("1. ");
                //Inserted "+" offset: shifted by +3!  ("\n" and one position to end up at the beginning of the next line.)
                addOffset = addOffset + 5;
            }
        }

        private void btnInsertPhoto_click(object sender, RoutedEventArgs e)
        {
            rtbMainText.Selection.Start.InsertTextInRun("![");
            rtbMainText.Selection.End.InsertTextInRun("](pfad)");
        }

        private void btnInsertHyperlink_click(object sender, RoutedEventArgs e)
        {

        }
    }
}
