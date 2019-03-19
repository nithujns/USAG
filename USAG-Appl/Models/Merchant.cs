using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace USAG_Appl.Models
{
    public class Merchant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        //Application Type
        [DisplayName("Email Address")]
        public string Email_ApplcationType { get; set; }

        [DisplayName("Pin")]
        public string Pin { get; set; }

        [DisplayName("Gross Yearly Debit Sales Volume")]
        public string GrossYearlyDebitSalesVolume { get; set; }

        [DisplayName("Average Ticket")]
        public string AverageTicket { get; set; }

        [DisplayName("Highest Ticket Amount")]
        public string HighestTicketAmount { get; set; }

        //Pin Based Transaction
        [DisplayName("Pin Debit Volume Discount")]
        public string PinDebitVolumeDiscount { get; set; }

        [DisplayName("Pin Debit trans(Per Attempt)")]
        public string PinDebitTrans { get; set; }

        [DisplayName("Amount of Surcharge")]
        public string AmountofSurcharge { get; set; }

        [DisplayName("EBT Volume Discount(Per Item)")]
        public string EBTVolumeDiscount { get; set; }

        [DisplayName("EBT Trans Fee(Per Attempt)")]
        public string EBTTransFee { get; set; }

        [DisplayName("Monthly Compliance Fee")]
        public string MonthlyComplianceFee { get; set; }

        [DisplayName("Monthly Statement Fee")]
        public string MonthlyStatementFee { get; set; }

        [DisplayName("Monthly Minimum")]
        public string MonthlyMinimum { get; set; }

        [DisplayName("Chargeback")]
        public string ChargeBack { get; set; }
        //End OF Pin Based Transactions


        //Pinless Based Transaction
        [DisplayName("Volume Discount")]
        public string VolumeDiscount { get; set; }

        [DisplayName("Auth Fee")]
        public string AuthFee { get; set; }

        [DisplayName("Trans Fee (Per attempt)")]
        public string TransFee { get; set; }

        [DisplayName("Push(Credit)")]
        public string PushCredit { get; set; }

        [DisplayName("Chargeback Fee")]
        public string ChargebackFee { get; set; }

        [DisplayName("Gateway Setup Fee(One-Time)")]
        public string GatewaySetupFee { get; set; }

        [DisplayName("Monthly Gateway Fee")]
        public string MonthlyGatewayFee { get; set; }

        [DisplayName("Application Fee")]
        public string ApplicationFee { get; set; }

        //End of Pinless Transaction

        //Setup Page 

        [DisplayName("Cust#")]
        public string CustomerNumber { get; set; }

     
        //Non-Taxable Items
        [DisplayName("Encryption Fee")]
        public string EncryptionFee { get; set; }

        [DisplayName("Wireless Activation Fee")]
        public string WirelessActivationFee { get; set; }

        [DisplayName("")]
        public string QtyApplicationFee { get; set; }
               
        [DisplayName("")]
        public string UPApplicationFee { get; set; }

        [DisplayName("")]
        public string AmtApplicationFee { get; set; }

        [DisplayName("")]
        public string QtyEncryptionFee { get; set; }

        [DisplayName("")]
        public string UPEncryptionFee { get; set; }

        [DisplayName("")]
        public string AmtEncryptionFee { get; set; }

        [DisplayName("")]
        public string QtyWirelessActivaionFee { get; set; }

        [DisplayName("")]
        public string UPWirelessActivaionFee { get; set; }

        [DisplayName("")]
        public string AmtWirelessActivaionFee { get; set; }

        //Taxable Items
        [DisplayName("Z11 Terminal")]
        public string Z11Terminal { get; set; }

        [DisplayName("Z9 Terminal")]
        public string Z9Terminal { get; set; }

        [DisplayName("Z6 Pinpad")]
        public string Z6Pinpad { get; set; }

        [DisplayName("Z3 Pinpad")]
        public string Z3Pinpad { get; set; }

        [DisplayName("Tax")]
        public string Tax { get; set; }

        [DisplayName("Sub Total Taxable Items")]
        public string SubTotalTaxableItems { get; set; }

        [DisplayName("Balance Due")]
        public string BalanceDue { get; set; }

        [DisplayName("Who is responsible for Payment : ")]
        public string WhoisResponsibleForPayment { get; set; }

        [DisplayName("")]
        public string PayTypeACH { get; set; }

        [DisplayName("")]
        public string PayCreditCard { get; set; }

        [DisplayName("")]
        public string PayTypeCheck { get; set; }

        [DisplayName("")]
        public string MerchantResponsible { get; set; }

        [DisplayName("")]
        public string RepResponsible { get; set; }

        [DisplayName("Select Payment Type : ")]
        public string SelectPaymentType { get; set; }

        [DisplayName("")]
        public string PurchaseZ11Terminal { get; set; }

        [DisplayName("")]
        public string RentZ11Terminal { get; set; }

        [DisplayName("")]
        public string reproOwnZ11Terminal { get; set; }

        [DisplayName("")]
        public string QtyZ11Terminal { get; set; }

        [DisplayName("")]
        public string UPZ11Terminal { get; set; }

        [DisplayName("")]
        public string AmtZ11Terminal { get; set; }

        [DisplayName("")]
        public string PurchaseZ9Terminal { get; set; }

        [DisplayName("")]
        public string RentZ9Terminal { get; set; }

        [DisplayName("")]
        public string reproOwnZ9Terminal { get; set; }

        [DisplayName("")]
        public string QtyZ9Terminal { get; set; }

        [DisplayName("")]
        public string UPZ9Terminal { get; set; }

        [DisplayName("")]
        public string AmtZ9Terminal { get; set; }

        [DisplayName("")]
        public string PurchaseZ6Pinpad { get; set; }

        [DisplayName("")]
        public string RentZ6Pinpad { get; set; }

        [DisplayName("")]
        public string reproOwnZ6Pinpad { get; set; }

        [DisplayName("")]
        public string QtyZ6Pinpad { get; set; }

        [DisplayName("")]
        public string UPZ6Pinpad { get; set; }

        [DisplayName("")]
        public string AmtZ6Pinpad { get; set; }

        [DisplayName("")]
        public string PurchaseZ3Pinpad { get; set; }

        [DisplayName("")]
        public string RentZ3Pinpad { get; set; }

        [DisplayName("")]
        public string reproOwnZ3Pinpad { get; set; }

        [DisplayName("")]
        public string QtyZ3Pinpad { get; set; }

        [DisplayName("")]
        public string UPZ3Pinpad { get; set; }

        [DisplayName("")]
        public string AmtZ3Pinpad { get; set; }

        // End of Setup Page

        [DisplayName("DBA Name")]
        public string dbaName { get; set; }

        [DisplayName("Merchant Legal Name")]
        public string legalName { get; set; }
        
        [DisplayName("Merchant Legal Address            (City)                      (State)         (Zip)")]
        public string legalAddress { get; set; }

        [DisplayName("Location Street Address            (City)                      (State)         (Zip)")]
        public string LocstreetAddress { get; set; }

        [DisplayName("Corporate Phone")]
        public string corporatePhone { get; set; }

        [DisplayName("Email")]
        public string merchantEmail { get; set; }

        [DisplayName("Legal Name as it appears on Merchant's tax return")]
        public string merchantname_taxreturn { get; set; }

        [DisplayName("Federal Tax ID")]
        public string federalTaxID { get; set; }

        [DisplayName("Website")]
        public string merchantwebsite { get; set; }


        [DisplayName("Corporate Fax")]
        public string corporateFax { get; set; }

        [DisplayName("DBA Phone")]
        public string dbaPhone { get; set; }

        [DisplayName("DBA Fax")]
        public string dbaFax { get; set; }

        [DisplayName("Name")]
        public string warrantyName { get; set; }

        [DisplayName("Address")]
        public string warrantyAddress { get; set; }

        [DisplayName("Location Street Address")]
        public string streetAddress2 { get; set; }
    }
}