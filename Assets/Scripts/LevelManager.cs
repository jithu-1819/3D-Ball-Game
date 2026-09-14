using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform  instantiatePos;

    public CameraFollow cameraFollow;
    void Start()
    {
        GameObject go = Instantiate(ballPrefab,instantiatePos.position,Quaternion.identity);
        cameraFollow.target = go.transform;
    }
}
