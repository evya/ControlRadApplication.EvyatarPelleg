namespace SimpleMVVMCalculator.ViewModels
{
    using System;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using System.Windows.Controls;
    using System.Windows.Input;
    using SimpleMVVMCalculator.Models;

    internal class CalculateViewModel
    {

        public const string CppDllRelativePath = @".\CppFunctions.dll";

        [DllImport(CppDllRelativePath, CallingConvention = CallingConvention.Cdecl)]

        public static extern double AddNumbers(double a, double b);
        /// <summary>
        /// Initializes a new instance of the CalculateViewModel class.
        /// </summary>
        public CalculateViewModel() {
            _Calculate = new Calculate();

            _Calculate.PropertyChanged += Calculate_PropertyChanged;
        }

        private void Calculate_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

            if (e.PropertyName == "Result")
                return;

            PerformCalculation();
        }

        private Calculate _Calculate;
        /// <summary>
        /// Gets the customer instance
        /// </summary>
        public Calculate Calculate {
            get {
                return _Calculate;
            }
        }

        /// <summary>
        /// Gets the UpdateCommand for the ViewModel
        /// </summary>
        public ICommand UpdateCommand {
            get;
            private set;
        }

        /// <summary>
        /// Saves changes made to the Calculate instance
        /// </summary>
        public void PerformCalculation() {
            Calculate.Result = AddNumbers(Calculate.Input1, Calculate.Input2);
        }
    }
}
