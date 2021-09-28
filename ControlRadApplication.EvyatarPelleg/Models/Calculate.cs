namespace SimpleMVVMCalculator.Models
{
    using SimpleMVVMCalculator.ViewModels;
    using System.ComponentModel;
    
    public class Calculate : INotifyPropertyChanged
    {
        /// <summary>
        /// Initializes a new instance of the Calculate class.
        /// </summary>
        public Calculate()
        {
            Input1 = 0;
            Input2 = 0;
            Result = 0;
        }

        private double _Input1;
        private double _Input2;
        private double _Result;

        public double Input1
        {
            get {
                return _Input1;
            }
            set
            {
                _Input1 = value;
                OnPropertyChanged("Input1");
            }
        }
        public double Input2
        {
            get
            {
                return _Input2;
            }
            set
            {
                _Input2 = value;
                OnPropertyChanged("Input2");
            }
        }
        public double Result
        {
            get
            {
                return _Result;
            }
            set
            {
                _Result = value;
                OnPropertyChanged("Result");
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}