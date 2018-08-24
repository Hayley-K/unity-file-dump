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
        float maxRotation = 90f;

        //controller.transform.rotation = Quaternion.RotateTowards(controller.transform.rotation, Quaternion.Euler(0, 90, 0), Time.deltaTime * speed);

        controller.transform.rotation = Quaternion.Euler(0f, maxRotation * Mathf.Sin(Time.time * speed), 0f);

        //need to specify a certain time?


    }
}
