using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NewBehaviourScript : MonoBehaviour
{
    private float MyVar; 
    // Start is called before the first frame update
    void Start()
    {

        MyVar = multiplicar(5.4f, 6.3f);
        print(MyVar);
    }

    // Update is called once per frame
    void Update()
    {

    }

     float multiplicar(float num1, float num2)
    {
        float resultado = num1 + num2;
        return resultado;
    }

}