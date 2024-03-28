using UnityEngine;

public class player : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float speed = 4f;
    private Vector2 moveVector;
    public Animator anim;

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        MovementLogic();
    }

    private void MovementLogic()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 8f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 4f;
            
        }
        float moveHorizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(moveHorizontal, 0, 0) * Time.deltaTime * speed;

        float moveVertical = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, moveVertical, 0) * Time.deltaTime * speed;

        anim.SetFloat("moveX", moveHorizontal);
        anim.SetFloat("moveY", moveVertical);
    }
    
}
