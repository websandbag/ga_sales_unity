using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//　遺伝的アルゴリズム
public class GeneticAlgorithm<T> {

    public List<DNA<T>> Population { get; private set; }    // 個体群
    public int Generation;                                  // 世代
    public int PointLength;                                 // 点の数

    // コンストラクタ
    public GeneticAlgorithm()
    {
        Generation = 1;
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
