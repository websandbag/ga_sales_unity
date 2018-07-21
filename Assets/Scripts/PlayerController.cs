using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    // 各ポイント取得
    public GameObject[] Points;

    // コンストラクタ
    public PlayerController()
    {
        
    }

    // 開始時
	void Start () {
        // ポイント情報を取得
        Points = GameObject.FindGameObjectsWithTag("CheckPoint");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
