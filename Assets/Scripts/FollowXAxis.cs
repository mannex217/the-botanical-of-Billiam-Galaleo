using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowXAxis : MonoBehaviour {

  public GameObject player;
  
  // Update is called once per frame
  void Update () {
  
  this.gameObject.transform.position = new Vector3(player.gameObject.transform.position.x,this.gameObject.transform.position.y,this.gameObject.transform.position.z);
  
  }
 }