using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VenderOrder.Models;

namespace VenderOrder.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/artists/{artistId}/albums/new")]
    public ActionResult New(int artistId)
    {
      Artist Artist = Artist.Find(artistId);
      return View(Artist);
    }

    [HttpGet("/artists/{artistId}/albums/{albumId}")]
    public ActionResult Show(int artistId, int albumId)
    {
      Album foundAlbum = Album.Find(albumId);
      Artist Artist = Artist.Find(artistId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("album", foundAlbum);
      model.Add("artist", Artist);
      return View(model);
    }
  }
}