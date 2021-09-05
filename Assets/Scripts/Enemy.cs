using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player.onEnemyHit += Damage;
    }

    void Damage(Color color)
    {
        transform.GetComponent<Renderer>().material.color = color;
        // whatever color we pass in is what the enemy color will change to
    }
    private void OnDisable()
    {
        Player.onEnemyHit -= Damage;
    }
}
