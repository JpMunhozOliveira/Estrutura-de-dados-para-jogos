using System;
using System.Collections.Generic;

public class Livro
{
    private string titulo;
    private string autor;
    private string ano;
    private int quantidade;

    public string GetTitulo()
    {
        return titulo;
    }
    public string SetTitulo(string value)
    {
        titulo = value;
        return value;
    }

    public string GetAutor()
    {
        return autor;
    }
    public void SetAutor(string value)
    {
        autor = value;
    }

    public string GetAno()
    {
        return ano;
    }
    public void SetAno(string value)
    {
        ano = value;
    }

    public int GetQuantidade()
    {
        return quantidade;
    }
    public void SetQuantidade(int value)
    {
        quantidade = value;
    }
}