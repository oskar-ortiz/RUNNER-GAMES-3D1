using System.Collections;
using UnityEngine;
using PathCreation;

public class BluePlayerMovement : MonoBehaviour
{
    private const float RigidbodyDrag = 3f;
    private const float RigidbodyAngularDrag = 10f;
    private const string RedCollisionLayerName = "RedCollision";
    private const string BlueCollisionLayerName = "BlueCollision";

    public float speed;
    private Animator animator;
    private Rigidbody myRigidbody;
    public float FallingThreshold = -10f;
    private int currentNivell;
    public AudioSource Winsound;
    private Transform myTransform;
    public AudioSource deathSound;
    public AudioSource runningsound;

    public GlobalVolumeManager volumeManager;
    public canvasManager canvasManager;

    public RedPlayerMovement RedPlayer;
    private ObstacleManager obstacleManager;

    public PathCreator pathCreator1;
    public PathCreator pathCreator2;

    //Nivell 2
    public float forceGrupPunxes1;
    public float forceGrupPunxes2;
    public float forceGrupPunxes3;
    public float forceGirador1;
    public float forceGirador2;

    //Nivell 1
    public float forceTorusNivell1;
    public float forced;


    [HideInInspector]
    private bool Falling;
    float pathState;
    bool colisionat;
    bool fentRestart;
    bool canviantNivell;
    bool guanyatBlue;
    bool perdutBlue;
    bool moveForwardRequested;
    bool waitForMoveKeyRelease;


    void Start()
    {
        animator = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody>();
        myTransform = transform;
        CacheObstacleManager();
        ConfigureRigidbody();
        ConfigurePlayerCollisionLayers();
        ResetMoveInputGate();
        canviantNivell = false;
        guanyatBlue = false;
        perdutBlue = false;
        animator.SetBool("isFalling", false);
        animator.SetBool("BlueCry", false);
        animator.SetBool("Climb", false);
        animator.SetBool("BlueWin", false);
        ComensaNivell(1);
    }

    private void Update()
    {
        moveForwardRequested = false;

        if (canviantNivell || guanyatBlue || perdutBlue)
        {
            runningsound.Pause();
            return;
        }

        if (TryHandleLevelChange())
        {
            return;
        }

        Falling = myRigidbody.velocity.y < FallingThreshold;
        if (Falling)
        {
            runningsound.Pause();
            animator.SetBool("isMoving", false);
        }

        if (colisionat)
        {
            if (!fentRestart)
            {
                animator.SetBool("isFalling", true);
                fentRestart = true;
                StartCoroutine(restartNivell());
            }
            return;
        }

        if (Falling || fentRestart)
        {
            return;
        }

        if (waitForMoveKeyRelease)
        {
            if (!IsMoveKeyPressed())
            {
                waitForMoveKeyRelease = false;
            }

            runningsound.Pause();
            animator.SetBool("isMoving", false);
            return;
        }

        moveForwardRequested = IsMoveKeyPressed();
        if (moveForwardRequested)
        {
            if (!runningsound.isPlaying)
            {
                runningsound.Play();
            }
        }
        else
        {
            runningsound.Pause();
            animator.SetBool("isMoving", false);
        }
    }

