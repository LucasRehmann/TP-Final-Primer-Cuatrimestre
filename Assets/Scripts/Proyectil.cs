using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * -0.2f;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name != "RigidBodyFPSController")
        {
            Destroy(gameObject);
        }
    }
}
