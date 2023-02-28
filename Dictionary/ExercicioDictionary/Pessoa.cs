using System;
using System.Collections.Generic;

class Pessoa
{
    private string nome;
    private string telefone;
    private string endereco;

    public string GetNome()
    {
        return nome;
    }
    public void SetNome(string value)
    {
        nome = value;
    }
    public string GetTelefone()
    {
        return telefone;
    }
    public void SetTelefone(string value)
    {
        telefone = value;
    }
    public string GetEndereco()
    {
        return endereco;
    }
    public void SetEndereco(string value)
    {
        endereco = value;
    }
}