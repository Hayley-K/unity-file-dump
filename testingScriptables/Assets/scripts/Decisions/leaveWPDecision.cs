using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PlugAi/Decisions/LeavePoint")]
public class leaveWPDecision : Decision
{
    public override bool Decide(StateController controller)
    {
        bool finishedSearch = CheckSearch(controller);
        return finishedSearch;
    }
    private bool CheckSearch(StateController controller)
    {
        
    }
}
