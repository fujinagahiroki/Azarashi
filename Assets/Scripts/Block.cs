﻿using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

    public float minHeight;
    public float maxHeight;
    public GameObject pivot;

	void Start () {
        //開始時に隙間の高さを変更
        ChangeHeight();
	}
    void ChangeHeight()
    {
        //ランダムな高さを生成して設定
        float height = Random.Range(minHeight, maxHeight);
        pivot.transform.localPosition = new Vector3(0.0f, height, 0.0f);
    }

    //ScrollObjectスクリプトからのメッセージを受け取って高さを変更
    void OnScrollEnd()
    {
        ChangeHeight();
    }	
	
}