using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class LoadUserInfo : MonoBehaviour
{
    public TextAsset jsonData;
    public string strJsonData;

    void Start()
    {
        // Resources 폴더의 JSON 파일을 로드
        jsonData = Resources.Load<TextAsset>("user_info.json");
        // TextAsset에서 string 타입의 텍스트를 추출
        strJsonData = jsonData.text;

        // JSON 파일을 파싱
        var N = JSON.Parse(strJsonData);

        // "이름" 키에 저장된 키값을 추출
        string user_name = N["이름"].ToString();
    }
}
