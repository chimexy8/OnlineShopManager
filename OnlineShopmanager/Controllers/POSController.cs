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
    public class POSController : Controller
    {
        private readonly ApplicationDbContext _context;
        Random random = new Random();
       
        public POSController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: POS
        public async Task<IActionResult> Index()
        {
            var rand = random.Next().ToString();
            var categories = _context.Categories.OrderBy(s=>s.CategoryName);
            ViewData["CategoryID"] = new SelectList(categories, "CategoryName", "CategoryName");
            var customers = _context.Customers.OrderBy(s => s.CustomerName);
            ViewData["Customers"] = new SelectList(customers, "ID", "CustomerName");
            ViewData["TransactionID"] = rand;

            return View(await _context.POS.ToListAsync());
        }
        [HttpPost]
        [AllowAnonymous]
        public JsonResult  DropDownVal1([FromBody]AjaxModel val)
        {
            var product = _context.Products.Where(p => p.ProductName == val.CategoryName).ToList();
            return Json(product);

        }

        [HttpPost]
        [AllowAnonymous]
        public JsonResult DropDownVal([FromBody]AjaxModel val)
        {
            var product = _context.Products.Where(p => p.CategoryName == val.CategoryName).ToList();
            return Json(product);

        }

        [HttpPost]
        [AllowAnonymous]
        public JsonResult Saver([FromBody]POS order)
        {

            if (order!=null)
            {
                _context.POS.Add(order);
                var productreorderlevel = _context.Products.Where(s => s.ProductName == order.ProductName).ToList();
                foreach (var item in productreorderlevel)
                {
                    item.ReorderLevel -= order.Quantity;
                }
                _context.SaveChangesAsync();
                return Json(order);
            }

            return Json(order);
            
            


        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ClearandRefresh()
        {
            var pos = _context.POS;
            foreach (var item in pos)
            {
                pos.Remove(item);
               
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
       

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> SdSaver([FromBody]SaleDetail order)
        {
            if (order != null)
            {
                _context.SalesDetails.Add(order);
                await _context.SaveChangesAsync();
            }
            return View();
        }


        [HttpPost]
        [AllowAnonymous]

        public async Task<IActionResult> Printer([FromBody]Sale order)
        {
            if (order != null)
            {
                order.Date = DateTime.Now;
                _context.Sales.Add(order);
                var customer = _context.Customers.Where(p => p.CustomerName == order.CustomerName);
                foreach (var item in customer)
                {
                    if (customer!=null)
                    {
                        var newpayment = item.payments + order.Amountpaid;
                        item.payments = newpayment;
                        var newbalance = item.Balance + order.Balance;
                        item.Balance = newbalance;
                    }

                   
                }
             
                await _context.SaveChangesAsync();
            }
            return View();
        }



        // GET: POS/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pOS = await _context.POS
                .FirstOrDefaultAsync(m => m.ID == id);
            if (pOS == null)
            {
                return NotFound();
            }

            return View(pOS);
        }

        // GET: POS/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: POS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ProductName,Quantity,Amount")] POS pOS)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pOS);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pOS);
        }

        // GET: POS/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pOS = await _context.POS.FindAsync(id);
            if (pOS == null)
            {
                return NotFound();
            }
            return View(pOS);
        }

        // POST: POS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ProductName,Quantity,Amount")] POS pOS)
        {
            if (id != pOS.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pOS);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!POSExists(pOS.ID))
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
            return View(pOS);
        }

        // GET: POS/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pOS = await _context.POS
                .FirstOrDefaultAsync(m => m.ID == id);
            if (pOS == null)
            {
                return NotFound();
            }

            return View(pOS);
        }

        // POST: POS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pOS = await _context.POS.FindAsync(id);
            _context.POS.Remove(pOS);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool POSExists(int id)
        {
            return _context.POS.Any(e => e.ID == id);
        }
    }
}
