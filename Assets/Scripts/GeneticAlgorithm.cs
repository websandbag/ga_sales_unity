using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//　遺伝的アルゴリズム
public class GeneticAlgorithm<T> {

    public List<DNA<T>> Population { get; private set; }    // 現在個体群
    public int Generation { get; private set; }             // 世代
    public int PointLength { get; private set; }            // 点の数
    public float BestFitness { get; private set; }          // 最短経路の距離
    public T[] BestPath {get; private set;}                 // 最短経路
    public T[] Original { get; private set; }               // ルート一覧


    // コンストラクタ
    public GeneticAlgorithm(
        int populationSize,                                 // 個体数
        int dnaSize,                                        // DNA数
        T[] rootList                                        // ランダムルート用の関数
    )
    {
        // 初期世代調整
        Generation = 1;

        // 最新
        this.Original = rootList;

        // 現世代の個体群作成
        Population = new List<DNA<T>>(populationSize);

        // 最短経路
        BestPath = new T[dnaSize];

        // 個体追加
        for (int i = 0; i < populationSize; i++)
        {
            // 個体群に個体追加
            Population.Add(new DNA<T>(
                populationSize,
                Original
            ));
        }
    }

    // 適応度比較
    private void CompareDNA(DNA<T> a, DNA<T> b)
    {

    }

    // 次世代作成
    private void NewGeneration()
    {

    }

    // 適応度計算
    private void CalculateFitness()
    {

    }

    // 親DNAを選定
    private DNA<T> ChooseParent()
    {
        return null;
    }

}
