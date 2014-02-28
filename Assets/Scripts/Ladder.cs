using UnityEngine;
using System.Collections;

public class Ladder : MonoBehaviour 
{
    public PlanetControl planet;

    void OnTriggerStay(Collider collider)
    {
        print("enter ladder " + collider.tag);
        if (collider.tag == "Player")
        {
            print("character enter ladder");
            planet.characterCanMoveUp = true;
        }

    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "Player")
        {
            print("character enter ladder");
            planet.characterCanMoveUp = false;
        }

    }

}
