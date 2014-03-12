<ValueConversion(GetType(String), GetType(String))>
<LocalizabilityAttribute(LocalizationCategory.NeverLocalize)>
Public NotInheritable Class SubstringConverter
  Implements IValueConverter

  Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As Globalization.CultureInfo) As Object Implements IValueConverter.Convert
    Dim Pos = 0
    Dim Len = value.ToString.Length
    If Not String.IsNullOrWhiteSpace(parameter) Then
      If parameter.ToString.Contains(",") Then
        Dim S = parameter.ToString.Split(",")
        Pos = CInt(S(0))
        Len = CInt(S(1))
      Else
        Pos = CInt(parameter)
      End If
      Pos = 0
      Len = value.ToString.Length
    End If
    Return value.ToString.Substring(Pos, Len)
  End Function

  Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
    Throw New NotImplementedException
  End Function
End Class
