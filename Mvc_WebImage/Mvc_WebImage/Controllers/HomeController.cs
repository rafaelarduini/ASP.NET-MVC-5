using System.Web.Helpers;
using System.Web.Mvc;

namespace Mvc_WebImage.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public void GetImagem()
        {
            WebImage wbimagem = new WebImage("~/Imagens/quati.bmp");
            wbimagem.Resize(300, 300);
            wbimagem.FileName = "quati.bmp";
            wbimagem.Write();
        }

        public string ImagePath
        {
            get
            {
                var server = ControllerContext.HttpContext.Server;
                var imagePath = server.MapPath("~/Imagens/quati.bmp");
                return imagePath;
            }
        }

        public void GetCropped()
        {
            new WebImage(ImagePath)
               .Crop(50, 50, 50, 50)  // crop 50px para todos os lados      
               .Write();
        }

        public void GetHorizontalFlip()
        {
            new WebImage(ImagePath)
                .FlipHorizontal()
                .Write();
        }
        public void GetVerticalFlip()
        {
            new WebImage(ImagePath)
                .FlipVertical()
                .Write();
        }
        public void GetResized()
        {
            new WebImage(ImagePath)
                .Resize(600, 600) // redimensiona para 500x500 px      
                .Write();
        }
        public void GetRotateLeft()
        {
            new WebImage(ImagePath)
                .RotateLeft()
                .Write();
        }
        public void GetRotateRight()
        {
            new WebImage(ImagePath)
                .RotateRight()
                .Write();
        }
        public void GetTextWatermark()
        {
            new WebImage(ImagePath)
                .AddTextWatermark("Macoratti .net", "white", 14, "Bold")
                .Write();
        }

    }
}