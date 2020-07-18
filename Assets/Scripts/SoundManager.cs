using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public Sprite SoundOnImage;
    public Sprite SoundOffImage;
    public Image SoundButton;

    // Start is called before the first frame update
    void Start()
    {
        SoundButton.sprite = GameState.SoundOn ? SoundOnImage : SoundOffImage;
    }

    public void ToggleSound()
    {
        GameState.SoundOn = !GameState.SoundOn;
        SoundButton.sprite = GameState.SoundOn ? SoundOnImage : SoundOffImage;
    }
}