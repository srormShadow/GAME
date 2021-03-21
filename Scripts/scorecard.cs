using UnityEngine;
using UnityEngine.UI;

public class scorecard : MonoBehaviour
{
    public Text scoretext;

    // Update is called once per frame
    void Update()
    { 
        scoretext.text = FindObjectOfType<GameManager>().playercollision().ToString("0");
    }
}
