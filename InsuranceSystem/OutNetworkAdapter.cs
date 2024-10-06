using System;

namespace Unit5_AdapterPatternPatient_Blazor.InsuranceSystem
{
    public class OutNetworkAdapter : InsuranceInterface
    {
        OutNetworkPatient onp;
        //Constuctor
        public OutNetworkAdapter(string newName, int newPolicyNumber) {onp = new OutNetworkPatient(newName, newPolicyNumber);}

        public bool IsCovered(string patientName, string policyNumber)
        {
            int pNum = int.Parse(policyNumber);
            return onp.IsCovered(patientName, pNum).Equals("yes"); //why does isCovered return a string??????
        }

        public decimal CoverageAmount(int ProcedureID, decimal ProcedureCost)
        {
            return ProcedureID * ProcedureCost;
        }

        public string getPatientName()
        {
            return onp.getPatientName();
        }

        public string getPolicyNumber()
        {
            return onp.PolicyNumber.ToString();
        }
    }
}
