using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region Singleton
    private static Player _instance;
    public static Player Instance;
    #endregion
    // Singleton is created so the enemies can access the players more easily

    public delegate void ChangeEnemyColor(Color color); // passing in reference to color
    public static event ChangeEnemyColor onEnemyHit;
    // Start is called before the first frame update

    private void Awake()
    {
        _instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // damage enemy
            if(onEnemyHit != null) // not null = people are listening for event
            {
                onEnemyHit(Color.red);
            }
        }
    }
}
