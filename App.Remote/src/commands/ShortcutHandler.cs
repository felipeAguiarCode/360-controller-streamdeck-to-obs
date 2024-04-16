using System;
using System.Diagnostics;

namespace App
{
  public class ShortcutHandler : InputSystem
  {

    public void StartOBS()
    {
      Environment.CurrentDirectory = @"C:\Program Files\obs-studio\bin\64bit";
      Process.Start(@"obs64.exe", "--scene '🎬[scene 3] -  full me' --disable-shutdown-check");
    }

    public void ChangeToScene(int SceneIndex)
    {
      switch (SceneIndex)
      {
        case 1:
          SimulateKeyPress(VIRTUALKEY_CONTROL);
          SimulateKeyPress(VIRTUALKEY_ALT);
          SimulateKeyPress(VIRTUALKEY_1);

          Thread.Sleep(100);

          SimulateKeyRelease(VIRTUALKEY_1);
          SimulateKeyRelease(VIRTUALKEY_ALT);
          SimulateKeyRelease(VIRTUALKEY_CONTROL);

          break;

        case 2:

          SimulateKeyPress(VIRTUALKEY_CONTROL);
          SimulateKeyPress(VIRTUALKEY_ALT);
          SimulateKeyPress(VIRTUALKEY_2);

          Thread.Sleep(100);

          SimulateKeyRelease(VIRTUALKEY_2);
          SimulateKeyRelease(VIRTUALKEY_ALT);
          SimulateKeyRelease(VIRTUALKEY_CONTROL);
          break;

        case 3:

          SimulateKeyPress(VIRTUALKEY_CONTROL);
          SimulateKeyPress(VIRTUALKEY_ALT);
          SimulateKeyPress(VIRTUALKEY_3);

          Thread.Sleep(100);

          SimulateKeyRelease(VIRTUALKEY_3);
          SimulateKeyRelease(VIRTUALKEY_ALT);
          SimulateKeyRelease(VIRTUALKEY_CONTROL);
          break;

      }
    }

    public void ContinueRecord()
    {
      SimulateKeyPress(VIRTUALKEY_CONTROL);
      SimulateKeyPress(VIRTUALKEY_ALT);
      SimulateKeyPress(VIRTUALKEY_OEM_1);

      Thread.Sleep(100);

      SimulateKeyRelease(VIRTUALKEY_OEM_1);
      SimulateKeyRelease(VIRTUALKEY_ALT);
      SimulateKeyRelease(VIRTUALKEY_CONTROL);
    }

    public void PauseRecord()
    {
      SimulateKeyPress(VIRTUALKEY_CONTROL);
      SimulateKeyPress(VIRTUALKEY_ALT);
      SimulateKeyPress(VIRTUALKEY_P);

      Thread.Sleep(100);

      SimulateKeyRelease(VIRTUALKEY_P);
      SimulateKeyRelease(VIRTUALKEY_ALT);
      SimulateKeyRelease(VIRTUALKEY_CONTROL);
    }

    public void StartRecord()
    {
      SimulateKeyPress(VIRTUALKEY_CONTROL);
      SimulateKeyPress(VIRTUALKEY_ALT);
      SimulateKeyPress(VIRTUALKEY_I);

      Thread.Sleep(100);

      SimulateKeyRelease(VIRTUALKEY_I);
      SimulateKeyRelease(VIRTUALKEY_ALT);
      SimulateKeyRelease(VIRTUALKEY_CONTROL);
    }
  }
}
