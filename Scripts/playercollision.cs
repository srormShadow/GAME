using UnityEngine;

public class playercollision : MonoBehaviour
{
    //this function runs when we hit
    //we get the collision information and call it collisioninfo
    public void OnCollisionEnter(Collision collisioninfo)
    {
        //checking the tag of the object the player hit
        if (collisioninfo.collider.tag == "points")
        {
            FindObjectOfType<GameManager>().playercollision();
        }   
    }
}
