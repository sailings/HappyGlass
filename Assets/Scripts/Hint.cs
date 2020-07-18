using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Hint : MonoBehaviour
{
    private LineRenderer lineRenderer;
    public Transform Finger;
    public bool AutoShow = false;

    private Vector3[] path;

    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
        path = new Vector3[lineRenderer.positionCount];
        for (int i = 0; i < path.Length; i++)
        {
            path[i] = lineRenderer.GetPosition(i);
        }
        //lineRenderer.enabled = false;
        lineRenderer.enabled = AutoShow;
        Finger.gameObject.SetActive(AutoShow);
    }

    // Start is called before the first frame update
    void Start()
    {
        //Vector3[] path = new Vector3[3];
        //path[0] = new Vector3(0, 0, 0);
        //path[1] = new Vector3(1, 1, 0);
        //path[2] = new Vector3(1, 2, 0);
        Finger.DOPath(path, 3.0f).SetLoops(-1);
    }

    public void HideFinger()
    {
        Finger.gameObject.SetActive(false);
    }

    public void ShowHint()
    {
        lineRenderer.enabled = true;
    }

}
