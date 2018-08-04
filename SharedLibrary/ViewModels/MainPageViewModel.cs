using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace SharedLibrary.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainPageViewModel()
        {
            AddCommand = new ActionCommand(() => People.Add(new Models.Person("New", DateTime.Now)));
        }

        string _labelText = "Is this Xamarin or WPF?";
        public string LabelText
        {
            get => _labelText;
            set
            {
                if (value == _labelText) return;
                _labelText = value;
                RaisePropertyChanged();
                Logs.Add("Label Text : " + value);
            }
        }

        double _sliderValue;
        public double SliderValue
        {
            get => _sliderValue;
            set
            {
                if (value == _sliderValue) return;
                _sliderValue = value;
                RaisePropertyChanged();
                Logs.Add("Slider Value : " + value);
            }
        }

        /// <summary>
        /// ObservableCollectionをListViewなどにバインドした場合、コレクションが編集されると自動で通知されて画面が更新されます
        /// </summary>
        public ObservableCollection<Models.Person> People { get; } = new ObservableCollection<Models.Person>();

        public ObservableCollection<string> Logs { get; } = new ObservableCollection<string>();

        public ICommand AddCommand { get; }
    }


}
