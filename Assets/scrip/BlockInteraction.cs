using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BlockInteraction : MonoBehaviour
{
    float horizontal;
    float vertical;
    public int speed = 5;
    public GameObject selectedBlock;
    public float jump = 5;
    Rigidbody rb;
    private float player = 1;
    public TextMeshProUGUI playerTurn;
    public bool gameover;
    public TextMeshProUGUI gameoverText;
    public GameObject gameOvered;
    public GameObject NoGameOvered;
    public float blockHitGround = 0;

    public Material blahKolor;

    Vector3 CameraPos;
    // Start is called before the first frame update
    void Start()
    {
        gameover = false;
        rb = selectedBlock.GetComponent<Rigidbody>();
        blahKolor = selectedBlock.GetComponent<Renderer>().material;
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(blockHitGround >= 10)
        {
            GameOver();
        }
        else
        {
            PlayerControl();
            playerTurn.text = "Player " + player + "'s Turn";
        }
    }

    private void FixedUpdate()
    {
        Vector3 position = rb.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;
        position.z = position.z + speed * vertical * Time.deltaTime;

        rb.MovePosition(position);
    }
    public void Turns()
    {
        if(player == 1)
        {
            player = 2;
        }
        else if(player == 2)
        {
            player = 1;
        }
    }
    private void GameOver()
    {
        NoGameOvered.SetActive(false);
        gameOvered.SetActive(true);
        if (player == 1)
        {
            gameoverText.text = "Player 2 Wins";
        }
        else if (player == 2 )
        {
            gameoverText.text = "Player 1 Wins";
        }
    }

    private void PlayerControl()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.gameObject.tag == "Block")
                {
                    selectedBlock = hit.transform.gameObject;
                    rb = selectedBlock.GetComponent<Rigidbody>();
                }
            }
        }

        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
        CameraPos = Camera.main.transform.forward;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(0, jump, 0);
        }
    }
}
