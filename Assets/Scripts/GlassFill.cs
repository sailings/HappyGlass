using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassFill : BaseMonoBehaviour
{
    public bool CanCheckComplete = false;
    private bool GameSuccess = false;
    private float totalCheckTime = 0;

    public SpriteRenderer spriteRenderer;

    public Sprite SurpriseGlass;
    public Sprite HappyGlass;
    public Sprite SadGlass;

    private int inGlassCount = 0;

    private void Awake()
    {
        inGlassCount = 0;
        totalCheckTime = 0;
        GameSuccess = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameSuccess && CanCheckComplete)
        {
            totalCheckTime += Time.deltaTime;
            if (totalCheckTime >= 5.0f)
            {
                Debug.Log("Failed");
                spriteRenderer.sprite = SadGlass;
                ExecuteAction(GameManager.Instance.ReloadScene, 1.0f);

            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("DynamicParticle"))
        {
            totalCheckTime = 0;
            if (inGlassCount == 0)
            {
                spriteRenderer.sprite = SurpriseGlass;
            }
            inGlassCount++;
            if (inGlassCount == 71)
            {
                Debug.Log("Success");
                spriteRenderer.sprite = HappyGlass;
                GameSuccess = true;
                GameManager.Instance.GameSuccess();
            }
        }
    }
}
