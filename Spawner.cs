using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] SharkVariants;
    
     
    public float TimeBtwSpawn;
    //public float startTimeBtwSpawn;
    //public float desTime;
    //public float minTime = 0.65f;

    private void Start()
    {
        StartCoroutine(BtwTime());
        StartCoroutine(SpeedUp());
    }

    private IEnumerator BtwTime()
    {
        int rang = Random.Range(0, SharkVariants.Length);
        Instantiate(SharkVariants[rang], transform.position, Quaternion.identity);

        
        yield return new WaitForSeconds(TimeBtwSpawn);

        StartCoroutine(BtwTime());
    }
    private IEnumerator SpeedUp()
    {

        yield return new WaitForSeconds(25f);
        if (TimeBtwSpawn >= 2.1f)
        {
            TimeBtwSpawn -= 0.5f;
        }

        StartCoroutine(SpeedUp());
    }
}
