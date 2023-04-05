using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
     [SerializeField] float movespeed = 10f;





    
    // Start is called before the first frame update
    void Start()
    {
       PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
       MovingPlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move Your Player with WASD or arrow Keys");
        Debug.Log("Don't hit the walls!");
}

    void MovingPlayer(){ float xValue = Input.GetAxis("Horizontal")*Time.deltaTime*movespeed;
                         float zValue = Input.GetAxis("Vertical")*Time.deltaTime*movespeed;
                         transform.Translate(xValue,0,zValue);}

   
}
  