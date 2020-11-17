using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Dim_Dat_Pro_2._0.Models.Entities;

namespace Dim_Dat_Pro_2._0.Controllers
{
    public class Cmpg323Project2DatasetController : Controller
    {
        private readonly CMPG323_Project2_datasetContext _context;

        public Cmpg323Project2DatasetController(CMPG323_Project2_datasetContext context)
        {
            _context = context;
        }

        // GET: Cmpg323Project2Dataset
        public async Task<IActionResult> Index(string filterString)
        {
            var record = from r in _context.Cmpg323Project2Datasets select r;
            if (!String.IsNullOrEmpty(filterString))
            {
                record = record.Where(r => r.Department.Contains(filterString));
            }         
            return View(await record.ToListAsync());
        }

        // GET: Cmpg323Project2Dataset/Details/5
        public async Task<IActionResult> Details(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cmpg323Project2Dataset = await _context.Cmpg323Project2Datasets
                .FirstOrDefaultAsync(m => m.EmployeeNumber == id);
            if (cmpg323Project2Dataset == null)
            {
                return NotFound();
            }

            return View(cmpg323Project2Dataset);
        }

        // GET: Cmpg323Project2Dataset/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cmpg323Project2Dataset/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Age,Attrition,BusinessTravel,DailyRate,Department,DistanceFromHome,Education,EducationField,EmployeeCount,EmployeeNumber,EnvironmentSatisfaction,Gender,HourlyRate,JobInvolvement,JobLevel,JobRole,JobSatisfaction,MaritalStatus,MonthlyIncome,MonthlyRate,NumCompaniesWorked,Over18,OverTime,PercentSalaryHike,PerformanceRating,RelationshipSatisfaction,StandardHours,StockOptionLevel,TotalWorkingYears,TrainingTimesLastYear,WorkLifeBalance,YearsAtCompany,YearsInCurrentRole,YearsSinceLastPromotion,YearsWithCurrManager")] Cmpg323Project2Dataset cmpg323Project2Dataset)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cmpg323Project2Dataset);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cmpg323Project2Dataset);
        }

        // GET: Cmpg323Project2Dataset/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cmpg323Project2Dataset = await _context.Cmpg323Project2Datasets.FindAsync(id);
            if (cmpg323Project2Dataset == null)
            {
                return NotFound();
            }
            return View(cmpg323Project2Dataset);
        }

        // POST: Cmpg323Project2Dataset/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("Age,Attrition,BusinessTravel,DailyRate,Department,DistanceFromHome,Education,EducationField,EmployeeCount,EmployeeNumber,EnvironmentSatisfaction,Gender,HourlyRate,JobInvolvement,JobLevel,JobRole,JobSatisfaction,MaritalStatus,MonthlyIncome,MonthlyRate,NumCompaniesWorked,Over18,OverTime,PercentSalaryHike,PerformanceRating,RelationshipSatisfaction,StandardHours,StockOptionLevel,TotalWorkingYears,TrainingTimesLastYear,WorkLifeBalance,YearsAtCompany,YearsInCurrentRole,YearsSinceLastPromotion,YearsWithCurrManager")] Cmpg323Project2Dataset cmpg323Project2Dataset)
        {
            if (id != cmpg323Project2Dataset.EmployeeNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cmpg323Project2Dataset);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Cmpg323Project2DatasetExists(cmpg323Project2Dataset.EmployeeNumber))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cmpg323Project2Dataset);
        }

        // GET: Cmpg323Project2Dataset/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cmpg323Project2Dataset = await _context.Cmpg323Project2Datasets
                .FirstOrDefaultAsync(m => m.EmployeeNumber == id);
            if (cmpg323Project2Dataset == null)
            {
                return NotFound();
            }

            return View(cmpg323Project2Dataset);
        }

        // POST: Cmpg323Project2Dataset/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            var cmpg323Project2Dataset = await _context.Cmpg323Project2Datasets.FindAsync(id);
            _context.Cmpg323Project2Datasets.Remove(cmpg323Project2Dataset);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Cmpg323Project2DatasetExists(decimal id)
        {
            return _context.Cmpg323Project2Datasets.Any(e => e.EmployeeNumber == id);
        }
    }
}
