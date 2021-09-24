using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    private Vector3 CubePosition = new Vector3(0f, 0f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        transform.position = CubePosition;
        speed = 15f;
    }

    // Update is called once per frame
    void Update()
    {
        float desp1H = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * desp1H);
        float desp1V = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * Time.deltaTime * speed * desp1V);
        float desp1Z = Input.GetAxis("Profundidad");
        transform.Translate(Vector3.back * Time.deltaTime * speed * desp1Z);
    }
}
