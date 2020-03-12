@model TheAA.SmartBreakdown.DTO.SmartBreakdownSale

@{
    ViewData["Title"] = "Payment Failed";
}

<form method="post">
    <div class="content animate fadeIn one">
        <div class="box">
            <div class="header">Payment Failed</div>
            <div class="text">The payment was @Model.PaymentDetails.PaymentResult.ToString()</div>
            @if (Model.PaymentDetails.PaymentResult.ToString() == "Successful" && Model.TotalSBArrears > 0)
            {
                <div class="text">The reason for the failure was: SAP service call failed</div>
            }
            else
            {
                <div class="text">The reason for the failure was: @Model.PaymentDetails.DeclinedReason</div>
            }
            <div class="button-box">
                <div class="button-grid-3">
                    <button type="submit" class="secondary_button" asp-action="Index" asp-controller="MembershipDetails"><span>Policy details</span></button>
                </div>
                <div class="button-grid-2">
                    <button type="submit" class="secondary_button" asp-action="Index" asp-controller="Search"><span>New search</span></button>
                </div>
            </div>
        </div>
</form>
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

    // Complete the matchingStrings function below.
    static int[] matchingStrings(string[] strings, string[] queries) {


            Dictionary<string, int> Map = new Dictionary<string, int>();

            int[] Result = new int[queries.Length];
            
            for(int i = 0;i<strings.Length;i++)
            {
                string inputString = strings[i];
                if(Map.ContainsKey(inputString))
                {
                    Map[inputString] = Map[inputString] + 1;
                }
                else
                {
                    Map.Add(inputString, 1);
                }
            }

            for(int i=0;i<queries.Length;i++)
            {
                string QueryString = queries[i];
                
                if (Map.ContainsKey(QueryString))
                {
                    Result[i] = Map[QueryString]; 
                }
            }

            return Result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int stringsCount = Convert.ToInt32(Console.ReadLine());

        string[] strings = new string [stringsCount];

        for (int i = 0; i < stringsCount; i++) {
            string stringsItem = Console.ReadLine();
            strings[i] = stringsItem;
        }

        int queriesCount = Convert.ToInt32(Console.ReadLine());

        string[] queries = new string [queriesCount];

        for (int i = 0; i < queriesCount; i++) {
            string queriesItem = Console.ReadLine();
            queries[i] = queriesItem;
        }

        int[] res = matchingStrings(strings, queries);

        textWriter.WriteLine(string.Join("\n", res));

        textWriter.Flush();
        textWriter.Close();
    }
}
    </div>
		
		
		
		
		<div class="subheader">Renewal Start Date</div>
            <div class="grid-col-350px top-space move-left">
                <div class="input-group date" id="tsm-datepicker" data-provide="datepicker" data-date-format="dd M yyyy" data-date-start-date="@DateTime.Now.ToString("dd MMM yyyy")" data-date-end-date="@Model.NextRenewalDate.Value.ToString("dd MMM yyyy")" )" >
                    <input type="text" id="tsm-datedata" class="form-control" asp-for="@Model.UserSelectedSaleDate" name="UserSelectedSaleDate" min="@DateTime.Now.ToString("dd MMM yyyy")" max="@Model.NextRenewalDate.Value.ToString("dd MMM yyyy")" value="@Model.UserSelectedSaleDate?.ToString("dd MMM yyyy")">                    
                    <div class="input-group-addon">
                        <span class="glyphicon datepicker-img"></span>
                    </div>
                </div>
            </div>
            <div class="grid-col-350px">
                <div id="DatePickerValidation"></div>
            </div>