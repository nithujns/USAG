using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using USAG_Appl.Models;

namespace USAG_Appl.DAL
{
    public class MerchantInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MerchantContext>
    {
        protected override void Seed(MerchantContext context)
        {
            var merchants = new List<Merchant>
            {
                new Merchant{ Email_ApplcationType = "test@test.com", Pin = "0", GrossYearlyDebitSalesVolume = "150", AverageTicket = "45.00", HighestTicketAmount = "450.00",
                PinDebitVolumeDiscount = "4", PinDebitTrans = ".06", AmountofSurcharge = "3", EBTVolumeDiscount = "8", EBTTransFee = ".10", MonthlyComplianceFee = "15", MonthlyStatementFee = "20",
                MonthlyMinimum = "20", ChargeBack = "45", dbaName = "Liberty X", legalName = "Liberty X", legalAddress = "29883 Santa Margarita Pkwy", LocstreetAddress = "3535 10th street",
                corporatePhone = "8666518724", merchantEmail = "kyle.elder@usag-inc.com", merchantname_taxreturn = "Liberty X", federalTaxID = "12-345678", merchantwebsite="www.usag-inc.com",
                corporateFax = "9097617902", dbaPhone = "9097317903", dbaFax = "9097317904", warrantyName = "Test Warranty", warrantyAddress = "4050 10th street", streetAddress2 = ""},
                new Merchant{ Email_ApplcationType = "kyle@test.com", Pin = "1", GrossYearlyDebitSalesVolume = "100", AverageTicket = "30.00", HighestTicketAmount = "350.00",
                PinDebitVolumeDiscount = "8", PinDebitTrans = ".08", AmountofSurcharge = "3", EBTVolumeDiscount = "10", EBTTransFee = ".12", MonthlyComplianceFee = "20", MonthlyStatementFee = "25",
                MonthlyMinimum = "25", ChargeBack = "50", dbaName = "Check Smart", legalName = "Check Smart", legalAddress = "12345 Santa Margarita Pkwy", LocstreetAddress = "4545 12th street",
                corporatePhone = "12365187512", merchantEmail = "Nithya.Caesar@usag-inc.com", merchantname_taxreturn = "Check Smart", federalTaxID = "87-654321", merchantwebsite="www.usag-inc-dev.com",
                corporateFax = "9097617000", dbaPhone = "9097617001", dbaFax = "9097617002", warrantyName = "Geico", warrantyAddress = "4050 Geico street", streetAddress2 = "" }
            };

            merchants.ForEach(m => context.Merchants.Add(m));
            context.SaveChanges();
        }
    }
}