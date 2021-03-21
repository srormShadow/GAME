using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public void OnTriggerEnter(Collider other) //when we hit the end point 
    {
        FindObjectOfType<GameManager>().LoadNextLevel(); //the function in the game manager will be taken
    }
}