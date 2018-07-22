using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//　遺伝的アルゴリズム
public class GeneticAlgorithm<T> {

    public List<DNA<T>> Population { get; private set; }    // 現在個体群
    public int Generation;                                  // 世代
    public int PointLength;                                 // 点の数

    private T[] rootList;


    // コンストラクタ
    public GeneticAlgorithm(
        int populationSize,                                 // 個体数
        int dnaSize,                                        // DNA数
        T[] rootList                                        // ランダムルート用の関数
    )
    {
        // 初期世代調整
        Generation = 1;

        // ランダムルート用の関数追加
        this.rootList = rootList;

        // 現世代の個体群作成
        // 空List作成
        Population = new List<DNA<T>>(populationSize);

        // 個体追加
        for (int i = 0; i < populationSize; i++)
        {
            // 個体群に個体追加
            Population.Add(new DNA<T>(
                populationSize,
                rootList
            ));
        }
    }

    // 次世代作成
    private void NewGeneration()
    {

    }

    // 適応度比較
    private void CompareDNA(DNA<T> a, DNA<T> b)
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
