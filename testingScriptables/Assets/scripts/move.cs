using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    
    //public AIStats AiStats;
    public GameObject destinationPoint;
    private float speed;

    // Use this for initialization
    void Start () {
        
        //speed = AiStats.moveSpeed;
        speed = 0.1f;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position != destinationPoint.transform.position)
            transform.position = Vector3.MoveTowards(transform.position, destinationPoint.transform.position, speed);

        
    }
}
