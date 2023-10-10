public class Patient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime DateOfBirth { get; set; }

    public List<Doctor> Doctors { get; set; }
    public List<TreatmentPlan> TreatmentPlans { get; set; }
}

public class Doctor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Specialty { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }

    public List<Patient> Patients { get; set; }
    public List<TreatmentPlan> TreatmentPlans { get; set; }
}

public class Lab
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }

    public List<Test> Tests { get; set; }
}

public class Pharmacy
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }

    public List<Treatment> Treatments { get; set; }
}

public class TreatmentPlan
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public Patient Patient { get; set; }
    public Doctor Doctor { get; set; }
    public List<Treatment> Treatments { get; set; }
}

public class Treatment
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Dosage { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public Pharmacy Pharmacy { get; set; }
    public TreatmentPlan TreatmentPlan { get; set; }
}

public class Test
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public Lab Lab { get; set; }
    public TreatmentPlan TreatmentPlan { get; set; }
}
