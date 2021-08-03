using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace ItemsSourceBindEnum.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "ComBox ItemsSource bind enum";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ObservableCollection<Week> Weeks
        {
            get
            {
                return weeks;
            }
        }

        private Week selectWeek;

        public Week SelectWeek
        {
            get { return selectWeek; }
            set 
            {
                SetProperty(ref selectWeek, value);
            }
        }


        public MainWindowViewModel()
        {

        }

        ObservableCollection<Week> weeks = new ObservableCollection<Week>(Enum.GetValues(typeof(Week)).Cast<Week>());
    }

    public enum Week
    {
        Monday=0,
        Tuesday=1,
        Wednesday=2,
        Thursday=3,
        Friday=4,
        Saturday=5,
        Sunday=6
    }
}
