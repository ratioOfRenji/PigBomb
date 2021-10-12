using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject winUi;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PlayerCollider"))
        {
            winUi.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
