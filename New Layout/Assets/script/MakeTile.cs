using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeTile : MonoBehaviour
{
    [Header("Configuration")]

    [SerializeField] GameObject Unchangeable_jG;
    [SerializeField] GameObject Unchangeable_SGTG;
    [SerializeField] GameObject Unchangeable_LGKRN;
    [SerializeField] GameObject Unchangeable_Hati;
    [SerializeField] GameObject Unchangeable_Ketupat;
    [SerializeField] GameObject Changeable;
    private int rows = 7;
    private int cols = 7;
    private float tileSize = 1;
    // Start is called before the first frame update
    void Start()
    {
        GenerateUIGrid();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GenerateUIGrid()
    {
        for(int row = 0;row<rows;row++)
        {
            for(int col = 0;col<cols;col++)
            {
                if((row == 0 && col == 0) || (row == 1 && col == 3) ||
                (row == 2 && col == 5) || (row == 6 && col == 3))
                {
                    GameObject JG_UN = (GameObject) Instantiate(Unchangeable_jG,transform);
                    float posX = col * tileSize;
                    float posY = row * -tileSize;
                    JG_UN.transform.position = new Vector2(posX,posY);
                }
                else if((row == 1 && col == 1) || (row == 4 && col == 4) ||
                (row == 5 && col == 6) || (row == 6 && col == 1))
                {
                    GameObject SGTG_UN = (GameObject) Instantiate(Unchangeable_SGTG,transform);
                    float posX = col * tileSize;
                    float posY = row * -tileSize;
                    SGTG_UN.transform.position = new Vector2(posX,posY);
                }
                else if((row == 0 && col == 1) || (row == 3 && col == 5) ||
                (row == 4 && col == 1))
                {
                    GameObject LGKRN_UN = (GameObject) Instantiate(Unchangeable_LGKRN,transform);
                    float posX = col * tileSize;
                    float posY = row * -tileSize;
                    LGKRN_UN.transform.position = new Vector2(posX,posY);
                }
                else if((row == 0 && col == 4) || (row == 5 && col == 2) ||
                (row == 6 && col == 6))
                {
                    GameObject Hati_UN = (GameObject) Instantiate(Unchangeable_Hati,transform);
                    float posX = col * tileSize;
                    float posY = row * -tileSize;
                    Hati_UN.transform.position = new Vector2(posX,posY);
                }
                else if((row == 0 && col == 5) || (row == 1 && col == 2) ||
                (row == 1 && col == 5) || (row == 2 && col == 3) || (row == 3 && col == 2) ||
                (row == 5 && col == 1) || (row == 6 && col == 0))
                {
                    GameObject KTPT_UN = (GameObject) Instantiate(Unchangeable_Ketupat,transform);
                    float posX = col * tileSize;
                    float posY = row * -tileSize;
                    KTPT_UN.transform.position = new Vector2(posX,posY);
                }
                else
                {
                    GameObject Changeable_Tile = (GameObject) Instantiate(Changeable,transform);
                    float posX = col * tileSize;
                    float posY = row * -tileSize;
                    Changeable_Tile.transform.position = new Vector2(posX,posY);
                }
            }
        }

        float gridW = cols * tileSize;
        float gridH = rows * tileSize;

        float offX = -gridW/2 + tileSize/2;
        float offY = gridH/2 - tileSize/2;
        
        transform.position = new Vector2(offX, offY);
    }
}
