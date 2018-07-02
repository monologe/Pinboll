using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
	
	private int score = 0;
    private Text scoreLabel;

    void Start()
    {
        // 「Text」コンポーネントにアクセスして取得する（ポイント）
        scoreLabel = this.gameObject.GetComponent<Text>();
        scoreLabel.text = "Score " + score;
    }

    // Update is called once per frame
    void Update()
    {
        scoreLabel.text = "Score " + score;

    }
        // スコアを加算するメソッド
        public void AddScore(int amount)
    {

        // 「amount」に入ってくる数値分を加算していく。
        score += amount;

        scoreLabel.text = "Score " + score;
    }
}