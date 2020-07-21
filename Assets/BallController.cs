using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour 
{

	//Scoreを表示するテキスト
	private GameObject scoretext;
	//得点
	private int score_point = 0;
	

	//ボールが見える可能性のあるz軸の最大値
	private float visiblePosZ = -6.5f;

	//ゲームオーバを表示するテキスト
	private GameObject gameoverText;

	// Use this for initialization
	void Start () 
	{
		//シーン中のGameOverTextオブジェクトを取得
		this.gameoverText = GameObject.Find("GameOverText");
		//Scoreテキストを取得
		this.scoretext = GameObject.Find("Score");
	}
	
	// Update is called once per frame
	void Update () 
	{
		//ボールが画面外に出た場合
		if(this.transform.position.z < this.visiblePosZ)
		{
			//GameoverTextにゲームオーバを表示
			this.gameoverText.GetComponent<Text>().text = "Game Over";
		}
	}
	//衝突時にスコアを表示
	void OnCollisionEnter(Collision other)
	{	
		if(other.gameObject.tag == "LargeStarTag")
		{
			//スコアを加算
			score_point += 50;
			//得点表示
			this.scoretext.GetComponent<Text>().text = "Score:" + score_point + "pt";
		
		}
		else if(other.gameObject.tag == "LargeCloudTag")
		{
			//スコアを加算
			score_point += 30;	
			//得点表示
			this.scoretext.GetComponent<Text>().text = "Score:" + score_point + "pt";
		}
		else if(other.gameObject.tag == "SmallCloudTag")
		{
			//スコアを加算
			score_point += 20;
			//得点表示
			this.scoretext.GetComponent<Text>().text = "Score:" + score_point + "pt";
		}
		else if(other.gameObject.tag == "SmallStarTag")
		{
			//スコアを加算
			score_point += 10;
			//得点表示
			this.scoretext.GetComponent<Text>().text = "Score:" + score_point + "pt";	
		}
	}
}
