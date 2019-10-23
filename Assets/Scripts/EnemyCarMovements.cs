using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCarMovements : MonoBehaviour
{
    public Vector2 direction;
    public float speed;
    //public float maxleft=-1.6f, maxright=1.7f;
    // Start is called before the first frame update
    void Start()
    {
        //Vector3 tempos = transform.position;
        //tempos.x = Random.Range(maxleft, maxright);
        //transform.position = tempos;
        direction = new Vector2(0, -1);
    }

    // Update is called once per frame
    void Update()
    {
        speed = Speedmanager.speed - Random.Range(0.2f, 0.5f);
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
