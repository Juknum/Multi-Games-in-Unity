using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeGenerator : MonoBehaviour
{

    [SerializeField] GameObject pipes;
    int timer = 500;

    public playerController pc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while(pc.dead == false){
        timer++;
            if(timer >= 500){
                timer = 0;
                GameObject pipe = Instantiate(pipes, new Vector2(pipes.transform.position.x, pipes.transform.position.y + Random.Range(-2, 2)), pipes.transform.rotation);
                Destroy(pipe, 5);
            }
        }
    }
}
