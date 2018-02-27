using UnityEngine;
using System.Collections;

public class playerControllerScript : MonoBehaviour {

    public float speed;

    private Vector2 target;

    private Rigidbody2D rb2d;
    private Camera Camera;

    // Use this for initialization
    void Start ()
    {
        rb2d = GetComponent<Rigidbody2D>();
        target = transform.position;
    }

    void PlayerPosition()   // Set Player Position.X to always attempt to mirror MousePos.X
    {
        if (true)
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //target.y = transform.position.y;
            //target.x = transform.position.x;
        }

        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

    }

    // Update is called once per frame
    void Update ()
    {
        PlayerPosition();	
	}
}
