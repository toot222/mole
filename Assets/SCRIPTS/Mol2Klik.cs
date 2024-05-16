using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Mol2Klik : MonoBehaviour
{
    public punten punten;
    public const float omlaag = 1.4f;
    public bool mol2Bool = false;

    void Start()
    {

    }
    void OnMouseDown()
    {
        if (mol2Bool)
        {
            transform.Translate(Vector3.down * omlaag);
            mol2Bool = false;
            punten.puntenOmhoog();
        }
    }
    void Update()
    {

    }
}
