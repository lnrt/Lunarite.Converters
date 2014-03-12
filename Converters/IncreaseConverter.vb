<ValueConversion(GetType(Decimal), GetType(Decimal))>
<LocalizabilityAttribute(LocalizationCategory.NeverLocalize)>
Public NotInheritable Class IncreaseConverter
  Implements IValueConverter

  Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As Globalization.CultureInfo) As Object Implements IValueConverter.Convert
    Dim N = 1D
    If parameter IsNot Nothing Then N = CDec(parameter)
    Return CDec(value) + N
  End Function

  Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
    Dim N = 1D
    If parameter IsNot Nothing Then N = CDec(parameter)
    Return CDec(value) - N
  End Function
End Class
