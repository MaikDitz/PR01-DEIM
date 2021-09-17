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
     
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Edad <= 18)
        {
            print(Edad);
            Edad++;
        }
    }
}
