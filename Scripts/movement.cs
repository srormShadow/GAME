using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;

    public int speed = 10;
    public int jump = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) //all this is for keyboard inputs
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S)) //all this is for keyboard inputs
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A)) //all this is for keyboard inputs
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D)) //all this is for keyboard inputs
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.Space)) //all this is for keyboard inputs
        {
            transform.Translate(Vector3.up * Time.deltaTime * jump);
        }
        if (rb.position.y < 335) //when we fall of the surfce....
        {
            FindObjectOfType<GameManager>().Endgame();
        }
    }
}
