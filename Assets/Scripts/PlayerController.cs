using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    int generation;                                         // 世代
    public GameObject[] originalPoints;                     // 初期位置
    int pointLength;                                        // 点の数

    private GeneticAlgorithm<char> ga;
    private System.Random random;

    // 開始時
    void Start () {
        generation = 0;
        originalPoints = GameObject.FindGameObjectsWithTag("CheckPoint");
        pointLength = originalPoints.Length;

        ga = new GeneticAlgorithm<char>(
            pointLength
        );
    }

	// Update is called once per frame
	void Update () {
		
	}
}
