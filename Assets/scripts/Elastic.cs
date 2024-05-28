using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elastic : MonoBehaviour
{
    public Transform _start;
    public Transform _end; 
    private LineRenderer lineRenderer;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        if (lineRenderer == null)
        {
            Debug.LogError("LineRenderer component missing from this GameObject.");
        }
    }

    void Update()
    {
        if (_start != null && _end != null && lineRenderer != null)
        {
            
            lineRenderer.SetPosition(0, _start.position);
            lineRenderer.SetPosition(1, _end.position);
        }
    }
}
