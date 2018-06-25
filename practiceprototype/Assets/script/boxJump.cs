using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxJump : MonoBehaviour {

    public GameObject environment;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<parabolaController>().FollowParabola();
            transform.SetParent(environment.transform);
            
            if (GetComponent<Rigidbody>() == null)
                gameObject.AddComponent<Rigidbody>();
        }
	}
}