    private void FixedUpdate()
    {
        if (!moveForwardRequested || Falling || colisionat || fentRestart || canviantNivell || guanyatBlue || perdutBlue)
        {
            return;
        }

        if (currentNivell == 1)
        {
            MouNivell1();
        }
        else if (currentNivell == 2)
        {
            MouNivell2();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        string collisionName = collision.collider.name;
        Vector3 collisionNormal = GetCollisionNormal(collision);

        if (collisionName == "punxes1" || collisionName == "punxes2" || collisionName == "punxes3" || collisionName == "punxes4")
        {
            ApplyHit(new Vector3(-1f, 1f, -1f) * forceGrupPunxes1);
        }
        else if (collisionName == "punxes8")
        {
            ApplyHit(new Vector3(0f, 1f, 1f) * forceGrupPunxes2);
        }
        else if (collisionName == "punxes11")
        {
            ApplyHit(new Vector3(-1f, 1f, 0f) * forceGrupPunxes3);
        }
        else if (collisionName == "cGran1")
        {
            ApplyHit(collisionNormal * forceGirador1);
        }
        else if (collisionName == "cGran2")
        {
            ApplyHit(collisionNormal * forceGirador2);
        }
        else if (collisionName == "Torus1" || collisionName == "Torus2")
        {
            ApplyHit(collisionNormal * forceTorusNivell1);
        }
        else if (collisionName == "d2" || collisionName == "d1" || collisionName == "d3")
        {
            ApplyHit(collisionNormal * forced);
        }
    }

    private bool TryHandleLevelChange()
    {
        if (Input.GetKey(KeyCode.Alpha1) && currentNivell != 1)
        {
            BeginLevelChange(1);
            return true;
        }

        if (Input.GetKey(KeyCode.Alpha2) && currentNivell != 2)
        {
            BeginLevelChange(2);
            return true;
        }

        return false;
    }

    private void BeginLevelChange(int nivell)
    {
        ResetMoveInputGate();
        runningsound.Pause();
        canviantNivell = true;
        animator.SetBool("isMoving", false);
        animator.SetBool("isFalling", false);
        StartCoroutine(canviaNivell(nivell));
    }

    private void ConfigureRigidbody()
    {
        myRigidbody.drag = RigidbodyDrag;
        myRigidbody.angularDrag = RigidbodyAngularDrag;
        myRigidbody.interpolation = RigidbodyInterpolation.Interpolate;
        myRigidbody.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
        myRigidbody.constraints = RigidbodyConstraints.FreezeRotation;
    }

    private void ConfigurePlayerCollisionLayers()
    {
        int redCollisionLayer = LayerMask.NameToLayer(RedCollisionLayerName);
        int blueCollisionLayer = LayerMask.NameToLayer(BlueCollisionLayerName);

        if (redCollisionLayer >= 0 && blueCollisionLayer >= 0)
        {
            Physics.IgnoreLayerCollision(redCollisionLayer, blueCollisionLayer, true);
        }
    }

    private void ClearPhysicsMotion()
    {
        myRigidbody.velocity = Vector3.zero;
        myRigidbody.angularVelocity = Vector3.zero;
    }

    private bool IsMoveKeyPressed()
    {
        return Input.GetKey(KeyCode.UpArrow);
    }

    private void ResetMoveInputGate()
    {
        moveForwardRequested = false;
        waitForMoveKeyRelease = true;
    }

    private Vector3 GetCollisionNormal(Collision collision)
    {
        if (collision.contactCount > 0)
        {
            return collision.GetContact(0).normal;
        }

        return -myTransform.forward;
    }

    private void ApplyHit(Vector3 force, bool enableGravity = false)
    {
        if (colisionat)
        {
            return;
        }

        moveForwardRequested = false;
        myRigidbody.angularVelocity = Vector3.zero;
        if (enableGravity)
        {
            myRigidbody.useGravity = true;
        }

        myRigidbody.AddForce(force);
        colisionat = true;
        deathSound.Play();
        animator.SetBool("isMoving", false);
    }

    private void ComensaNivell(int nivell)
    {
        CacheObstacleManager();
        ConfigureRigidbody();
        myRigidbody.useGravity = true;
        ClearPhysicsMotion();
        ResetMoveInputGate();
        Falling = false;
        colisionat = false;
        currentNivell = nivell;
        if (obstacleManager != null)
        {
            obstacleManager.SetActiveLevel(nivell);
        }
        pathState = 0f;
        animator.SetBool("isMoving", false);
        animator.SetBool("Climb", false);

        if (nivell == 1)
        {
            TeleportTo(pathCreator1.path.GetPointAtDistance(pathState), Quaternion.LookRotation(Vector3.right, Vector3.up));
        }
        else if (nivell == 2)
        {
            TeleportTo(pathCreator2.path.GetPointAtDistance(pathState), Quaternion.LookRotation(Vector3.forward, Vector3.up));
        }
    }

    private void TeleportTo(Vector3 position, Quaternion rotation)
    {
        myRigidbody.position = position;
        myRigidbody.rotation = rotation;
    }

    private void CacheObstacleManager()
    {
        if (obstacleManager == null)
        {
            obstacleManager = FindObjectOfType<ObstacleManager>();
        }
    }

    private void MoveAlongPath(PathCreator pathCreator, float finishDistance)
    {
        pathState += speed * Time.fixedDeltaTime;
        if (pathState > finishDistance)
        {
            StartCoroutine(guanyat());
            return;
        }

        Vector3 currentPosition = myRigidbody.position;
        Vector3 pathPosition = pathCreator.path.GetPointAtDistance(pathState);
        Vector3 pathPositionNext = pathCreator.path.GetPointAtDistance(pathState * 1.01f);
        Vector3 targetPosition = new Vector3(pathPosition.x, currentPosition.y, pathPosition.z);
        Vector3 targetForward = new Vector3(pathPositionNext.x, currentPosition.y, pathPositionNext.z) - targetPosition;

        myRigidbody.useGravity = true;
        myRigidbody.MovePosition(targetPosition);
        if (targetForward.sqrMagnitude > 0.0001f)
        {
            myRigidbody.MoveRotation(Quaternion.LookRotation(targetForward.normalized, Vector3.up));
        }

        animator.SetBool("isMoving", true);
    }

    private void MouNivell1()
    {
        MoveAlongPath(pathCreator1, 480f);
    }

    private void MouNivell2()
    {
        MoveAlongPath(pathCreator2, 309f);
    }

    private IEnumerator restartNivell()
    {
        animator.SetBool("Climb", false);
        ResetMoveInputGate();
        yield return new WaitForSeconds(2f);
        StartCoroutine(canvasManager.transitionBlueExposureNegre(2f));
        animator.SetBool("isFalling", false);
        yield return new WaitForSeconds(1f);
        ClearPhysicsMotion();
        ComensaNivell(currentNivell);
        ResetMoveInputGate();
        yield return new WaitForSeconds(1f);
        fentRestart = false;
    }

    private IEnumerator canviaNivell(int nivell)
    {
        animator.SetBool("Climb", false);
        ResetMoveInputGate();
        StartCoroutine(volumeManager.transitionExposureBlanc(2f));
        yield return new WaitForSeconds(1f);
        ClearPhysicsMotion();
        animator.SetBool("BlueWin", false);
        animator.SetBool("BlueCry", false);
        ComensaNivell(nivell);
        ResetMoveInputGate();
        yield return new WaitForSeconds(1f);
        canviantNivell = false;
        guanyatBlue = false;
        perdutBlue = false;
    }

    private IEnumerator guanyat()
    {
        Winsound.Play();

        StartCoroutine(RedPlayer.perdut());
        guanyatBlue = true;
        canviantNivell = true;
        ResetMoveInputGate();
        animator.SetBool("BlueWin", true);
        if (currentNivell == 1)
        {
            yield return new WaitForSeconds(3f);
            StartCoroutine(canviaNivell(2));
        }
        else
        {
            canvasManager.guanyaCredits();
        }
    }

    public IEnumerator perdut()
    {
        perdutBlue = true;
        canviantNivell = true;
        ResetMoveInputGate();
        animator.SetBool("BlueCry", true);
        if (currentNivell == 1)
        {
            yield return new WaitForSeconds(3f);
            StartCoroutine(canviaNivell(2));
        }
    }

    public void ComensaPrincipi()
    {
        ComensaNivell(1);
    }
}
