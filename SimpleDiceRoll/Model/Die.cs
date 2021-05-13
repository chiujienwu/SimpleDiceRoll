using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SimpleDiceRoll.Model
{
    public class Die: INotifyPropertyChanged
    {
        //setting up object for raising event for Two Way Binding through INotifyPropertyChanged interface implementation on the two properties for Die

        //backing fields are needed for property change notification
        private int _sides;
        private int _rolls;
        public int Sides
        {
            get => _sides;
            set
            {
                _sides = value;
                RaisePropertyChanged(nameof(Sides));
            }
        }
        public int Rolls
        {
            get => _rolls;
            set
            {
                _rolls = value;
                RaisePropertyChanged(nameof(Rolls));
            }
        }

        //INotifyPropertyChanged interface implementation
        public event PropertyChangedEventHandler PropertyChanged;

        //Method to capture the property has changed and if so invoke the event passing in the sender and the property name that is passed
        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
