using System;
using System.Collections.Generic;

public class Operario : Empregado
{
    private double valorProducao;
    private double comissao;

    public new double calcularSalario()
    {
        double salarioLiquido = base.calcularSalario() + (GetValorProducao() * GetComissao());
        return salarioLiquido;
    }

    public double GetValorProducao()
    {
        return valorProducao;
    }

    public void SetValorProducao(double value)
    {
        valorProducao = value;
    }

    public double GetComissao()
    {
        return comissao;
    }

    public void SetComissao(double value)
    {
        comissao = value;
    }
}