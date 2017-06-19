using UnityEngine;  
using System.Collections;  

public class HelloWorld : MonoBehaviour {  

	// Use this for initialization  
	void Start () {  

	}  

	// Update is called once per frame  
	void Update () {  

	}  

	void OnGUI () {    
		//改变字体大小  
		GUI.skin.label.fontSize = 40;   
		//定位显示(左边距x, 上边距y, 宽, 高)  
		GUI.Label (new Rect (10, 50, 900, 120), "Hello World!");  
	}  
}  