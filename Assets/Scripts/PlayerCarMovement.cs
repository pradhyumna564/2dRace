using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCarMovement : MonoBehaviour
{
    public Vector2 direction;
    public float speed;
    public float leftpos, rightpos;
    public UIscript uiobject;
   // public Transform objtransform;
    // Start is called before the first frame update
    void Start()
    {
        //objtransform = GetComponent<Transform>();
        direction = new Vector2(1, 0);
    }

    // Update is called once per frame
    void Update()
    {

#if (UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR
        direction.x = Input.acceleration.x;
#elif UNITY_STANDALONE ||UNITY_EDITOR
        direction.x = Input.GetAxis("Horizontal");
#endif
        if (transform.position.x < leftpos)
        {
            Vector2 tempos = transform.position;
            tempos.x = leftpos;
            transform.position = tempos;
        }
        else if (transform.position.x > rightpos)
        {
            Vector2 tempos = transform.position;
            tempos.x = rightpos;
            transform.position = tempos;
        }

        else
        {
            transform.Translate(direction * speed * Time.deltaTime);
        }



        //    if (Input.GetKey(KeyCode.LeftArrow))
        //    {
        //        if (transform.position.x > leftpos)
        //        {
        //            transform.Translate(direction * speed * -1 * Time.deltaTime);
        //        }
        //        else
        //        {
        //            Vector2 tempos = transform.position;
        //            tempos.x = leftpos;
        //            transform.position = tempos;

        //        }

        //    }
        //    if (Input.GetKey(KeyCode.RightArrow))
        //    {

        //        if (transform.position.x < rightpos)
        //        {
        //            transform.Translate(direction * speed * Time.deltaTime);
        //        }
        //        else
        //        {
        //            Vector2 tempos = transform.position;
        //            tempos.x = rightpos;
        //            transform.position = tempos;

        //        }
        //    }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "EnemyCar" )
        {
            Time.timeScale = 0;
            uiobject.MakeGameover();
        }
    }
}
