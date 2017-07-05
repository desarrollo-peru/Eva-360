﻿using System.Linq;
using Eva360.Models;
using System.Web.Mvc;
using Eva360.ViewModel.User;
using System.Transactions;
using System;
using System.Net;
using System.Data.Entity.Validation;
using System.Collections.Generic;

namespace Eva360.Controllers
{
    public class UsuarioController : BaseController
    {
        [NonAction]
        public JsonResult getData()
        {
            var context = new EVA360Entities();
            context.Configuration.LazyLoadingEnabled = false;
            context.Configuration.ProxyCreationEnabled = false;

            var LstUsuarios = context.Usuario.ToList();
            var LstTipoDocumentos = context.TipoDocumento.Select(x => new
            {
                x.TipoDocumentoId,
                x.Sigla
            }).ToList();

            return Json(new
            {
                usuarios = LstUsuarios,
                tipodocumentos = LstTipoDocumentos
            }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult ListarUsuario()
        {
            return getData();
        }

        [HttpPost]
        public ActionResult ActualizarUsuario(UsuarioForm usuarioModel)  
        {
            var context = new EVA360Entities();
            Usuario usuario;

            if (!usuarioModel.UsuarioId.HasValue) // Crear nuevo
            {                                      
                usuario = new Usuario();
                usuario.Estado = UsuarioEstado.Activo;
                context.Usuario.Add(usuario);
            }
            else // Editar exsistente
            { 
                usuario = context.Usuario
                    .FirstOrDefault(u => u.UsuarioId == usuarioModel.UsuarioId);
            }

            try {
                using (var transaction = new TransactionScope())
                {
                    usuario.Nombre = usuarioModel.Nombre;
                    usuario.Apellido = usuarioModel.Apellido;
                    usuario.Codigo = usuarioModel.Codigo;
                    usuario.Email = usuarioModel.Email;
                    usuario.FechaNacimiento = usuarioModel.FechaNacimiento;
                    usuario.Sexo = usuarioModel.Sexo;
                    usuario.TipoDocumentoId = usuarioModel.TipoDocumentoId;
                    usuario.NroDocumento = usuarioModel.NroDocumento;

                    context.SaveChanges();
                    transaction.Complete();
                }
            }
            catch (DbEntityValidationException e)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;

                List<String> errores = new List<String>();

                foreach (var eve in e.EntityValidationErrors)
                {
                    foreach (var ve in eve.ValidationErrors)
                    {
                        errores.Add(ve.ErrorMessage);
                    }
                }

                return Json(new { errores = errores });
            }

            return getData();
        }
    }
}