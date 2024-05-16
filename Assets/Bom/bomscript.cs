using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomscript : MonoBehaviour
{
    public punten punten;

    void Start()
    {
        
    }
    void OnMouseDown()
    {
         transform.Translate(Vector3.down * 1.4f);
         punten.puntenOmlaag();
    }

    void Update()
    {
        
    }
}
