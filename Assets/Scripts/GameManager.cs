using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public LineRenderer LineRenderer;
    private int pointCount = 0;
    private List<Vector2> pointList = new List<Vector2>();
    private bool allowDraw = true;

    private void Awake()
    {
        LineRenderer.positionCount = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0) && allowDraw)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (!pointList.Contains(mousePosition))
            {
                LineRenderer.positionCount = pointCount + 1;
                LineRenderer.SetPosition(pointCount, mousePosition);
                pointCount++;
                pointList.Add(mousePosition);
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            allowDraw = false;
        }
    }
}