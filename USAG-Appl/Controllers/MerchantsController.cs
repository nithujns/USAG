using EntityFramework.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using USAG_Appl.DAL;
using USAG_Appl.Models;

namespace USAG_Appl.Controllers
{
    public class MerchantsController : Controller
    {
        private MerchantContext db = new MerchantContext();

        // GET: Merchants
        public ActionResult Index()
        {
            return View(db.Merchants.ToList());
        }

        // GET: Merchants/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Merchant merchant = db.Merchants.Find(id);
            if (merchant == null)
            {
                return HttpNotFound();
            }
            return View(merchant);
        }

        // GET: Merchants/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Merchants/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Email_ApplcationType,Pin,GrossYearlyDebitSalesVolume,AverageTicket,HighestTicketAmount,PinDebitVolumeDiscount,PinDebitTrans,AmountofSurcharge,EBTVolumeDiscount,EBTTransFee,MonthlyComplianceFee,MonthlyStatementFee,MonthlyMinimum,ChargeBack,dbaName,legalName,legalAddress,LocstreetAddress,corporatePhone,merchantEmail,merchantname_taxreturn,federalTaxID,merchantwebsite,corporateFax,dbaPhone,dbaFax,warrantyName,warrantyAddress,streetAddress2")] Merchant merchant)
        {
            if (ModelState.IsValid)
            {
                merchant.ID = Guid.NewGuid();
                db.Merchants.Add(merchant);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(merchant);
        }

        // GET: Merchants/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Merchant merchant = db.Merchants.Find(id);
            if (merchant == null)
            {
                return HttpNotFound();
            }
            return View(merchant);
        }

        // POST: Merchants/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Email_ApplcationType,Pin,GrossYearlyDebitSalesVolume,AverageTicket,HighestTicketAmount,PinDebitVolumeDiscount,PinDebitTrans,AmountofSurcharge,EBTVolumeDiscount,EBTTransFee,MonthlyComplianceFee,MonthlyStatementFee,MonthlyMinimum,ChargeBack,dbaName,legalName,legalAddress,LocstreetAddress,corporatePhone,merchantEmail,merchantname_taxreturn,federalTaxID,merchantwebsite,corporateFax,dbaPhone,dbaFax,warrantyName,warrantyAddress,streetAddress2")] Merchant merchant)
        {
            if (ModelState.IsValid)
            {
                db.Entry(merchant).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(merchant);
        }

        // GET: Merchants/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Merchant merchant = db.Merchants.Find(id);
            if (merchant == null)
            {
                return HttpNotFound();
            }
            return View(merchant);
        }

        // POST: Merchants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Merchant merchant = db.Merchants.Find(id);
            db.Merchants.Remove(merchant);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Test1()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Test1([Bind(Include = "ID,Email_ApplcationType,Pin,GrossYearlyDebitSalesVolume,AverageTicket,HighestTicketAmount,PinDebitVolumeDiscount,PinDebitTrans,AmountofSurcharge,EBTVolumeDiscount,EBTTransFee,MonthlyComplianceFee,MonthlyStatementFee,MonthlyMinimum,ChargeBack,dbaName,legalName,legalAddress,LocstreetAddress,corporatePhone,merchantEmail,merchantname_taxreturn,federalTaxID,merchantwebsite,corporateFax,dbaPhone,dbaFax,warrantyName,warrantyAddress,streetAddress2")] Merchant merchant)
        {
            if (ModelState.IsValid)
            {
                merchant.ID = Guid.NewGuid();
                db.Merchants.Add(merchant);
                db.SaveChanges();
                Guid id = merchant.ID;
                merchant = new Merchant() { ID = id };
                return RedirectToAction("Test2", merchant);
            }

            return View(merchant);
        }

        public ActionResult Test2(Merchant merchant)
        {
            return View("Test2", merchant);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult submitTest2([Bind(Include = "ID,Email_ApplcationType,Pin,GrossYearlyDebitSalesVolume,AverageTicket,HighestTicketAmount,PinDebitVolumeDiscount,PinDebitTrans,AmountofSurcharge,EBTVolumeDiscount,EBTTransFee,MonthlyComplianceFee,MonthlyStatementFee,MonthlyMinimum,ChargeBack,dbaName,legalName,legalAddress,LocstreetAddress,corporatePhone,merchantEmail,merchantname_taxreturn,federalTaxID,merchantwebsite,corporateFax,dbaPhone,dbaFax,warrantyName,warrantyAddress,streetAddress2")] Merchant merchant)
        {
            if (ModelState.IsValid)
            {
                db.Entry(merchant).State = EntityState.Modified;
                //Merchant dbMerchant = db.Merchants.Where(m=>m.ID == merchant.ID).FirstOrDefault();
                db.Merchants.Where(x => x.ID == merchant.ID).Update(m => new Merchant()
                {
                    legalName = merchant.legalName,
                    dbaName = merchant.dbaName
                });
                //db.SaveChanges();
                Guid id = merchant.ID;
                return RedirectToAction("Details", id);
            }
            return View(merchant);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
