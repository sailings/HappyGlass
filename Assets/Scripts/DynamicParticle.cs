using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicParticle : MonoBehaviour
{
    private bool isGas = false;
    public Color GasCol;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetGas()
    {
        if (!isGas)
        {
            isGas = true;
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            GetComponent<Rigidbody2D>().gravityScale = -0.5f;
            GetComponent<CircleCollider2D>().enabled = false;
            GetComponent<TrailRenderer>().enabled = false;
            GetComponent<SpriteRenderer>().color = GasCol;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Hot"))
        {
            SetGas();
        }
    }
}