using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LabTestOne.Data;
using LabTestOne.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabTestOne.Controllers
{
    public class IncomeTaxController : Controller
    {
        private readonly IncomeTaxDbContext _context;

        public IncomeTaxController(IncomeTaxDbContext _context)
        {
            this._context = _context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index(IncomeTaxViewModel  model)
        {
            string utin = "";
            string tin = "";

            for (int i = 0; i < model.utin.Length; i++)
            {
                utin = utin + model.utin[i];

            }
            for (int j = 0; j < model.tin.Length; j++)
            {
                tin = tin + model.tin[j];
            }

            IncomeTax incomeTax = new IncomeTax
            {
                nameOfAsse = model.nameOfAsse,
                nid = model.nid,
                utin = utin,
                tin = tin,
                circel = model.circel,
                taxZone = model.taxZone,
                asseYear = model.asseYear,
                isResident = model.isResident,
                familyStatus = model.familyStatus,
                nameOFEmployee = model.nameOFEmployee,
                husbandORWife = model.husbandORWife,
                father = model.father,
                mother = model.mother,
                dateOFBirth = model.dateOFBirth,
                presentAddress = model.presentAddress,
                prmanentAddress = model.prmanentAddress,
                mobileOffice = model.mobileOffice,
                residential = model.residential,
                vatRegistrationNo = model.vatRegistrationNo

            };

            await _context.IncomeTaxes.AddAsync(incomeTax);
            await _context.SaveChangesAsync();

            return Json(_context.IncomeTaxes.ToList());
        }

        public IActionResult RePracticePge01()
        {
            return View();
        }
    }
}