using System.Windows;
using System.Windows.Media;

namespace project4WPFtextEditor.Models
{
    public class FormatModel : ObservableObject
    {
        private FontStyle _style;
        private FontWeight _weight;
        private FontFamily _family;
        private TextWrapping _wrap;
        private bool _isWrapped;
        private double _size;

        public FontStyle Style
        {
            get { return _style; }
            set { OnPropertyChange(ref _style, value);  }
        }

        public FontWeight Weight
        {
            get { return _weight; }
            set { OnPropertyChange(ref _weight, value); }
        }

        public FontFamily Family
        {
            get { return _family; }
            set { OnPropertyChange(ref _family, value); }
        }

        public TextWrapping Wrap
        {
            get { return _wrap; }
            set
            {
                OnPropertyChange(ref _wrap, value);
                isWrapped = value == TextWrapping.Wrap ? true : false;
            }
        }

        public bool isWrapped
        {
            get { return _isWrapped; }
            set { OnPropertyChange(ref _isWrapped, value); }
        }

        public double Size
        {
            get { return _size; }
            set { OnPropertyChange(ref _size, value); }
        }
    }
}
