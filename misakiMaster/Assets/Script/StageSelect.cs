﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageSelect : MonoBehaviour
{
    // シーン管理マネージャの取得
    GameObject SceneNavigatorObj;
    SceneNavigator script;

    [SerializeField] GameObject menuPanel = default;
    [SerializeField] GameObject setting_buton = default;

    [SerializeField] GameObject HAZIMARINOUMI = default;
    [SerializeField] GameObject SEIREINOMORI = default;
    [SerializeField] GameObject KARAPPONOKAZAN = default;

    // Start is called before the first frame update
    void Start()
    {
        //BackToMenuメソッドを呼び出す
        InitStageChoice();

        SceneNavigatorObj = GameObject.Find("SceneNavigator");
        script = SceneNavigatorObj.GetComponent<SceneNavigator>();
    }


    // ステージセレクト画面１ではじまりのうみステージを選択した場合
    public void StageChoice_HAZIMARINOUMI()
    {
        Debug.Log("はじまりのうみステージ");
        // menuPanelはActive(true)のままにする
        HAZIMARINOUMI.SetActive(true);
    }
    public void StageChoice_SEIREINOMORI()
    {
        Debug.Log("せいれいのもりステージ");
        // menuPanelはActive(true)のままにする
        SEIREINOMORI.SetActive(true);
    }
    public void StageChoice_KARAPPONOKAZAN()
    {
        Debug.Log("からっぽのかざんステージ");
        // menuPanelはActive(true)のままにする
        KARAPPONOKAZAN.SetActive(true);
    }

    //ステージセレクト画面１に戻るとき
    public void InitStageChoice()
    {
        menuPanel.SetActive(true);
        setting_buton.SetActive(false);

        // 各ステージセレクト画面は非表示にする（ワールド選択が見えなくなるため）
        HAZIMARINOUMI.SetActive(false);
        SEIREINOMORI.SetActive(false);
        KARAPPONOKAZAN.SetActive(false);
    }

    // ここから各ステージの遷移
    public void Stage1_1()
    {
        Debug.Log("はじまりのうみ1-1に遷移");
        script.SceneChange_Fade("1-1",1.0f);
    }

    public void Stage1_2()
    {
        Debug.Log("はじまりのうみ1-2に遷移");
        script.SceneChange_Fade("1-2", 1.0f);
    }
    public void Stage1_3()
    {
        Debug.Log("はじまりのうみ1-3に遷移");
        script.SceneChange_Fade("1-3", 1.0f);
    }

    public void Stage2_1()
    {
        Debug.Log("せいれいのもり2-1に移動");
        script.SceneChange_Fade("2-1",1.0f);
    }

    public void Stage2_2()
    {
        Debug.Log("せいれいのもり2-2に移動");
        script.SceneChange_Fade("2-2", 1.0f);
    }

    public void Stage2_3()
    {
        Debug.Log("せいれいのもり2-3に移動");
        script.SceneChange_Fade("2-3", 1.0f);
    }
    public void Stage3_1()
    {
        Debug.Log("からっぽのかざん1-1に移動");
        script.SceneChange_Fade("3-1",1.0f);
    }
    public void Tutorial()
    {
        Debug.Log("ちゅーとりあるに移動");
        script.SceneChange_Fade("tutorial", 1.0f);
    }
    //設定ボタンのパネルの表示オンオフ
    public void OnSetting()
    {
        setting_buton.SetActive(true);
    }
    public void OnSettingEnd()
    {
        setting_buton.SetActive(false);
    }
}
