using UnityEngine;
using UnityEngine.SceneManagement;

namespace HoopsPro.Core
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        [Header("Match")]
        public int scoreA;
        public int scoreB;
        public int quarter = 1;
        public float quarterLength = 60f;
        public float quarterClock;
        public float shotClock = 24f;
        public TeamId possession = TeamId.A;
        public bool running;
        public bool paused;

        [Header("Refs")]
        public BallController ball;
        public Transform hoopA;
        public Transform hoopB;

        public enum TeamId { A, B }

        void Awake()
        {
            if (Instance != null && Instance != this) { Destroy(gameObject); return; }
            Instance = this;
        }

        void Start()
        {
            quarterClock = quarterLength;
            running = true;
        }

        void Update()
        {
            if (!running || paused) return;
            float dt = Time.deltaTime;
            quarterClock -= dt;
            if (ball == null || ball.State != BallController.BallState.Shot)
                shotClock -= dt;

            if (shotClock <= 0f)
            {
                shotClock = 24f;
                possession = possession == TeamId.A ? TeamId.B : TeamId.A;
            }

            if (quarterClock <= 0f)
                EndQuarter();
        }

        public void Score(TeamId team, int points)
        {
            if (team == TeamId.A) scoreA += points;
            else scoreB += points;
            shotClock = 24f;
            possession = team == TeamId.A ? TeamId.B : TeamId.A;
        }

        void EndQuarter()
        {
            if (quarter >= 4)
            {
                running = false;
                Debug.Log($"Final {scoreA} - {scoreB}");
                return;
            }
            quarter++;
            quarterClock = quarterLength;
            shotClock = 24f;
        }

        public Transform AttackHoop(TeamId team) => team == TeamId.A ? hoopB : hoopA;
    }
}
