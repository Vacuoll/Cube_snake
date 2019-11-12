using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CubeMovement : MonoBehaviour
{
    public GameObject PanelWin;
    public GameObject PanelLose;
    public GameObject btnLeft;
    public GameObject btnRight;
    public GameObject Stars;
    public GameObject Pause;

    float PosBtnLeft;
    float PosBtnRight;

    public float speed;
    public float rotationSpeed;

    public Text Score;
    private int score;
    private int winningScore = 9;

    private float offset = 2f;
    public List<GameObject> tailObjects = new List<GameObject>();
    public GameObject tailPrefab;

    public bool pause = false;
    private bool isMove = true;


    void Start()
    {
        tailObjects.Add(gameObject);
        PosBtnLeft = btnLeft.transform.position.y;
        PosBtnRight = btnRight.transform.position.y;

    }

    void Update()
    {

        Score.text = score.ToString();
    if (isMove)
     {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (PosBtnLeft != btnLeft.transform.position.y)
        {
            transform.Rotate(-Vector3.up * rotationSpeed * Time.deltaTime);
        }
        if (PosBtnRight != btnRight.transform.position.y)
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }
        

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("End"))
        {
            if (score == winningScore)
            {
                Win();
            }
        }
    }

public void AddTail()
    {
        score++;
        
        Vector3 newTailPos = tailObjects[tailObjects.Count - 1].transform.position;
        newTailPos.z -= offset;
        tailObjects.Add( GameObject.Instantiate(tailPrefab, newTailPos, Quaternion.identity) as GameObject);
        
    } 

    public void Lose()
    {
        Stars.SetActive(true);
        PanelLose.SetActive(true);
        Pause.SetActive(false);
        isMove = false;
    }

    public void Win()
    {
        PanelWin.SetActive(true);
        pause = true;
    }
}
