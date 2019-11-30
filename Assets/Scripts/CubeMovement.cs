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

    private float _posBtnLeft;
    private float _posBtnRight;

    public float speed;
    private float rotationSpeed = 130;

    public Text Score;
    private int _score = 0;
    private int winningScore = 9;

    private float offset = 2f;
    public List<GameObject> tailObjects = new List<GameObject>();
    public GameObject tailPrefab;

    public bool pause = false;
    private bool _isMove = true;

    private int difficulty; 


    void Start()
    {
        tailObjects.Add(gameObject);
        _posBtnLeft = btnLeft.transform.position.y;
        _posBtnRight = btnRight.transform.position.y;

        difficulty = PlayerPrefs.GetInt("Diff");
        if (difficulty == 0)
        {
            speed = 4f;
        }
        else if (difficulty == 1)
        {
            speed = 5f;
        }
        else if (difficulty == 2)
        {
            speed = 6f;
        }

    }

    void Update()
    {

        Score.text = _score.ToString() + "/9";
    if (_isMove)
    {
        transform.Translate(Time.deltaTime * speed * Vector3.forward);

        if (_posBtnLeft != btnLeft.transform.position.y)
        {
            transform.Rotate(Time.deltaTime * rotationSpeed * -Vector3.up);
        }
        if (_posBtnRight != btnRight.transform.position.y)
        {
            transform.Rotate(Time.deltaTime * rotationSpeed * Vector3.up);
        }
    }
        

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("End"))
        {
            if (_score == winningScore)
            {
                Win();
            }
        }
    }

public void AddTail()
    {
        _score++;
        
        Vector3 newTailPos = tailObjects[tailObjects.Count - 1].transform.position;
        newTailPos.z -= offset;
        tailObjects.Add( GameObject.Instantiate(tailPrefab, newTailPos, Quaternion.identity) as GameObject);
        
    } 

    public void Lose()
    {
        Stars.SetActive(true);
        PanelLose.SetActive(true);
        Pause.SetActive(false);
        _isMove = false;
    }

    public void Win()
    {
        PanelWin.SetActive(true);
        pause = true;
    }
}
