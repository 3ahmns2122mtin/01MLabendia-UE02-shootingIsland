using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject target;
    public GameObject parentOfTargets;
    public GameObject objCounter;

    private Text textCounter;
    public int score;
    public bool won;

    void Start()
    {
        textCounter = objCounter.GetComponent<Text>();
        InvokeRepeating("Spawn", 1f, 2f);
        won = false;
    }

    //Spawn a target att a random position within a specified  x and y range.
    //Instatiate (make a concrete GameObject, i.e, a clone from the given prefab target) the
    //target as child of the parentOfTargets. In this case transform.localposition instead of
    //transform.position is imoirtant!!
    private void Spawn()
    {
        float randomX = Random.Range(-425, 430);
        float randomY = Random.Range(-249, 210);

        Vector2 random2DPosition = new Vector2(randomX, randomY);

        GameObject myTarget = Instantiate(target, parentOfTargets.transform);
        myTarget.transform.localPosition = random2DPosition;

        Debug.Log(random2DPosition);
    }

    void Update()
    {
        if (won == true)
        {
            CancelInvoke("Spawn");
        }
        else
        {
            Debug.Log(won);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse pressed");
        }
    }

    public void IncrementScore()
    {
        score++;
        Debug.Log("Increment ... " + score);
        textCounter.text = score.ToString();

        if(score == 10)
        {
            won = true;
        }
    }
}