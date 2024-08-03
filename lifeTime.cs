using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifeTime : MonoBehaviour
{
    public float TimeOfLife;
    private void Start()
    {
        Destroy(gameObject, TimeOfLife);
    }
}
