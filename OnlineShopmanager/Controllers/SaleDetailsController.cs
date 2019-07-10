using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineShopmanager.Data;
using OnlineShopmanager.Models;

namespace OnlineShopmanager.Controllers
{
    [Authorize]
    public class SaleDetailsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SaleDetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SaleDetails
        public async Task<IActionResult> Index(string transactionid)
        {
            var holdme = new List<SaleDetail>();
            if (transactionid!=null)
            {
                var convertToString = transactionid.ToString();
                var salesdetails = await _context.SalesDetails.AsNoTracking().ToListAsync();
                foreach (var item in salesdetails)
                {
                    if (item.TransactionID.ToString().Contains(transactionid))
                    {
                        holdme.Add(item);
                    }
                }

                return View(holdme);
            }
            else
            {
                return View(await _context.SalesDetails.ToListAsync());
            }
           
        }

        // GET: SaleDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saleDetail = await _context.SalesDetails
                .FirstOrDefaultAsync(m => m.ID == id);
            if (saleDetail == null)
            {
                return NotFound();
            }

            return View(saleDetail);
        }

        // GET: SaleDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SaleDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,TransactionID,ProductName,Quantity,Amount")] SaleDetail saleDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(saleDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(saleDetail);
        }

        // GET: SaleDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saleDetail = await _context.SalesDetails.FindAsync(id);
            if (saleDetail == null)
            {
                return NotFound();
            }
            return View(saleDetail);
        }

        // POST: SaleDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,TransactionID,ProductName,Quantity,Amount")] SaleDetail saleDetail)
        {
            if (id != saleDetail.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(saleDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SaleDetailExists(saleDetail.ID))
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
            return View(saleDetail);
        }

        // GET: SaleDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saleDetail = await _context.SalesDetails
                .FirstOrDefaultAsync(m => m.ID == id);
            if (saleDetail == null)
            {
                return NotFound();
            }

            return View(saleDetail);
        }

        // POST: SaleDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var saleDetail = await _context.SalesDetails.FindAsync(id);
            _context.SalesDetails.Remove(saleDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SaleDetailExists(int id)
        {
            return _context.SalesDetails.Any(e => e.ID == id);
        }
    }
}
