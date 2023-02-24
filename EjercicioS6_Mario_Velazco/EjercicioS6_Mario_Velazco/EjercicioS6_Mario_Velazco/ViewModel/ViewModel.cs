using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using EjercicioS6_Mario_Velazco.Model;

namespace EjercicioS6_Mario_Velazco.ViewModel
{
    public class ViewModelExpresion: INotifyiPropertyChanged 
    {
            float num1;
             float num2;
        public float Num1
        {
            get => num1;
            set
            {
                num1 = value;
                var args = new PropertyChangedEventArgs(nameof(Num1));
                PropertyChanged?.Invoke(this, args);
            }


        }
        public float Num2
        {
            get => num2;
            set
            {
                num2 = value;
                var args = new PropertyChangedEventArgs(nameof(Num2));
                PropertyChanged?.Invoke(this, args);
            }


        }


        public event PropertyChangedEventHandler PropertyChanged;
}      
    
}

