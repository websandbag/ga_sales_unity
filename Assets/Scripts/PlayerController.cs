using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField] public int populationSize = 10;

    private int generation;                             // 世代
    private GameObject[] originalPoints;                // 初期位置


    private GeneticAlgorithm<int> ga;
    private System.Random random;

    // 開始時
    void Start () {
        generation = 0;
        originalPoints = GameObject.FindGameObjectsWithTag("CheckPoint");

        // 遺伝的アルゴリズムの初期設定
        ga = new GeneticAlgorithm<int>(
            populationSize,                             // 個体数
            originalPoints.Length,                      // チェックポイント数
            GetRootIDs()                                // チェックポイントID
        );
    }

    // フレーム単位の更新処理
    void Update () {

    }

    // ルートのゲームオブジェクトを取得
    private int[] GetRootIDs()
    {
        var ids = new int[originalPoints.Length];
        for (int i = 0; i < originalPoints.Length; i++)
        {
            ids[i] = originalPoints[i].GetInstanceID();
        }        
        return ids;
    }
}
