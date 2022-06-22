using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notesRenderer : MonoBehaviour
{
    MeshRenderer meshRenderer;
    [SerializeField] float timeDistanceRenderer;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.time);

        //when is time enable renderer of note
        if (Time.time >= timeDistanceRenderer)
        {
            meshRenderer.enabled = true;
        }
    }
}
