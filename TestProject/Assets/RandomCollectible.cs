using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCollectible : MonoBehaviour
{
    public ScoreScript score;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        RepositionCollectible();
    }
    void RepositionCollectible()
    {
        float maxX = Random.Range(-5, 5);
        float maxY = Random.Range(-3, 3);
        Vector2 newpos = new Vector2(maxX, maxY);
        transform.position = newpos;

        score.AddScore();
    }
}
