using System;
using System.Windows;
using System.Windows.Data;

namespace Workbench_Example.Converters
{
    /// <summary>
    /// Converter that converts Boolean values to and from Visibility values.
    /// True = Visible
    /// False = Hidden
    /// </summary>
    public class BooleanToVisibilityConverter : IValueConverter
    {

        #region Public Methods

        /// <summary>
        /// Converts Boolean value to Visibility value
        /// </summary>
        /// <param name="value">Value</param>
        /// <param name="targetType">Target type</param>
        /// <param name="parameter">Parameter</param>
        /// <param name="culture">Culture info</param>
        /// <returns>Visibility value</returns>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return GetVisibility(value);
        }

        /// <summary>
        /// Not Implemented
        /// </summary>
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Private Methods

        private object GetVisibility(object value)
        {
            if (!(value is bool))
            {
                return Visibility.Hidden;
            }

            bool objValue = (bool)value;

            if (objValue)
            {
                return Visibility.Visible;
            }

            return Visibility.Hidden;
        }

        #endregion

    }
}
