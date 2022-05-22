


using OOPInCSharp.ClassInheritance.ExplicitVsImplicitInterfaces;
using OOPInCSharp.ClassInheritance.Interface;


#region IDisposable
using (MyDisposable testClassInterface = new MyDisposable()) { }
#endregion 

#region ExplicitVsImplicitInterfaces
// ImplicitInterface
ImplicitInterfaceClass implicitInterfaceClass = new();
implicitInterfaceClass.Temp();
implicitInterfaceClass.Test();

#region Description
/// <summary>
/// به چه دردی میخوره : 
/// در شراطی مختلفی ممکنه که بخوام یک تایپی رو استفاده بکنم یک امپلیمنشن انجام بدم  یک پیاد هزی انجام بدم
/// که این پیاده سازی من از یک اینترفیسی باشه  ولی کسی بخواد مستقیم از تایپ من استفاده بکنه نبینه که من 
/// دقیقا چه پیاده سازی انجام دادم نتونه مستقیم دسترسی پیدا بکنه
/// یا ممکنه امضاهای یکسانی در دو اینترفیسمختل داشته باشیم در اینصورت میایم اکسپلیسیت استفاده میکنیم 
/// تا دقیقا بگیم از کدوم امضا توی کدوم اینترفیس باید استفاده کنیم
/// </summary> 
#endregion
// ExplicitInterface
ExplicitInterfaceClass explicitInterfaceClass = new();
ExplicitInterface explicitInterface = explicitInterfaceClass;
explicitInterface.Test();
explicitInterface.Temp();
#endregion