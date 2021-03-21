using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    private float velocidad = 0.1f;
    private Vector2 fondoPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        fondoPos = new Vector2(Time.time * velocidad, 0);

        GetComponent<Renderer>().material.mainTextureOffset = fondoPos;
    }

    void MoveBackground()
    {
        
    }
}
