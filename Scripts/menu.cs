using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{

    public void startgame() //from the menu scene
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //to load the next level in the game based on built index....
    }

}
