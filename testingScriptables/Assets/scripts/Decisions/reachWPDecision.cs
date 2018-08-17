using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PlugAi/Decisions/ReachPoint")]
public class reachWPDecision : Decision
{
    public override bool Decide(StateController controller)
    {
        bool reachedWayPoint = CheckPoint(controller);
        return reachedWayPoint;
    }
    private bool CheckPoint(StateController controller)
    {
        Vector3 dest = controller.waypointList[controller.nextWayPoint].position;
        if (controller.transform.position == dest)
            return true;
        else
            return false;
    }
}
