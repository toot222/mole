using UnityEngine;
using System.Collections;
using UnityEditor.PackageManager;
public class MainScript : MonoBehaviour
{
    public Mol1Klik mol1;
    public Mol2Klik mol2;
    public Mol3Klik mol3;
    public Mol4Klik mol4;
    public GameObject molOBJ1;
    public GameObject molOBJ2;
    public GameObject molOBJ3;
    public GameObject molOBJ4;
    public GameObject bomobj;

    private float rand;
    private const float hoogte = 1.4f;
    private const float marge = 0.45f;
    void Start()
    {
        StartCoroutine(wachten(1));
    }
    void bom()
    {
        int randBOM = Random.Range(1, 100);
        if (randBOM > 70)
        {
            if (rand == 1)
            {
                bomobj.transform.position = new Vector3(-3.107f + marge, -0.192f + hoogte, -1.6f);
            }
            if (rand == 2)
            {
                bomobj.transform.position = new Vector3(-1.574f + marge, -0.192f + hoogte, -1.6f);
            }
            if (rand == 3)
            {
                bomobj.transform.position = new Vector3(-0.04499996f + marge, -0.192f + hoogte, -1.6f);
            }
            if (rand == 4)
            {
                bomobj.transform.position = new Vector3(1.584f + marge, -0.192f + hoogte, -1.6f);
            }
        }

    }
    bool randomMOL()
    {
        
         rand = Random.Range(1, 4);

        switch (rand)
        {
            case 1:
                return mol1.mol1Bool;
            case 2:
                return mol2.mol2Bool;
            case 3:
                return mol3.mol3Bool;
            case 4:
                return mol4.mol4Bool;
            default:
            return mol1.mol1Bool;

        }
    }

    IEnumerator wachten(int seconden)
    {

        while (true)
        {

            yield return new WaitForSeconds(seconden);
            bom();
            if (randomMOL() == false)
            {
                if (rand == 1)
                {
                    molOBJ1.transform.Translate(Vector3.up * hoogte);
                    mol1.mol1Bool = true; }
                if (rand == 2)
                {
                    molOBJ2.transform.Translate(Vector3.up * hoogte);
                    mol2.mol2Bool = true; }
                if (rand == 3)
                {
                    molOBJ3.transform.Translate(Vector3.up * hoogte);
                    mol3.mol3Bool = true; }
                if (rand == 4)
                {
                    molOBJ4.transform.Translate(Vector3.up * hoogte);
                    mol4.mol4Bool = true; }
            }
        }
    }
        void Update()
    {

    }

}
