using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Xml.Linq;

namespace Convert_String_GUI
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string _user_input;
        public string user_input
        {
            get { return _user_input; }
            set
            {
                if (value != _user_input)
                {
                    _user_input = value;
                }
            }
        }

        private string _convert;
        public string convert
        {
            get { return _convert; }
            set
            {
                if (value != _convert)
                {
                    _convert = value;
                    OnPropertyChanged("convert");
                }
            }
        }

        private ICommand m_ButtonCommand;
        public ICommand ButtonCommand
        {
            get
            {
                return m_ButtonCommand;
            }
            set
            {
                m_ButtonCommand = value;
            }
        }
        public MainWindowViewModel()
        {
            ButtonCommand = new RelayCommand(new Action(ShowMessage));
        }
        public void ShowMessage()
        {
            convert = _user_input.ToUpper();
            MessageBox.Show(_user_input);        
        }
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

    }
}
