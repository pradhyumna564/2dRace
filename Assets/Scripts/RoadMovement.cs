using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMovement : MonoBehaviour
{
    public Vector2 MoveDirection;
    public float speed;
    public Transform RoadStart, RoadEnd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = Speedmanager.speed;
        transform.Translate(MoveDirection * speed * Time.deltaTime);
    }
}
