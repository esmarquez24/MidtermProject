using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameCheckpoints : MonoBehaviour
{
    private void Awake()
    {
        Transform checkpointsTransform = transform.Find("Checkpoints");

        foreach (Transform checkpointSingleTransform in checkpointsTransform)
        {
            Debug.Log("checkpointSingleTransform");
        }
    }
}
