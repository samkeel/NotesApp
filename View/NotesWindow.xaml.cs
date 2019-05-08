using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace NotesApp.View
{
    /// <summary>
    /// Interaction logic for NotesWindow.xaml
    /// </summary>
    public partial class NotesWindow : Window
    {
        public NotesWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ContentRichTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int ammountOfCharacters = (new TextRange(contentRichTextbox.Document.ContentStart, contentRichTextbox.Document.ContentEnd)).Text.Length;
            statusTextBlock.Text = $"Document length: {ammountOfCharacters} characters";
        }

        private void boldButton_Click(object sender, RoutedEventArgs e)
        {
            //var textToBold = new TextRange(contentRichTextbox.Selection.Start, contentRichTextbox.Selection.End);
            contentRichTextbox.Selection.ApplyPropertyValue(Inline.FontWeightProperty, FontWeights.Bold);
        }
    }
}
