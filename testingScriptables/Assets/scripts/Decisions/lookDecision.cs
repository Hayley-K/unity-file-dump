using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PlugAi/Decisions/Look")]
public class lookDecision : Decision {

    public override bool Decide(StateController controller)
    {
        bool targetVisable = Look(controller);
        return targetVisable;
    }
    private bool Look(StateController controller)
    {
        RaycastHit hit;

        Debug.DrawRay(controller.eyes.position, controller.eyes.forward.normalized * controller.AiStats.lookRange, Color.green);

        if (Physics.SphereCast(controller.eyes.position, controller.AiStats.lookSphereCastRadius, controller.eyes.forward, out hit, controller.AiStats.lookRange) 
            && hit.collider.CompareTag ("Player"))
        {
            controller.chaseTarget = hit.transform;
            return true;
        }
        else
        {
            return false;
        }
    }
}
