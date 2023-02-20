using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Balls
{
    public class AppleTree : MonoBehaviour
    {
        public GameObject BallsPrefab;
        public GameObject GreenBallsPrefab;
        public GameObject BlueBallsPrefab;
        public GameObject YellowBallsPrefab;

        public float speed = 1f;

        public float leftAndRightEdge = 10f;

        public float northAndSouthEdge = 10f;

        public float chanceToChangeDirections;

        public float secondsBetweenBallsDrops;
        public float secondsBetweenBlueBallsDrops;
        public float secondsBetweenYellowBallsDrops;

        public float secondsBetweenGreenBallsDrops;
        // Start is called before the first frame update
        void Start()
        {
            Invoke("DropBalls", 2f);
        }
        void DropBalls()
        {
            var Balls = Instantiate(BallsPrefab);
            Balls.transform.position = transform.position;
            Invoke("DropBalls", secondsBetweenBallsDrops);

            var BlueBalls = Instantiate(BlueBallsPrefab);
            BlueBalls.transform.position = transform.position;
            Invoke("DropBalls", secondsBetweenBlueBallsDrops);

            var GreenBalls = Instantiate(GreenBallsPrefab);
            GreenBalls.transform.position = transform.position;
            Invoke("DropBalls", secondsBetweenGreenBallsDrops);

            var YellowBalls = Instantiate(YellowBallsPrefab);
            YellowBalls.transform.position = transform.position;
            Invoke("DropBalls", secondsBetweenYellowBallsDrops);

        }

        // Update is called once per frame
        void Update()
        {
            // Basic Movement
            Vector3 pos = transform.position;

            pos.x += speed * Time.deltaTime;

            transform.position = pos;




            pos.z += speed * Time.deltaTime;

            transform.position = pos;
            //Changing Direction
            if (pos.x < -leftAndRightEdge)
            {

                speed = Mathf.Abs(speed); // Move ri
            }
            else if (pos.x > leftAndRightEdge)
            {

                speed = -Mathf.Abs(speed); // Move l

            }

            if (pos.z == pos.x)
            {
                if (pos.z < -northAndSouthEdge)
                {

                    speed = Mathf.Abs(speed); // Move up
                }
                else if (pos.z > northAndSouthEdge)
                {

                    speed = -Mathf.Abs(speed); // Move down

                }
            }
            void FixedUpdate()
            {
                // Changing Direction Randomly is now t
                if (Random.value < chanceToChangeDirections)
                    speed *= -1; // Change direction

            }
        }
    }
}