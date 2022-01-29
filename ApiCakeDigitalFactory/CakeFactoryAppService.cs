using ApiCakeDigitalFactory.Models;
using HostManager.Backend.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;


namespace HostManager.Backend
{
    
    public class CakeFactoryAppService
    {
        private readonly CakeDigitalFactoryDBContext _DataContext;
        public CakeFactoryAppService(CakeDigitalFactoryDBContext CakeFactoryContext
            )
        {
            _DataContext = CakeFactoryContext;
        }

        public Response ValidateLogin(string user, string password) 
        {
            Usuario activeUser = _DataContext.Usuarios.FirstOrDefault(x => x.Nombre == user && x.Contraseña == password);
            
            if (activeUser==null)
            {
                return new Response { Message = "Usuario Inexistente o Credenciales Invalidas" };
            }
                return new Response {Message= $"Login Complete", Data= activeUser };

        }


        public Response GetDetalles()
        {
            IEnumerable<Detalle> modelList = _DataContext.Detalles;
            return new Response { Data = modelList };
        }

        public Response GetDetallesProductos(int idProducto)
        {
            IEnumerable<Detalle> modelList = _DataContext.Detalles.Where(x=>x.IdProducto == idProducto);
            return new Response { Data = modelList };
        }

        public Response getPedidosByUsuario(int idUsuario)
        {
            IEnumerable<Pedido> modelList = _DataContext.Pedidos.Where(x => x.IdUsuario == idUsuario);
            return new Response { Data = modelList };
        }
        public Response GetPanaderiasId(int idPanaderia)
        {
            IEnumerable<Usuario> modelList = _DataContext.Usuarios.Where(x => x.Roll == "cliente");
            return new Response { Data = modelList.FirstOrDefault(x=>x.Id == idPanaderia) };
        }

        public Response GetProductosByPanaderia(int idPanaderia)
        {
            IEnumerable<Producto> modelList = _DataContext.Productos.Where(x => x.IdCliente == idPanaderia);
            return new Response { Data = modelList};
        }
        public Response CreateUser(Usuario request)
        {
            if (string.IsNullOrWhiteSpace(request.Nombre))
            {
                return new Response { Message = "Nombre no puede estar vacio" };
            }

            if (string.IsNullOrWhiteSpace(request.Contraseña))
            {
                return new Response { Message = "Contrasena no puede estar vacio" };
            }

            if (request.Roll != "admin" || request.Roll != "cliente")
            {
                request.Roll = "usuario";
            }

            _DataContext.Add(request);
            int result = _DataContext.SaveChanges();

            if (result==1)
            {
                Usuario user = _DataContext.Usuarios.FirstOrDefault(x => x.Nombre == request.Nombre);

                return new Response { Message = $"Usuario {request.Nombre} creado con exito", Data = user};
            }
            else
            {
                return new Response { Message = "Database error" };
            }
            
        }

        public Response CreateProduct(Producto request)
        {
            if (string.IsNullOrWhiteSpace(request.Nombre))
            {
                return new Response { Message = "Nombre no puede estar vacio" };
            }

            if (string.IsNullOrWhiteSpace(request.Img))
            {
                return new Response { Message = "Imagen no puede estar vacio" };
            }


            _DataContext.Add(request);
            int result = _DataContext.SaveChanges();

            
            if (result==1)
            {
                Producto product = _DataContext.Productos.FirstOrDefault(x => x.Nombre == request.Nombre);

                return new Response { Message = $"Producto {request.Nombre} creado con exito", Data = product};
            }
            else
            {
                return new Response { Message = "Database error" };
            }
        }

        public Response CreatePedido(Pedido request)
        {
            _DataContext.Add(request);
            _DataContext.SaveChanges();

                return new Response { Message = $"Pedido creado con exito"};
        }

        public Response CreateDetail(Detalle request)
        {
            if (string.IsNullOrWhiteSpace(request.Nombre))
            {
                return new Response { Message = "Nombre no puede estar vacio" };
            }

            _DataContext.Add(request);
            int result = _DataContext.SaveChanges();


            if (result == 1)
            {
                Detalle detail = _DataContext.Detalles.FirstOrDefault(x => x.Nombre == request.Nombre);

                return new Response { Message = $"Detalle '{request.Nombre}' creado con exito", Data = detail };
            }
            else
            {
                return new Response { Message = "Database error" };
            }
        }

    }

}

