using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleGenerator : BaseMonoBehaviour
{
    public GameObject ParticleObj;
    public int ParticleMaxCount = 100;
    private int particleCount = 0;
    private bool isGenerating = false;
    public Transform WaterPoint;

    public GlassFill GlassFill;


    public void GenerateParticle()
    {
        if (!isGenerating)
        {
            isGenerating = true;
            StartCoroutine(CreateParticle());
            PlayAudioSource(GetComponent<AudioSource>());
        }
    }

    IEnumerator CreateParticle()
    {
        while (particleCount < ParticleMaxCount)
        {
            yield return new WaitForSeconds(0.01f);
            var newObj = Instantiate(ParticleObj);
            newObj.transform.parent = gameObject.transform;
            newObj.transform.position = new Vector3(Random.Range(WaterPoint.position.x - 0.001f, WaterPoint.position.x + 0.001f), Random.Range(WaterPoint.position.y - 0.001f, WaterPoint.position.y + 0.001f), 0);
            particleCount++;
        }
        GlassFill.CanCheckComplete = true;
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
