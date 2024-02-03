using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CarListApp.Maui.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        string _title;
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotLoading))]
        bool  isLoading;

        public bool IsNotLoading => !isLoading;

      /*  public bool IsBusy
        {

            get=> _isBusy; 
            set
            {
                if (_isBusy == value)
                    return;
                _isBusy = value;
                OnPropertyChanged();
            }
        }
        public string Title
        {
            get => _title;
            set
            {
                if (_title == value) return;
                _title = value;
                OnPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        } */
    }
}
