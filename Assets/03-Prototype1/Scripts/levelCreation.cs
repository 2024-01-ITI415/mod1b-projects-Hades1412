using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelCreation : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject bordersPrefab;
    public Vector2 bordersPos;
    public int numBorder = 50;
    public GameObject backgroundPrefab;
    public Vector2 backgroundPos;
    public int backgroundWidth = 5;
    public int backgroundHeight = 5;

    [Header("Set Dynamically")]
    public GameObject borders;
    public GameObject background;

    // Start is called before the first frame update
    void Start()
    {
        //adding the top border of the game
        for (int i = 0; i <= numBorder; i++)
        {
            borders = Instantiate<GameObject>(bordersPrefab);
            Vector2 bPos = Vector2.zero;
            bPos.x = i - 25;
            bPos.y = 25;
            borders.transform.position = bPos;
        }
        //adding the right border of the game
        for (int i = 0; i < numBorder; i++)
        {
            borders = Instantiate<GameObject>(bordersPrefab);
            Vector2 bPos = Vector2.zero;
            bPos.x = 25;
            bPos.y = i - 25;
            borders.transform.position = bPos;
        }
        //adding the left border of the game
        for (int i = 0; i < numBorder; i++)
        {
            borders = Instantiate<GameObject>(bordersPrefab);
            Vector2 bPos = Vector2.zero;
            bPos.x = -25;
            bPos.y = i - 25;
            borders.transform.position = bPos;
        }
        //adding the bottom border of the game
        for (int i = 0; i < numBorder; i++)
        {
            borders = Instantiate<GameObject>(bordersPrefab);
            Vector2 bPos = Vector2.zero;
            bPos.x = i - 25;
            bPos.y = -25;
            borders.transform.position = bPos;
        }

        for (int i = 0; i < backgroundWidth; i++)
        {
            background = Instantiate<GameObject>(backgroundPrefab);
            Vector2 baPos = Vector2.zero;
            baPos.x = i*10 - 20;
                for (int g = 0; g < backgroundHeight; g++)
                {
                    baPos.y = g*10 - 20;
                    background.transform.position = baPos;
                }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
