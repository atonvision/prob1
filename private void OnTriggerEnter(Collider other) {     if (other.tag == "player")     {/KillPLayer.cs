private void OnTriggerEnter(Collider other) {
    if (other.tag == "player")
    {
        //other.gameobject.GetComponent<CharacterController>().Move(Vector3.up - other.transform.position) ;
        LevelManger.instance.Respawn();
    }
}
