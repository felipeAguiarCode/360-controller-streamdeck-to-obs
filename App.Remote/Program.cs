using System;
using System.Threading;
using SharpDX.XInput;

namespace App
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("🎮 Gamepad is Listening....");

      var controller = new Controller(UserIndex.One);
      var command = new ShortcutHandler();
      bool isRunning = true;
      bool isInitiate = false;

      while (isRunning)
      {
        var state = new State();
        controller.GetState(out state);

        switch (state.Gamepad.Buttons)
        {
          case GamepadButtonFlags.Start:
            if (isInitiate == false)
            {
              command.StartOBS();
              isInitiate = true;
            }
            else
            {
              command.PauseRecord();
            }
            break;
          case GamepadButtonFlags.B:
            command.StartRecord();
            break;
          case GamepadButtonFlags.A:
            command.PauseRecord();
            break;
          case GamepadButtonFlags.Y:
            command.ContinueRecord();
            break;
          case GamepadButtonFlags.DPadUp:
            command.ChangeToScene(1);
            break;
          case GamepadButtonFlags.DPadLeft:
            command.ChangeToScene(2);
            break;
          case GamepadButtonFlags.DPadRight:
            command.ChangeToScene(3);
            break;
        }

        Thread.Sleep(100);
      }
    }
  }
}
