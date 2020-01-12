using blinkApi.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace blinkApi.Controllers
{
    public class BlinkController : ControllerBase
    {
        protected readonly BlinkDB _db;

        public BlinkController(BlinkDB db)
        {
            _db = db;
        }
    }
}