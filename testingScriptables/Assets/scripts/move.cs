using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    //Rigidbody rb;
    //public AIStats AiStats;
    public GameObject point1;
    private float speed;

    // Use this for initialization
    void Start () {
        //rb = GetComponent<Rigidbody>();
        //speed = AiStats.moveSpeed;
        speed = 0.1f;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position != point1.transform.position)
            transform.position = Vector3.MoveTowards(transform.position, point1.transform.position, speed);
        
    }
}
