using System;
using System.Collections.Generic;

public class Pessoa
{
    private string nome;
    private string endereco;
    private string telefone;

    public Pessoa(){

    }

    public Pessoa(string nome, string endereco, string telefone){
        this.nome = nome;
        this.endereco = endereco;
        this.telefone = telefone;
    }

    public string GetNome()
    {
        return nome;
    }

    public void SetNome(string value)
    {
        nome = value;
    }

    public string GetEndereco()
    {
        return endereco;
    }

    public void SetEndereco(string value)
    {
        endereco = value;
    }

    public string GetTelefone()
    {
        return telefone;
    }

    public void SetTelefone(string value)
    {
        telefone = value;
    }
}
