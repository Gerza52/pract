using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class VievModel : INotifyPropertyChanged
    {
        private Phone selectedPhone;

        public ObservableCollection<Phone> Phones { get; set; }
        public Phone SelectedPhone
        {
            get { return selectedPhone; }
            set
            {
                selectedPhone = value;
                OnPropertyChanged("SelectedPhone");
            }
        }

        public VievModel()
        {
            Phones = new ObservableCollection<Phone>
            {
                new Phone { Title = "MagicBook", Company = "Honor", Price = 56000 },
                new Phone { Title = "Forse 1", Company = "DEXP", Price = 6000 },
                new Phone { Title = "RogStrigs", Company = "ASUS", Price = 109990 },
                new Phone { Title = "Redmi Note 12S", Company = "Xiaomi", Price = 22000 }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
