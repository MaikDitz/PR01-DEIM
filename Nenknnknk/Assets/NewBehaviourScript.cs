using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NewBehaviourScript : MonoBehaviour
{
    private float MyVar; 
    // Start is called before the first frame update
    void Start()
    {
        Cuentas(7, 5, "sumar");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Cuentas(int Num1, int Num2, string operacion)
    {
        if(operacion == "dividir")
        {
            int Num3 = Num1 / Num2;

            if (Num3 % 2 == 0)
            {
                print(Num3 + " numero par");
            }

            else
            {
                print(Num3 + " numero impar");
            }
        }

        else if(operacion == "sumar")
        {
            int Num3 = Num1 + Num2;

            if (Num3 % 2 == 0)
            {
                print(Num3 + " numero par");
            }

            else
            {
                print(Num3 + " numero impar");
            }
        }

        else if(operacion == "restar")
        {
            int Num3 = Num1 - Num2;

            if (Num3 % 2 == 0)
            {
                print(Num3 + " numero par");
            }

            else
            {
                print(Num3 + " numero impar");
            }
        }

        else if(operacion == "multiplicar")
        {
            int Num3 = Num1 * Num2;

            if (Num3 % 2 == 0)
            {
                print(Num3 + " numero par");
            }

            else
            {
                print(Num3 + " numero impar");
            }
        }

    }

}