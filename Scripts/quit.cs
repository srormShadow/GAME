using UnityEngine;

public class quit : MonoBehaviour
{
    public void OnApplicationQuit()
    {
        Debug.Log("application quit");
        Application.Quit();
    }
}
