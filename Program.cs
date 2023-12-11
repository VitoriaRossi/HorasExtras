double SalarioFinal(double salarioHora, double horasTotais, double horasExtras) {
  return (salarioHora * (horasTotais - horasExtras)) + (salarioHora * horasExtras * 1.4);
}

Console.WriteLine($"Se o salário por hora for R$ {12:N2}, trabalhando {360} horas, sendo {0} horas-extra, o salário será R$ {SalarioFinal(12, 360, 0):N2}");
Console.WriteLine($"Se o salário por hora for R$ {50:N2}, trabalhando {200} horas, sendo {10} horas-extra, o salário será R$ {SalarioFinal(50, 200, 10):N2}");