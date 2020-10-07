using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using GooglePlayGames;
//using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;
public class PlayServices : MonoBehaviour {
	public GameObject doesnt;
	public GameObject does;
	// Use this for initialization
	void Awake(){
		//PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder ().Build();
		//PlayGamesPlatform.InitializeInstance (config);
		//PlayGamesPlatform.Activate ();
		Social.localUser.Authenticate (sucsses => {
			if(sucsses){
				Debug.Log("worked");
				does.SetActive(true);
				doesnt.SetActive(false);
			}else{
				Debug.Log("doesnt worked");
				doesnt.SetActive(true);
				does.SetActive(false);
			}
		});

	}
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void LogIn(){
		
		Social.localUser.Authenticate (sucsses => {
			if(sucsses){
				Debug.Log("worked");
				does.SetActive(true);
				doesnt.SetActive(false);
			}else{
				Debug.Log("doesnt worked");
				doesnt.SetActive(true);
				does.SetActive(false);
			}
		});
	}
	public static void PostScore(long score, string leaderbord){
		Social.ReportScore (score, leaderbord, (sucsess => {}));
	}
	public static void ShowLeaderbord(string leaderbord){
		//PlayGamesPlatform.Instance.ShowLeaderboardUI (leaderbord);
	}
	public static long GetPlayerScore(string Leaderboard){
		long score = 0;
		//PlayGamesPlatform.Instance.LoadScores (Leaderboard, LeaderboardStart.PlayerCentered, 1, LeaderboardCollection.Public, 
			//LeaderboardTimeSpan.AllTime, (LeaderboardScoreData data) => {
			//score = data.PlayerScore.value;
		//});
		return score;
	}
}
