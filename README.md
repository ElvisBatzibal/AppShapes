# AppShapes
AppShapes


# 1) Update to Xamarin.Forms and install

- NGraphics Version="0.6.0-beta2" 
- SkiaSharp.Views.Forms Version="2.80.2" 
- Xamarin.Forms Version="4.8.0.1560" 
- Xamarin.Essentials Version="1.3.1" 


# 2) Configure Flags /AppShapes/App.xaml.cs

 - Device.SetFlags(new string[] { "Shapes_Experimental"});


# 3) Configure /AppShapes.Android/MainActivity.cs

- Xamarin.Forms.Forms.SetFlags("Shapes_Experimental");
- Xamarin.Essentials.Platform.Init(this, savedInstanceState);
- global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
