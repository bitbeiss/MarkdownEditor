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
using System.Diagnostics;
using System.Reflection;
using Markdig;

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


        private void btnUndo_click(object sender, RoutedEventArgs e) {
            rtbMainText.Undo();

        }

        private void btnRedo_click(object sender, RoutedEventArgs e) {
            rtbMainText.Redo();
        }                                                                       

        private void btnDisplay_click(object sender, RoutedEventArgs e)
        {
            string richText = new TextRange(rtbMainText.Document.ContentStart, rtbMainText.Document.ContentEnd).Text;
            var result = Markdown.ToHtml(richText);
            webBrowser.NavigateToString(result);
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
            rtbMainText.Selection.Text = Regex.Replace(rtbMainText.Selection.Text, "\r\n", "  \r\n\t");
            rtbMainText.Selection.Text = "  \n\t" + rtbMainText.Selection.Text;
        }

        private void btnSeparator_click(object sender, RoutedEventArgs e)
        {
            TextPointer position = rtbMainText.Selection.Start;
            if (position.IsAtLineStartPosition)
            {
                position.InsertTextInRun("- - -");
                position.InsertLineBreak();
            }
            else
            {
                position = position.InsertLineBreak();
                position.GetPositionAtOffset(0, LogicalDirection.Forward).InsertTextInRun("- - -");
                position.GetPositionAtOffset(5, LogicalDirection.Forward).InsertLineBreak();
            }
        }

        private void btnLineBreak_click(object sender, RoutedEventArgs e)
        {
            rtbMainText.Selection.Start.InsertTextInRun("  ");
            rtbMainText.Selection.Start.GetPositionAtOffset(2, LogicalDirection.Forward).InsertLineBreak();
        }

        private void btnParagraph_click(object sender, RoutedEventArgs e)
        {
            rtbMainText.Selection.Start.InsertLineBreak();
            rtbMainText.Selection.Start.InsertLineBreak();
        }

        private void btnQuote_click(object sender, RoutedEventArgs e)
        {
            rtbMainText.Selection.Text = Regex.Replace(rtbMainText.Selection.Text, "\r\n", "  \r\n> ");
            rtbMainText.Selection.Text = "  \n> " + rtbMainText.Selection.Text;
        }

        private void OnClickHeading1Level(object sender, RoutedEventArgs e)
        {
            //heading level 1 #txt#
            rtbMainText.Selection.Start.InsertTextInRun(" # ");
            rtbMainText.Selection.End.InsertTextInRun(" # ");
        }

        private void OnClickHeading2Level(object sender, RoutedEventArgs e)
        {
            //heading level 2 #txt#
            rtbMainText.Selection.Start.InsertTextInRun(" ## ");
            rtbMainText.Selection.End.InsertTextInRun(" ## ");
        }

        private void OnClickHeading3Level(object sender, RoutedEventArgs e)
        {
            //heading level 3 #txt#
            rtbMainText.Selection.Start.InsertTextInRun(" ### ");
            rtbMainText.Selection.End.InsertTextInRun(" ### ");
        }

        private void OnClickHeading4Level(object sender, RoutedEventArgs e)
        {
            //heading level 4 #txt#
            rtbMainText.Selection.Start.InsertTextInRun(" #### ");
            rtbMainText.Selection.End.InsertTextInRun(" #### ");
        }

        private void OnClickHeading5Level(object sender, RoutedEventArgs e)
        {
            //heading level 5 #txt#
            rtbMainText.Selection.Start.InsertTextInRun(" ##### ");
            rtbMainText.Selection.End.InsertTextInRun(" ##### ");
        }

        private void OnClickHeading6Level(object sender, RoutedEventArgs e)
        {
            //heading level 6 #txt#
            rtbMainText.Selection.Start.InsertTextInRun(" ###### ");
            rtbMainText.Selection.End.InsertTextInRun(" ###### ");
        }

        private void btnList_click(object sender, RoutedEventArgs e)
        {
            
            rtbMainText.Selection.Start.InsertTextInRun("+ ");
            
            //Regex reg = new Regex("(\n|\r\n?)", RegexOptions.Compiled);
            //Regex reg = new Regex("(\n)", RegexOptions.Compiled);
            TextPointer position = rtbMainText.Selection.Start;
            rtbMainText.Selection.Text = Regex.Replace(rtbMainText.Selection.Text.Trim('\n'), "\r\n", "  \r\n+ ");
            /*
            MatchCollection matches = reg.Matches(rtbMainText.Selection.Text);
            Int32 addOffset = 0;
            foreach (Match ma in matches)
            {
                //System.Diagnostics.Debug.WriteLine("%i:"+ i.ToString());
                rtbMainText.CaretPosition = position.GetPositionAtOffset(ma.Index + addOffset + 2, LogicalDirection.Forward);
                rtbMainText.CaretPosition.InsertTextInRun("+ ");
                //Inserted "+" offset: shifted by +3!  ("\n" and one position to end up at the beginning of the next line.)
                addOffset = addOffset + 4;
            }
            */
        }

        private void btnNumberedList_click(object sender, RoutedEventArgs e)
        {
            
            rtbMainText.Selection.Start.InsertTextInRun("1. ");

            //Regex reg = new Regex("(\n)", RegexOptions.Compiled);

            TextPointer position = rtbMainText.Selection.Start;
            rtbMainText.Selection.Text = Regex.Replace(rtbMainText.Selection.Text.Trim('\n'), "\r\n", "  \r\n1. ");

            /*
            MatchCollection matches = reg.Matches(rtbMainText.Selection.Text);
            Int32 addOffset = 0;
            foreach (Match ma in matches)
            {
                rtbMainText.CaretPosition = position.GetPositionAtOffset(ma.Index + addOffset + 3, LogicalDirection.Forward);
                rtbMainText.CaretPosition.InsertTextInRun("1. ");
                addOffset = addOffset + 5;
            }
            */
        }

        private void btnInsertPhoto_click(object sender, RoutedEventArgs e)
        {
            rtbMainText.Selection.Start.InsertTextInRun("![");
            rtbMainText.Selection.End.InsertTextInRun("](pfad)");
        }

        private void btnInsertHyperlink_click(object sender, RoutedEventArgs e)
        {
            if(rtbMainText.Selection.IsEmpty)
                rtbMainText.Selection.Start.InsertTextInRun("[](http://)");
            else
            {
                rtbMainText.Selection.Start.InsertTextInRun("[");
                rtbMainText.Selection.End.InsertTextInRun("](http://)");
            }
            
        }

        private void btnInsertTable_click(object sender, RoutedEventArgs e)
        {
            rtbMainText.Selection.Start.InsertTextInRun(
                "| Spalte 1 | Spalte 2 | Spalte 3 |  \n" +
                "| :------- | :------: | -------:  |  \n" +
                "| Zeile1 |Zeile 2 |Zeile 3|  \n" +
                "|Zeile1 |Zeile 2 |Zeile 3|  \n");
        }

        private void btnNewInstance_click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (Process myProcess = new Process())
                {
                    String path = System.AppDomain.CurrentDomain.BaseDirectory + "Markdown_Editor.exe";

                    myProcess.StartInfo.UseShellExecute = false;
                    myProcess.StartInfo.FileName = path;
                    myProcess.StartInfo.CreateNoWindow = false;
                    myProcess.Start();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private void btnFind_Click(object sender, RoutedEventArgs e)
        {
            string keyword = txbFind.Text;

            TextRange text = new TextRange(rtbMainText.Document.ContentStart, rtbMainText.Document.ContentEnd);
            TextPointer current = text.Start.GetInsertionPosition(LogicalDirection.Forward);
            while (current != null)
            {
                string textInRun = current.GetTextInRun(LogicalDirection.Forward);
                if (!string.IsNullOrWhiteSpace(textInRun))
                {
                    int index = textInRun.IndexOf(keyword);
                    if (index != -1)
                    {
                        TextPointer selectionStart = current.GetPositionAtOffset(index, LogicalDirection.Forward);
                        TextPointer selectionEnd = selectionStart.GetPositionAtOffset(keyword.Length, LogicalDirection.Forward);
                        TextRange selection = new TextRange(selectionStart, selectionEnd);
                        selection.ApplyPropertyValue(TextElement.BackgroundProperty, Brushes.Yellow);
                        rtbMainText.Selection.Select(selection.Start, selection.End);
                        rtbMainText.Focus();
                    }
                }
                current = current.GetNextContextPosition(LogicalDirection.Forward);
            }
        }

        private void btnReplace_Click(object sender, RoutedEventArgs e)
        {
            string keyword = txbFind.Text;
            string newString = txbReplace.Text;
            TextRange text = new TextRange(rtbMainText.Document.ContentStart, rtbMainText.Document.ContentEnd);
            TextPointer current = text.Start.GetInsertionPosition(LogicalDirection.Forward);
            while (current != null)
            {
                string textInRun = current.GetTextInRun(LogicalDirection.Forward);
                if (!string.IsNullOrWhiteSpace(textInRun))
                {
                    int index = textInRun.IndexOf(keyword);
                    if (index != -1)
                    {
                        TextPointer selectionStart = current.GetPositionAtOffset(index, LogicalDirection.Forward);
                        TextPointer selectionEnd = selectionStart.GetPositionAtOffset(keyword.Length, LogicalDirection.Forward);
                        TextRange selection = new TextRange(selectionStart, selectionEnd);
                        selection.Text = newString;
                        rtbMainText.Selection.Select(selection.Start, selection.End);
                        rtbMainText.Focus();
                    }
                }
                current = current.GetNextContextPosition(LogicalDirection.Forward);
            }
        }

        private void txbFind_TextChanged(object sender, TextChangedEventArgs e)
        {
            rtbMainText.SelectAll();
            rtbMainText.Selection.ApplyPropertyValue(TextElement.BackgroundProperty, Brushes.White);
        }
    }
}
