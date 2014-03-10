using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Endless Scroll Manager.
/// </summary>
public class EndlessScroller : MonoBehaviour {

	Transform mTrans;
	bool mIsDragging = false;
	bool mIsClickStart = false;
	Vector3 mPosition, mLocalPosition;
	Vector3 mDragStartPosition;
	Vector3 mDragPosition;
	Vector3 mStartPosition;
	
	public float mCheckTime, mDeltaScrollY = 0f;

	public float totalHeight = 0f;
	public float cellHeight = 135f;
	public float windowHeight = 550f;
	
	Camera nguiCamera;
	Transform emptyTrans;
	
	// Memory Current position
	void Awake(){
		mTrans = transform;
		mPosition = mTrans.position;
		mLocalPosition = mTrans.localPosition;
	}
	
	// Init Default Value and Spawn Measure Object
	void Start () {
		int layer = LayerMask.NameToLayer("UI2D");
		nguiCamera = NGUITools.FindCameraForLayer(layer);
		GameObject emptyObject = new GameObject( "EmptyObject" );
		emptyTrans = emptyObject.transform;
		emptyTrans.parent = transform.parent;
	}
	
	// Adjust Smooth Scroll Position
	void Update () {
		if (Mathf.Abs( mDeltaScrollY ) > 0f) {
			float delta = mDeltaScrollY * 0.1f;
			Vector3 pos = mTrans.localPosition;
			mDeltaScrollY -= delta;
			pos -= Vector3.up * delta;
			mTrans.localPosition = pos;
			SetPosition();
		}
	}
	
	// Set Current Position
	void SetPosition(){
		Vector3 pos = mTrans.localPosition;
		if (pos.y<0f) pos.y = 0f;
		float height = (totalHeight<windowHeight) ? 0 : totalHeight - windowHeight;
		if (pos.y>height) pos.y = height;
		mTrans.localPosition = pos;
	}
	
	// Drop!
	void Drop () {
		SetPosition();
	}
	
	// Drage Event
	void OnDragEvent () {
		emptyTrans.position = mDragPosition; 
		Vector3 pos1 = emptyTrans.localPosition;
		emptyTrans.position = mDragStartPosition; 
		Vector3 pos2 = emptyTrans.localPosition;
		Vector3 dist = pos1 - pos2;
		
		float deltaTime = Time.time - mCheckTime;
		if (deltaTime > 0) {
			mDeltaScrollY = dist.y * 0.5f / deltaTime;
		}
	}
	
	// Push Click Event
	void OnClickEvent(){
		WordItem[] wordItems = GetComponentsInChildren<WordItem>();
		WordItem curItem = null;
		Ray ray = UICamera.currentCamera.ScreenPointToRay(UICamera.lastTouchPosition);
		float dist = 0f;
		Vector3 currentPos = ray.GetPoint(dist);
		Vector3 cpos = new Vector3(mTrans.position.x, currentPos.y, mTrans.position.z);
		foreach (WordItem item in wordItems) {
			if (curItem == null) {
				curItem = item;
				continue;
			}
			float dist1 = Vector3.Distance(cpos, item.transform.position);
			float dist2 = Vector3.Distance(cpos, curItem.transform.position);
			if (dist1 < dist2) {
				curItem = item;
			}
		}
		curItem.SendMessage("OnClick", SendMessageOptions.DontRequireReceiver);
	}
	
	// When Drag
	public void OnDrag (Vector2 delta) {
		mIsClickStart = false;
		Ray ray = UICamera.currentCamera.ScreenPointToRay(UICamera.lastTouchPosition);
		float dist = 0f;
		// determine drag state and current drag position
		Vector3 currentPos = ray.GetPoint(dist);

		if (UICamera.currentTouchID == -1 || UICamera.currentTouchID == 0) {
			if (!mIsDragging) {
				mIsDragging = true;
				mDragPosition = currentPos;
			} else {
				Vector3 pos = mStartPosition - (mDragStartPosition - currentPos);
				Vector3 cpos = new Vector3(mTrans.position.x, pos.y, mTrans.position.z);
				mTrans.position = cpos;
			}
		}
	}
	
	// When Press
	public void OnPress (bool isPressed) {
		if (isPressed) mIsClickStart = true;
		mIsDragging = false;
		Collider col = collider;
		// determine press start position
		if (col != null) {
			Ray ray = UICamera.currentCamera.ScreenPointToRay(UICamera.lastTouchPosition);
			float dist = 0f;
			mDragStartPosition = ray.GetPoint(dist);
			mStartPosition = mTrans.position;
			col.enabled = !isPressed;
		}
		if (!isPressed) {
			if (mIsClickStart) {
				OnClickEvent();
				mIsClickStart = false;
			} else {
				OnDragEvent();
			}
		} else {
			mDeltaScrollY = 0f;
			mCheckTime = Time.time;
		}
		if (!isPressed) Drop();
	}
}
