using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class RecevoirJeton : MonoBehaviour
{
	public GameObject jeton1;
	public GameObject jeton2;
	public GameObject jeton3;
	public GameObject jeton4;
	public GameObject jeton5;
	public GameObject jeton6;
	public GameObject[] jetons;
	short jeton = 1010;

	// Start is called before the first frame update
	void Start()
    {
		jetons = new GameObject[6];
		jetons[0] = jeton1;
		jetons[1] = jeton2;
		jetons[2] = jeton3;
		jetons[3] = jeton4;
		jetons[4] = jeton5;
		jetons[5] = jeton6;
		NetworkServer.RegisterHandler(jeton, onJetonReceived);
	}

	private void onJetonReceived(NetworkMessage netMsg)
	{
		var v = netMsg.ReadMessage<MyJetonMessage>();
		int pos = v.joueur;
		Debug.Log("joueur " + v.joueur);
		string s = "Jetons/" + v.sprite;
		Debug.Log("sprite jeton : " + s);
		Sprite jeton_actuel = Resources.Load<Sprite>(s);
		Debug.Log("sprite jeton : " + jeton_actuel);
		Debug.Log(jetons[pos-1].gameObject);
		gameObject objet = Object.Instantiate(jetons[pos - 1]);
		jetons[pos - 1].gameObject.SetActive(true);
		Debug.Log(jetons[pos - 1].gameObject.GetComponent<SpriteRenderer>());
		jetons[pos-1].gameObject.GetComponent<SpriteRenderer>().sprite = jeton_actuel;
		jetons[pos - 1] = objet;
	}

	// Update is called once per frame
	void Update()
    {
        
    }
}
