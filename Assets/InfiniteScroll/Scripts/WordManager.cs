using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Word Manager.
/// </summary>
public class WordManager : MonoBehaviour {
	public EndlessScroller table;
	List<Word> words;
	GameObject wordPrefab;

	float posScrollY = 0f;
	public float cellWidth = 602f;
	public float cellHeight = 100f;
	float cellPadiding = 8f;
	float totalHeight = 0f;

	// Init Word List and Collider Size
	void Start () {
		wordPrefab = Resources.Load("WordItem", typeof(GameObject)) as GameObject;

		string[,] dic = LolSkillData.dic;
		words = new List<Word>();
		for (int i=0; i<dic.GetLength(0); i++){
			Word word = new Word(dic[i,0], dic[i,1], dic[i,2]);
			words.Add(word);
		}

		for (int i=0; i<10; i++) {
			if (i>=words.Count) break;
			Word word = words[i];
			SetWordItem(word, i);
		}

		totalHeight = cellHeight * words.Count + cellPadiding * (words.Count+1);
		BoxCollider collider = table.collider as BoxCollider;
		collider.size = new Vector3(cellWidth, totalHeight, 1f);
		collider.center = new Vector3(0f, totalHeight*-0.5f+cellHeight*0.5f, 0f);
		table.totalHeight = totalHeight;
		table.cellHeight = cellHeight;
	}
	
	void Update () {
		UpdateTable();
	}
	
	// Display Items in Screen
	void UpdateTable(){
		int idxPos =  Mathf.FloorToInt( table.transform.localPosition.y / (cellHeight+cellPadiding) );
		WordItem[] items = table.GetComponentsInChildren<WordItem>();
		for (int i=idxPos-1;i<idxPos+6;i++) {
			if (i<0) continue;
			if (i>words.Count-1) continue;
			Word word = words[i];
			bool ok = false;
			foreach (WordItem item in items) {
				if (item.word.no == word.no) ok = true;
			}
			if (ok) continue;
			SetWordItem(word, i);
		}
	}
	
	// Display Word Item
	void SetWordItem(Word word, int i){
		GameObject instance = NGUITools.AddChild(table.gameObject, wordPrefab);
		UILabel[] labels = instance.GetComponentsInChildren<UILabel>();
		labels[0].text = word.skill;
		labels[1].text = word.champion;
		Vector3 pos = new Vector3(0f, i*-(cellHeight+cellPadiding), 0f);
		instance.transform.localPosition = pos;
		instance.name = "Word " + i.ToString();
		WordItem wditem = instance.GetComponent<WordItem>();
		wditem.word = word;
		wditem.mParentTrans = table.transform;
		wditem.manager = gameObject;
	}
}
