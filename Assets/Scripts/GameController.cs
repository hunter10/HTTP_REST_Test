using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	// Use this for initialization
	void Start () {

        HTTPClient.Instance.GET("http://127.0.0.1:8080/member", delegate (WWW www) {
            Debug.Log(www.text);
            User res = JsonUtility.FromJson<User>(www.text);
            Debug.Log(res.bbbb);
            Debug.Log(res.cccc);
        });
	}
}
