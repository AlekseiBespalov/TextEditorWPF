using project4WPFtextEditor.Models;
using System;
using System.Windows.Input;

namespace project4WPFtextEditor.ViewModels
{
    public class EditorViewModel
    {
        public ICommand FormatCommand { get; }
        public ICommand WrapCommand { get; }
        public FormatModel Format { get; set; }
        public DocumentModel Document { get; set; }

        public EditorViewModel(DocumentModel document)
        {
            Document = document;
            Format = new FormatModel();
            FormatCommand = new RelayCommand(OpenStyleDialog);
            WrapCommand = new RelayCommand(ToggleWrapp);
        }

        private void OpenStyleDialog()
        {
            var fontDialog = new FontDialog();
            fontDialog.DataContext = Format;
            fontDialog.ShowDialog();
        }

        private void ToggleWrapp()
        {
            if (Format.Wrap == System.Windows.TextWrapping.Wrap)
                Format.Wrap = System.Windows.TextWrapping.NoWrap;
            else
                Format.Wrap = System.Windows.TextWrapping.Wrap;
        }
    }
}
