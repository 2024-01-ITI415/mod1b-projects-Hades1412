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
    public GameObject playerObjectPrefab;

    [Header("Set Dynamically")]
    public GameObject borders;
    public GameObject background;
    public GameObject playerObject;

    public CamFollow followCam;

    // Start is called before the first frame update
    void Start()
    {
        GameObject anchor = GameObject.Find("Background and Borders");
        //adding the top border of the game
        for (int i = 0; i <= numBorder; i++)
        {
            borders = Instantiate<GameObject>(bordersPrefab);
            Vector2 bPos = Vector2.zero;
            bPos.x = i - 25;
            bPos.y = 25;
            borders.transform.position = bPos;
            borders.transform.SetParent(anchor.transform);
        }
        //adding the right border of the game
        for (int i = 0; i < numBorder; i++)
        {
            borders = Instantiate<GameObject>(bordersPrefab);
            Vector2 bPos = Vector2.zero;
            bPos.x = 25;
            bPos.y = i - 25;
            borders.transform.position = bPos;
            borders.transform.SetParent(anchor.transform);
        }
        //adding the left border of the game
        for (int i = 0; i < numBorder; i++)
        {
            borders = Instantiate<GameObject>(bordersPrefab);
            Vector2 bPos = Vector2.zero;
            bPos.x = -25;
            bPos.y = i - 25;
            borders.transform.position = bPos;
            borders.transform.SetParent(anchor.transform);
        }
        //adding the bottom border of the game
        for (int i = 0; i < numBorder; i++)
        {
            borders = Instantiate<GameObject>(bordersPrefab);
            Vector2 bPos = Vector2.zero;
            bPos.x = i - 25;
            bPos.y = -25;
            borders.transform.position = bPos;
            borders.transform.SetParent(anchor.transform);
        }

        for (int i = 0; i < backgroundWidth; i++)
        {
            
            Vector3 baPos = Vector3.zero;
            baPos.z = 1;
            baPos.x = i*10 - 20;
                for (int g = 0; g < backgroundHeight; g++)
                {
                    background = Instantiate<GameObject>(backgroundPrefab);
                    baPos.y = g*10 - 20;
                    background.transform.position = baPos;
                    background.transform.SetParent(anchor.transform);
                }

        }
        Vector3 playerPos = Vector3.zero;
        playerObject = Instantiate<GameObject>(playerObjectPrefab);
        playerObject.transform.position = playerPos;


        // Assign the instantiated player object to the FollowCam script
        followCam.target = playerObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
