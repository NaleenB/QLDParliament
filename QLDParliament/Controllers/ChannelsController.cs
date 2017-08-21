using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QLDParliament.Models;

namespace QLDParliament.Controllers
{
    public class ChannelsController : Controller
    {
        private readonly QLDParliamentContext _context;

        public ChannelsController()
        {
            _context = new QLDParliamentContext();
        }

        // GET: Channels
        public IActionResult Index()
        {
            return View(_context.Channel);
        }

        // GET: Channels/Details/5
        public IActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var channel = _context.Channel.FirstOrDefault(m => m.ID == id);
            if (channel == null)
            {
                return NotFound();
            }

            return View(channel);
        }

        // GET: Channels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Channels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Date,ID,Programme,Category")] Channel channel)
        {
            if (ModelState.IsValid)
            {
                _context.Channel.Add(channel);
                return RedirectToAction(nameof(Index));
            }
            return View(channel);
        }

        // GET: Channels/Edit/5
        public IActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var channel = _context.Channel.FirstOrDefault(m => m.ID == id);
            if (channel == null)
            {
                return NotFound();
            }
            return View(channel);
        }

        // POST: Channels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(string id, [Bind("Date,ID,Programme,Category")] Channel channel)
        {
            if (id != channel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //update operation
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChannelExists(channel.ID))
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
            return View(channel);
        }

        // GET: Channels/Delete/5
        public IActionResult Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var channel = _context.Channel.FirstOrDefault(m => m.ID == id);
            if (channel == null)
            {
                return NotFound();
            }

            return View(channel);
        }

        // POST: Channels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(string id)
        {
            var channel = _context.Channel.FirstOrDefault(m => m.ID == id);
            _context.Channel.Remove(channel);
            return RedirectToAction(nameof(Index));
        }

        private bool ChannelExists(string id)
        {
            return _context.Channel.Any(e => e.ID == id);
        }
    }
}
