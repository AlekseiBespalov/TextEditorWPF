using System.Windows.Input;

namespace project4WPFtextEditor.ViewModels
{
    public class HelpViewModel : ObservableObject
    {
        public ICommand HelpCommand { get; set; }

        public HelpViewModel()
        {
            HelpCommand = new RelayCommand(DisplayAbout);
        }

        private void DisplayAbout()
        {
            //We will open help dialog
        }
    }
}
