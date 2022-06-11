using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    public Text miTexto;

    public GameObject suficiente, insuficiente, perdiste;
    public GameObject Llave1, Llave2, Llave3, Llave4;

    public AudioClip cerrado, abierto, llave;

    AudioSource sourceAudio;

    int cuenta = 0;

    void Start()
    {
        sourceAudio = GetComponent<AudioSource>();
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
        for (int i = 1; i <= 4; i++)
        {
            if (col.gameObject.name == "Llave" + i)
            {
                col.gameObject.SetActive(false);
                cuenta++;
                sourceAudio.clip = llave;
                sourceAudio.Play();
            }
        }


        if (col.gameObject.name == "PisoFin")
        {
            transform.position = new Vector3(0, 0, 0);
            cuenta = 0;
            perdiste.SetActive(true);

            Llave1.SetActive(true);
            Llave2.SetActive(true);
            Llave3.SetActive(true);
            Llave4.SetActive(true);
        }

        if (col.gameObject.name == "Puerta")
        {
            if (cuenta == 4)
            {
                suficiente.SetActive(true);
                sourceAudio.clip = abierto;
                sourceAudio.Play();
            }

            else
            {
                insuficiente.SetActive(true);
                sourceAudio.clip = cerrado;
                sourceAudio.Play();
            }
        }
    }
}
