﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace Flight__n_Bite.ViewModels
{
    public class ShellViewModel : INotifyPropertyChanged
    {
        private Visibility _isPersonnel;
        public Visibility IsPersonnel { 
            get {
                return _isPersonnel;
            }
            set {
                _isPersonnel = value;
                OnPropertyChanged("IsPersonnel");
}
        }
        private Visibility _isPassenger;
        public Visibility IsPassenger {
            get {
                return _isPassenger;
            }
            set {
                _isPassenger = value;
                OnPropertyChanged("IsPassenger");
            }
        }
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}