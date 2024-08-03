using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    public float speed;//скорость
    public float endX;//конечная точка
    public float startX;//стартовая точка

    private void Update()
    {
        transform.Translate(Vector2.left *  speed * Time.deltaTime);
        if (transform.position.x <= endX)
        {
            Vector2 pos = new Vector2(startX, transform.position.y);
            transform.position = pos;
        }
    }
}
