using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorecontroller : MonoBehaviour
{
	//Scoreを表示するテキスト
	private GameObject scoretext;
	//得点
	private int score_point = 0;

	// Use this for initialization
	void Start ()
	{
		//Scoreテキストを取得
		this.scoretext = GameObject.Find("Score");
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	//衝突時にスコアを表示
	void OnCollisionEnter(Collision other)
	{	
		if(tag == "LargeStarTag")
		{
			//スコアを加算
			score_point += 50;
			//得点表示
			this.scoretext.GetComponent<Text>().text = "Score:" + score_point + "pt";
		
		}
		else if(tag == "LargeCloudTag")
		{
			//スコアを加算
			score_point += 30;	
			//得点表示
			this.scoretext.GetComponent<Text>().text = "Score:" + score_point + "pt";
		}
		else if(tag == "SmallCloudTag")
		{
			//スコアを加算
			score_point += 20;
			//得点表示
			this.scoretext.GetComponent<Text>().text = "Score:" + score_point + "pt";
		}
		else if(tag == "SmallStarTag")
		{
			//スコアを加算
			score_point += 10;
			//得点表示
			this.scoretext.GetComponent<Text>().text = "Score:" + score_point + "pt";	
		}
	}
}
