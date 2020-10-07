using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitiatePrefab : MonoBehaviour {
	public GameObject Ground;
	GameObject GroundClone;
	public GameObject Ground1;
	GameObject Ground1Clone;
	public GameObject Ground12;
	GameObject Ground12Clone;
	public GameObject BeginLake;
	GameObject BeginLakeClone;
	public GameObject MediumLake;
	GameObject MediumLakeClone;
	public GameObject EndLake;
	GameObject EndLakeClone;
	public GameObject Cave;
	GameObject CaveClone;
	public GameObject Cave1;
	GameObject Cave1Clone;
	public GameObject Cliff;
	GameObject CliffClone;
	public GameObject Stair1;
	GameObject Stair1Clone;
	public GameObject Stair2;
	GameObject Stair2Clone;
	public GameObject Invitation;
	GameObject InvitationClone;
	public float velocity;
	public int test;
	public bool Stairr;
	public Transform ff;
	public Transform fd;
	public bool store = false;
	public int cont;
	public bool caveToAnother;
	public int help;
	public int helpIce;
	public GameObject River;
	GameObject RiverClone;
	public GameObject RiverLog;
	GameObject RiverLogClone;
	public GameObject CaveBeginRight;
	GameObject CaveBeginRightClone;
	public GameObject CaveBeginLeft;
	GameObject CaveBeginLeftClone;
	public GameObject WalkGrass;
	GameObject WalkGrassClone;
	public GameObject Receptor;
	GameObject ReceptorClone;
	public GameObject IceFirst;
	GameObject IceFirstClone;
	public GameObject IceSecond;
	GameObject IceSecondClone;
	public GameObject IceThird;
	GameObject IceThirdClone;
	public bool Ice;
	public GameObject Exit;
	GameObject ExitClone;
	public GameObject CaveIceBegin;
	GameObject CaveIceBeginClone;
	public GameObject Archer;
	GameObject ArcherClone;
	public bool Inform;
	public GameObject StairStorm;
	GameObject StairStormClone;
	public static InitiatePrefab p;
	public bool Endlake;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		velocity += Time.deltaTime;

		if (cont > 4) {
			test = Random.Range (0, 40);
		} else {
			test = Random.Range (0, 30);
		}
		if (!Inform && store) {
			
			test = Random.Range (0, 20);	
		} else if(Inform && store){
			
			test = Random.Range (20, 30);
		}

		if (velocity > 7 && store == false && !Stairr && !Ice) {
			cont += 1;
			Endlake = false;
			if (test >= 0 && test <= 2) {
				GroundClone = Instantiate (Ground, transform.position, Quaternion.Euler (new Vector3 (-90, 0, 0))) as GameObject;
				Destroy (GroundClone, 20);
				velocity = 1.8f;
				caveToAnother = false;
			} else if (test > 2 && test <= 4) {
				WalkGrassClone = Instantiate (WalkGrass, transform.position, Quaternion.Euler (new Vector3 (-90, 0, 0))) as GameObject;
				Destroy (WalkGrassClone, 20);
				velocity = 1.8f;
				caveToAnother = false;

			} else if (test > 4 && test <= 6) {
				ArcherClone = Instantiate (Archer, transform.position, Quaternion.Euler (new Vector3 (-90, 0, 0))) as GameObject;
				Destroy (ArcherClone, 20);
				velocity = 1.8f;
				caveToAnother = false;

			}else if (test > 6 && test <= 8) {
				InvitationClone = Instantiate (Invitation, transform.position, Quaternion.Euler (new Vector3 (-90, 0, 0))) as GameObject;
				Destroy (InvitationClone, 20);
				velocity = 1.8f;
				Stairr = true;
				help = 0;
				caveToAnother = false;


			}else if (test > 8 && test <= 10) {
				Ground1Clone = Instantiate (Ground1, transform.position, Quaternion.Euler (new Vector3 (-90, 0, 0))) as GameObject;
				Destroy (Ground1Clone, 20);
				velocity = 1.8f;
				caveToAnother = false;

			} else if (test > 10 && test <= 12) {
				Ground12Clone = Instantiate (Ground12, transform.position, Quaternion.Euler (new Vector3 (-90, 0, 0))) as GameObject;
				Destroy (Ground12Clone, 20);
				velocity = 1.8f;
				caveToAnother = false;

			}else if (test > 12 && test <= 14) {
				RiverClone = Instantiate (River, transform.position, Quaternion.Euler (new Vector3 (-90, 0, 0))) as GameObject;
				Destroy (RiverClone, 20);
				velocity = 1.8f;
				caveToAnother = false;

			}else if (test > 14 && test <= 16 ) {
				CliffClone = Instantiate (Cliff, Cliff.transform.position , Quaternion.Euler (new Vector3 (0, 0, 0))) as GameObject;
				Destroy (CliffClone, 20);
				velocity = 1.8f;
				caveToAnother = true;

			}else if (test > 16 && test <= 18 ) {
				RiverLogClone = Instantiate (RiverLog, transform.position , Quaternion.Euler (new Vector3 (-90, 0, 0))) as GameObject;
				Destroy (RiverLogClone, 20);
				velocity = 1.8f;
				caveToAnother = true;

			} 
			else if (test > 18 && test <= 20 ) {
				CaveClone = Instantiate (Cave, Cave.transform.position , Quaternion.Euler (new Vector3 (0, -90, 90))) as GameObject;
				Destroy (CaveClone, 20);
				velocity = 2f;
				caveToAnother = true;

	
			}
			else if (test > 20 && test <= 24 ) {
				Cave1Clone = Instantiate (Cave1, Cave1.transform.position , Quaternion.Euler (new Vector3 (0, -90, 90))) as GameObject;
				Destroy (Cave1Clone, 20);
				velocity = 2f;
				caveToAnother = true;


			}else if (test > 24 && test <= 28 ) {
				CaveBeginLeftClone = Instantiate (CaveBeginLeft, CaveBeginLeft.transform.position , Quaternion.Euler (new Vector3 (0, -90, 90))) as GameObject;
				Destroy (CaveBeginLeftClone, 20);
				velocity = 2f;
				caveToAnother = true;


			}else if (test > 28 && test <= 30 ) {
				CaveBeginRightClone = Instantiate (CaveBeginRight, CaveBeginRight.transform.position , Quaternion.Euler (new Vector3 (0, -90, 90))) as GameObject;
				Destroy (CaveBeginRightClone, 20);
				velocity = 2f;
				caveToAnother = true;

			}else if(test > 30 && test <= 40 && cont > 4 && caveToAnother == false) {
				
				BeginLakeClone = Instantiate (BeginLake, BeginLake.transform.position, Quaternion.Euler (new Vector3 (-90, 0, 0))) as GameObject;
				Destroy (BeginLakeClone, 20);
				velocity = 1.8f;
				store = true;
				cont = 0;
			}



		}
		if (velocity > 7 && store == true) {
			
			if (test >= 0 && test <= 10) {
				MediumLakeClone = Instantiate (MediumLake, MediumLake.transform.position, Quaternion.Euler (new Vector3 (-90, 0, 0))) as GameObject;
				Destroy (MediumLakeClone, 20);
				velocity = 2.2f;
				Inform = false;
			} else if (test > 10 && test <= 20) {
				EndLakeClone = Instantiate (EndLake, EndLake.transform.position, Quaternion.Euler (new Vector3 (-90, 0, 0))) as GameObject;
				Destroy (EndLakeClone, 20);
				velocity = 1.8f;
				Endlake = true;
				Inform = true;
			}else if (test > 20 && test <= 30) {

				velocity = 1.8f;
				store = false;
				Inform = false;
			}


		}
		if (velocity > 16.5 && Stairr == true) {
			if (help == 0) {
				ff = InvitationClone.transform.Find ("Stair");
				ff.GetComponent<Ground> ().enabled = true;
				ff.transform.parent = null;
				help = 1;

			}

			if (test >= 0 && test <= 10 ) {
				Stair1Clone = Instantiate (Stair1, Stair1.transform.position, Quaternion.Euler (new Vector3 (-110, 0, 0))) as GameObject;
				Destroy (Stair1Clone, 20);
				velocity = 11.5f;

			} else if (test > 10 && test <= 15 ) {
				Stair2Clone = Instantiate (Stair2, Stair2.transform.position, Quaternion.Euler (new Vector3 (-110, 0, 0))) as GameObject;
				Destroy (Stair2Clone, 20);
				velocity = 11.5f;

			} else if (test > 15 && test <= 20 ) {
				StairStormClone = Instantiate (StairStorm, StairStorm.transform.position, Quaternion.Euler (new Vector3 (-110, 0, 0))) as GameObject;
				Destroy (StairStormClone, 20);
				velocity = 11.5f;

			} else if (test > 20 && test <= 30 ) {
				ExitClone = Instantiate (Exit, Exit.transform.position, Quaternion.Euler (new Vector3 (-110, 0, 0))) as GameObject;
				Destroy (ExitClone, 20);
				velocity = 1.8f;
				Stairr = false;
				Ice = true;
				helpIce = 0;

			} 

		}
		if (velocity > 12.3 && Ice == true) {
			if (helpIce == 0) {
				fd = ExitClone.transform.Find ("IceFirst");
				fd.GetComponent<Ground> ().enabled = true;
				fd.transform.parent = null;
				helpIce = 1;

			}

			if (test >= 0 && test <= 7 && Ice) {
				IceFirstClone = Instantiate (IceFirst, IceFirst.transform.position, Quaternion.Euler (new Vector3 (-90, 0, 0))) as GameObject;
				Destroy (IceFirstClone, 20);
				velocity = 7.2f;
				Inform = true;
			}  else if (test > 7 && test <= 12) {
				IceSecondClone = Instantiate (IceSecond, IceSecond.transform.position, Quaternion.Euler (new Vector3 (-90, 0, 0))) as GameObject;
				Destroy (IceSecondClone, 20);
				velocity = 7.2f;
				Inform = true;
			} else if (test > 12 && test <= 18) {
				IceThirdClone = Instantiate (IceThird, IceThird.transform.position, Quaternion.Euler (new Vector3 (-90, 0, 0))) as GameObject;
				Destroy (IceThirdClone, 20);
				velocity = 7.2f;
				Inform = true;
			} else if (test > 18 && test <= 25 && Inform) {
				CaveIceBeginClone = Instantiate (CaveIceBegin, CaveIceBegin.transform.position, Quaternion.Euler (new Vector3 (0, -90, 90))) as GameObject;
				Destroy (CaveIceBeginClone, 20);
				velocity = 3f;
				Inform = false;
			} else if (test > 25 && test <= 30) {
				ReceptorClone = Instantiate (Receptor, transform.position, Quaternion.Euler (new Vector3 (-90, 0, 0))) as GameObject;
				Destroy (ReceptorClone, 20);
				velocity = 1.8f;
				Inform = false;
				Ice = false;
			} 

		}

	}
}
