﻿using NotesApp.Model;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NotesApp.View.UserControls
{
    /// <summary>
    /// Interaction logic for NotebookControl.xaml
    /// </summary>
    public partial class NotebookControl : UserControl
    {


        public Notebook DisplayNotebook
        {
            get { return (Notebook)GetValue(notebookProperty); }
            set { SetValue(notebookProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty notebookProperty =
            DependencyProperty.Register("DisplayNotebook", typeof(Notebook), typeof(NotebookControl), new PropertyMetadata(null, SetValues));

        private static void SetValues(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            NotebookControl notebook = d as NotebookControl;
            if(notebook != null)
            {
                notebook.notebookNameTextBlock.Text = (e.NewValue as Model.Notebook).Name;
            }

        }

        public NotebookControl()
        {
            InitializeComponent();
        }
    }
}
