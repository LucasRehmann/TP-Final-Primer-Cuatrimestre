using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    public Text miTexto;
    public GameObject suficiente;
    public GameObject insuficiente;
    public GameObject perdiste;

    int cuenta = 0;

    void Start()
    {

    }

    void Update()
    {
        miTexto.text = "Llaves recolectadas: " + cuenta + "/4";

        if (Input.GetKeyDown(KeyCode.C))
        {
            insuficiente.SetActive(false);
            perdiste.SetActive(false);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Llave")
        {
            Destroy(col.gameObject);
            cuenta++;
        }

        if (col.gameObject.name == "PisoFin")
        {
            transform.position = new Vector3(0, 0, 0);
            cuenta = 0;
            perdiste.SetActive(true);
        }

        if (col.gameObject.name == "Puerta")
        {
            if (cuenta == 4)
            {
                suficiente.SetActive(true);
            }

            else
            {
                insuficiente.SetActive(true);
            }
        }
    }
}
