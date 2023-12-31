﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductService.Models.DTOs;
using ProductService.Services.IServices;

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProduct _product;
        private readonly IMapper _mapper;
        private readonly ResponseDTO _response;
        public ProductController(IProduct product, IMapper mapper)
        {
            _mapper = mapper;
            _product = product;
            _response = new ResponseDTO();
        }

        [HttpPost]
        public Task<ActionResult<ResponseDTO>> AddProduct(AddProductDTO addProductDTO)
        {

        }
    }

}
