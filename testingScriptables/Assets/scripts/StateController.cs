using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateController : MonoBehaviour {

    public State currentState;
    public AIStats AiStats;
    public Transform eyes;
    public State remainState;

    public bool aiActive;       //in tutorial, private

    public List<Transform> waypointList;    //in tutorial, comes from game manager.
    [HideInInspector] public int nextWayPoint;
    [HideInInspector] public Transform chaseTarget;

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

    public void TransitionToState(State nextState)
    {
        if (nextState != remainState)
        {
            currentState = nextState;
        }
    }
}
