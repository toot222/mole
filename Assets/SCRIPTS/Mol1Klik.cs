using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Mol1Klik : MonoBehaviour
{
    public punten punten;
    public const float omlaag = 1.4f;
    public bool mol1Bool = false;

    void Start()
    {

    }
    void OnMouseDown()
    {
        if (mol1Bool)
        {
            transform.Translate(Vector3.down * omlaag);
            mol1Bool = false;
            punten.puntenOmhoog();
        }
    }
        void Update()
    {

    }
}
