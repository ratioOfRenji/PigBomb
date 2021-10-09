using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadomAi : MonoBehaviour
{
    int stepCount = 0;
    Vector3 _direction;
    float stepSize = 45;
    //
    private float xInput, yInput;
    public int speed = 5, collisionDistance = 1;
    private Rigidbody2D body;
    private bool isMovin;
    private int choseDirection;
    Vector3 currentPos;
   public float distance;
    void Start()
    {
        // currentPos = new Vector3 (150, 0,0);
        currentPos = this.transform.position;
         body = GetComponent<Rigidbody2D>();
        isMovin = false;
        StartCoroutine(patrol());
    }

   
    void Update()
    {
        if(isMovin)
        body.MovePosition(new Vector2((transform.position.x + _direction.x * speed * Time.deltaTime),
                transform.position.y + _direction.y * speed * Time.deltaTime));
    }
    private IEnumerator patrol()
    {
        //объявление значение, котрое игок точно не получит в игре, чтобы первый раз запустить цикл

        distance = Vector3.Distance(this.transform.position, currentPos);
        if (currentPos == this.transform.position)
        {
            ChangeDirection();
            
        }
        // transform.Translate(_direction * stepSize * Time.deltaTime);
        isMovin = true;
        yield return new WaitForSeconds(1f);
        stepCount--;
        isMovin = false;
        currentPos = transform.position;
        StartCoroutine(patrol());
        //if(stepCount == 0)
        //{
        //    int drection = Random.Range(0, 5);
        //    if(drection == 1)
        //    {
        //        _direction = new Vector3 (0.1f, 1, 0);
        //    }
        //    if (drection == 2)
        //    {
        //        _direction = Vector3.left;
        //    }
        //    if (drection == 3)
        //    {
        //        _direction = new Vector3 (-0.1f,-1,0);
        //    }
        //    if (drection == 4)
        //    {
        //        _direction = Vector3.right;
        //    }
        //    stepCount = 5;
        //}
        ////// transform.Translate(_direction * stepSize * Time.deltaTime);
        //isMovin = true;
        //yield return new WaitForSeconds(.3f);
        //stepCount--;
        //isMovin = false;
        //StartCoroutine(patrol());
    }
    private void ChangeDirection()
    {
       choseDirection = Random.Range(0, 5);
            if (choseDirection == 1)
            {
                _direction = new Vector3(0.1f, 1, 0);
            }
            if (choseDirection == 2)
            {
                _direction = Vector3.left;
            }
            if (choseDirection == 3)
            {
                _direction = new Vector3(-0.1f, -1, 0);
            }
            if (choseDirection == 4)
            {
                _direction = Vector3.right;
            }
    }
}
