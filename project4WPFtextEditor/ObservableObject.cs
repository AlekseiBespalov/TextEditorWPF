using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace project4WPFtextEditor
{
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChange<T>(ref T property, T value, [CallerMemberName] string propertyName = "")
        {
            property = value;
            var handler = PropertyChanged;
            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
