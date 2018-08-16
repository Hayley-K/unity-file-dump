using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PlugAi/Actions/Patrol")]
public class PatrolAction : Action {

    public override void Act(StateController controller)
    {
        Patrol(controller);
    }

    private void Patrol(StateController controller)
    {
        //controller.navMeshAgent.destination = controller.waypointlIST [controller.nextWayPoint].position;
        //controller.navMeshAgent.Resume();

        //if (controller.NavMeshAgent.remainingDistance <= controller.navMeshAgent.stoppingDistance && !controller.navMeshAgent.pathPending;
        //{
        //controller.nextWayPoint = (controller.nextWaypoint + 1) % controller.wayPointList.Count;  //loops back through waypoint list.
        //}

        Vector3 dest = controller.waypointList[controller.nextWayPoint].position;
        if (controller.transform.position != dest)
            controller.transform.position = Vector3.MoveTowards(controller.transform.position, dest, 0.1f);
        else
            controller.nextWayPoint = (controller.nextWayPoint + 1) % controller.waypointList.Count;


    }
}
