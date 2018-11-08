namespace project4WPFtextEditor.Models
{
    public class DocumentModel : ObservableObject
    {
        private string _text;
        private string _filePath;
        private string _fileName;

        public string Text
        {
            get { return _text; }
            set { OnPropertyChange(ref _text, value); }
        }

        public string FilePath
        {
            get { return _filePath; }
            set { OnPropertyChange(ref _filePath, value); }
        }

        public string FileName
        {
            get { return _fileName; }
            set { OnPropertyChange(ref _fileName, value); }
        }

        public bool isEmpty
        {
            get
            {
                if (string.IsNullOrEmpty(FileName) || 
                    string.IsNullOrEmpty(FilePath))
                    return true;

                return false;
            }
        }
    }
}
