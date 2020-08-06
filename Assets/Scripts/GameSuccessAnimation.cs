using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GameSuccessAnimation : BaseMonoBehaviour
{
    public GameObject Star1;
    public GameObject Star2;
    public GameObject Star3;

    public GameObject NextButton;

    private void Awake()
    {
        Star1.SetActive(false);
        Star2.SetActive(false);
        Star3.SetActive(false);

        if (GameState.LevelPlaying >= GameState.MaxLevel)
            NextButton.SetActive(false);
    }

    public void PlayAnimation(int stars)
    {
        if (stars > 0)
        {
            Star1.SetActive(true);
            PlayAudioSource(GetComponent<AudioSource>());
            Star1.transform.DOScale(1.0f, 0.5f).OnComplete(()=> {
                if (stars > 1)
                {
                    Star2.SetActive(true);
                    PlayAudioSource(GetComponent<AudioSource>());
                    Star2.transform.DOScale(1.0f,0.5f).OnComplete(()=> {
                        if (stars > 2)
                        {
                            Star3.SetActive(true);
                            PlayAudioSource(GetComponent<AudioSource>());
                            Star3.transform.DOScale(1.0f, 0.5f);
                        }
                    });
                }
            });

            
            
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
