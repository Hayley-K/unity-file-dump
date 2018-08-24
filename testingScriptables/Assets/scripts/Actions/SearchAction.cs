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
        float speed = 1f;
        Quaternion platerStartRotation = controller.transform.rotation;
        
        //moving to a position not amount 
        controller.transform.rotation = Quaternion.Slerp(platerStartRotation, Quaternion.Euler(0, -360, 0), Time.deltaTime * speed);
        
        //controller.transform.rotation = Quaternion.RotateTowards(platerStartRotation, Quaternion.Euler(0, 180, 0), Time.deltaTime * speed);
        //controller.transform.rotation = Quaternion.Slerp(controller.transform.rotation, Quaternion.Euler(0, 90, 0), Time.deltaTime * speed);
    }
}
