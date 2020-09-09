# Windows9xClassicWpf
The windows 9x classic window style for wpf.

# Screenshot
<img src="https://github.com/EjiHuang/Windows9xClassicWpf/blob/master/Screenshots/DemoScreenshot.bmp"/>

# Instruction manual
Add project reference which is Windows9xClassic. </br>
Edit your project's App.xaml like this:
```xml
<Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="/PresentationFramework.Classic;component/themes/Classic.xaml" />
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
</Application.Resources>
```
Finally, you can use Windows9xClassicWindow in main window xaml like this:
```xml
<win9x:Windows9xClassicWindow
    ...
    xmlns:win9x="clr-namespace:Windows9xClassic;assembly=Windows9xClassic"
    ...>
</win9x:Windows9xClassicWindow>
```

# Thanks
https://github.com/Ciastex/Windows95-WPF </br>
https://qiita.com/nia_tn1012/items/dad2ad412d648401600f