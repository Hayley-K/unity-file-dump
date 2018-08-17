using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PlugAi/Decisions/ActiveState")]
public class ActiveStateDecision : Decision {

    public override bool Decide(StateController controller)
    {
        //chase till player is dead i think

        bool chaseTargetIsActive = controller.chaseTarget.gameObject.activeSelf;
        return chaseTargetIsActive;
    }

}
