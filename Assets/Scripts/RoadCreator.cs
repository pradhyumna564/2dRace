using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadCreator : MonoBehaviour
{
    public GameObject Roadprefab;
    public GameObject currentRoadEndpoint;
    public Transform Roadendpos;
    public UIscript uiobject;
    // Start is called before the first frame update
    void Start()
    {
        Roadendpos = currentRoadEndpoint.transform;
        Createroad();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision )
    {
        if (collision.gameObject.tag == "Roads")
        {
        //    GameObject parentobject = collision.transform.parent.gameObject;
        //    Vector3 nextRoad = parentobject.GetComponent<RoadMovement>().RoadEnd.position;
            Destroy(collision.transform.parent.gameObject,2.0f);
            Createroad();
        }
        if(collision.gameObject.tag == "EnemyCar")
        {
            Destroy(collision.gameObject,2.0f);
            uiobject.Increascore();
        }
    }
    private void Createroad()
    {
        GameObject temproad = Instantiate(Roadprefab,Roadendpos.position,Quaternion.identity);
        Roadendpos = temproad.GetComponent<RoadMovement>().RoadEnd;
    }
}
