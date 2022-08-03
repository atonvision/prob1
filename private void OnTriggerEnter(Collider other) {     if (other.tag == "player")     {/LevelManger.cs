public static LevelManger instance;



private void Awake() {
    instance = this;
}

public waitBeforeRespawning;

[HideInInspector]
        //problem here
public bool respawning ;

private PlayerController Player;

public Vector3 Respwanpoint;

private void Start() {
    Player = FindObjectOfType<playerController>();
    Respwanpoint = Player.transform.position + Vector3.up;
}
           
public void Respawn(){
      // problem here
    if(!respawning){
        //problem here
        respawning = true;

        StartCoroutine(RespawnCo());

    }
}

public IEnumerator RespawnCo(){

    Player.gameobject.Setactive(false);
    yield return new  WaitForSeconds(waitBeforeRespawning);
    Player.transform.position = Respwanpoint
    Player.gameobject.Setactive(true);

    //problem here
    respawning = false;

}
