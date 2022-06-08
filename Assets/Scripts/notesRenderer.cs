using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notesRenderer : MonoBehaviour
{
    MeshRenderer meshRenderer;
    [SerializeField] float distanceTimeRenderer;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.time);
        if (Time.time >= distanceTimeRenderer)
        {
            meshRenderer.enabled = true;
        }
    }
}
