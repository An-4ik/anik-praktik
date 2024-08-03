using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyPos : MonoBehaviour
{
    public float speed;
    public int damage;

    public GameObject effect; // эффект пузырек

    public AudioSource bite; //звук укуса



   

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           // bite.Play();
            
            Vector2 pos = new Vector2(transform.position.x - 1.5f, transform.position.y);
            Instantiate(bite, transform.position, Quaternion.identity); // создать звук для префаба
            Instantiate(effect, pos, Quaternion.identity); // эффукт пузырек
            collision.GetComponent<Move>().Health -= damage;
            collision.GetComponent<Move>().EnmAtak = true;
            Destroy(gameObject);
           collision.GetComponent<Move>().Dmg.SetTrigger("isDamage");

        }

      
    }

    

    

}
