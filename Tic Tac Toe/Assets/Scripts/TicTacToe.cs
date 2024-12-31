using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TicTacToe : MonoBehaviour
{
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
    }

    private void FixedUpdate()
    {
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
        else if (mat[0, 0] == 2) but4.GetComponent<Image>().sprite = O;

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
}