using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snakePos : MonoBehaviour
{
   public float speed;
   public float score;

    public AudioSource Eat;

    private void Start()
    {
        StartCoroutine(SpeedUp());
    }

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           // collision.GetComponent<Move>().Score += score;
            Destroy(gameObject);
            Eat.pitch = Random.Range(0.8f, 1.2f);
            Eat.Play();
        }
    }
    private IEnumerator SpeedUp()
    {

        yield return new WaitForSeconds(20f);
        if (speed < 5)
        {
            speed += 0.5f;
        }

        StartCoroutine(SpeedUp());
    }
}
