using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pokemon.Data;
using pokemon.Models;

namespace pokemon.Controllers
{
    public class Pokemon: Controller
    {
        // added this below to make a direct connection from my db context to my controller
        private readonly ApplicationDbContext _context; 

        public Pokemon(ApplicationDbContext context)
        {
            _context = context;
        }

        //***********************Display***************************

        public IActionResult ViewPosts()
        {
            return View(_context);
        }

        public IActionResult pokeDetails(int pokeId)
        {
            PokemonModel foundPoke = _context.pokeList.FirstOrDefault(pokeDetails => pokeDetails.id == pokeId);
            return View(foundPoke);
        }

        //**************************Add****************************

        public IActionResult addPOke(PokemonModel newPoke)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newPoke);
                _context.SaveChanges();
                return RedirectToAction("ViewPosts");
            }
            else{
                return Content("Not Valid")
            }
        }

        public IActionResult addPokeForm(
            {
                return View();
            }
        )

        //********************Edit***************************
    _
     }
    }