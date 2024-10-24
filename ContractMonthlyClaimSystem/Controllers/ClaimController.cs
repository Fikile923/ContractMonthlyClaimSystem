using ContractMonthlyClaimSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ContractMonthlyClaimSystem.Controllers
{
    public class ClaimController : Controller
    {
        // Mock database for storing claims
        private static List<Claim> Claims = new List<Claim>();

        // GET: Claim/Index
        public IActionResult Index()
        {
            return View(Claims);
        }

        // GET: Claim/Submit
        public IActionResult Submit()
        {
            return View();
        }

        // POST: Claim/Submit
        [HttpPost]
        public IActionResult Submit(Claim claim)
        {
            if (ModelState.IsValid)
            {
                claim.Total = claim.Rate; // Simplified total calculation for now
                Claims.Add(claim);
                return RedirectToAction("Index");
            }

            return View(claim);
        }

        // GET: Claim/Approve
        public IActionResult Approve()
        {
            return View(Claims);
        }

        // POST: Claim/Approve
        [HttpPost]
        public IActionResult Approve(int claimId, bool approve)
        {
            var claim = Claims.Find(c => c.ClaimId == claimId);
            if (claim != null)
            {
                claim.Status = approve ? "Approved" : "Rejected";
            }
            return RedirectToAction("Approve");
        }

    }
}
