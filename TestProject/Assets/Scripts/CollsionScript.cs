using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollsionScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("OnCollsionEnter2D");    
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("OnCollsionExit2D");

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("OnCollsionStay2D");

    }


}
