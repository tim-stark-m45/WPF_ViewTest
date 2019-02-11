using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowviewModel vm = new MainWindowviewModel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void open0_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var viewWindow = new ViewWindow();
            viewWindow.ShowDialog();
            

            //viewWindow.ViewTextBox.Text = vm.SelectedText.MainWindowText;
        }
    }

    public class MainWindowviewModel : ObservableObject
    {
        private ObservableCollection<Text> texts = new ObservableCollection<Text>();
        public ObservableCollection<Text> Texts { get => texts; set => Set(ref texts, value); }

        private Text selectedText;
        public Text SelectedText { get => selectedText; set => Set(ref selectedText, value); }

        public MainWindowviewModel()
        {
            Texts.Add(new Text
            {
                MainWindowText = "japsojdfpaofj",
            });
        }
    }

    public class Text : ObservableObject
    {
        private string mainWindowtext;
        public string MainWindowText { get => mainWindowtext; set => Set(ref mainWindowtext, value); }
    }
}
