namespace App
{
  public abstract class InputSystem
  {
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    private static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

    public const int KEYEVENTF_KEYDOWN = 0x0001; // Key down flag
    public const int KEYEVENTF_KEYUP = 0x0002; // Key up flag
    public const int VIRTUALKEY_ALT = 0x12; // Alt key code
    public const int VIRTUALKEY_CONTROL = 0x11; // Ctrl key code
    public const int VIRTUALKEY_0 = 0x30; // 0 key
    public const int VIRTUALKEY_1 = 0x31; // 1 key
    public const int VIRTUALKEY_2 = 0x32; // 2 key
    public const int VIRTUALKEY_3 = 0x33; // 3 key
    public const int VIRTUALKEY_4 = 0x34; // 4 key
    public const int VIRTUALKEY_5 = 0x35; // 5 key
    public const int VIRTUALKEY_6 = 0x36; // 6 key
    public const int VIRTUALKEY_7 = 0x37; // 7 key
    public const int VIRTUALKEY_8 = 0x38; // 8 key
    public const int VIRTUALKEY_9 = 0x39; // 9 key
    public const int VIRTUALKEY_A = 0x41; // A key
    public const int VIRTUALKEY_B = 0x42; // B key
    public const int VIRTUALKEY_C = 0x43; // C key
    public const int VIRTUALKEY_D = 0x44; // D key
    public const int VIRTUALKEY_E = 0x45; // E key
    public const int VIRTUALKEY_F = 0x46; // F key
    public const int VIRTUALKEY_G = 0x47; // G key
    public const int VIRTUALKEY_H = 0x48; // H key
    public const int VIRTUALKEY_I = 0x49; // I key
    public const int VIRTUALKEY_J = 0x4A; // J key
    public const int VIRTUALKEY_K = 0x4B; // K key
    public const int VIRTUALKEY_L = 0x4C; // L key
    public const int VIRTUALKEY_M = 0x4D; // M key
    public const int VIRTUALKEY_N = 0x4E; // N key
    public const int VIRTUALKEY_O = 0x4F; // O key
    public const int VIRTUALKEY_P = 0x50; // P key
    public const int VIRTUALKEY_Q = 0x51; // Q key
    public const int VIRTUALKEY_R = 0x52; // R key
    public const int VIRTUALKEY_S = 0x53; // S key
    public const int VIRTUALKEY_T = 0x54; // T key
    public const int VIRTUALKEY_U = 0x55; // U key
    public const int VIRTUALKEY_V = 0x56; // V key
    public const int VIRTUALKEY_W = 0x57; // W key
    public const int VIRTUALKEY_X = 0x58; // X key
    public const int VIRTUALKEY_Y = 0x59; // Y key
    public const int VIRTUALKEY_Z = 0x5A; // Z key
    public const int VIRTUALKEY_LWIN = 0x5B; // Left Windows key (Natural keyboard)
    public const int VIRTUALKEY_RWIN = 0x5C; // Right Windows key (Natural keyboard)
    public const int VIRTUALKEY_APPS = 0x5D; // Applications key (Natural keyboard)
    public const int VIRTUALKEY_SLEEP = 0x5F; // Computer Sleep key
    public const int VIRTUALKEY_NUMPAD0 = 0x60; // Numeric keypad 0 key
    public const int VIRTUALKEY_NUMPAD1 = 0x61; // Numeric keypad 1 key
    public const int VIRTUALKEY_NUMPAD2 = 0x62; // Numeric keypad 2 key
    public const int VIRTUALKEY_NUMPAD3 = 0x63; // Numeric keypad 3 key
    public const int VIRTUALKEY_NUMPAD4 = 0x64; // Numeric keypad 4 key
    public const int VIRTUALKEY_NUMPAD5 = 0x65; // Numeric keypad 5 key
    public const int VIRTUALKEY_NUMPAD6 = 0x66; // Numeric keypad 6 key
    public const int VIRTUALKEY_NUMPAD7 = 0x67; // Numeric keypad 7 key
    public const int VIRTUALKEY_NUMPAD8 = 0x68; // Numeric keypad 8 key
    public const int VIRTUALKEY_NUMPAD9 = 0x69; // Numeric keypad 9 key
    public const int VIRTUALKEY_MULTIPLY = 0x6A; // Multiply key (*)
    public const int VIRTUALKEY_ADD = 0x6B; // Add key (+)
    public const int VIRTUALKEY_SEPARATOR = 0x6C; // Separator key
    public const int VIRTUALKEY_SUBTRACT = 0x6D; // Subtract key (-)
    public const int VIRTUALKEY_DECIMAL = 0x6E; // Decimal key
    public const int VIRTUALKEY_DIVIDE = 0x6F; // Divide key (/)
    public const int VIRTUALKEY_F1 = 0x70; // F1 key
    public const int VIRTUALKEY_F2 = 0x71; // F2 key
    public const int VIRTUALKEY_F3 = 0x72; // F3 key
    public const int VIRTUALKEY_F4 = 0x73; // F4 key
    public const int VIRTUALKEY_F5 = 0x74; // F5 key
    public const int VIRTUALKEY_F6 = 0x75; // F6 key
    public const int VIRTUALKEY_F7 = 0x76; // F7 key
    public const int VIRTUALKEY_F8 = 0x77; // F8 key
    public const int VIRTUALKEY_F9 = 0x78; // F9 key
    public const int VIRTUALKEY_F10 = 0x79; // F10 key
    public const int VIRTUALKEY_F11 = 0x7A; // F11 key
    public const int VIRTUALKEY_F12 = 0x7B; // F12 key
    public const int VIRTUALKEY_F13 = 0x7C; // F13 key
    public const int VIRTUALKEY_F14 = 0x7D; // F14 key
    public const int VIRTUALKEY_F15 = 0x7E; // F15 key
    public const int VIRTUALKEY_F16 = 0x7F; // F16 key
    public const int VIRTUALKEY_F17 = 0x80; // F17 key
    public const int VIRTUALKEY_F18 = 0x81; // F18 key
    public const int VIRTUALKEY_F19 = 0x82; // F19 key
    public const int VIRTUALKEY_F20 = 0x83; // F20 key
    public const int VIRTUALKEY_F21 = 0x84; // F21 key
    public const int VIRTUALKEY_F22 = 0x85; // F22 key
    public const int VIRTUALKEY_F23 = 0x86; // F23 key
    public const int VIRTUALKEY_F24 = 0x87; // F24 key
    public const int VIRTUALKEY_NUMLOCK = 0x90; // NUM LOCK key
    public const int VIRTUALKEY_SCROLL = 0x91; // SCROLL LOCK key
    public const int VIRTUALKEY_LSHIFT = 0xA0; // Left SHIFT key
    public const int VIRTUALKEY_RSHIFT = 0xA1; // Right SHIFT key
    public const int VIRTUALKEY_LCONTROL = 0xA2; // Left CONTROL key
    public const int VIRTUALKEY_RCONTROL = 0xA3; // Right CONTROL key
    public const int VIRTUALKEY_LMENU = 0xA4; // Left MENU key
    public const int VIRTUALKEY_RMENU = 0xA5; // Right MENU key
    public const int VIRTUALKEY_BROWSER_BACK = 0xA6; // Browser Back key
    public const int VIRTUALKEY_BROWSER_FORWARD = 0xA7; // Browser Forward key
    public const int VIRTUALKEY_BROWSER_REFRESH = 0xA8; // Browser Refresh key
    public const int VIRTUALKEY_BROWSER_STOP = 0xA9; // Browser Stop key
    public const int VIRTUALKEY_BROWSER_SEARCH = 0xAA; // Browser Search key
    public const int VIRTUALKEY_BROWSER_FAVORITES = 0xAB; // Browser Favorites key
    public const int VIRTUALKEY_BROWSER_HOME = 0xAC; // Browser Start and Home key
    public const int VIRTUALKEY_VOLUME_MUTE = 0xAD; // Volume Mute key
    public const int VIRTUALKEY_VOLUME_DOWN = 0xAE; // Volume Down key
    public const int VIRTUALKEY_VOLUME_UP = 0xAF; // Volume Up key
    public const int VIRTUALKEY_MEDIA_NEXT_TRACK = 0xB0; // Next Track key
    public const int VIRTUALKEY_MEDIA_PREV_TRACK = 0xB1; // Previous Track key
    public const int VIRTUALKEY_MEDIA_STOP = 0xB2; // Stop Media key
    public const int VIRTUALKEY_MEDIA_PLAY_PAUSE = 0xB3; // Play/Pause Media key
    public const int VIRTUALKEY_LAUNCH_MAIL = 0xB4; // Start Mail key
    public const int VIRTUALKEY_LAUNCH_MEDIA_SELECT = 0xB5; // Select Media key
    public const int VIRTUALKEY_LAUNCH_APP1 = 0xB6; // Start Application 1 key
    public const int VIRTUALKEY_LAUNCH_APP2 = 0xB7; // Start Application 2 key
    public const int VIRTUALKEY_OEM_1 = 0xBA; // Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the ';:' key
    public const int VIRTUALKEY_OEM_PLUS = 0xBB; // For any country/region, the '+' key
    public const int VIRTUALKEY_OEM_COMMA = 0xBC; // For any country/region, the ',' key
    public const int VIRTUALKEY_OEM_MINUS = 0xBD; // For any country/region, the '-' key
    public const int VIRTUALKEY_OEM_PERIOD = 0xBE; // For any country/region, the '.' key
    public const int VIRTUALKEY_OEM_2 = 0xBF; // Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the '/?' key
    public const int VIRTUALKEY_OEM_3 = 0xC0; // Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the '`~' key
    public const int VIRTUALKEY_OEM_4 = 0xDB; // Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the '[{' key
    public const int VIRTUALKEY_OEM_5 = 0xDC; // Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the '\|' key
    public const int VIRTUALKEY_OEM_6 = 0xDD; // Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the ']}' key
    public const int VIRTUALKEY_OEM_7 = 0xDE; // Used for miscellaneous characters; it can vary by keyboard. For the US standard keyboard, the 'single-quote/double-quote' key
    public const int VIRTUALKEY_OEM_8 = 0xDF; // Used for miscellaneous characters; it can vary by keyboard.
    public const int VIRTUALKEY_OEM_AX = 0xE1; // OEM specific
    public const int VIRTUALKEY_OEM_102 = 0xE2; // Either the angle bracket key or the backslash key on the RT 102-key keyboard
    public const int VIRTUALKEY_ICO_HELP = 0xE3; // ICO_HELP
    public const int VIRTUALKEY_ICO_00 = 0xE4; // ICO_00
    public const int VIRTUALKEY_PROCESSKEY = 0xE5; // PROCESSKEY
    public const int VIRTUALKEY_ICO_CLEAR = 0xE6; // ICO_CLEAR
    public const int VIRTUALKEY_PACKET = 0xE7; // PACKET
    public const int VIRTUALKEY_OEM_RESET = 0xE9; // OEM Reset
    public const int VIRTUALKEY_OEM_JUMP = 0xEA; // OEM Jump
    public const int VIRTUALKEY_OEM_PA1 = 0xEB; // OEM PA1
    public const int VIRTUALKEY_OEM_PA2 = 0xEC; // OEM PA2
    public const int VIRTUALKEY_OEM_PA3 = 0xED; // OEM PA3
    public const int VIRTUALKEY_OEM_WSCTRL = 0xEE; // OEM WSCTRL
    public const int VIRTUALKEY_OEM_CUSEL = 0xEF; // OEM CUSEL
    public const int VIRTUALKEY_OEM_ATTN = 0xF0; // OEM ATTNT
    public const int VIRTUALKEY_OEM_FINISH = 0xF1; // OEM FINISH
    public const int VIRTUALKEY_OEM_COPY = 0xF2; // OEM COPY
    public const int VIRTUALKEY_OEM_AUTO = 0xF3; // OEM AUTO
    public const int VIRTUALKEY_OEM_ENLW = 0xF4; // OEM ENLW
    public const int VIRTUALKEY_OEM_BACKTAB = 0xF5; // OEM BACKTAB
    public const int VIRTUALKEY_ATTN = 0xF6; // ATTN
    public const int VIRTUALKEY_CRSEL = 0xF7; // CRSEL
    public const int VIRTUALKEY_EXSEL = 0xF8; // EXSEL
    public const int VIRTUALKEY_EREOF = 0xF9; // EREOF
    public const int VIRTUALKEY_PLAY = 0xFA; // PLAY
    public const int VIRTUALKEY_ZOOM = 0xFB; // ZOOM
    public const int VIRTUALKEY_NONAME = 0xFC; // NONAME
    public const int VIRTUALKEY_PA1 = 0xFD; // PA1
    public const int VIRTUALKEY_OEM_CLEAR = 0xFE; // OEM Clear


    public static void SimulateKeyPress(int keyCode)
    {
      keybd_event((byte)keyCode, 0, KEYEVENTF_KEYDOWN, 0);
    }

    public static void SimulateKeyRelease(int keyCode)
    {
      keybd_event((byte)keyCode, 0, KEYEVENTF_KEYDOWN | KEYEVENTF_KEYUP, 0);
    }

    public static void PressCombineButtons(int[] buttons)
    {
      //press keys
      foreach (var keycode in buttons)
      {
        SimulateKeyPress(keycode);
      }

      Thread.Sleep(100);

      //release keys
      foreach (var keycode in buttons)
      {
        SimulateKeyRelease(keycode);
      }

    }

  }
}