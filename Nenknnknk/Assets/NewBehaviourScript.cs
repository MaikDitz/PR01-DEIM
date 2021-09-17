using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int Var1 = 2;
    public string Var2 = "hola wenas";
    public float Var3 = 4f;
    public bool Var4 = true;
    // Start is called before the first frame update
    void Start()
    {
        print(Var1 + Var2 + Var3 + Var4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
