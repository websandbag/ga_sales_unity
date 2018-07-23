using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


// 染色体情報
public class DNA<T>{

    // 遺伝子(ポイント)
    public T[] Genes { get; private set; }

    // 適応度
    public float Fitness { get; private set; }

    // 突然変異用の乱数機
    private System.Random random;

    // ルートリスト作成
    private T[] original;
    

    // 初期設定
    public DNA(
        int size,                       // 遺伝子の数（ポイント数）
        T[] original,                   // ランダム用の関数追加
        bool shouldInitGene = true      // 初期化設定
    )
    {
        // 空のリストを用意
        Genes = new T[size];

        // ランダムルート関数追加
        this.original = original;

        // 初回のみ、ランダムなポイントを指定
        if (shouldInitGene)
        {
            Genes = original.OrderBy(i => Guid.NewGuid()).ToArray();
        }
    }

    // 交叉
    public DNA<T> Crossover(DNA<T> otherParent)
    {
        return otherParent;
    }


    // 突然変異
    public void Mutate(float mutateRate)
    {
        for(int i = 0; i < Genes.Length; i++)
        {
            if(random.NextDouble() <= mutateRate)
            {
                // 突然変異発生
            }
        }
    }


}
