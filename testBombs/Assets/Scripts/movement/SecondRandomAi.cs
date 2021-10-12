using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondRandomAi : MonoBehaviour
{
    private Vector3 VerticalDirection = new Vector3(0.1f, 1, 0);
    private Vector3 HorizontalDirection = new Vector3(1, 0, 0);
    Vector3 currentPos;
    Vector3 _direction;
 private string[] orientations = { "horizontal", "verical" };
    [SerializeField]
    private string orientaton;
    public int speed = 5, collisionDistance = 1;
    private Rigidbody2D body;
    [SerializeField]
    private float ostacleRayDistance;
    [SerializeField]
    private GameObject rayDownGameObjectOne;
    [SerializeField]
    private GameObject rayDownGameObjectTwo;
    [SerializeField]
    private GameObject rayLeftGameObjectOne;
    [SerializeField]
    private GameObject rayLeftGameObjectTwo;
    [SerializeField]
    private GameObject rayRightGameObjectOne;
    [SerializeField]
    private GameObject rayRightGameObjectTwo;
    [SerializeField]
    private GameObject rayUpGameObjectOne;
    [SerializeField]
    private GameObject rayUpGameObjectTwo;

    // visuals
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

    private bool playedNotFirstTime;
    void Start()
    {
        
        currentPos = this.transform.position ;
        if(orientaton == "horizontal")
        {
            _direction = HorizontalDirection;
        }
        if(orientaton == "verical")
        {
            _direction = VerticalDirection;
        }
        body = GetComponent<Rigidbody2D>();
        
        StartCoroutine(Patrol());
    }

    void Update()
    {
        
            body.MovePosition(new Vector2((transform.position.x + _direction.x * speed * Time.deltaTime),
                    transform.position.y + _direction.y * speed * Time.deltaTime));
        if(orientaton == "horizontal")
        {
         CastRayDown();
         CastRayUp();
        }
       if(orientaton == "verical")
        {
        CastRayleft();
        CastRayRight();
        }
        
        
    }

    private IEnumerator Patrol()
    {
        if(currentPos == this.transform.position && playedNotFirstTime)
        {
            if (orientaton == "horizontal")
            {
                if (playerSprite.GetComponent<SpriteRenderer>().sprite == _right)
                {
                    playerSprite.GetComponent<SpriteRenderer>().sprite = _left;
                } 
                else
                {
                    playerSprite.GetComponent<SpriteRenderer>().sprite = _right;
                }
            }
            if (orientaton == "verical")
            {
                if (playerSprite.GetComponent<SpriteRenderer>().sprite == front)
                {
                    playerSprite.GetComponent<SpriteRenderer>().sprite = back;
                }
                else
                {
                    playerSprite.GetComponent<SpriteRenderer>().sprite = front;
                }
            }


            _direction = _direction * -1;
        }
        currentPos = this.transform.position;
        yield return new WaitForSeconds(.2f);
        playedNotFirstTime = true;
        StartCoroutine(Patrol());
    }
    void CastRayDown()
    {
      RaycastHit2D hitDownOne =  Physics2D.Raycast(rayDownGameObjectOne.transform.position,  new Vector2(-.1f, -1), ostacleRayDistance);
        Debug.DrawRay(rayDownGameObjectOne.transform.position, new Vector2(-.1f, -1), Color.red);
        RaycastHit2D hitDownTwo = Physics2D.Raycast(rayDownGameObjectTwo.transform.position, new Vector2(-.1f, -1), ostacleRayDistance);
        Debug.DrawRay(rayDownGameObjectTwo.transform.position, new Vector2(-.1f, -1), Color.red);
        if (hitDownOne.collider == null && hitDownTwo.collider == null)
        {
           
            int chanceToChangeDirection = Random.Range(0, 195);
            if(chanceToChangeDirection == 80)
            {
             _direction = VerticalDirection * -1; orientaton = "verical";
                playerSprite.GetComponent<SpriteRenderer>().sprite = front;
            }
         
        }
    }
    void CastRayRight()
    {
        RaycastHit2D hitRight = Physics2D.Raycast(rayRightGameObjectOne.transform.position, new Vector2(1f, 0), ostacleRayDistance);
        Debug.DrawRay(rayRightGameObjectOne.transform.position, new Vector2(1f, 0), Color.red);
        RaycastHit2D hitRightTwo = Physics2D.Raycast(rayRightGameObjectTwo.transform.position, new Vector2(1f, 0), ostacleRayDistance);
        Debug.DrawRay(rayRightGameObjectTwo.transform.position, new Vector2(1f, 0), Color.red);
        if (hitRight.collider == null && hitRightTwo.collider == null)
        {

            int chanceToChangeDirection = Random.Range(0, 195);
            if (chanceToChangeDirection == 40)
            {
                _direction = HorizontalDirection; orientaton = "horizontal";
                playerSprite.GetComponent<SpriteRenderer>().sprite = _right;
            }

        }
    }
    void CastRayleft()
    {
        RaycastHit2D hitleft = Physics2D.Raycast(rayLeftGameObjectOne.transform.position, new Vector2(-1f, 0), ostacleRayDistance);
        Debug.DrawRay(rayLeftGameObjectOne.transform.position, new Vector2(-1f, 0), Color.red);
        RaycastHit2D hitleftTwo = Physics2D.Raycast(rayLeftGameObjectTwo.transform.position, new Vector2(-1f, 0), ostacleRayDistance);
        Debug.DrawRay(rayLeftGameObjectTwo.transform.position, new Vector2(-1f, 0), Color.red);
        if (hitleft.collider == null && hitleftTwo.collider == null)
        {

            int chanceToChangeDirection = Random.Range(0, 195);
            if (chanceToChangeDirection == 10)
            {
                _direction = HorizontalDirection * -1; orientaton = "horizontal";
                playerSprite.GetComponent<SpriteRenderer>().sprite = _left;
            }

        }

    }
    void CastRayUp()
    {
        RaycastHit2D hitUp = Physics2D.Raycast(rayUpGameObjectOne.transform.position, new Vector2(.1f, 1), ostacleRayDistance);
        Debug.DrawRay(rayUpGameObjectOne.transform.position, new Vector2(.1f, 1), Color.red);
        RaycastHit2D hitUpTwo = Physics2D.Raycast(rayUpGameObjectTwo.transform.position, new Vector2(.1f, 1), ostacleRayDistance);
        Debug.DrawRay(rayUpGameObjectTwo.transform.position, new Vector2(.1f, 1), Color.red);
        if (hitUp.collider == null && hitUpTwo.collider == null)
        {

            int chanceToChangeDirection = Random.Range(0, 195);
            if (chanceToChangeDirection == 20)
            {
                _direction = VerticalDirection; orientaton = "verical";
                playerSprite.GetComponent<SpriteRenderer>().sprite = back;
            }

        }
    }
}
