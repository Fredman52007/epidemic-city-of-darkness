using UnityEngine;

public class playerfightmove : MonoBehaviour
{
    public int hp = 4;
    private Rigidbody2D _rb;
    public float speed = 4f;
    private Vector2 moveVector;
    //public Animator anim;

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        //anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        MovementLogicFight();
    }

    private void MovementLogicFight()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(moveHorizontal, 0, 0) * Time.deltaTime * speed;

        float moveVertical = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, moveVertical, 0) * Time.deltaTime * speed;

        //anim.SetFloat("moveX", moveHorizontal);
        //anim.SetFloat("moveY", moveVertical);
    }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("attack"))
            {
               hp -= 1;
            }
        }
}