{"payerType":"MPH","customer":{"commsPreference":"PAPER","title":"Ms","firstName":"T","lastName":"GOMVYBVWC","emailAddress":"","initials":"","cmdPartyId":"1501967"},"policy":{"membershipNumber":"6356011156402904","startDate":"2020-01-16","endDate":"2021-01-15","coverType":"SINGLE","caseId":"NOT APPLICABLE","transactionType":"RENEWAL","source":"CONTACT_CENTRE","policyAdmin":"TIARA","saleDate":"2020-01-17T10:25:06Z"},"price":{"roadPrice":59.0,"roadTax":0.0,"carGeniePrice":49.0,"carGenieTax":8.17,"carGenieTaxType":"VAT","carGenieTaxRate":20.0,"annual":49.0,"monthly":5.0,"prorata":0.0},"payment":{"method":"CARD","amount":49.0,"currency":"GBP","frequency":"Annual","transactionEffectiveDate":"2020-01-16","transactionType":"RENEWAL","cardDetails":{"transactionReference":"5E213E125CD7A189E60C0269C96F7C9F44155489;0;010016692166928","authCode":"tst230","profileId":"COM-JC-MUNNASOHKKQPWYW","orderId":"TSMxcbCyAQxEuJw","cardNumber":"5262","bankNumber":"426397","cardType":"Visa","expiryDate":"01/2020","continuousAuthority":false,"nameOnCard":"asdasd","transactionDate":"2020-01-17T10:24:00.0849031Z"}}}


saleDto.CanReactivate = saleDto.ExistingSmartBreakdownPolicy != null 
                        && saleDto.ExistingSmartBreakdownPolicy.Status == "CANCELLED"
                        && saleDto.DeviceStatus != "RETURNED"
                        && saleDto.ExistingSmartBreakdownPolicy.HasPremiumBeenRefunded
                        && (saleDto.ExistingSmartBreakdownPolicy.EndDate.Subtract(DateTime.Now).TotalDays >= saleDto.PostCancellationReactivationCycleInDays);
						
						
						@if (String.IsNullOrEmpty(Model.EmailAddress))
    {
        <div class="subheader-email">Email</div>
        <input class="input-emailAddress" type="text" asp-for="@Model.NewEmailAddress" name="NewEmailAddress" value="" placeholder="type email address here..." style="margin-bottom:25px;"/>
    }
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {
            int n = a.Length;
            int[] newArray = new int[n];

            for (int oldIndex = 0; oldIndex < n; oldIndex++)
            {
                int newIndex = (oldIndex + n - d) % n;
                newArray[newIndex] = a[oldIndex];
            }

            return newArray;
        }


    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;
        int[] result = rotLeft(a, d);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
        <span asp-validation-for="@Model.NewEmailAddress"></span>