using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using models;
using System.Reflection;

namespace back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<Categoria>> GetCategorias()
        {
            return Ok(DataStore.Categorias);
        }

    }
}