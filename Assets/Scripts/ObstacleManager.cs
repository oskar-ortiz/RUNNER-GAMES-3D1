using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GlobalVolumeManager volumeManager;


    //Nivell 2
    public Transform punxes1;
    public Transform punxes2;
    public Transform punxes3;
    public Transform punxes4;
    private float posicioInicialYPunxa1;
    private float posicioInicialYPunxa2;
    private float posicioInicialYPunxa3;
    private float posicioInicialYPunxa4;
    private bool pujantGrupPunxes1;
    public float speedGrupPunxes1Pujada;
    public float speedGrupPunxes1Baixada;
    private float rangeGrupPunxes1;



    public Transform punxes6;
    public Transform punxes7;
    public Transform punxes8;
    public Transform punxes9;
    public Transform punxes10;
    private float posicioInicialYPunxa8;
    private float posicioInicialYPunxa6;
    private float posicioInicialYPunxa10;
    private float posicioInicialYPunxa7;
    private float posicioInicialYPunxa9;
    private bool pujantGrupPunxes2;
    public float speedGrupPunxes2Pujada;
    public float speedGrupPunxes2Baixada;
    private float rangeGrupPunxes2;

    public Transform punxes11;
    private float posicioInicialYPunxa11;
    private bool pujantGrupPunxes3;
    public float speedGrupPunxes3Pujada;
    public float speedGrupPunxes3Baixada;
    private float rangeGrupPunxes3;

    public Transform Girador1;
    public float speedGirador1;

    public Transform Girador2;
    public float speedGirador2;


    //Nivell 1
    public Transform Torus1Nivell1;
    public float speedTorus1Nivell1;
    public Transform Torus2Nivell1;
    public float speedTorus2Nivell1;
    public Transform d1;
    private float posicioInicialZd1;
    bool fentEsquerrad1;
    private float ranged1;
    public float speedd1; 
    public Transform d2;
    private float posicioInicialZd2;
    bool fentEsquerrad2;
    private float ranged2; 
    public float speedd2;
    public Transform d3;
    private float posicioInicialZd3;
    bool fentEsquerrad3;
    private float ranged3; 
    public float speedd3;


    //Nivell 3
    public Transform pendulum1; 
    public float MaxAngleDeflectionPendulum1;
    public float SpeedPendulum1;
    public Transform pendulum2;
    public float MaxAngleDeflectionPendulum2;
    public float SpeedPendulum2;
    public Transform pendulum3;
    public float MaxAngleDeflectionPendulum3;
    public float SpeedPendulum3;
    public Transform pendulum4;
    public float MaxAngleDeflectionPendulum4;
    public float SpeedPendulum4;
    public Transform pendulum5;
    public float MaxAngleDeflectionPendulum5;
    public float SpeedPendulum5;
    public Transform pendulum6;
    public float MaxAngleDeflectionPendulum6;
    public float SpeedPendulum6;
    public Transform pendulum7;
    public float MaxAngleDeflectionPendulum7;
    public float SpeedPendulum7;
    public Transform aspa1;
    public float speedaspa1;
    public Transform aspa2;
    public float speedaspa2;

    //Nivell 5
    public Transform porta11;
    public float speedPorta1;
    public Transform porta12;
    public Transform porta21;
    public float speedPorta2;
    public Transform porta22;
    public Transform porta31;
    public float speedPorta3;
    public Transform porta32;
    public Transform porta41;
    public float speedPorta4;
    public Transform porta42;
    public Transform Roda1;
    public float speedRoda1;
    public Transform Roda2;
    public float speedRoda2;
    public Transform d8;
    private float posicioInicialZd8;
    bool fentEsquerrad8;
    private float ranged8;
    public float speedd8;
    public Transform Girador3;
    public float speedGirador3;

    //Nivell 4
    public Transform martell1;
    public float speedmartell1;
    public Transform martell2;
    public float speedmartell2;
    public Transform martell3;
    public float speedmartell3;
    public Transform martell4;
    public float speedmartell4;
    public Transform martell5;
    public float speedmartell5;
    public Transform martell6;
    public float speedmartell6;
    public Transform martell7;
    public float speedmartell7;
    public Transform martell8;
    public float speedmartell8;
    public Transform Torus3;
    public float speedTorus3;
    public Transform aspa3;
    public float speedaspa3;
    public Transform aspa4;
    public float speedaspa4;
    public Transform Boxa1; 
    public float speedboxa1;
    public Transform Boxa2;
    public float speedboxa2;
    public Transform Boxa3;
    public float speedboxa3;
    public Transform Boxa4;
    public float speedboxa4;


    //Invulnerabilitat
    bool invulnerable;
    public MeshCollider Torus1Collider;
    public MeshCollider Torus2Collider;
    public CapsuleCollider punxes1Colider; 
    public CapsuleCollider punxes2Colider;
    public CapsuleCollider punxes3Colider;
    public CapsuleCollider punxes4Colider;
    public BoxCollider punxes8Colider;
    public BoxCollider punxes11Colider;
    public CapsuleCollider cGran1Colider;
    public CapsuleCollider cGran2Colider;
    public BoxCollider d2Colider;
    public BoxCollider d1Colider;
    public BoxCollider d3Colider;
    public SphereCollider f11Colider;
    public SphereCollider f22Colider;
    public SphereCollider f33Colider;
    public SphereCollider f44Colider;
    public SphereCollider f55Colider;
    public SphereCollider f66Colider;
    public SphereCollider f77Colider;
    public BoxCollider pal2aspa1Colider;
    public BoxCollider pal1aspa1Colider;
    public BoxCollider pal1aspa2Colider;
    public BoxCollider pal2aspa2Colider;
    public BoxCollider porta11Colider;
    public BoxCollider porta12Colider;
    public BoxCollider porta21Colider;
    public BoxCollider porta22Colider;
    public BoxCollider porta31Colider;
    public BoxCollider porta32Colider;
    public BoxCollider porta41Colider;
    public BoxCollider porta42Colider;
    public MeshCollider Roda1Objecte1Colider;
    public MeshCollider Roda1Objecte2Colider;
    public MeshCollider Roda1Objecte3Colider;
    public MeshCollider Roda1Objecte4Colider;
    public MeshCollider Roda4Objecte1Colider;
    public MeshCollider Roda4Objecte2Colider;
    public MeshCollider Roda4Objecte3Colider;
    public MeshCollider Roda4Objecte4Colider;
    public BoxCollider d8Colider;
    public CapsuleCollider cGran3Collider;
    public BoxCollider picMartell1Colider;
    public BoxCollider picMartell2Colider;
    public BoxCollider picMartell3Colider;
    public BoxCollider picMartell4Colider;
    public BoxCollider picMartell5Colider;
    public BoxCollider picMartell6Colider;
    public BoxCollider picMartell7Colider;
    public BoxCollider picMartell8Colider;
    public BoxCollider pal2aspa3Colider;
    public BoxCollider pal1aspa3Colider;
    public BoxCollider pal2aspa4Colider;
    public BoxCollider pal1aspa4Colider;
    public MeshCollider Torus3Colider;
    public BoxCollider picoBoxa1Colider;
    public BoxCollider picoBoxa2Colider;
    public BoxCollider picoBoxa3Colider;
    public BoxCollider picoBoxa4Colider;
    public AudioSource magicTecles;
    private readonly WaitForFixedUpdate waitForFixedUpdate = new WaitForFixedUpdate();
    private readonly Dictionary<Transform, Rigidbody> hazardRigidbodies = new Dictionary<Transform, Rigidbody>();
    private readonly Dictionary<int, List<Transform>> levelHazardRoots = new Dictionary<int, List<Transform>>();
    private readonly Dictionary<int, List<Collider>> levelHazardColliders = new Dictionary<int, List<Collider>>();
    private readonly HashSet<Collider> allHazardColliders = new HashSet<Collider>();
    private int activeLevel;






    private void Awake()
    {
        invulnerable = false;
        activeLevel = 0;
        InitializeHazardGroups();
        ConfigureAnimatedHazards();
        RefreshHazardState();
    }

    // Start is called before the first frame update
    void Start()
    {
        //Nivell 2
        posicioInicialYPunxa1 = punxes1.position.y;
        posicioInicialYPunxa2 = punxes2.position.y;
        posicioInicialYPunxa3 = punxes3.position.y;
        posicioInicialYPunxa4 = punxes4.position.y;
        pujantGrupPunxes1 = false;
        rangeGrupPunxes1 = 5f;
        StartCoroutine(MouGrupPunxes1());

        posicioInicialYPunxa8 = punxes8.position.y;
        posicioInicialYPunxa6 = punxes6.position.y;
        posicioInicialYPunxa7 = punxes7.position.y;
        posicioInicialYPunxa9 = punxes9.position.y;
        posicioInicialYPunxa10 = punxes10.position.y;
        pujantGrupPunxes2 = false;
        rangeGrupPunxes2 = 5f;
        StartCoroutine(MouGrupPunxes2());


        posicioInicialYPunxa11 = punxes11.position.y;
        pujantGrupPunxes3 = false;
        rangeGrupPunxes3 = 7f;
        StartCoroutine(MouGrupPunxes3());



        //Nivell 1
        posicioInicialZd1 = d1.localPosition.z;
        fentEsquerrad1 = true;
        ranged1 = 10f; 
        StartCoroutine (Moud1());

        posicioInicialZd2 = d2.localPosition.z;
        fentEsquerrad2 = true;
        ranged2 = 10f;
        StartCoroutine(Moud2());

        posicioInicialZd3 = d3.localPosition.z;
        fentEsquerrad3 = true;
        ranged3 = 10f;
        StartCoroutine(Moud3());

    }

    void Update()
    {
        //Lo de la invulnerabilitat
        if (Input.GetKeyDown(KeyCode.G))
        {
            magicTecles.Play(); 
            if (!invulnerable)
            {
                invulnerable = true;
                volumeManager.BlancINegre();
                treuColiders(); 
            }
            else
            {
                invulnerable = false;
                volumeManager.Color();
                posaColiders(); 
            }
        }


    }

    private void FixedUpdate()
    {
        if (IsLevelActive(2))
        {
            RotateHazard(Girador1, new Vector3(0f, -speedGirador1 * Time.fixedDeltaTime, 0f), Space.Self);
            RotateHazard(Girador2, new Vector3(0f, -speedGirador2 * Time.fixedDeltaTime, 0f), Space.Self);
        }

        if (IsLevelActive(1))
        {
            RotateHazard(Torus1Nivell1, new Vector3(0f, 0f, -speedTorus1Nivell1 * Time.fixedDeltaTime), Space.Self);
            RotateHazard(Torus2Nivell1, new Vector3(0f, 0f, speedTorus2Nivell1 * Time.fixedDeltaTime), Space.Self);
        }
    }

    private void ConfigureAnimatedHazards()
    {
        foreach (KeyValuePair<int, List<Transform>> levelGroup in levelHazardRoots)
        {
            foreach (Transform hazardRoot in levelGroup.Value)
            {
                ConfigureKinematicRigidbody(hazardRoot);
            }
        }
    }

    private void InitializeHazardGroups()
    {
        levelHazardRoots.Clear();
        levelHazardColliders.Clear();
        allHazardColliders.Clear();

        RegisterHazardGroup(1, Torus1Nivell1, Torus2Nivell1, d1, d2, d3);
        RegisterHazardGroup(2, punxes1, punxes2, punxes3, punxes4, punxes6, punxes7, punxes8, punxes9, punxes10, punxes11, Girador1, Girador2);
    }

    private void RegisterHazardGroup(int level, params Transform[] hazardRoots)
    {
        HashSet<Transform> uniqueRoots = new HashSet<Transform>();
        foreach (Transform hazardRoot in hazardRoots)
        {
            if (hazardRoot != null)
            {
                uniqueRoots.Add(hazardRoot);
            }
        }

        List<Transform> roots = new List<Transform>(uniqueRoots);
        levelHazardRoots[level] = roots;
        CacheHazardColliders(level, roots);
    }

    private void CacheHazardColliders(int level, List<Transform> hazardRoots)
    {
        HashSet<Collider> levelColliders = new HashSet<Collider>();

        foreach (Transform hazardRoot in hazardRoots)
        {
            Collider[] colliders = hazardRoot.GetComponentsInChildren<Collider>(true);
            foreach (Collider hazardCollider in colliders)
            {
                if (hazardCollider == null)
                {
                    continue;
                }

                levelColliders.Add(hazardCollider);
                allHazardColliders.Add(hazardCollider);
            }
        }

        levelHazardColliders[level] = new List<Collider>(levelColliders);
    }

    public void SetActiveLevel(int level)
    {
        if (activeLevel == level)
        {
            return;
        }

        activeLevel = level;
        RefreshHazardState();
    }

    private bool IsLevelActive(int level)
    {
        return activeLevel == level;
    }

    private void RefreshHazardState()
    {
        if (invulnerable)
        {
            SetAllHazardColliders(false);
            return;
        }

        foreach (KeyValuePair<int, List<Collider>> levelGroup in levelHazardColliders)
        {
            bool enableColliders = levelGroup.Key == activeLevel;
            foreach (Collider hazardCollider in levelGroup.Value)
            {
                if (hazardCollider != null)
                {
                    hazardCollider.enabled = enableColliders;
                }
            }
        }
    }

    private void SetAllHazardColliders(bool enabled)
    {
        foreach (Collider hazardCollider in allHazardColliders)
        {
            if (hazardCollider != null)
            {
                hazardCollider.enabled = enabled;
            }
        }
    }

    private void ConfigureKinematicRigidbody(Transform hazardRoot)
    {
        if (hazardRoot == null)
        {
            return;
        }

        Rigidbody hazardRigidbody = hazardRoot.GetComponent<Rigidbody>();
        if (hazardRigidbody == null)
        {
            hazardRigidbody = hazardRoot.gameObject.AddComponent<Rigidbody>();
        }

        hazardRigidbody.useGravity = false;
        hazardRigidbody.isKinematic = true;
        hazardRigidbody.interpolation = RigidbodyInterpolation.Interpolate;
        hazardRigidbody.collisionDetectionMode = CollisionDetectionMode.ContinuousSpeculative;
        hazardRigidbodies[hazardRoot] = hazardRigidbody;
    }

    private Rigidbody GetHazardRigidbody(Transform hazardRoot)
    {
        if (hazardRoot == null)
        {
            return null;
        }

        if (!hazardRigidbodies.TryGetValue(hazardRoot, out Rigidbody hazardRigidbody) || hazardRigidbody == null)
        {
            hazardRigidbody = hazardRoot.GetComponent<Rigidbody>();
            if (hazardRigidbody != null)
            {
                hazardRigidbodies[hazardRoot] = hazardRigidbody;
            }
        }

        return hazardRigidbody;
    }

    private void MoveHazardPosition(Transform hazardRoot, Vector3 worldPosition)
    {
        Rigidbody hazardRigidbody = GetHazardRigidbody(hazardRoot);
        if (hazardRigidbody == null)
        {
            hazardRoot.position = worldPosition;
            return;
        }

        hazardRigidbody.MovePosition(worldPosition);
    }

    private void MoveHazardRotation(Transform hazardRoot, Quaternion worldRotation)
    {
        Rigidbody hazardRigidbody = GetHazardRigidbody(hazardRoot);
        if (hazardRigidbody == null)
        {
            hazardRoot.rotation = worldRotation;
            return;
        }

        hazardRigidbody.MoveRotation(worldRotation);
    }

    private void TranslateHazard(Transform hazardRoot, Vector3 translation, Space relativeTo)
    {
        Vector3 worldDelta = relativeTo == Space.Self ? hazardRoot.TransformDirection(translation) : translation;
        MoveHazardPosition(hazardRoot, hazardRoot.position + worldDelta);
    }

    private void RotateHazard(Transform hazardRoot, Vector3 eulerAngles, Space relativeTo)
    {
        Quaternion deltaRotation = Quaternion.Euler(eulerAngles);
        Quaternion targetRotation = relativeTo == Space.Self
            ? hazardRoot.rotation * deltaRotation
            : deltaRotation * hazardRoot.rotation;

        MoveHazardRotation(hazardRoot, targetRotation);
    }

    private void SetHazardLocalRotation(Transform hazardRoot, Quaternion localRotation)
    {
        Quaternion worldRotation = hazardRoot.parent != null
            ? hazardRoot.parent.rotation * localRotation
            : localRotation;

        MoveHazardRotation(hazardRoot, worldRotation);
    }

    private IEnumerator MouGrupPunxes1()
    {
        while (true)
        {
            if (!IsLevelActive(2))
            {
                yield return waitForFixedUpdate;
                continue;
            }


            if ((punxes1.position.y > posicioInicialYPunxa1) && (pujantGrupPunxes1))
            {
                pujantGrupPunxes1 = false;
                yield return new WaitForSeconds(1f);
            }
            else if ((punxes1.position.y < (posicioInicialYPunxa1 - rangeGrupPunxes1)) && (!pujantGrupPunxes1))
            {
                pujantGrupPunxes1 = true;
                yield return new WaitForSeconds(1f);
            }
            else
            {
                if (pujantGrupPunxes1)
                {
                    TranslateHazard(punxes1, new Vector3(0f, speedGrupPunxes1Pujada * Time.fixedDeltaTime, 0f), Space.Self);
                    TranslateHazard(punxes2, new Vector3(0f, speedGrupPunxes1Pujada * Time.fixedDeltaTime, 0f), Space.Self);
                    TranslateHazard(punxes3, new Vector3(0f, speedGrupPunxes1Pujada * Time.fixedDeltaTime, 0f), Space.Self);
                    TranslateHazard(punxes4, new Vector3(0f, speedGrupPunxes1Pujada * Time.fixedDeltaTime, 0f), Space.Self);
                }
                else
                {
                    TranslateHazard(punxes1, new Vector3(0f, -speedGrupPunxes1Baixada * Time.fixedDeltaTime, 0f), Space.Self);
                    TranslateHazard(punxes2, new Vector3(0f, -speedGrupPunxes1Baixada * Time.fixedDeltaTime, 0f), Space.Self);
                    TranslateHazard(punxes3, new Vector3(0f, -speedGrupPunxes1Baixada * Time.fixedDeltaTime, 0f), Space.Self);
                    TranslateHazard(punxes4, new Vector3(0f, -speedGrupPunxes1Baixada * Time.fixedDeltaTime, 0f), Space.Self);
                }
            }
            yield return waitForFixedUpdate;
        }

    }


    private IEnumerator MouGrupPunxes2()
    {
        while (true)
        {
            if (!IsLevelActive(2))
            {
                yield return waitForFixedUpdate;
                continue;
            }


            if ((punxes8.position.y > posicioInicialYPunxa8) && (pujantGrupPunxes2))
            {
                pujantGrupPunxes2 = false;
                yield return new WaitForSeconds(1f);
            }
            else if ((punxes8.position.y < (posicioInicialYPunxa8 - rangeGrupPunxes2)) && (!pujantGrupPunxes2))
            {
                pujantGrupPunxes2 = true;
                yield return new WaitForSeconds(1f);
            }
            else
            {
                if (pujantGrupPunxes2)
                {
                    TranslateHazard(punxes6, new Vector3(0f, speedGrupPunxes2Pujada * Time.fixedDeltaTime, 0f), Space.Self);
                    TranslateHazard(punxes7, new Vector3(0f, speedGrupPunxes2Pujada * Time.fixedDeltaTime, 0f), Space.Self);
                    TranslateHazard(punxes8, new Vector3(0f, speedGrupPunxes2Pujada * Time.fixedDeltaTime, 0f), Space.Self);
                    TranslateHazard(punxes9, new Vector3(0f, speedGrupPunxes2Pujada * Time.fixedDeltaTime, 0f), Space.Self);
                    TranslateHazard(punxes10, new Vector3(0f, speedGrupPunxes2Pujada * Time.fixedDeltaTime, 0f), Space.Self);
                }
                else
                {
                    TranslateHazard(punxes6, new Vector3(0f, -speedGrupPunxes2Baixada * Time.fixedDeltaTime, 0f), Space.Self);
                    TranslateHazard(punxes7, new Vector3(0f, -speedGrupPunxes2Baixada * Time.fixedDeltaTime, 0f), Space.Self);
                    TranslateHazard(punxes8, new Vector3(0f, -speedGrupPunxes2Baixada * Time.fixedDeltaTime, 0f), Space.Self);
                    TranslateHazard(punxes9, new Vector3(0f, -speedGrupPunxes2Baixada * Time.fixedDeltaTime, 0f), Space.Self);
                    TranslateHazard(punxes10, new Vector3(0f, -speedGrupPunxes2Baixada * Time.fixedDeltaTime, 0f), Space.Self);
                }
            }
            yield return waitForFixedUpdate;
        }

    }


    private IEnumerator MouGrupPunxes3()
    {
        while (true)
        {
            if (!IsLevelActive(2))
            {
                yield return waitForFixedUpdate;
                continue;
            }


            if ((punxes11.position.y > posicioInicialYPunxa11) && (pujantGrupPunxes3))
            {
                pujantGrupPunxes3 = false;
                yield return new WaitForSeconds(0.5f);
            }
            else if ((punxes11.position.y < (posicioInicialYPunxa11 - rangeGrupPunxes3)) && (!pujantGrupPunxes3))
            {
                pujantGrupPunxes3 = true;
                yield return new WaitForSeconds(1f);
            }
            else
            {
                if (pujantGrupPunxes3)
                {
                    TranslateHazard(punxes11, new Vector3(0f, speedGrupPunxes3Pujada * Time.fixedDeltaTime, 0f), Space.Self);
                }
                else
                {
                    TranslateHazard(punxes11, new Vector3(0f, -speedGrupPunxes3Baixada * Time.fixedDeltaTime, 0f), Space.Self);
                }
            }
            yield return waitForFixedUpdate;
        }

    }


    private IEnumerator Moud1()
    {
        while (true)
        {
            if (!IsLevelActive(1))
            {
                yield return waitForFixedUpdate;
                continue;
            }


            if ((d1.localPosition.z > posicioInicialZd1) && (!fentEsquerrad1))
            {
                fentEsquerrad1 = true; 
                yield return new WaitForSeconds(1f);
            }
            else if ((d1.localPosition.z < (posicioInicialZd1 - ranged1)) && (fentEsquerrad1))
            {
                fentEsquerrad1 = false; 
                yield return new WaitForSeconds(1f);
            }
            else
            {
                if (fentEsquerrad1)
                {
                    TranslateHazard(d1, new Vector3(0f, 0f, -speedd1 * Time.fixedDeltaTime), Space.Self);
                }
                else
                {
                    TranslateHazard(d1, new Vector3(0f, 0f, +speedd1 * Time.fixedDeltaTime), Space.Self);
                }
            }
            yield return waitForFixedUpdate;
        }

    }


    private IEnumerator Moud2()
    {
        while (true)
        {
            if (!IsLevelActive(1))
            {
                yield return waitForFixedUpdate;
                continue;
            }


            if ((d2.localPosition.z > posicioInicialZd2) && (!fentEsquerrad2))
            {
                fentEsquerrad2 = true;
                yield return waitForFixedUpdate;
            }
            else if ((d2.localPosition.z < (posicioInicialZd2 - ranged2)) && (fentEsquerrad2))
            {
                fentEsquerrad2 = false;
                yield return waitForFixedUpdate;
            }
            else
            {
                if (fentEsquerrad2)
                {
                    TranslateHazard(d2, new Vector3(0f, 0f, -speedd2 * Time.fixedDeltaTime), Space.Self);
                }
                else
                {
                    TranslateHazard(d2, new Vector3(0f, 0f, +speedd2 * Time.fixedDeltaTime), Space.Self);
                }
            }
            yield return waitForFixedUpdate;
        }

    }


    private IEnumerator Moud3()
    {
        while (true)
        {
            if (!IsLevelActive(1))
            {
                yield return waitForFixedUpdate;
                continue;
            }


            if ((d3.localPosition.z > posicioInicialZd3) && (!fentEsquerrad3))
            {
                fentEsquerrad3 = true;
                yield return new WaitForSeconds(1f);
            }
            else if ((d3.localPosition.z < (posicioInicialZd3 - ranged3)) && (fentEsquerrad3))
            {
                fentEsquerrad3 = false;
                yield return new WaitForSeconds(1f);
            }
            else
            {
                if (fentEsquerrad3)
                {
                    TranslateHazard(d3, new Vector3(0f, 0f, -speedd3 * Time.fixedDeltaTime), Space.Self);
                }
                else
                {
                    TranslateHazard(d3, new Vector3(0f, 0f, +speedd3 * Time.fixedDeltaTime), Space.Self);
                }
            }
            yield return waitForFixedUpdate;
        }

    }


    private IEnumerator MouPorta2()
    {
        float angle = 0f; 
        while (true)
        {
            if (!IsLevelActive(5))
            {
                yield return waitForFixedUpdate;
                continue;
            }

            angle += -speedPorta2 * Time.fixedDeltaTime;
             
            if (angle < -180f)
            {
                angle = 0f;
                yield return new WaitForSeconds(1f);
            }
            else
            {
                SetHazardLocalRotation(porta21, Quaternion.Euler(0f, angle, 0f));
                SetHazardLocalRotation(porta22, Quaternion.Euler(0f, -angle, 0f));
                yield return waitForFixedUpdate;
            }
        }

    }

    private IEnumerator MouPorta4()
    {
        float angle = 0f;
        while (true)
        {
            if (!IsLevelActive(5))
            {
                yield return waitForFixedUpdate;
                continue;
            }

            angle += -speedPorta4 * Time.fixedDeltaTime;

            if (angle < -180f)
            {
                angle = 0f;
                yield return new WaitForSeconds(1f);
            }
            else
            {
                SetHazardLocalRotation(porta41, Quaternion.Euler(-angle, 0f, 0f));
                SetHazardLocalRotation(porta42, Quaternion.Euler(-angle - 90f, 0f, 0f));
                yield return waitForFixedUpdate;
            }
        }

    }

    private IEnumerator MouRoda2()
    {
        float current = 0f;
        float angle = 0f; 
        while (true)
        {
            if (!IsLevelActive(5))
            {
                yield return waitForFixedUpdate;
                continue;
            }

            angle += speedRoda2 * Time.fixedDeltaTime;
            current += speedRoda2 * Time.fixedDeltaTime; 

            if (current > 45f)
            {
                current = 0f;
                yield return new WaitForSeconds(1f);
            }
            else
            {
                SetHazardLocalRotation(Roda2, Quaternion.Euler(90f, 0f, angle));
                yield return waitForFixedUpdate;
            }
        }
        
    }

    private IEnumerator Moud8()
    {
        while (true)
        {
            if (!IsLevelActive(5))
            {
                yield return waitForFixedUpdate;
                continue;
            }


            if ((d8.localPosition.z > posicioInicialZd8) && (!fentEsquerrad8))
            {
                fentEsquerrad8 = true;
                yield return new WaitForSeconds(1f);
            }
            else if ((d8.localPosition.z < (posicioInicialZd8 - ranged8)) && (fentEsquerrad8))
            {
                fentEsquerrad8 = false;
                yield return new WaitForSeconds(1f);
            }
            else
            {
                if (fentEsquerrad8)
                {
                    TranslateHazard(d8, new Vector3(0f, 0f, -speedd8 * Time.fixedDeltaTime), Space.Self);
                }
                else
                {
                    TranslateHazard(d8, new Vector3(0f, 0f, +speedd8 * Time.fixedDeltaTime), Space.Self);
                }
            }
            yield return waitForFixedUpdate;
        }

    }



    private IEnumerator MouMartell1()
    {
        float angle = 0f;
        bool fentdalt = true; 
        while (true)
        {
            if (!IsLevelActive(4))
            {
                yield return waitForFixedUpdate;
                continue;
            }

            if (fentdalt)
            {
                angle += -speedmartell1 * Time.fixedDeltaTime;
                if (angle < -90f)
                {
                    fentdalt = false;
                    yield return new WaitForSeconds(1f);
                }
                else
                {
                    SetHazardLocalRotation(martell1, Quaternion.Euler(0f, 0f, angle));
                    yield return waitForFixedUpdate; 
                }
            }
            else
            {
                angle += speedmartell1 * Time.fixedDeltaTime;

                if (angle > 0f)
                {
                    fentdalt = true;
                    yield return new WaitForSeconds(1f);
                }
                else
                {
                    SetHazardLocalRotation(martell1, Quaternion.Euler(0f, 0f, angle));
                    yield return waitForFixedUpdate; 
                }
            }
        }

    }

    private IEnumerator MouMartell2()
    {
        float angle = 0f;
        bool fentdalt = true;
        while (true)
        {
            if (!IsLevelActive(4))
            {
                yield return waitForFixedUpdate;
                continue;
            }

            if (fentdalt)
            {
                angle += -speedmartell2 * Time.fixedDeltaTime;
                if (angle < -90f)
                {
                    fentdalt = false;
                    yield return new WaitForSeconds(1f);
                }
                else
                {
                    SetHazardLocalRotation(martell2, Quaternion.Euler(0f, 0f, angle));
                    yield return waitForFixedUpdate;
                }
            }
            else
            {
                angle += speedmartell2 * Time.fixedDeltaTime;

                if (angle > 0f)
                {
                    fentdalt = true;
                    yield return new WaitForSeconds(1f);
                }
                else
                {
                    SetHazardLocalRotation(martell2, Quaternion.Euler(0f, 0f, angle));
                    yield return waitForFixedUpdate;
                }
            }
        }

    }

    private IEnumerator MouMartell3()
    {
        float angle = 0f;
        bool fentdalt = true;
        while (true)
        {
            if (!IsLevelActive(4))
            {
                yield return waitForFixedUpdate;
                continue;
            }

            if (fentdalt)
            {
                angle += -speedmartell3 * Time.fixedDeltaTime;
                if (angle < -90f)
                {
                    fentdalt = false;
                    yield return new WaitForSeconds(0.5f);
                }
                else
                {
                    SetHazardLocalRotation(martell3, Quaternion.Euler(0f, 0f, angle));
                    yield return waitForFixedUpdate;
                }
            }
            else
            {
                angle += speedmartell3 * Time.fixedDeltaTime;

                if (angle > 0f)
                {
                    fentdalt = true;
                    yield return new WaitForSeconds(0.5f);
                }
                else
                {
                    SetHazardLocalRotation(martell3, Quaternion.Euler(0f, 0f, angle));
                    yield return waitForFixedUpdate;
                }
            }
        }

    }

    private IEnumerator MouMartell4()
    {
        float angle = 0f;
        bool fentdalt = true;
        while (true)
        {
            if (!IsLevelActive(4))
            {
                yield return waitForFixedUpdate;
                continue;
            }

            if (fentdalt)
            {
                angle += -speedmartell4 * Time.fixedDeltaTime;
                if (angle < -90f)
                {
                    fentdalt = false;
                    yield return new WaitForSeconds(0.5f);
                }
                else
                {
                    SetHazardLocalRotation(martell4, Quaternion.Euler(0f, 0f, angle));
                    yield return waitForFixedUpdate;
                }
            }
            else
            {
                angle += speedmartell4 * Time.fixedDeltaTime;

                if (angle > 0f)
                {
                    fentdalt = true;
                    yield return new WaitForSeconds(0.5f);
                }
                else
                {
                    SetHazardLocalRotation(martell4, Quaternion.Euler(0f, 0f, angle));
                    yield return waitForFixedUpdate;
                }
            }
        }

    }

    private IEnumerator MouMartell5()
    {
        float angle = 0f;
        bool fentdalt = true;
        while (true)
        {
            if (!IsLevelActive(4))
            {
                yield return waitForFixedUpdate;
                continue;
            }

            if (fentdalt)
            {
                angle += -speedmartell5 * Time.fixedDeltaTime;
                if (angle < -90f)
                {
                    fentdalt = false;
                    yield return waitForFixedUpdate;
                }
                else
                {
                    SetHazardLocalRotation(martell5, Quaternion.Euler(0f, 0f, angle));
                    yield return waitForFixedUpdate;
                }
            }
            else
            {
                angle += speedmartell5 * Time.fixedDeltaTime;

                if (angle > 0f)
                {
                    fentdalt = true;
                    yield return waitForFixedUpdate;
                }
                else
                {
                    SetHazardLocalRotation(martell5, Quaternion.Euler(0f, 0f, angle));
                    yield return waitForFixedUpdate;
                }
            }
        }

    }

    private IEnumerator MouMartell6()
    {
        float angle = 0f;
        bool fentdalt = true;
        while (true)
        {
            if (!IsLevelActive(4))
            {
                yield return waitForFixedUpdate;
                continue;
            }

            if (fentdalt)
            {
                angle += -speedmartell6 * Time.fixedDeltaTime;
                if (angle < -90f)
                {
                    fentdalt = false;
                    yield return new WaitForSeconds(0.5f);
                }
                else
                {
                    SetHazardLocalRotation(martell6, Quaternion.Euler(0f, 0f, angle));
                    yield return waitForFixedUpdate;
                }
            }
            else
            {
                angle += speedmartell6 * Time.fixedDeltaTime;

                if (angle > 0f)
                {
                    fentdalt = true;
                    yield return new WaitForSeconds(0.5f);
                }
                else
                {
                    SetHazardLocalRotation(martell6, Quaternion.Euler(0f, 0f, angle));
                    yield return waitForFixedUpdate;
                }
            }
        }

    }

    private IEnumerator MouMartell7()
    {
        float angle = 0f;
        bool fentdalt = true;
        while (true)
        {
            if (!IsLevelActive(4))
            {
                yield return waitForFixedUpdate;
                continue;
            }

            if (fentdalt)
            {
                angle += -speedmartell7 * Time.fixedDeltaTime;
                if (angle < -90f)
                {
                    fentdalt = false;
                    yield return waitForFixedUpdate;
                }
                else
                {
                    SetHazardLocalRotation(martell7, Quaternion.Euler(0f, 0f, angle));
                    yield return waitForFixedUpdate;
                }
            }
            else
            {
                angle += speedmartell7 * Time.fixedDeltaTime;

                if (angle > 0f)
                {
                    fentdalt = true;
                    yield return waitForFixedUpdate;
                }
                else
                {
                    SetHazardLocalRotation(martell7, Quaternion.Euler(0f, 0f, angle));
                    yield return waitForFixedUpdate;
                }
            }
        }

    }

    private IEnumerator MouMartell8()
    {
        float angle = 0f;
        bool fentdalt = true;
        while (true)
        {
            if (!IsLevelActive(4))
            {
                yield return waitForFixedUpdate;
                continue;
            }

            if (fentdalt)
            {
                angle += -speedmartell8 * Time.fixedDeltaTime;
                if (angle < -90f)
                {
                    fentdalt = false;
                    yield return waitForFixedUpdate;
                }
                else
                {
                    SetHazardLocalRotation(martell8, Quaternion.Euler(0f, 0f, angle));
                    yield return waitForFixedUpdate;
                }
            }
            else
            {
                angle += speedmartell8 * Time.fixedDeltaTime;

                if (angle > 0f)
                {
                    fentdalt = true;
                    yield return waitForFixedUpdate;
                }
                else
                {
                    SetHazardLocalRotation(martell8, Quaternion.Euler(0f, 0f, angle));
                    yield return waitForFixedUpdate;
                }
            }
        }

    }

    private IEnumerator MouBoxa4()
    {
        bool fentFora = false;
        float posicioInicialBoxa4X = Boxa4.localPosition.x;
        float range = 4f;
        while (true)
        {
            if (!IsLevelActive(4))
            {
                yield return waitForFixedUpdate;
                continue;
            }

            if ((Boxa4.localPosition.x > (posicioInicialBoxa4X + range)) && (fentFora))
            {
                fentFora = false;
                yield return new WaitForSeconds(1f);
            }
            else if ((Boxa4.localPosition.x < (posicioInicialBoxa4X)) && (!fentFora))
            {
                fentFora = true;
                yield return new WaitForSeconds(1f);
            }
            else
            {
                if (fentFora)
                {
                    TranslateHazard(Boxa4, new Vector3(speedboxa4 * Time.fixedDeltaTime, 0f, 0f), Space.Self);
                }
                else
                {
                    TranslateHazard(Boxa4, new Vector3(-speedboxa4 * Time.fixedDeltaTime, 0f, 0f), Space.Self);
                }
            }
            yield return waitForFixedUpdate;
        }

    }

    private IEnumerator MouBoxa3()
    {
        bool fentFora = false;
        float posicioInicialBoxa3X = Boxa3.localPosition.x;
        float range = 4f;
        while (true)
        {
            if (!IsLevelActive(4))
            {
                yield return waitForFixedUpdate;
                continue;
            }

            if ((Boxa3.localPosition.x > (posicioInicialBoxa3X + range)) && (fentFora))
            {
                fentFora = false;
                yield return new WaitForSeconds(1f);
            }
            else if ((Boxa3.localPosition.x < (posicioInicialBoxa3X)) && (!fentFora))
            {
                fentFora = true;
                yield return new WaitForSeconds(1f);
            }
            else
            {
                if (fentFora)
                {
                    TranslateHazard(Boxa3, new Vector3(speedboxa3 * Time.fixedDeltaTime, 0f, 0f), Space.Self);
                }
                else
                {
                    TranslateHazard(Boxa3, new Vector3(-speedboxa3 * Time.fixedDeltaTime, 0f, 0f), Space.Self);
                }
            }
            yield return waitForFixedUpdate;
        }

    }

    private IEnumerator MouBoxa2()
    {
        bool fentFora = true;
        float range = 4f;
        float posicioInicialBoxa2X = Boxa2.localPosition.x + range;
        while (true)
        {
            if (!IsLevelActive(4))
            {
                yield return waitForFixedUpdate;
                continue;
            }

            if ((Boxa2.localPosition.x < (posicioInicialBoxa2X - range)) && (fentFora))
            {
                fentFora = false;
                yield return new WaitForSeconds(1f);
            }
            else if ((Boxa2.localPosition.x > (posicioInicialBoxa2X)) && (!fentFora))
            {
                fentFora = true;
                yield return new WaitForSeconds(1f);
            }
            else
            {
                if (fentFora)
                {
                    TranslateHazard(Boxa2, new Vector3(speedboxa2 * Time.fixedDeltaTime, 0f, 0f), Space.Self);
                }
                else
                {
                    TranslateHazard(Boxa2, new Vector3(-speedboxa2 * Time.fixedDeltaTime, 0f, 0f), Space.Self);
                }
            }
            yield return waitForFixedUpdate;
        }

    }

    private IEnumerator MouBoxa1()
    {
        bool fentFora = true;
        float range = 4f;
        float posicioInicialBoxa1X = Boxa1.localPosition.x + range;
        while (true)
        {
            if (!IsLevelActive(4))
            {
                yield return waitForFixedUpdate;
                continue;
            }

            if ((Boxa1.localPosition.x < (posicioInicialBoxa1X - range)) && (fentFora))
            {
                fentFora = false;
                yield return new WaitForSeconds(1f);
            }
            else if ((Boxa1.localPosition.x > (posicioInicialBoxa1X)) && (!fentFora))
            {
                fentFora = true;
                yield return new WaitForSeconds(1f);
            }
            else
            {
                if (fentFora)
                {
                    TranslateHazard(Boxa1, new Vector3(speedboxa1 * Time.fixedDeltaTime, 0f, 0f), Space.Self);
                }
                else
                {
                    TranslateHazard(Boxa1, new Vector3(-speedboxa1 * Time.fixedDeltaTime, 0f, 0f), Space.Self);
                }
            }
            yield return waitForFixedUpdate;
        }

    }


    private void treuColiders()
    {
        SetAllHazardColliders(false);
    }

    private void posaColiders()
    {
        RefreshHazardState();
    }

}
