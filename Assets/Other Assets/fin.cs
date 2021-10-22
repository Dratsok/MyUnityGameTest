using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fin : MonoBehaviour
{

    public GameObject end;
  

    void Start()
    {
        end.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            end.SetActive(true);
        }

    }
}
