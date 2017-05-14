using UnityEngine;
using System.Collections.Generic;

public class ShowHighscores : MonoBehaviour {

	public Camera _cam;
    public ScoreboardHandler scoreHandler;

    public GameObject aFirst, aSecond, aThird;
    public GameObject bFirst, bSecond, bThird;

    public void LoadHighscores()
	{
        //include logic for loading and displaying highscores
        List<int> scores = scoreHandler.GetAllEntries();
		
		bFirst.GetComponent<UnityEngine.UI.Text>().text = "1) " + scores[0].ToString();
		aFirst.GetComponent<UnityEngine.UI.Text>().text = "1) " + scores[3].ToString();
		bSecond.GetComponent<UnityEngine.UI.Text>().text = "1) " + scores[1].ToString();
		aSecond.GetComponent<UnityEngine.UI.Text>().text = "1) " + scores[4].ToString();
		bThird.GetComponent<UnityEngine.UI.Text>().text = "1) " + scores[2].ToString();
		aThird.GetComponent<UnityEngine.UI.Text>().text = "1) " + scores[5].ToString();


		/*
        if(scoreHandler.bestBlockadeScore.score > 0)
            bFirst.GetComponent<UnityEngine.UI.Text>().text = "1) " + scores[0].ToString();
        if (scoreHandler.bestArcadeScore.score > 0)
            aFirst.GetComponent<UnityEngine.UI.Text>().text = "1) " + scores[3].ToString();

        ScoreEntry aSecondPlace, aThirdPlace;
        aSecondPlace.type = 1;
        aSecondPlace.score = 0;
        aThirdPlace = aSecondPlace;

        ScoreEntry bSecondPlace, bThirdPlace;
        bSecondPlace.type = 0;
        bSecondPlace.score = 0;
        bThirdPlace = bSecondPlace;

        Debug.Log(scores.Count.ToString());

            if (score.type == 0)
            {
                if (score.score > bSecondPlace.score)
                {
                    bSecondPlace = score;
                }
                else if (score.score > bThirdPlace.score)
                {
                    bThirdPlace = score;
                }
            }
            else
            {
                if (score.score > aSecondPlace.score)
                {
                    aSecondPlace = score;
                }
                else if (score.score > aThirdPlace.score)
                {
                    aThirdPlace = score;
                }
            }
        }

        if (aSecondPlace.score > 0)
        {
            aSecond.GetComponent<UnityEngine.UI.Text>().text = "2) " + aSecondPlace.score.ToString();
        }
        if (aThirdPlace.score > 0)
        {
            aThird.GetComponent<UnityEngine.UI.Text>().text = "3) " + aThirdPlace.score.ToString();
        }

        if (bSecondPlace.score > 0)
        {
            bSecond.GetComponent<UnityEngine.UI.Text>().text = "2) " + bSecondPlace.score.ToString();
        }
        if (bThirdPlace.score > 0)
        {
            bThird.GetComponent<UnityEngine.UI.Text>().text = "3) " + bThirdPlace.score.ToString();
        }
       */
	}

	void Start()
	{
		Screen.SetResolution (480, 800, false);
		_cam.GetComponent<Camera>().aspect = 3.0f / 5.0f;
	}
}
