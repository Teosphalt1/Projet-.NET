using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_String_GUI
{
    public class ConvertedString : INotifyPropertyChanged
    {
        private string m_convert;
        
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string convert
        {
            get
            {
                return m_convert;
            }
            set
            {
                m_convert = value;
                OnPropertyChanged("convert");
            }
        }
        
    }
}
