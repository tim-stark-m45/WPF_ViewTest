using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    public class MainWindowViewModel : ObservableObject
    {
        public ObservableCollection<Text> Texts { get; set; } = new ObservableCollection<Text>();

        private Text selectedText;
        public Text SelectedText { get => selectedText; set => Set(ref selectedText, value); }

        public MainWindowViewModel()
        {
            Texts.Add(new Text
            {
                MainWindowText = "japsojdfpaofj",
            });
            Texts.Add(new Text
            {
                MainWindowText = "sdasdfdasdjif",
            });
        }

        //private string viewText;
        //public string ViewText { get => viewText; set => Set(ref viewText, value); }

        private RelayCommand viewButtonCommand;
        public RelayCommand ViewButtonCommand
        {
            get => viewButtonCommand ?? (viewButtonCommand = new RelayCommand(
            param =>
            {
                //MessageBox.Show(SelectedText.MainWindowText);
                ViewWindow viewWindow = new ViewWindow();
                viewWindow.ShowDialog();
                //viewWindow.ViewTextBox.Text = SelectedText.MainWindowText;
                //viewWindow.ViewTextBox.Text = SelectedText.MainWindowText;
            },
            param => SelectedText != null
            ));
        }
    }
}
