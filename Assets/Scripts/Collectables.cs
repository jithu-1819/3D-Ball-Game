using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //add score
            ScoreManager.instance.AddScore(1);
            Invoke("DestroyCollectable", 0.2f);
        }
    }

    void DestroyCollectable()
    {
        Destroy(gameObject);
    }
}
