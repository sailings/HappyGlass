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

    public static int LevelReached
    {
        get {
            return PlayerPrefs.GetInt("LevelReached", 1);
        }
        set {
            PlayerPrefs.SetInt("LevelReached",value);
        }
    }

    public static int GetLevelStars(int level)
    {
        return PlayerPrefs.GetInt("Level" + level + "Stars", 0);
    }

    public static void SetLevelStars(int level, int stars)
    {
        var val = GetLevelStars(level);
        if (stars > val)
            PlayerPrefs.SetInt("Level" + level + "Stars", stars);
    }
}