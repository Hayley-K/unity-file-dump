using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PlugAi/Actions/Chase")]
public class ChaseAction : Action {
    public override void Act(StateController controller)
    {
        Chase(controller);
    }

    private void Chase(StateController controller)
    {
        if (controller.transform.position != controller.chaseTarget.position)
        {
            controller.transform.position = Vector3.MoveTowards(controller.transform.position, controller.chaseTarget.position, 0.1f);
        }
    }
}
