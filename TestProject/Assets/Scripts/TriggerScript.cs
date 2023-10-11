using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("onTriggerEnter2D");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("onTriggerExit2D");

    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("onTriggerStay2D");

    }
}
