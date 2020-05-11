using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public List<GameObject> targets;
    public TextMeshProUGUI ScoreText;
    private int Score = 0;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TargetSpawner());
        UpdateScore(0);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator TargetSpawner()
    {
        while (true)
        {
            
            yield return new WaitForSeconds(1);
            int TargetIndex = Random.Range(0, targets.Count);
            Instantiate(targets[TargetIndex]);
        }
    }

    public void UpdateScore(int delta)
    {
        Score += delta;
        if (Score < 0)
        {
            Score = 0;
        }
        ScoreText.text = "Score " + Score;

    }


}
