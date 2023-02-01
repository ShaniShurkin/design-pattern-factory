
using DesignPatterns1;

#region תרגיל 1
Waiter Sam = Waiter.WaiterInstance;
int hour;
Console.WriteLine("enter hour");
int.TryParse(Console.ReadLine(), out hour);
int minutes;
Console.WriteLine("enter minutes");
int.TryParse(Console.ReadLine(), out minutes);
if (hour == null)
{
    hour = 9;
}
if (minutes == null)
{
    minutes = 0;
}
if (hour < 9 || hour > 21 || minutes < 0 || minutes > 59)
{
    Console.WriteLine("You entered wrong time, We are ope between 09:00 - 21:00");
}
else
{
    List<Enum> list = Sam.ServeMeal(new DateTime(2023, 1, 1, hour, minutes, 0));
    foreach (Enum item in list)
    {
        Console.WriteLine(item.ToString());
    }
}


#endregion
#region תרגיל 2
IGUIFactory factory;
Console.WriteLine("please enter your CPU name");
string CPU = Console.ReadLine();


switch (CPU.ToLower())
{
    case "macintosh":
        factory = MacFactory.Factory;
        
        break;
    case "windows":
        factory = WinFactory.Factory;
        break;
    default:
        Console.WriteLine("You enter wrong name, the default is windows");
        factory = WinFactory.Factory;
        break;
}
Button button = factory.CreateButton();
Checkbox checkbox = factory.CreateCheckbox();
IControl specialControl = factory.CreateSpecialControl();
Console.WriteLine($"{button.Draw()}\n{checkbox.Draw()}\n{specialControl.Draw()}");


#endregion
