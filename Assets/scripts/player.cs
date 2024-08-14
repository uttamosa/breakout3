using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject pelaaja;
    private float difficulty = 1;

    private void Start()
    {
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 newpos = new Vector3(-0.025f * difficulty, 0, 0);
            pelaaja.transform.position += newpos;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 newpos = new Vector3(0.025f * difficulty, 0, 0);
            pelaaja.transform.position += newpos;
        }
    }
}
