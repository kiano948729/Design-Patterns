using StrategyPattern.Classes;
using StrategyPattern.Classes.Commands;
using StrategyPattern.Interfaces;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            Light kitchenLight = new Light("Kitchen");
            Light livingRoomLight = new Light("Living Room");
            CeilingFan ceilingFan = new CeilingFan("Living Room Ceiling Fan");
            GarageDoor garageDoor = new GarageDoor(new Light("Garage"));
            Stereo stereo = new Stereo();

            remoteControl.SetCommand(1, new LightOnCommand(livingRoomLight), new LightOffCommand(livingRoomLight));
            remoteControl.SetCommand(2, new LightOnCommand(kitchenLight), new LightOffCommand(kitchenLight));
            remoteControl.SetCommand(3, new CeilingFanHighCommand(ceilingFan), new CeilingFanOffCommand(ceilingFan));
            remoteControl.SetCommand(4, new GarageDoorUpCommand(garageDoor), new GarageDoorDownCommand(garageDoor));
            remoteControl.SetCommand(5, new StereoOnWithCdCommand(stereo), new StereoOffCommand(stereo));

            Console.WriteLine(remoteControl);

            Console.WriteLine("Living room light: on, off, undo, undo");
            remoteControl.OnButtonWasPushed(1);   
            remoteControl.OffButtonWasPushed(1);  
            remoteControl.UndoButtonWasPushed();  
            remoteControl.UndoButtonWasPushed();  

            Console.WriteLine("Ceiling fan: high, off, undo, undo");
            remoteControl.OnButtonWasPushed(3);   
            remoteControl.OffButtonWasPushed(3);  
            remoteControl.UndoButtonWasPushed();  
            remoteControl.UndoButtonWasPushed();  

            Console.WriteLine("Garage door: up, undo");
            remoteControl.OnButtonWasPushed(4);   
            remoteControl.UndoButtonWasPushed();  

            Console.WriteLine("Stereo: on with CD, undo");
            remoteControl.OnButtonWasPushed(5);   
            remoteControl.UndoButtonWasPushed();  

            Console.WriteLine("History: kitchen on, fan high, garage up, dan 3x undo");
            remoteControl.OnButtonWasPushed(2);
            remoteControl.OnButtonWasPushed(3);
            remoteControl.OnButtonWasPushed(4);
            remoteControl.UndoButtonWasPushed();  
            remoteControl.UndoButtonWasPushed();  
            remoteControl.UndoButtonWasPushed();  

            Console.WriteLine("Undo op lege history");
            remoteControl.UndoButtonWasPushed();  

            Console.WriteLine("Macro: licht + stereo aan, undo");
            Command[] partyOn = { new LightOnCommand(livingRoomLight), new StereoOnWithCdCommand(stereo) };
            Command[] partyOff = { new LightOffCommand(livingRoomLight), new StereoOffCommand(stereo) };
            remoteControl.SetCommand(6, new MacroCommand(partyOn), new MacroCommand(partyOff));
            remoteControl.OnButtonWasPushed(6);   
            remoteControl.UndoButtonWasPushed();  
        }
    }
}