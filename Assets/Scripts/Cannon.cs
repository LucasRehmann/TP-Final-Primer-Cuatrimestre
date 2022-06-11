using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject cannon;
    float tiemRecarga;


    // Start is called before the first frame update
    void Start()
    {
        tiemRecarga = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (tiemRecarga > 0)
        {
            tiemRecarga -= Time.deltaTime;
        }

        if (tiemRecarga <= 0)
        {
            Instantiate(cannon, new Vector3(-24.79f, -0.47f, 25.79f), new Quaternion(0, 0, 0, 0));
            Instantiate(cannon, new Vector3(-32.13f, -0.06f, 13f), new Quaternion(0, 90, 0, 0));
            Instantiate(cannon, new Vector3(52f, -0.06f, 11.28f), new Quaternion(0, 45, 0, 45));
            Instantiate(cannon, new Vector3(43f, -0.06f, 15.711f), new Quaternion(0, -90, 0, 90));

            tiemRecarga = 3;
        }
    }
}
