using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCar : MonoBehaviour
{
    public GameObject[] enemycar;
    public int timeGap;
    public float maxleft = -1.6f, maxright = 1.7f;
    public Vector3 lastCarPos;
    //public float speed;
    // Start is called before the first frame update
    void Start()
    {
        timeGap = 3;
        lastCarPos = transform.position;
        StartCoroutine(DecreaseTimeGap(5));
        CreateEnemyCar();
    }
 
    private void CreateEnemyCar()
    {
        int random = Random.Range(0, enemycar.Length);
        Vector3 tempos = lastCarPos;
        while (true)
        {
            tempos.x = Random.Range(maxleft, maxright);
            if(Mathf.Abs(lastCarPos.x - tempos.x) > 1.0f)
            {
                break;
            }
        }
        Instantiate(enemycar[random], tempos, Quaternion.identity);
        lastCarPos = tempos;
        StartCoroutine(CreateCars());
    }

    private IEnumerator CreateCars()
    {
        yield return new WaitForSeconds(timeGap);
        CreateEnemyCar();
    }

    private IEnumerator DecreaseTimeGap(int time)
    {
        yield return new WaitForSeconds(time);
        if (timeGap > 1)
        {
            timeGap--;
            StartCoroutine(DecreaseTimeGap(5));
        }
    }
    //Another Way for creation of car
    //private IEnumerator Enemy()
    //{
    //    yield return new WaitForSeconds(timegap);
    //    int random = Random.Range(0, enemycar.Length);
    //    Instantiate(enemycar[random], transform.position, Quaternion.identity);
    //    StartCoroutine(Enemy());
    //    if (Speedmanager.speed % 3 == 0 && timegap > 1)
    //    {
    //        timegap--;
    //    }
    //}

}
