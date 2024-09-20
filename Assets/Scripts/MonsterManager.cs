using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class MonsterManager : MonoBehaviour
{

    public GameObject monster_path;

    public float speed;

    //Definción de rooms (Agregar los elementos que correspondan a una room)

    public List<int> rooms;

    //Generación de camino

    private List<int> final_path;

    private List<int>[] grafo;

    private bool[] visitado;

    //

    //Variables dinámicas

    //Liberar monstruo 

    public bool monstruo_libre = false;

    //

    private int n;

    private int current_step = 0;

    private System.Random random;

    //

    public void liberarMonstruo () {

        this.monstruo_libre = true;

    }

    // Determinar visita 

    private bool visit (float possibility) {

        float monster_possibility = 100f - possibility;

        float random_generation = (float) (random.NextDouble() * 100);

        Debug.Log(monster_possibility + " " + random_generation);

        return random_generation < monster_possibility;

    }

    // Búsqueda en profundidad

    private void dfs (int i, int p) {

        visitado[i] = true;

        Transform target_transform = this.monster_path.transform.Find(i.ToString());
        StepManager step = target_transform.GetComponent<StepManager>();

        bool addStep = !step.isRoom();

        if (step.isRoom()) {

            addStep = visit(step.getPossiblity());

        }

        if (addStep) {

            final_path.Add(i);

            foreach (int v in grafo[i]) {

                if (!visitado[v]) {

                    dfs(v, i);

                }

            }

            if (p != 0) {

                final_path.Add(p);

            }

        }
        
    }

    void Awake()
    {
        this.random = new System.Random();

        this.n = this.monster_path.transform.childCount;

        this.grafo = new List<int>[n + 1];
        this.visitado = new bool[n + 1];

        this.final_path = new List<int>();

        for (int i = 1; i <= n; i++) {

            grafo[i] = new List<int>();

            Transform target_transform = this.monster_path.transform.Find(i.ToString());
            StepManager step = target_transform.GetComponent<StepManager>();

            List<int> step_vecinos = step.getVecinos();

            foreach (int v in step_vecinos) {

                this.grafo[i].Add(v);

            }

        }

    }

    void Start()
    {
        
        dfs(1, 0);

    }

    void Update()
    {

        if (this.monstruo_libre) {

            if (current_step < this.final_path.Count) {

                Transform current_transform = this.transform;
                Transform target_transform = monster_path.transform.Find(this.final_path[current_step].ToString());
                this.transform.position = Vector3.Lerp(current_transform.position, target_transform.position, Time.deltaTime * speed);

                if (Vector3.Distance(current_transform.position, target_transform.position) < 0.1f) {

                    current_step++;

                }

            }

        }

    }

}
