using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour {

    public GameObject player;
    public GameObject pbRoot;
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.P))
        {
            Destroy(GetComponent<Rigidbody>());
            AddParabola();

            Vector3 itemPosition = player.transform.position;
            itemPosition.y += player.transform.GetComponent<Collider>().bounds.size.y;
            itemPosition.y += GetComponent<Collider>().bounds.size.y / 2;

            transform.Translate(itemPosition - transform.position, Space.World);
            transform.SetParent(player.transform);
            Quaternion currentFacing = transform.rotation;

            //GameObject pbRootClone = Instantiate(pbRoot, transform.position, transform.rotation, transform);
            
        }
	}
    public void AddParabola()
    {
        gameObject.AddComponent<parabolaController>();
        gameObject.GetComponent<parabolaController>().ParabolaRoot = Instantiate(pbRoot, transform.position, transform.rotation, transform);
    }
}
