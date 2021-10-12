using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeMovement : MonoBehaviour
    
{
    //private float speed = 5f;
    //private Rigidbody2D _rigidbody2D;
    //// Start is called before the first frame update
    //void Start()
    //{
    //    _rigidbody2D = GetComponent<Rigidbody2D>();
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    if(Input.GetKey(KeyCode.W))
    //    {
    //        MovePlayer(Vector3.up);
    //    }
    //    if (Input.GetKey(KeyCode.A))
    //    {
    //        MovePlayer(Vector3.left);
    //    }
    //    if (Input.GetKey(KeyCode.S))
    //    {
    //        MovePlayer(Vector3.down);
    //    }
    //    if (Input.GetKey(KeyCode.D))
    //    {
    //        MovePlayer(Vector3.right);
    //    }
    //}
    //private void MovePlayer(Vector3 direction)
    //{
    //    _rigidbody2D.transform.Translate(direction * speed * Time.deltaTime);
    //}
    private float xInput, yInput;
    public int speed = 5, collisionDistance = 1;
    private Rigidbody2D body;
    private bool isMovin;


    private bool up;
    private bool left;
    private bool down;
    private bool right;

    [SerializeField]
    private Sprite front;
    [SerializeField]
    private Sprite back;
    [SerializeField]
    private Sprite _right;
    [SerializeField]
    private Sprite _left;
    [SerializeField]
    private GameObject playerSprite;

    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
        isMovin = false;
    }
    private void Update()
    {
        //xInput = Input.GetAxisRaw("Horizontal");
        //yInput = Input.GetAxisRaw("Vertical");
        if (up)
        {
            xInput = .1f;
            yInput = 1f;
            isMovin = (xInput != 0 || yInput != 0);
            if (isMovin)
            {
                move(xInput, yInput);
            }
        }
        if (left)
        {
            xInput = -1;
            yInput = 0;
            isMovin = (xInput != 0 || yInput != 0);
            if (isMovin)
            {
                move(xInput, yInput);
            }
        }
        if (down)
        {
            yInput = -1;
            xInput = -0.1f;
            isMovin = (xInput != 0 || yInput != 0);
            if (isMovin)
            {
                move(xInput, yInput);
            }
        }
        if (right)
        {
            xInput = 1;
            yInput = 0;
            isMovin = (xInput != 0 || yInput != 0);
            if (isMovin)
            {
                move(xInput, yInput);
            }
        }

       
    }

    public void UpPointerUp()
    {
        up = true;
        playerSprite.GetComponent<SpriteRenderer>().sprite = back;
    }
    public void LeftPointerUp()
    {
        left = true;
        playerSprite.GetComponent<SpriteRenderer>().sprite = _left;
    }
    public void DownPointerUp()
    {
        down = true;
        playerSprite.GetComponent<SpriteRenderer>().sprite = front;
    }
    public void RightPointerUp()
    {
        right = true;
        playerSprite.GetComponent<SpriteRenderer>().sprite = _right;
    }

    public void UpPointerDown()
    {
        up = false;
    }
    public void LeftPointerDown()
    {
        left = false;
    }
    public void DownPointerDown()
    {
        down = false;
    }
    public void RightPointerDown()
    {
        right = false;
    }
    private void move(float xinput, float yinput)
    {
 var moveVector = new Vector3(xinput, yinput, 0);
            body.MovePosition(new Vector2((transform.position.x + moveVector.x * speed * Time.deltaTime),
                transform.position.y + moveVector.y * speed * Time.deltaTime));
    }
}
