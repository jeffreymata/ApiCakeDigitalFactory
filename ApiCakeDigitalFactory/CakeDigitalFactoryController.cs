using ApiCakeDigitalFactory.Models;
using HostManager.Backend.Helpers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HostManager.Backend.Features
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CakeDigitalFactoryController : ControllerBase
    {
        private readonly CakeFactoryAppService _CakeFactoryAppService;
        public CakeDigitalFactoryController(CakeFactoryAppService CakeFactoryAppService)
        {
            _CakeFactoryAppService = CakeFactoryAppService;
        }

        [HttpPost]
        [Route("login")]
        public ActionResult getLoginValidation(Usuario request)
        {
            Response response = _CakeFactoryAppService.ValidateLogin(request.Nombre, request.Contraseña);
            return Ok(response);
        }

        [HttpPost]
        [Route("create-user")]
        public ActionResult createUser(Usuario request)
        {
            Response response = _CakeFactoryAppService.CreateUser(request);
            return Ok(response);
        }

        [HttpPost]
        [Route("create-producto")]
        public ActionResult createProduct(Producto request)
        {
            Response response = _CakeFactoryAppService.CreateProduct(request);
            return Ok(response);
        }

        [HttpPost]
        [Route("create-pedido")]
        public ActionResult createPedido(Pedido request)
        {
            Response response = _CakeFactoryAppService.CreatePedido(request);
            return Ok(response);
        }

        [HttpGet]
        [Route("get-detalles")]
        public ActionResult getDetails()
        {
            Response response = _CakeFactoryAppService.GetDetalles();
            return Ok(response);
        }

        [HttpGet]
        [Route("get-detalles-producto/{idProducto}")]
        public ActionResult getProductDetails(int idProducto)
        {
            Response response = _CakeFactoryAppService.GetDetallesProductos(idProducto);
            return Ok(response);
        }

        [HttpGet]
        [Route("get-pedido-usuario/{idUsuario}")]
        public ActionResult getPedidosUser(int idUsuario)
        {
            Response response = _CakeFactoryAppService.getPedidosByUsuario(idUsuario);
            return Ok(response);
        }

        [HttpGet]
        [Route("get-panaderias-byId/{idPanaderia}")]
        public ActionResult getPanaderiaById(int idPanaderia)
        {
            Response response = _CakeFactoryAppService.GetPanaderiasId(idPanaderia);
            return Ok(response);
        }

        [HttpGet]
        [Route("get-product-byPanaderia/{idPanaderia}")]
        public ActionResult getProdcutsPanaderia(int idPanaderia)
        {
            Response response = _CakeFactoryAppService.GetProductosByPanaderia(idPanaderia);
            return Ok(response);
        }

        [HttpPost]
        [Route("create-detalle")]
        public ActionResult createDetails(Detalle request)
        {
            Response response = _CakeFactoryAppService.CreateDetail(request);
            return Ok(response);
        }

    }
}
