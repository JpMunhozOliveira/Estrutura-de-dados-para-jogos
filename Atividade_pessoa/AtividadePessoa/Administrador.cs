using System;
using System.Collections.Generic;

public class Administrador : Empregado
{
    private double ajudaCusto;

    public new double calcularSalario()
    {
        double salarioLiquido = base.calcularSalario() + GetAjudaCusto();
        return salarioLiquido;
    }

    public double GetAjudaCusto()
    {
        return ajudaCusto;
    }

    public void SetAjudaCusto(double value)
    {
        ajudaCusto = value;
    }
}
