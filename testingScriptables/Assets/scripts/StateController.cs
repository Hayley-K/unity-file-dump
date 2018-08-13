using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateController : MonoBehaviour {

    public State currentState;
    public AIStats AiStats;
    public bool aiActive;
    public Transform eyes;


    public List<Transform> waypointList;
    [HideInInspector] public int nextWayPoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!aiActive)
            return;
        currentState.UpdateState(this);
	}

    private void OnDrawGizmos()
    {
        if (currentState != null && eyes != null)
        {
            Gizmos.color = currentState.sceneGizmoCol;
            Gizmos.DrawWireSphere(eyes.position, AiStats.lookSphereCastRadius);
        }
    }
}
