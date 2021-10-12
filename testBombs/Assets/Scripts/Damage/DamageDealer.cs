using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Tilemaps;

public class DamageDealer : MonoBehaviour
{
    public Tilemap tilemap;
        public Tile tile;


    private void OnTriggerEnter2D(Collider2D other)
    {
        var damagableObject = other.gameObject.GetComponent<IDamagable>();

        if (damagableObject != null)

        {
            damagableObject.ApplyDamage();
        }
    }
}
