Cmm paid to expiry - today
Cmm expiry on cancel screen
automatically changing radio button
sp cancel screen for expiry policy



saleDto.AllowRenewal = Constants.AllowRenewals
                        && saleDto.ExistingSmartBreakdownPolicy != null //if they don't have a smart breakdown policy 
                        && saleDto.TotalSBArrears == 0 && !(saleDto.Entitlements.Any() && saleDto.Entitlements.All(a => a.PolicyStatusEnum == StatusTypes.Expired))
                        && ValidForRenewalPaymentType.Contains(saleDto.PolicyDetails.TransactionType.ToLower())
                        //&& (!saleDto.IsInRenewalCycle && DateTime.Now.Date < saleDto.PolicyDetails.PolicyEndDate.Value.Date)
                        &&  (!saleDto.IsInRenewalCycle && (DateTimeInjection.Now.Date > saleDto.PolicyDetails.PolicyStartDate.Value.Date && DateTimeInjection.Now.Date <= (saleDto.PolicyDetails.PolicyEndDate.Value.Date).AddDays(28)))
                        && (saleDto.ExistingSmartBreakdownPolicy.EndDate.Subtract(DateTimeInjection.Now).TotalDays <= saleDto.PreExpiryRenewalDateLimitInDays &&
                            saleDto.ExistingSmartBreakdownPolicy.EndDate.Subtract(DateTimeInjection.Now).TotalDays > saleDto.PostExpiryRenewalDateLimitInDays);

							
							"CompatibilityCheckResult":{"vehicleFoundFlag":true,"vehicleDetails":{"Make":"VAUXHALL","Model":"MERIVA CLUB","Range":"MERIVA","ModelYear":"2010","Steering":"rhd","FuelType":"PETROL"},"deviceCompatibility":[{"Device":"danlawc_dl880","Compatibility":"incompatible","InstallationDifficulty":"2"},{"Device":"trakm8_connect300","Compatibility":"compatiblewithcable","InstallationDifficulty":"3"}],"faultDetails":null,"fault":null,"InputVehicleRegistration":"EX10JXT"},"SelectedSmartBreakdownVehicle":{"Registration":"EX10JXT","Make":"VAUXHALL","Model":"MERIVA CLUB","Identification":null,"YearOfManufacture":"2010-01-01T00:00:00","RegistrationDate":null,"Mileage":null,"OffRisk":null,"OnRisk":null,"ParentVehicle":null,"engineType":"PETROL"},
							
							
INC001240372 	-  While receiving response from UES we are getting "AA SAP Instalment Account" in detailsResponse.Contact.PaymentMethod but it should've been 
					I think that issue is with Tiara not sending the correct Payment Method in the Contact Model.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the simpleArraySum function below.
     */
    static int simpleArraySum(int[] ar) {
        /*
         * Write your code here.
         */
         int sum=0;
         foreach(int num in ar)
         {
             sum=sum+num;
         }

        return sum;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = simpleArraySum(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
					"Continuous Monthly Membership". However we are receiving correct info in TransactionType in <RoadPolicyDetails> model,