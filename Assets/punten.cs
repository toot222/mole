using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class punten : MonoBehaviour
{
    public TMP_Text puntenreg;
    public int puntenAantal = 0;
    void Start()
    {
        puntenreg.text = "Punten: " + puntenAantal;

    }
    public void puntenOmhoog()
    {
        puntenAantal += 1;
        puntenreg.text = "Punten: " + puntenAantal;
    }
    public void puntenOmlaag()
    {
        puntenAantal -= 5;
        puntenreg.text = "Punten: " + puntenAantal;
    }
    void Update()
    {
        
    }
}
