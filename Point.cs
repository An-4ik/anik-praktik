using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public GameObject Shark;


         private void Start()
        {
                     Instantiate(Shark, transform.position, Quaternion.identity);
        }
}
