# This example demonstrate how to apply background color for different group in xamarin.forms listview

You can format the different levels of the group by binding the [converter](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/data-binding/converters) for the loaded elements to the [GroupHeaderTemplate](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfListView.XForms~Syncfusion.ListView.XForms.SfListView~GroupHeaderTemplate.html) of the Xamarin.Forms [SfListView](https://help.syncfusion.com/xamarin/listview/overview).

**XAML**

Defined group header template with **converter**.
``` xml
<syncfusion:SfListView.GroupHeaderTemplate>
    <DataTemplate>
        <ViewCell>
            <ViewCell.View>
                <StackLayout BackgroundColor="{Binding Level, Converter={StaticResource groupHeaderConverter}}" 
                                Padding="{Binding Level,Converter={StaticResource groupHeaderConverter}}">
                    <Label x:Name="label" Text="{Binding Key}" 
                            FontSize="22"                                   
                            FontAttributes="Bold"                                    
                            VerticalOptions="Center" 
                            HorizontalOptions="Start" 
                            />
                </StackLayout>
            </ViewCell.View>
        </ViewCell>
    </DataTemplate>
</syncfusion:SfListView.GroupHeaderTemplate>
```
**C#**

Set [BackgroundColor](https://docs.microsoft.com/en-us/dotnet/api/xamarin.forms.visualelement.backgroundcolor?view=xamarin-forms) and [Padding](https://docs.microsoft.com/en-us/dotnet/api/xamarin.forms.layout.padding) to the different group levels.
``` c#
public class GroupHeaderConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (targetType.Name == "Color")
        {
            if ((int)value == 1)
                return Color.Aqua;
            else
                return Color.AntiqueWhite;
        }
        else
        {
            if ((int)value == 1)
                return new Thickness(5, 5, 5, 0);
            else
                return new Thickness((int)value * 15, 5, 5, 0);
        }
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return value;
    }
}
```
**Output**

![MultiGrouping](https://github.com/SyncfusionExamples/level-based-formatting-of-group-header-listview-xamarin/blob/master/ScreenShot/MultiGrouping.png)
