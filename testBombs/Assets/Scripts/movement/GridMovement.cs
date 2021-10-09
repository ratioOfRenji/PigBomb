using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMovement : MonoBehaviour
{
    private bool isMovin;
    private Vector3 origPos, targetPos;
    private float timeToMove = 0.35f;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && !isMovin)
        {
            StartCoroutine(MovePlayer(Vector3.up));
                }
        if (Input.GetKey(KeyCode.A) && !isMovin)
        {
            StartCoroutine(MovePlayer(Vector3.left));
        }
        if (Input.GetKey(KeyCode.S) && !isMovin)
        {
            StartCoroutine(MovePlayer(Vector3.down));
        }
        if (Input.GetKey(KeyCode.D) && !isMovin)
        {
            StartCoroutine(MovePlayer(Vector3.right));
        }
    }
    private IEnumerator MovePlayer(Vector3 Direction)
    {
        isMovin = true;
        float elapsedTime = 0;
        origPos = transform.position;
        targetPos = origPos + Direction;
        while( elapsedTime < timeToMove)
        { transform.position = Vector3.Lerp(origPos, targetPos, (elapsedTime / timeToMove));
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        // еще раз привожу объект ровно к нужной позиции, чтобы избежать минимальных отклонений.
        transform.position = targetPos;
        isMovin = false;
    }
    //private void MovePlayerr(Vector3 Direction)
    //{
    //    transform.Translate(Direction * speed * Time.deltaTime);
    //}
}
