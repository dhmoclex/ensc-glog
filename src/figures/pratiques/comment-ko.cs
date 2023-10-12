// Vérifier si l'employé peut bénéficier de tous les avantages
if ((employee.flags & HOURLY_FLAG) &&
    (employee.age > 65))
  ...