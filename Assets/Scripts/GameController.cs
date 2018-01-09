using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	// Use this for initialization
	void Start () {

        User user = new User();
        user.id = "ab";
        user.password = "12";

        string data = JsonUtility.ToJson(user);

        //HTTPClient.Instance.GET("http://127.0.0.1:8080/member", delegate (WWW www) {

        //HTTPClient.Instance.GET("http://localhost:3000", delegate (WWW www) {
        //        Debug.Log(www.text);
        //});

        HTTPClient.Instance.POST("http://localhost:3000/login", data, delegate(WWW www) {
            Debug.Log(www.text);
        });
    }
}
