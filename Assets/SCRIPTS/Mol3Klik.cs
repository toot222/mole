using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Mol3Klik : MonoBehaviour
{
    public punten punten;
    public const float omlaag = 1.4f;
    public bool mol3Bool = false;

    void Start()
    {

    }
    void OnMouseDown()
    {
        if (mol3Bool)
        {
            transform.Translate(Vector3.down * omlaag);
            mol3Bool = false;
            punten.puntenOmhoog();
        }
    }
    void Update()
    {

    }
}
