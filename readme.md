## References

* [asp-net-core](http://fiyazhasan.me/story-of-file-uploading-in-asp-net-core-part-i-mvc/)
* [EditableInvoice](https://css-tricks.com/examples/EditableInvoice/)

## Screenshots

| ARC | ARC2 
| --- | --- 
| ![postman](screenshots/1.PNG?raw=true ) | ![postman](screenshots/2.PNG?raw=true )


### Model class for file uploads

```csharp
public class AdModel
{
    public IFormFileCollection AdImages { get; set; }
    public string AdId { get; set; }
    public string AdCaption { get; set; }
}
```

### Code to generate Unique IDs

```csharp
public static string TickIdGet()
{
    var diff = DateTime.UtcNow.Ticks - new DateTime(2019, 2, 1).Ticks;
    return diff.ToString("X");
}
```
#### Sample output
```
TickIdGet-ID 77: AB6C1E15E70
TickIdGet-ID 78: AB6C1E16C4D
TickIdGet-ID 79: AB6C1E17A9C
TickIdGet-ID 80: AB6C1E188AC
TickIdGet-ID 81: AB6C1E197F9
TickIdGet-ID 82: AB6C1E1AF7A
TickIdGet-ID 83: AB6C1E1C018
TickIdGet-ID 84: AB6C1E1D86E
TickIdGet-ID 85: AB6C1E1E720
TickIdGet-ID 86: AB6C1E1F4B5
TickIdGet-ID 87: AB6C1E20326
TickIdGet-ID 88: AB6C1E216A1
TickIdGet-ID 89: AB6C1E22C65
TickIdGet-ID 90: AB6C1E2D1CE
TickIdGet-ID 91: AB6C1E307F3
TickIdGet-ID 92: AB6C1E35EDE
TickIdGet-ID 93: AB6C1E3B877
TickIdGet-ID 94: AB6C1E426D1
TickIdGet-ID 95: AB6C1E470BA
TickIdGet-ID 96: AB6C1E49591
TickIdGet-ID 97: AB6C1E4A5DE
TickIdGet-ID 98: AB6C1E4B8F1
TickIdGet-ID 99: AB6C1E4CA37
```

```csharp

public override bool FinishedLaunching(UIApplication app, NSDictionary options)
{
    global::Xamarin.Forms.Forms.Init();
    LoadApplication(new App());

    MessagingCenter.Subscribe<SignaturePadView>(this, "AllowLandscape", sender =>
    {

        long value = (long)UIInterfaceOrientation.LandscapeLeft;
        UIDevice.CurrentDevice.SetValueForKey(new NSNumber(value), new NSString("orientation"));
        UIViewController.AttemptRotationToDeviceOrientation();
    });
    
    //forces app to portrait mode after closing a Page containing only a Plot
    MessagingCenter.Subscribe<SignaturePadView>(this, "PreventLandscape", sender =>
    {
        long value = (long)UIInterfaceOrientation.Portrait;
        UIDevice.CurrentDevice.SetValueForKey(new NSNumber(value), new NSString("orientation"));
        UIViewController.AttemptRotationToDeviceOrientation();
    });

    return base.FinishedLaunching(app, options);
}
    
```

