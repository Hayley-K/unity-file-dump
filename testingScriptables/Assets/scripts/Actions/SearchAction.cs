using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PlugAi/Actions/Search")]
public class SearchAction : Action {

    public override void Act(StateController controller)
    {
        Search(controller);
    }

    public void Search(StateController controller)
    {
        //ROTATE THE PLAYER 
    }
}
