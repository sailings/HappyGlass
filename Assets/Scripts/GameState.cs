using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState
{
    public static bool IsGameSuccess = false;

    public static int LevelPlaying = 1;

    public static bool SoundOn
    {
        get {
            return PlayerPrefs.GetInt("SoundOn", 1) == 1;
        }
        set {
            PlayerPrefs.SetInt("SoundOn", value ? 1 : 0);
        }
    }
}