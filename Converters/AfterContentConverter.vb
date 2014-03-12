﻿<ValueConversion(GetType(String), GetType(String))>
<LocalizabilityAttribute(LocalizationCategory.NeverLocalize)>
Public NotInheritable Class AfterContentConverter
  Implements IValueConverter

  Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As Globalization.CultureInfo) As Object Implements IValueConverter.Convert
    Return value & parameter
  End Function

  Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
    Return value.Substring(0, value.Length - parameter.Length)
  End Function
End Class
