using Activity7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Activity7.Controllers
{
    public class GameController : Controller
    {
        // GET: Display Main Game Board Page
        [HttpGet]
        public ActionResult Index()
        {
            return View("GameBoard");
        }

        // POST: On Select of Game Button (AJAX Form with Partial View)
        [HttpPost]
        public PartialViewResult OnSelectGamePiece(string gpValue)
        {
            return PartialView("_GameBoard");
        }

        // POST: Get all the Game Board updates from this Controller method
        [HttpPost]
        public string GetMoreInfo(string gpValue)
        {
            // Create some Game Pieces around Game Piece 4 in the middle with all with random values
            List<GamePieceModel> pieces = new List<GamePieceModel>();
            pieces.Add(new GamePieceModel(0, DateTime.Now.Millisecond & 0x03));
            Thread.Sleep(10);
            pieces.Add(new GamePieceModel(1, DateTime.Now.Millisecond & 0x03));
            Thread.Sleep(10);
            pieces.Add(new GamePieceModel(2, DateTime.Now.Millisecond & 0x03));
            Thread.Sleep(10);
            pieces.Add(new GamePieceModel(3, DateTime.Now.Millisecond & 0x03));
            Thread.Sleep(10);
            pieces.Add(new GamePieceModel(4, 0));
            Thread.Sleep(10);
            pieces.Add(new GamePieceModel(5, DateTime.Now.Millisecond & 0x03));
            Thread.Sleep(10);
            pieces.Add(new GamePieceModel(6, DateTime.Now.Millisecond & 0x03));
            Thread.Sleep(10);
            pieces.Add(new GamePieceModel(7, DateTime.Now.Millisecond & 0x03));
            Thread.Sleep(10);
            pieces.Add(new GamePieceModel(8, DateTime.Now.Millisecond & 0x03));

            // Convert list of Game Pieces to JSON for return back to the Browser
            var serializer = new JavaScriptSerializer();
            var serializedResult = serializer.Serialize(pieces);

            // Return JSON back to the Browser
            return Convert.ToString(serializedResult);
        }
    }
}