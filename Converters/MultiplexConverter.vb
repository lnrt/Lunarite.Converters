<ValueConversion(GetType(Object), GetType(Object))>
<LocalizabilityAttribute(LocalizationCategory.NeverLocalize)>
Public NotInheritable Class MultiplexConverter
  Implements IValueConverter

  Private _Converters As New Collections.ObjectModel.Collection(Of IValueConverter)

  <ComponentModel.BindableAttribute(True)>
  Public ReadOnly Property Items As Collections.ObjectModel.Collection(Of IValueConverter)
    Get
      Return _Converters
    End Get
  End Property

  Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As Globalization.CultureInfo) As Object Implements IValueConverter.Convert
    Dim ConvertedValue = value
    For Each _Converter In _Converters
      ConvertedValue = _Converter.Convert(ConvertedValue, targetType, parameter, culture)
    Next
    Return ConvertedValue
  End Function

  Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
    Dim ConvertedValue = value
    For Each _Converter In _Converters.Reverse
      ConvertedValue = _Converter.ConvertBack(ConvertedValue, targetType, parameter, culture)
    Next
    Return ConvertedValue
  End Function
End Class
