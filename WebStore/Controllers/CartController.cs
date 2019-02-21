﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebStore.Infrastructure.Interfaces;

namespace MyWebStore.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService _cartService;

        public IActionResult Details()
        {
            return View(_cartService.TransformCart());
        }
        public IActionResult DecrementFromCart(int id)
        {
            _cartService.DecrementFromCart(id);
            return RedirectToAction("Details");
        }

        public IActionResult RemoveFromCart(int id)
        {
            _cartService.RemoveFromCart(id);
            return RedirectToAction("Details");
        }

        public IActionResult RemoveAll()
        {
            _cartService.RemoveAll();
            return RedirectToAction("Details");
        }

        public IActionResult AddToCart(int id, string ReturnUrl)
        {
            _cartService.AddToCart(id);

            return Redirect(ReturnUrl);
        }


    }
}