using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Mol4Klik : MonoBehaviour
{
    public punten punten;
    public const float omlaag = 1.4f;
    public bool mol4Bool = false;

    void Start()
    {

    }
    void OnMouseDown()
    {
        if (mol4Bool)
        {
            transform.Translate(Vector3.down * omlaag);
            mol4Bool = false;
            punten.puntenOmhoog();
        }
    }
    void Update()
    {

    }
}
