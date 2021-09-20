using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NewBehaviourScript : MonoBehaviour
{
    public int Var1 = 2;
    public string Var2 = "hola wenas";
    public float Var3 = 4f;
    public bool Var4 = true;
    public int Edad = 1;
    // Start is called before the first frame update
    void Start()
    {
        for (; Edad < 19; Edad++)
        {
            if (Edad < 10)
            {
                print("Tas chiquito");
            }

            else if (Edad >= 10 && Edad < 18)
            {
                print("Tas medio chiquito");
            }
            else
            {
                print("Tas mayor");
            }
        }
            

    }
    // Update is called once per frame
    void Update()
    {

    }
}