using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NewBehaviourScript : MonoBehaviour
{
    public int Var1 = 10;
    public string Var2 = "hola wenas";
    public float Var3 = 4f;
    public bool Var4 = true;
    public int Edad = 1;
    public int Aleatorio;
    // Start is called before the first frame update
    void Start()
    {
        while (Aleatorio != 5)
        {
            Aleatorio = Random.Range(0, 10);
            print("El numero es " + Aleatorio);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}