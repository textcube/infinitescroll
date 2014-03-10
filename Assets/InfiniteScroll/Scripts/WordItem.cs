using UnityEngine;
using System.Collections;

/// <summary>
/// Word Item.
/// </summary>
public class WordItem : MonoBehaviour {
	public Word word;
	public Transform mParentTrans;
	public GameObject manager;

	Transform mTrans;
	Vector3 mPosition, mLocalPosition;
	EndlessScroller table;
	
	// Memory Current position
	void Awake(){
		mTrans = transform;
		mPosition = mTrans.position;
		mLocalPosition = mTrans.localPosition;
	}
	
	// Clear Outside Word Item
	void UpdateTableItem() {
		if (mParentTrans==null) return;
		EndlessScroller table = mParentTrans.GetComponent<EndlessScroller>();
		Vector3 pos = mParentTrans.localPosition + mTrans.localPosition;
		if (pos.y > table.cellHeight * 2f || pos.y < table.cellHeight * -6f) {
			Destroy(gameObject);
		}
	}
	
	void Update () {
		UpdateTableItem();
	}
}
