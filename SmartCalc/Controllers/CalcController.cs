using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace SmartCalc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {
        private readonly IMemoryCache _cache;
        public CalcController(IMemoryCache _cache)
        {
            this._cache = _cache;
        }

        [HttpPost]
        public IActionResult calc ([FromBody]Payload obj)
        {

           // Object o;
            if (_cache.TryGetValue(obj, out object val))
                return Ok(val.ToString());
            MethodInfo method = typeof(Calulator).GetMethod(obj.Operator.ToLower());
            if (method==null)//method not valid or devide in zero
                return BadRequest();
             Object o= method.Invoke(this,new object[] { obj.Left, obj.Right });
            _cache.Set(obj, o);
            return Ok(o.ToString());
        }



    }



}
