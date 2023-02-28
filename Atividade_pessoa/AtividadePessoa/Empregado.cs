using System;
using System.Collections.Generic;

public class Empregado : Pessoa
{
    private int codigoSetor;
    private double salarioBase;
    private double imposto;

    public double calcularSalario()
    {
        double salarioLiquido = GetSalarioBase() - (GetSalarioBase() * GetImposto());
        return salarioLiquido;
    }

    public int GetCodigoSetor()
    {
        return codigoSetor;
    }

    public void SetCodigoSetor(int value)
    {
        codigoSetor = value;
    }

    public double GetSalarioBase()
    {
        return salarioBase;
    }

    public void SetSalarioBase(double value)
    {
        salarioBase = value;
    }

    public double GetImposto()
    {
        return imposto;
    }

    public void SetImposto(double value)
    {
        imposto = value;
    }
}
