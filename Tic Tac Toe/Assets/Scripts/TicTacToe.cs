using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TicTacToe : MonoBehaviour
{
    public LineRenderer lr;

    public GameObject but1;
    public GameObject but2;
    public GameObject but3;
    public GameObject but4;
    public GameObject but5;
    public GameObject but6;
    public GameObject but7;
    public GameObject but8;
    public GameObject but9;

    public Sprite X;
    public Sprite O;
    public Sprite Nothing;

    public TextMeshProUGUI text;

    int nr = 1;
    int nr2 = 2;
    int i, j;

    float[,] mat = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };

    bool wining = false;

    public void getI(int ii)
    {
        i = ii;
    }
    public void getJ(int jj)
    {
        j = jj;
    }
    public void change()
    {
        mat[i, j] = nr;
        int aux = nr;
        nr = nr2;
        nr2 = aux;
    }

    public void Reset()
    {
        Array.Clear(mat, 0, mat.Length);
        but1.GetComponent<Image>().sprite = Nothing;
        but2.GetComponent<Image>().sprite = Nothing;
        but3.GetComponent<Image>().sprite = Nothing;
        but4.GetComponent<Image>().sprite = Nothing;
        but5.GetComponent<Image>().sprite = Nothing;
        but6.GetComponent<Image>().sprite = Nothing;
        but7.GetComponent<Image>().sprite = Nothing;
        but8.GetComponent<Image>().sprite = Nothing;
        but9.GetComponent<Image>().sprite = Nothing;
        lr.SetPosition(0, Vector3.zero);
        lr.SetPosition(1, Vector3.zero);
        wining = false;
    }

    private void FixedUpdate()
    {
        if (wining == false)
        {
            win();
        }

        if (nr == 1)
            text.text = "X turn";
        else if (nr == 2)
            text.text = "O turn";

        if (mat[0, 0] == 1)
            but1.GetComponent<Image>().sprite = X;
        else if (mat[0, 0] == 2) but1.GetComponent<Image>().sprite = O;

        if (mat[0, 1] == 1)
            but2.GetComponent<Image>().sprite = X;
        else if (mat[0, 1] == 2) but2.GetComponent<Image>().sprite = O;

        if (mat[0, 2] == 1)
            but3.GetComponent<Image>().sprite = X;
        else if (mat[0, 2] == 2) but3.GetComponent<Image>().sprite = O;

        if (mat[1, 0] == 1)
            but4.GetComponent<Image>().sprite = X;
        else if (mat[1, 0] == 2) but4.GetComponent<Image>().sprite = O;

        if (mat[1, 1] == 1)
            but5.GetComponent<Image>().sprite = X;
        else if (mat[1, 1] == 2) but5.GetComponent<Image>().sprite = O;

        if (mat[1, 2] == 1)
            but6.GetComponent<Image>().sprite = X;
        else if (mat[1, 2] == 2) but6.GetComponent<Image>().sprite = O;

        if (mat[2, 0] == 1)
            but7.GetComponent<Image>().sprite = X;
        else if (mat[2, 0] == 2) but7.GetComponent<Image>().sprite = O;

        if (mat[2, 1] == 1)
            but8.GetComponent<Image>().sprite = X;
        else if (mat[2, 1] == 2) but8.GetComponent<Image>().sprite = O;

        if (mat[2, 2] == 1)
            but9.GetComponent<Image>().sprite = X;
        else if (mat[2, 2] == 2) but9.GetComponent<Image>().sprite = O;
    }

    void win()
    {
        if (mat[0, 1] == mat[0, 0] && mat[0, 1] == mat[0, 2] && mat[0, 1] != 0)
        {
            lr.SetPosition(0, but1.transform.position);
            lr.SetPosition(1, but3.transform.position);
            wining = true;
            DisabeButton();
        }

        if (mat[1, 1] == mat[1, 0] && mat[1, 1] == mat[1, 2] && mat[1, 1] != 0)
        {
            lr.SetPosition(0, but4.transform.position);
            lr.SetPosition(1, but6.transform.position);
            wining = true;
            DisabeButton();
        }

        if (mat[2, 1] == mat[2, 0] && mat[2, 1] == mat[2, 2] && mat[2, 1] != 0)
        {
            lr.SetPosition(0, but7.transform.position);
            lr.SetPosition(1, but9.transform.position);
            wining = true;
            DisabeButton();
        }

        if (mat[1, 0] == mat[0, 0] && mat[1, 0] == mat[2, 0] && mat[1, 0] != 0)
        {
            lr.SetPosition(0, but1.transform.position);
            lr.SetPosition(1, but7.transform.position);
            wining = true;
            DisabeButton();
        }

        if (mat[1, 1] == mat[0, 1] && mat[1, 1] == mat[2, 1] && mat[1, 1] != 0)
        {
            lr.SetPosition(0, but2.transform.position);
            lr.SetPosition(1, but8.transform.position);
            wining = true;
            DisabeButton();
        }

        if (mat[1, 2] == mat[0, 2] && mat[1, 2] == mat[2, 2] && mat[1, 2] != 0)
        {
            lr.SetPosition(0, but3.transform.position);
            lr.SetPosition(1, but9.transform.position);
            wining = true;
            DisabeButton();
        }

        if (mat[0, 0] == mat[1, 1] && mat[0, 0] == mat[2, 2] && mat[0, 0] != 0)
        {
            lr.SetPosition(0, but1.transform.position);
            lr.SetPosition(1, but9.transform.position);
            wining = true;
            DisabeButton();
        }

        if (mat[0, 2] == mat[1, 1] && mat[1, 1] == mat[2, 0] && mat[1, 1] != 0)
        {
            lr.SetPosition(0, but3.transform.position);
            lr.SetPosition(1, but7.transform.position);
            wining = true;
            DisabeButton();
        }
    }

    void DisabeButton()
    {
        but1.GetComponent<Button>().enabled = false;
        but2.GetComponent<Button>().enabled = false;
        but3.GetComponent<Button>().enabled = false;
        but4.GetComponent<Button>().enabled = false;
        but5.GetComponent<Button>().enabled = false;
        but6.GetComponent<Button>().enabled = false;
        but7.GetComponent<Button>().enabled = false;
        but8.GetComponent<Button>().enabled = false;
        but9.GetComponent<Button>().enabled = false;
    }
}