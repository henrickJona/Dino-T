using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour {
	public Canvas loading;
	public Image loa;
	private AsyncOperation op;
	// Use this for initialization
	void Awake(){
		DontDestroyOnLoad (gameObject);
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void LoadScene(string SceneName){
		loading.gameObject.SetActive (true);
		StartCoroutine (BeginLoad(SceneName));

	}
     IEnumerator BeginLoad (string SceneName){
		

		op = SceneManager.LoadSceneAsync(SceneName);
		while(!op.isDone){
			loa.transform.Rotate (0,0,-50*Time.deltaTime);
			yield return null;
		}
		op = null;
		loading.gameObject.SetActive(false);
	}
}
